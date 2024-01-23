using EchoClip.gRPC.Interfaces;
using EchoClip.Models;
using EchoClip.Repositories.Interfaces;
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;

namespace EchoClip.gRPC.Services;

class VoiceRecordingController : gRPC.VoiceRecodringController.VoiceRecodringControllerBase
{
    private readonly IVoiceRecordingService _voiceRecordingService;
    private readonly UserFromTokenReader _userFromTokenReader;
    private readonly string _audioFolderPath;

    public VoiceRecordingController(IVoiceRecordingService voiceRecordingService, UserFromTokenReader userFromTokenReader)
    {
        _voiceRecordingService = voiceRecordingService;
        _userFromTokenReader = userFromTokenReader;
        _audioFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "..", "..", "Audio");
    }

    public override Task<CreateVoiceRecordingResponse> CreateVoiceRecording(CreateVoiceRecordingRequest request, ServerCallContext context)
    {
        Guid myId = _userFromTokenReader.GetUserGUID() ?? throw new RpcException(new Status(StatusCode.InvalidArgument, "To nie jest mój guid!"));
        VoiceRecording voiceRecording = _voiceRecordingService.CreateVoiceRecording(request.Name, myId, request.AudioData.ToByteArray());

        return Task.FromResult(new CreateVoiceRecordingResponse{
            VoiceRecordingId = voiceRecording.VoiceRecordingId.ToString(),
        });
    }

    public override Task<GetMyVoiceRecordingResponse> GetMyVoiceRecording(GetMyVoiceRecordingRequest request, ServerCallContext context)
    {
        Guid myId = _userFromTokenReader.GetUserGUID() ?? throw new RpcException(new Status(StatusCode.InvalidArgument, "To nie jest mój guid!"));
        List<VoiceRecording> voiceRecodrings = _voiceRecordingService.GetMyVoiceRecording(myId);

        List<VoiceRecodringMessage> voiceRecodringMessages = voiceRecodrings.Select(
            voiceRecodring => new VoiceRecodringMessage
            {
                VoiceRecordingId = voiceRecodring.VoiceRecordingId.ToString(),
                Name = voiceRecodring.Name,
                AudioData = ByteString.CopyFrom(File.ReadAllBytes(Path.Combine(_audioFolderPath, voiceRecodring.AudioDataPath)))
            }).ToList();

        return Task.FromResult(new GetMyVoiceRecordingResponse
        {
            MyVoiceRecordings = { voiceRecodringMessages }
        });
    }

    public override Task<GetVoiceRecordingResponse> GetVoiceRecording(GetVoiceRecordingRequest request, ServerCallContext context)
    {
        Guid myId = _userFromTokenReader.GetUserGUID() ?? throw new RpcException(new Status(StatusCode.InvalidArgument, "To nie jest mój guid!"));
        VoiceRecording? voiceRecording = _voiceRecordingService.GetVoiceRecording(Guid.Parse(request.VoiceRecordingId));

        if(voiceRecording == null)
        {
            throw new RpcException(new Status(StatusCode.NotFound, "No found voice recording"));
        }

        VoiceRecodringMessage voiceRecodringMessage = new VoiceRecodringMessage
        {
            VoiceRecordingId = voiceRecording.VoiceRecordingId.ToString(),
            Name = voiceRecording.Name,
            AudioData = ByteString.CopyFrom(File.ReadAllBytes(Path.Combine(_audioFolderPath, voiceRecording.AudioDataPath)))
        };

        return Task.FromResult(new GetVoiceRecordingResponse
        {
            VoiceRecording = voiceRecodringMessage
        });

    }
}

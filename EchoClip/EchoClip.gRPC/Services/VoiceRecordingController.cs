using EchoClip.gRPC.Interfaces;
using EchoClip.Models;
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;

namespace EchoClip.gRPC.Services;

class VoiceRecordingController : gRPC.VoiceRecodringController.VoiceRecodringControllerBase
{
    private readonly IVoiceRecordingService _voiceRecordingService;
    private readonly UserFromTokenReader _userFromTokenReader;

    public override Task<CreateVoiceRecordingResponse> CreateVoiceRecording(CreateVoiceRecordingRequest request, ServerCallContext context)
    {
        Guid myId = _userFromTokenReader.GetUserGUID() ?? throw new RpcException(new Status(StatusCode.InvalidArgument, "To nie jest mój guid!"));
        _voiceRecordingService.CreateVoiceRecording(request.Name, myId, request.AudioData.ToByteArray());

        return Task.FromResult(new CreateVoiceRecordingResponse{});
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
                AudioData = ByteString.CopyFrom(voiceRecodring.AudioData)
            }).ToList();

        return Task.FromResult(new GetMyVoiceRecordingResponse
        {
            MyVoiceRecordings = { voiceRecodringMessages }
        });
    }
}

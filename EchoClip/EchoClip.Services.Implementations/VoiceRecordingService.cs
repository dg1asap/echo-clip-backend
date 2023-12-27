using EchoClip.gRPC.Interfaces;
using EchoClip.Models;
using EchoClip.Repositories.Interfaces;

namespace EchoClip.Services.Implementations;

public class VoiceRecordingService(IVoiceRecordingRepository voiceRecordingRepository) : IVoiceRecordingService
{
    private readonly IVoiceRecordingRepository _voiceRecordingRepository = voiceRecordingRepository;

    public void CreateVoiceRecording(string name, Guid ownerUserId, byte[] bytes)
    {
        VoiceRecording voiceRecording = new VoiceRecording
        {
            VoiceRecordingId = Guid.NewGuid(),
            Name = name,
            OwnerUserId = ownerUserId,
            AudioData = bytes,
            UploadDataTime = DateTime.Now,
        };
        _voiceRecordingRepository.Insert(voiceRecording);
    }

    public List<VoiceRecording> GetMyVoiceRecording(Guid ownerUserId)
    {
        List<VoiceRecording> voiceRecordings = _voiceRecordingRepository.GetByOwnerUserId(ownerUserId);
        
        voiceRecordings.Sort((x, y) => x.UploadDataTime.CompareTo(y.UploadDataTime));
        
        return voiceRecordings;
    }
}

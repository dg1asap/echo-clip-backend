using EchoClip.gRPC.Interfaces;
using EchoClip.Models;
using EchoClip.Repositories.Interfaces;

namespace EchoClip.Services.Implementations;

public class VoiceRecordingService : IVoiceRecordingService
{
    private readonly IVoiceRecordingRepository _voiceRecordingRepository;

    private readonly string _audioFolderPath;

    public VoiceRecordingService(IVoiceRecordingRepository voiceRecordingRepository)
    {
        _voiceRecordingRepository = voiceRecordingRepository;
        _audioFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "..", "..", "Audio");
    }

    public void CreateVoiceRecording(string name, Guid ownerUserId, byte[] bytes)
    {
        string filePath = Path.Combine(_audioFolderPath, name);
        File.WriteAllBytes(filePath, bytes);

        VoiceRecording voiceRecording = new VoiceRecording
        {
            VoiceRecordingId = Guid.NewGuid(),
            Name = name,
            OwnerUserId = ownerUserId,
            AudioDataPath = name + ".mp3",
            UploadDataTime = DateTime.Now,
        };
        _voiceRecordingRepository.Insert(voiceRecording);
        _voiceRecordingRepository.Save();
    }

    public List<VoiceRecording> GetMyVoiceRecording(Guid ownerUserId)
    {
        List<VoiceRecording> voiceRecordings = _voiceRecordingRepository.GetByOwnerUserId(ownerUserId);
        
        voiceRecordings.Sort((x, y) => x.UploadDataTime.CompareTo(y.UploadDataTime));
        
        return voiceRecordings;
    }
}

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

    public VoiceRecording CreateVoiceRecording(string name, Guid ownerUserId, byte[] bytes)
    {
        Guid voiceRecordingId = Guid.NewGuid();
        string fileName = $"{name}-{voiceRecordingId}.mp3";
        string filePath = Path.Combine(_audioFolderPath, fileName);
        File.WriteAllBytes(filePath, bytes);

        VoiceRecording voiceRecording = new VoiceRecording
        {
            VoiceRecordingId = Guid.NewGuid(),
            Name = name,
            OwnerUserId = ownerUserId,
            AudioDataPath = fileName,
            UploadDataTime = DateTime.Now,
        };
        _voiceRecordingRepository.Insert(voiceRecording);
        _voiceRecordingRepository.Save();
        return voiceRecording;
    }

    public List<VoiceRecording> GetMyVoiceRecording(Guid ownerUserId)
    {
        List<VoiceRecording> voiceRecordings = _voiceRecordingRepository.GetByOwnerUserId(ownerUserId);
        
        voiceRecordings.Sort((x, y) => x.UploadDataTime.CompareTo(y.UploadDataTime));
        
        return voiceRecordings;
    }

    public VoiceRecording? GetVoiceRecording(Guid voiceRecordingId)
    {
        VoiceRecording? voiceRecording = _voiceRecordingRepository.GetById(voiceRecordingId);

        return voiceRecording;
    }
}

using EchoClip.Models;

namespace EchoClip.Repositories.Interfaces;

public interface IVoiceRecordingRepository : IGenericRepository<VoiceRecording>
{
    List<VoiceRecording> GetByOwnerUserId(Guid ownerUserId);
}

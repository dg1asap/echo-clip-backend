using EchoClip.Models;
using EchoClip.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EchoClip.Repositories.Implementations;

public class VoiceRecordingRepository : GenericRepository<VoiceRecording>, IVoiceRecordingRepository
{
    public VoiceRecordingRepository(DatabaseEchoClipContext context) : base(context) { }

    public List<VoiceRecording> GetByOwnerUserId(Guid ownerUserId)
    {
        return _table.Where(e => e.OwnerUserId == ownerUserId).ToList();
    }
}

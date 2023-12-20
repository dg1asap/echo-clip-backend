using EchoClip.gRPC.Interfaces;
using EchoClip.Models;

namespace EchoClip.Services.Implementations;

public class VoiceRecordingService : IVoiceRecordingService
{
    public void CreateVoiceRecording(string name, Guid myId, byte[] bytes)
    {
        throw new NotImplementedException();
    }

    public List<VoiceRecording> GetMyVoiceRecording(Guid myId)
    {
        throw new NotImplementedException();
    }
}

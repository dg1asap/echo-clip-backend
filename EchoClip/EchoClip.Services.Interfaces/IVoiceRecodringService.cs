using EchoClip.Models;

namespace EchoClip.gRPC.Interfaces;

public interface IVoiceRecordingService
{
    void CreateVoiceRecording(string name, Guid myId, byte[] bytes);
    List<VoiceRecording> GetMyVoiceRecording(Guid myId);
}

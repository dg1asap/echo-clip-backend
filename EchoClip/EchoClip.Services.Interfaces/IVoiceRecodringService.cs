using EchoClip.Models;

namespace EchoClip.gRPC.Interfaces;

public interface IVoiceRecordingService
{
    VoiceRecording CreateVoiceRecording(string name, Guid ownerUserId, byte[] bytes);
    List<VoiceRecording> GetMyVoiceRecording(Guid ownerUserId);

    VoiceRecording? GetVoiceRecording(Guid voiceRecordingId);
}

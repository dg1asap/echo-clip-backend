using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EchoClip.Models;

[Table("Chats_voice_recordings")]
public class ChatsVoiceRecordings
{
    [Key]
    [Column("Chat_id")]
    public Guid ChatId { get; set; }

    [Key]
    [Column("Voice_recording_id")]
    public Guid VoiceRecordingId { get; set; }


    public Chats Chat { get; set; }
    public VoiceRecordings VoiceRecording { get; set; }

}

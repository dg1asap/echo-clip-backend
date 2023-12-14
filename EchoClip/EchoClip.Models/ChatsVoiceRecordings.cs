using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EchoClip.Models;

[Table("Chats_voice_recordings")]
public class ChatsVoiceRecording
{
    [Key]
    [Column("Chat_id")]
    public Guid ChatId { get; set; }

    [Key]
    [Column("Voice_recording_id")]
    public Guid VoiceRecordingId { get; set; }

    [Required]
    [Column("Date_of_added")]
    public DateTime DataOfAdded { get; set; }


    public Chat Chat { get; set; }
    public VoiceRecording VoiceRecording { get; set; }

}

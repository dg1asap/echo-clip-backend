using System.ComponentModel.DataAnnotations;

namespace EchoClip.Models;

public class ChatsVoiceRecordings
{
    [Key]
    public Guid ChatId { get; set; }

    [Key]
    public Guid VoiceRecordingsId { get; set; }
}

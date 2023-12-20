using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EchoClip.Models;

[Table("Voice_recordings")]

public class VoiceRecording
{
    [Key]
    [Column("Voice_recording_id")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid VoiceRecordingId { get; set; }

    [Required]
    [Column("Name")]
    public string Name { get; set; }

    [Required]
    [Column("Owner_user_id")]
    public Guid OwnerUserId { get; set; }

    [Required]
    [Column("Audio_data")]
    public byte[] AudioData { get; set; }

    [Required]
    [Column("Upload_data_time")]
    public DateTime UploadDataTime { get; set; }


    public User OwnerUser { get; set; }

    public List<ChatsVoiceRecording> ChatsVoiceRecordings { get; set; } = new();
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EchoClip.Models;

public class VoiceRecordings
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid VoideRecodingId { get; set; }

    [Required]
    public byte[] Recording { get; set; }

    [Required]
    public Guid OwnerUserId { get; set; }

    [Required]
    public DateTime UploadDataTime { get; set; }

    public List<Chats> Chats { get; set; } = new();
}

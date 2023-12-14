using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EchoClip.Models;

public class Chats
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid ChatId { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    public Guid OwnerUserId { get; set; }

    public List<Users> Users { get; set; } = new();

    public List<VoiceRecordings> VoiceRecordings { get; set; } = new();
}

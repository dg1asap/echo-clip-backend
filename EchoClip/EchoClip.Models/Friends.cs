using System.ComponentModel.DataAnnotations;

namespace EchoClip.Models;

public class Friends
{
    [Key]
    public Guid UserId { get; set; }

    [Required]
    public Guid UserFriendId { get; set; }
}

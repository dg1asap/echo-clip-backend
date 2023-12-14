using System.ComponentModel.DataAnnotations;

namespace EchoClip.Models;

public class FriendInvates
{
    [Key]
    public Guid UserId { get; set; }

    [Required]
    public Guid UserFriendInvatesId { get; set; }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EchoClip.Models;

[Table("Users_relationships")]
public class UserRelationship
{
    [Key]
    [Column("User_id")]
    public Guid UserId { get; set; }

    [Key]
    [Column("User_friend_id")]
    public Guid UserFriendId { get; set; }

    [Required]
    public string Status { get; set; }


    public User User { get; set; }
    
    public User UserFriend { get; set; }
}

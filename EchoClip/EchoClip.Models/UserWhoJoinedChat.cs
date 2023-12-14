using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EchoClip.Models;

[Table("Users_who_joined_chats")]
public class UserWhoJoinedChat
{
    [Key]
    [Column("User_id")]
    public Guid UserId { get; set; }

    [Key]
    [Column("Chat_id")]
    public Guid ChatId { get; set; }


    public User User { get; set; }

    public Chat Chat { get; set; }
}

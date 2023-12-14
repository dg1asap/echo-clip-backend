using System.ComponentModel.DataAnnotations;

namespace EchoClip.Models;

public class UsersWhoJoinedChats
{
    [Key]
    public Guid User_id { get; set; }

    [Key]
    public Guid Chat_id { get; set; }


    public Users User { get; set; }

    public Chats Chat { get; set; }
}

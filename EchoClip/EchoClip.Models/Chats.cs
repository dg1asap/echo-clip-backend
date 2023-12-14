using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EchoClip.Models;

public class Chats
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Chat_id { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    public Guid Owner_user_id { get; set; }


    public Users Owner_user { get; set; }

    public List<ChatsVoiceRecordings> ChatsVoiceRecordings { get; set; } = new();

    public List<UsersWhoJoinedChats> Users_who_joined_chats { get; set; } = new();
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EchoClip.Models;

[Table("Chats")]
public class Chat
{
    [Key]
    [Column("Chat_id")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid ChatId { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    [Column("Owner_user_id")]
    public Guid OwnerUserId { get; set; }


    public User OwnerUser { get; set; }

    public List<ChatsVoiceRecording> ChatsVoiceRecordings { get; set; } = new();

    public List<UserWhoJoinedChat> UsersWhoJoinedChats { get; set; } = new();

}

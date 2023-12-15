using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EchoClip.Models;

[Table("Users")]
public class User
{
    [Key]
    [Column("User_id")]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid UserId { get; set; }

    [Required]
    public string Username { get; set; }

    [Required]
    public string Password { get; set; }

    [Required]
    public string Email { get; set; }


    public List<Chat> CreatedChats { get; set; } = new();

    public List<UserWhoJoinedChat> UsersWhoJoinedChats { get; set; } = new();

    public List<VoiceRecording> VoiceRecordings { get; set; } = new();

    public List<UserRelationship> UserRelationshipsToOther { get; set; } = new();

    public List<UserRelationship> OthersRelationshipsToUser {  get; set; } = new();
}

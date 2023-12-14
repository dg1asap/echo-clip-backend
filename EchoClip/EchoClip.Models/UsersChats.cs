using System.ComponentModel.DataAnnotations;

namespace EchoClip.Models;

public class UsersChats
{
    [Key]
    public Guid UsersId { get; set; }

    [Key]
    public Guid ChatId { get; set; }
}

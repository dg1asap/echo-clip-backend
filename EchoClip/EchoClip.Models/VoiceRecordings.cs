using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EchoClip.Models;

public class VoiceRecordings
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid Voide_recoding_id { get; set; }

    [Required]
    public byte[] Recording { get; set; }

    [Required]
    public Guid Owner_user_id { get; set; }

    [Required]
    public DateTime Upload_data_time { get; set; }


    public List<ChatsVoiceRecordings> ChatsVoiceRecordings { get; set; } = new();
}

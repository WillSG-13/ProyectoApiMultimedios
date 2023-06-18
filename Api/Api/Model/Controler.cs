using System.ComponentModel.DataAnnotations;

namespace Api.Model
{
    public class Controler
    {
        
            [Key]
            public int IdController { get; set; }
            [MaxLength(11)]
            public String NameControllerView { get; set; }
            [MaxLength(50)]
            public DateTime CreatedAt { get; set; }
            public bool Enabled { get; set; }
            [MaxLength(2)]
            public DateTime UpdateAt { get; set; }
        
    }
}

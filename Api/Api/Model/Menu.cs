using System.ComponentModel.DataAnnotations;

namespace Api.Model
{
    public class Menu
    {
        [Key]
        [MaxLength(11)]
        public int IdMenu { get; set; }
        [MaxLength(50)]
        public string NameMenu { get; set; }
        [MaxLength(11)]
        public int IdCatalogoMenu { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        [MaxLength(2)]
        public bool Enabled { get; set; }
    }
}

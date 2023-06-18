using System.ComponentModel.DataAnnotations;

namespace Api.Model
{
    public class Controler
    {
        
            [Key]
            public int IdController { get; set; }
           
            public String NameControllerView { get; set; }
          
            public DateTime CreatedAt { get; set; }
            public bool Enabled { get; set; }
            
            public DateTime UpdatedAt { get; set; }
        
    }
}

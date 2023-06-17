using System.ComponentModel.DataAnnotations;

namespace Api.Model
{
    public class User
    {
        [Key]
        public int IdUser { get; set; }
      
        public String IdPersonal { get; set; }
        public String NameUser { get; set; }
        public String LastName { get; set; }
        public String Email { get; set; }
        public String UserName { get; set; }
        public String Password { get; set; }
        public int IdRol { get; set; }
        public DateTime CreatedAt { get; set; }
        public int Enabled { get; set; }
        public DateTime UpdateAt { get; set; }
    }
}

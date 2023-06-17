using Api.Data;
using Api.Model;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("Usuarios")]
    public class UsuarioController : Controller
    {

        readonly Context contextoBD;

        public UsuarioController(Context contextoBD)
        {
            this.contextoBD = contextoBD;
        }

        [HttpGet]
        [Route("listUser")]
        public List<User> listUser()
        {
            return this.contextoBD.user.ToList();
        }

        [HttpPut]
        [Route("AddUser")]
        public void AddUser(User user)
        {
            this.contextoBD.user.Add(user);
            this.contextoBD.SaveChanges();
        }

        [HttpDelete]
        [Route("deleteUser/{id}")]
        public Boolean deleteUser(int id)
        {
            foreach (User user in this.contextoBD.user) {
                if(user.IdUser==id){ 
                    this.contextoBD.user.Remove(user);
                    return true;
                }
            }
            return false;
        }
    }
}

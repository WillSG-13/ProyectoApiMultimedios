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
        public void deleteUser(int id)
        {
            var temp = this.contextoBD.user.FirstOrDefault(u => u.IdUser == id);
            this.contextoBD.Remove(temp);
            this.contextoBD.SaveChanges();
        }
    }
}

using Api.Data;
using Api.Model;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("Menu")]
    public class MenuController : Controller
    {

        readonly Context contextoBD;

        public MenuController(Context contextoBD)
        {
            this.contextoBD = contextoBD;
        }

        [HttpGet]
        [Route("listMenu")]
        public List<Menu> listMenu()
        {
            return this.contextoBD.menu.ToList();
        }

        [HttpPut]
        [Route("AddMenu")]
        public void AddMenu(Menu menu)
        {
            this.contextoBD.menu.Add(menu);
            this.contextoBD.SaveChanges();
        }

        [HttpDelete]
        [Route("deleteMenu/{id}")]
        public void deleteMenu(int id)
        {
            var temp = this.contextoBD.menu.FirstOrDefault(u => u.IdMenu == id);
            this.contextoBD.Remove(temp);
            this.contextoBD.SaveChanges();
        }
    }
}

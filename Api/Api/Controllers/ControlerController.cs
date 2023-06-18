using Api.Data;
using Api.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("Controller")]
public class ControllerController : Controller
{
    readonly Context contextoBD;
    public ControllerController(Context contextoBD)
    {
        this.contextoBD = contextoBD;
    }

    //Consultar todos los registros
    [HttpGet]
    [Route("listController")]
    public List<Controler> listController()
    {
        return this.contextoBD.controller.ToList();
    }

    //Almacenar registros de error
    [HttpPut]
    [Route("AddController")]
    public void AddController(Controler controller)
    {
        this.contextoBD.controller.Add(controller);
        this.contextoBD.SaveChanges();
    }

    //Eliminar un controller individual por id
    [HttpDelete]
    [Route("deleteController/{id}")]
    public void deleteController(int id)
    {
        var temp = this.contextoBD.controller.FirstOrDefault(u => u.IdController == id);
        this.contextoBD.Remove(temp);
        this.contextoBD.SaveChanges();
    }

    //Consultar un registro en especifico por  id
    [HttpGet("getController/{id}")]
    public ActionResult<Controller> getController(int id)
    {
        var controller = this.contextoBD.controller.Find(id);
        if (controller != null)
        {
            return Ok(controller);
        }
        else
        {
            return NotFound();
        }
    }


    //Actualizar datos
    [HttpPut]
    [Route("editController")]
    public void editController(Controller controller)
    {
        this.contextoBD.Entry(controller).State = EntityState.Modified;
        this.contextoBD.SaveChanges();
    }

}
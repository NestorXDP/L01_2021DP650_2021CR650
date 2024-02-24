using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using L01_2021DP650_2021CR650.Models;
using Microsoft.EntityFrameworkCore;


namespace L01_2021DP650_2021CR650.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class blogController : ControllerBase
    {
        private readonly blogContext _blogContexto;

        public blogController(blogContext blogContexto)
        {
            _blogContexto = blogContexto;
        }

        [HttpGet]
        [Route("GetAll")]

        public IActionResult Get()
        {
            List<usuarios> listadoEquipo = (from e in _blogContexto.usuarios
                                           select e).ToList();

            if (listadoEquipo.Count() == 0)
            {
                return NotFound();

            }
            return Ok(listadoEquipo);


            
        }
        [HttpGet]
        [Route("GetById/{id}")]
        public IActionResult Get(int id)
        {
            var usuario = _blogContexto.usuarios.FirstOrDefault(e => e.rolId == id);

            if (usuario == null)
            {
                return NotFound();
            }

            return Ok(usuario);
        }

        [HttpGet]
        [Route("FindNombre{filtro}")]
        public IActionResult FindNombre(string filtro)
        {
            var usuarios = _blogContexto.usuarios.Where(e => e.nombre.Contains(filtro)).ToList();

            if (usuarios == null || usuarios.Count == 0)
            {
                return NotFound();
            }

            return Ok(usuarios);
        }

        [HttpGet]
        [Route("FindApellido{filtro}")]
        public IActionResult FindApellido(string filtro)
        {
            var usuarios = _blogContexto.usuarios.Where(e => e.apellido.Contains(filtro)).ToList();

            if (usuarios == null || usuarios.Count == 0)
            {
                return NotFound();
            }

            return Ok(usuarios);
        }

        [HttpGet]
        [Route("FindRol{rolId}")]
        public IActionResult FindByRole(int rolId)
        {
            var usuarios = _blogContexto.usuarios.Where(e => e.rolId == rolId).ToList();

            if (usuarios == null || usuarios.Count == 0)
            {
                return NotFound();
            }

            return Ok(usuarios);
        }


    }
}

using Microsoft.AspNetCore.Mvc;
using UniCheckProgreso_API.Datos;
using UniCheckProgreso_API.Modelos.Dto;

namespace UniCheckProgreso_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UniProgresoController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<CarreraDto>> GetCarreras()
        {
            return Ok(CarreraStore.ListaCarrera);
        }

        [HttpGet("id:int")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public ActionResult<CarreraDto> GetCarrera(int id)
        {
            try
            {
                if (id <= 0)
                {
                    return BadRequest();
                }

                var carrera = CarreraStore.ListaCarrera.FirstOrDefault(c => c.ID_carrera == id);
            
                if (carrera == null)
                {
                    return NotFound();
                }

                return Ok(carrera);

            }
            catch (Exception ex)
            {

                throw;
            }

        }
    }
}

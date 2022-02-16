using System.Data;
using System.Net;
using System.Web.Http;
using Examen_KY.Models.Entity;
using Examen_KY.Models.Persistence;

namespace Examen_KY.Controllers
{
    [System.Web.Http.RoutePrefix("api/libro")]
    public class LibroController : ApiController
    {
        /// <summary>
        /// Obtener equipo(s) segun parametro: EquipmentCode (opcional)
        /// </summary>
        /// <param name="idLibro">Codigo de Libro</param>
        /// <param name="Nombre_Libro">Nombre de Libro</param>
        /// <param name="NomAutor">Nombre de Autor</param>
        /// <returns>HttpResponseMessage</returns>
        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("get")]
        public IHttpActionResult GetLibro(int idLibro = 0, string Nombre_Libro = null,string NomAutor = null)
        {
            var persintence = new P_Libro();
            DataSet dts = persintence.GetLibro(idLibro, Nombre_Libro, NomAutor);
            if (dts.Tables[0].TableName == "Error")
            {
                var message = new E_Message();
                message.Message = dts.Tables["Error"].Rows[0]["message"].ToString();
                return Content(HttpStatusCode.BadRequest, message);
            }
            return Ok(dts.Tables[0]);
        }

        /// <summary>
        /// Insertar un libro
        /// </summary>
        /// <param name="dataLibro">Entidad de Libro</param>
        /// <returns>HttpResponseMessage</returns>
        [HttpPost]
        [Route("insert")]
        public IHttpActionResult InsertLibro(E_Libro dataLibro)
        {
            var message = new E_Message();
            var persistence = new P_Libro();
            if (dataLibro == null)
            {
                message.Message = "Sin datos en el cuerpo.";
                return Content(HttpStatusCode.BadRequest, message);
            }
            string response = persistence.InsertLibro(dataLibro);
            message.Message = response;
            return Content((response == "success") ? HttpStatusCode.Created : HttpStatusCode.BadRequest, message);
        }

        /// <summary>
        /// Actualizar un libro
        /// </summary>
        /// <param name="dataLibro">Entidad de Libro</param>
        /// <returns>HttpResponseMessage</returns>
        [HttpPut]
        [Route("update")]
        public IHttpActionResult UpdateLibro(E_Libro dataLibro)
        {
            var message = new E_Message();
            var persistence = new P_Libro();
            if (dataLibro == null)
            {
                message.Message = "Sin datos en el cuerpo.";
                return Content(HttpStatusCode.BadRequest, message);
            }
            string response = persistence.UpdateLibro(dataLibro);
            message.Message = response;
            return Content((response == "success") ? HttpStatusCode.OK : HttpStatusCode.BadRequest, message);
        }

        /// <summary>
        /// Eliminar un libro
        /// </summary>
        /// <param name="idLibro">Codigo de libro</param>
        /// <returns>IHttpActionResult</returns>
        [HttpDelete]
        [Route("delete")]
        public IHttpActionResult DeleteLibro(int idLibro)
        {
            var message = new E_Message();
            var persistence = new P_Libro();
            if (idLibro == 0)
            {
                message.Message = "Sin datos en el cuerpo.";
                return Content(HttpStatusCode.BadRequest, message);
            }
            string response = persistence.DeleteLibro(idLibro);
            message.Message = response;
            return Content((response == "success") ? HttpStatusCode.OK : HttpStatusCode.BadRequest, message);
        }
    }
}
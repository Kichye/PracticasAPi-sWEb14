using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using PDB.Models.Request;
using PDB.Models.Response;
using PDB.Models;

namespace PDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InfoController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetInfo()
        {
            Respuesta oRes = new Respuesta();
            try
            {

                using (peliculaContext db = new peliculaContext())
                {
                    var lst = db.Informacions.ToList();
                    oRes.Exito = 1;
                    oRes.Data = lst;
                }


            }
            catch (Exception ex) { oRes.Mensaje = ex.Message; }
            return Ok(oRes);
        }
        [HttpGet("{id}")]
        public IActionResult GetEsInfo(int id)
        {
            Respuesta oRes = new Respuesta();
            try
            {

                using (peliculaContext db = new peliculaContext())
                {
                    var lst = db.Informacions.Find(id);
                    oRes.Exito = 1;
                    oRes.Data = lst;
                }


            }
            catch (Exception ex) { oRes.Mensaje = ex.Message; }
            return Ok(oRes);
        }

        [HttpPost]
        public IActionResult Add(PeliculaRequest model)
        {
            Respuesta oRes = new Respuesta();
            try
            {
                using (peliculaContext db = new peliculaContext())
                {
                    Informacion oIn = new Informacion();
                    oIn.Titulo = model.titulo;
                    oIn.Director = model.director;
                    oIn.Genero = model.genero;
                    oIn.Puntuación = model.puntuacion;
                    oIn.Rating = model.rating;
                    oIn.Anpub = model.anpub;
                    db.Informacions.Add(oIn);
                    db.SaveChanges();
                    oRes.Exito = 1;

                }


            }
            catch (Exception ex) { oRes.Mensaje = ex.Message; }
            return Ok(oRes);



        }
        [HttpPost("{id}")]
        public IActionResult AddInfo(int id)
        {
            
            return NotFound("Metodo no permitido (405)");



        }


        [HttpPut]
        public IActionResult EditInfo(PeliculaRequest model)
        {
            Respuesta oRes = new Respuesta();
            try
            {
                using (peliculaContext db = new peliculaContext())
                {
                    Informacion oIn = db.Informacions.Find(model.id);
                    oIn.Titulo = model.titulo;
                    oIn.Director = model.director;
                    oIn.Genero = model.genero;
                    oIn.Puntuación = model.puntuacion;
                    oIn.Rating = model.rating;
                    oIn.Anpub = model.anpub;
                    db.Entry(oIn);
                    db.SaveChanges();
                    oRes.Exito = 1;
                }

            }
            catch (Exception ex) { oRes.Mensaje = ex.Message; }
            return Ok(oRes);


        }
        [HttpPut("{id}")]
        public IActionResult EditEsInfo(PeliculaRequest model, int id)
        {
            Respuesta oRes = new Respuesta();
            try
            {
                using (peliculaContext db = new peliculaContext())
                {
                    Informacion oIn = db.Informacions.Find(id);
                    oIn.Titulo = model.titulo;
                    oIn.Director = model.director;
                    oIn.Genero = model.genero;
                    oIn.Puntuación = model.puntuacion;
                    oIn.Rating = model.rating;
                    oIn.Anpub = model.anpub;
                    db.Entry(oIn);
                    db.SaveChanges();
                    oRes.Exito = 1;
                }

            }
            catch (Exception ex) { oRes.Mensaje = ex.Message; }
            return Ok(oRes);


        }

        [HttpDelete("{id}")]

        public IActionResult Elmnr(int Id)
        {
            Respuesta oRes = new Respuesta();

            try
            {
                using (peliculaContext db = new peliculaContext())
                {
                    Informacion oIn = db.Informacions.Find(Id);
                    db.Remove(oIn);
                    db.SaveChanges();
                    oRes.Exito = 1;
                }


            }
            catch (Exception ex)
            { oRes.Mensaje = ex.Message; }
            return Ok(oRes);
        }

    }
}

using Estados.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Estados.Controllers
{
    public class EstadoController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        // GET: Estado
        public JsonResult JsonList()
        {

            var estados = from est in db.estados
                          select new { estadoID = est.estadoID, estado = est.estado };
            return Json(estados, JsonRequestBehavior.AllowGet);
        }

        public JsonResult optenerMunicipios(int estado)
        {

            var municipios = from mun in db.municipios
                             where mun.estadoID == estado
                             select new { municipioID = mun.municipioID, municipio = mun.municipio };
            return Json(municipios, JsonRequestBehavior.AllowGet);
        }
    }
}
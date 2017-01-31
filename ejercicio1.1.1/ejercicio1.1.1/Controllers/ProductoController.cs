using ejercicio1._1._1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ejercicio1._1._1.Controllers
{

    public class ProductoController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        
        // GET: Producto
        [AllowCrossSiteJsonAtribute]
        public JsonResult jsonListar()
        {
            var productos = db.productos.ToList();
            return Json(productos, JsonRequestBehavior.AllowGet);
        }

        [HttpPost, AllowCrossSiteJsonAtribute]
        public JsonResult createProducto(Producto producto)
        {
            var respuesta = new { funciono = true };

            db.productos.Add(producto);
            db.SaveChanges();

            return Json(respuesta, JsonRequestBehavior.AllowGet);
        }
        [HttpGet,AllowCrossSiteJsonAtribute]
        public JsonResult editarProducto(int id)
        {
            var editado = db.productos.Find(id);
            var result = new { id = editado.productoID, nombre = editado.nombre, precio = editado.precio };
            return Json(result, JsonRequestBehavior.AllowGet);
        }
        [HttpPost, AllowCrossSiteJsonAtribute]
        public JsonResult editarProducto(int id, string nombre, int precio)
        {
            var respuesta = new { funciono = false };

            try
            {
                var producto = db.productos.Find(id);
                producto.nombre = nombre;
                producto.precio = precio;
                int registrosModificados = db.SaveChanges();

                if (registrosModificados > 0)
                {
                    respuesta = new { funciono = true };
                }
            }
            catch { }

            return Json(respuesta, JsonRequestBehavior.AllowGet);

        }
        [HttpPost, AllowCrossSiteJsonAtribute]
        public JsonResult eliminarProducto(int id)
        {
            var respuesta = new { funciono = true };

            try
            {
                var producto = db.productos.Find(id);
                db.productos.Remove(producto);
                int registrosModificados = db.SaveChanges();

                if (registrosModificados > 0)
                {
                    respuesta = new { funciono = true };
                }
            }
            catch { }

            return Json(respuesta, JsonRequestBehavior.AllowGet);
        }

        public class AllowCrossSiteJsonAtribute : ActionFilterAttribute
        {
            public override void OnActionExecuted(ActionExecutedContext filterContext)
            {
                filterContext.RequestContext.HttpContext.Response.AddHeader("Access-Control-Allow-Origin", "*");
                base.OnActionExecuted(filterContext);
            }
        }
    }
}
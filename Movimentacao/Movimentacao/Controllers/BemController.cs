using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Movimentacao.DataAccess;
using Movimentacao.Models;

namespace Movimentacao.Controllers
{
    public class BemController : Controller
    {

        //private MarcaAccess marcaAccess;
        //private ModeloAccess modeloAccess;


        // GET: Bem
        public ActionResult Index()
        {
            //return View();

            BemAccess access = new BemAccess();
            IList<Bem> lista = access.Lista();
            return View(lista);
        }

        public ActionResult Form(int? id)
        {
            BemAccess access = new BemAccess();
                        
            Bem obj = id == null ? new Bem() : access.BuscaPorId(Convert.ToInt32(id));

            MarcaAccess marcaAccess = new MarcaAccess();
            ModeloAccess modeloAccess = new ModeloAccess();

            ViewBag.Marca = marcaAccess.Lista();
            ViewBag.Modelo = modeloAccess.Lista();

            return View(obj);
        }

        [HttpPost] //Força esse método aceitar por post
        public ActionResult Grava(Bem obj)
        {
            if (ModelState.IsValid)
            {
                BemAccess access = new BemAccess();

                access.Grava(obj);

                return RedirectToAction("Index");
            }
            else
            {
                return View("Form", obj);
            }
        }
                        
    }
}
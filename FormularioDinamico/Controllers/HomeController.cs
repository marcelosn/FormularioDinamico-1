using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FormularioDinamico.Models;

namespace FormularioDinamico.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            IList<CampoDinamico> retorno = new List<CampoDinamico>();

            retorno.Add(new CampoDinamico { Nome = "campo_texto", Prompt = "Campo Texto", Requerido = true, Tipo = Tipo.String });
            retorno.Add(new CampoDinamico { Nome = "campo_date", Prompt = "Campo Data", Requerido = true, Tipo = Tipo.Date });
            retorno.Add(new CampoDinamico { Nome = "campo_inteiro", Prompt = "Campo Inteiro", Requerido = false, Tipo = Tipo.Int});
            retorno.Add(new CampoDinamico { Nome = "campo_checkbox", Prompt = "Campo Check", Requerido = true, Tipo = Tipo.CheckBox });
            retorno.Add(new CampoDinamico { Nome = "campo_decimal", Prompt = "Campo Decimal", Requerido = true, Tipo = Tipo.Decimal });

            return View(retorno);
        }

        public PartialViewResult Selecionar()
        {
            return PartialView();
        }

        public PartialViewResult ListarEstados()
        {
            var r = new List<String>();
            r.Add("RJ");
            r.Add("SP");
            r.Add("GO");
            r.Add("MG");
            
            ViewBag.Titulo = "Listagem de Estados";

            return PartialView("Listagem", r);
        }

        public PartialViewResult ListarCidades()
        {
            var r = new List<String>();
            r.Add("GOIÂNIA");
            r.Add("RIO DE JANEIRO");
            r.Add("SANTOS");
            r.Add("BELO HORIZONTE");

            ViewBag.Titulo = "Listagem de Cidades";
            return PartialView("Listagem", r);
        }

        public PartialViewResult InsertPost(string newStatus)
        {
            var post = new Post { Status = newStatus };
            return PartialView("_NovoStatus", post);
        }

    }
}

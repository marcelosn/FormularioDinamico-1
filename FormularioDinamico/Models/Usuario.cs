using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FormularioDinamico.Models
{
    //Classe original
    public partial class Usuario
    {
        public String Nome { get; set; }
        public String Senha { get; set; }
        public String Login { get; set; }
    }

    //Classe partial decorada para uma MD
    [MetadataType(typeof(UsuarioMD))]
    public partial class Usuario {
        public int Numero { get; set; }
    }

    //Classe MD com os comportamentos acrescentados ao modelo original
    [Bind(Prefix="ctr", Exclude="campox", Include="CampoY")]
    public class UsuarioMD
    {
        [Required(ErrorMessage="Mensagem de erro")]
        public String Nome { get; set; }

        [DisplayName("Número de processo"), 
        Required(ErrorMessage = "Número obrigatório"), 
        StringLength(5),
        Range(0,15,ErrorMessage="Fora do intervalo",ErrorMessageResourceName="Não sei o que é isso",ErrorMessageResourceType = typeof(String)),
        ScaffoldColumn(true)]
        public int Numero { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FormularioDinamico.Models
{
    public class CampoDinamico
    {
        public string Prompt { get; set; }
        public string Nome { get; set; }
        public Tipo Tipo { get; set; }
        public bool Requerido { get; set; } 
    }

    public class Tipo
    {
        public String Nome { get; private set;}
        public Tipo(String tipo){
            this.Nome = tipo;
        }

        public static Tipo CheckBox = new Tipo("CheckBox");
        public static Tipo Date = new Tipo("Date");
        public static Tipo Decimal = new Tipo("Decimal");
        public static Tipo Int = new Tipo("Int");
        public static Tipo String = new Tipo("String");
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FormularioDinamico.Models
{
    public class Post
    {
        public String Status { get; set; }
        public String DataCriacao{
            get
            {
                return String.Format("{0:d/M/yyyy HH:mm:ss}",DateTime.Now);
            } 
        }
    }
}
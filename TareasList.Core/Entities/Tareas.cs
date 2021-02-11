using System;
using System.Collections.Generic;
using System.Text;

namespace TareasList.Core.Entities
{
   public class Tareas
    {
        public int TareaId { get; set; }

        public string Titulo { get; set; }

        public string Descripcion { get; set; }

        public string Estado { get; set; }

        public int UserId { get; set; }
    }
}

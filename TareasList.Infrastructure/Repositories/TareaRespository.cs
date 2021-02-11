using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TareasList.Core.Entities;
using TareasList.Core.Interfaces;

namespace TareasList.Infrastructure.Repositories
{
   public class TareaRespository : ITareaRepository
    {
        public async Task<IEnumerable<Tareas>> GetTareas()
        {
            var tareas = Enumerable.Range(1, 10).Select(x => new Tareas
            {
                TareaId = x,
                Descripcion = $"Description {x}",
                Titulo= $"Title{x}",
                Estado=$"Status {x}",
                UserId= x * 2

            });
            await Task.Delay(10);
            return tareas;
        }

        
    }
}

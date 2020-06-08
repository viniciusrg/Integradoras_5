using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaoLendario.Models
{
    public class ProcedimentosPreAdocao
    {
      

        public string Descricao { get; set; }
        public DateTime Data { get; set; }
        public Animal Animal { get; set; }
    }
}

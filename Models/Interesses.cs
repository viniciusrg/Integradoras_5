using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaoLendario.Models
{

        public class Interesse : Adotante
        {
            private DateTime data;
            private Boolean adotado;

            public DateTime Data { get; set; }
            public Boolean Adotado { get; set; }
        }
}

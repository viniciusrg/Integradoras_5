using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaoLendario.Models
{

        public class Interesse
        {
<<<<<<< Updated upstream
            private DateTime data;
            private Boolean adotado;

=======
        //private DateTime data;
        //private Boolean adotado;

            public int InteresseID { get; set; }
        
>>>>>>> Stashed changes
            public DateTime Data { get; set; }
            public Boolean Adotado { get; set; }

            public int AnimalID { get; set; }
            public Animal Animal { get; set; }
            public int AdotanteID { get; set; }
            public Adotante Adotante { get; set; }
        }
}

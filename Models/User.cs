using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaoLendario.Models
{
    public class User
    {
        private int UserID { get; set; }
        private string nome { get; set; }
        private string email { get; set; }
        private string senha { get; set; }
        private DateTime data_nascimento { get; set; }
        private string endereco { get; set; }
        private string cep { get; set; }
        private string uf { get; set; }
        private string telefone { get; set; }
    }
}

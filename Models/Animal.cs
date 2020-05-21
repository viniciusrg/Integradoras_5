using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CaoLendario.Models;

namespace CaoLendario.Models
{
    public class Animal
    {
        public int AnimalID { get; set; }
        public DateTime Nascimento { get; set; }
        public double Peso { get; set; }
        public TSexo Sexo { get; }
        public TPelagem TipoPelagem { get; }
        public TPorte Porte { get; }
        public bool GostaBrincar { get; set; }
        public string Temperamento { get; set; }
        public bool RelacionaOutroCao { get; set; }
        public bool RelacionaGato { get; set; }
        public bool PossuiDeficiencia { get; set; }
        public string HistoricoVida { get; set; }
        public string urlFoto { get; set; }

    }

    #region Definição das Enum
    public enum TPelagem
    {
        Curto,
        Médio,
        Longo
    }

    public enum TSexo
    {
        Masculino,
        Feminino
    }

    public enum TPorte
    {
        Pequeno,
        Médio,
        Grande
    }
    #endregion
}



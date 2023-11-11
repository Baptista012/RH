using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RHSolutions.Data
{
    class FuncionarioData
    {
        public string NomeFunc { get; set; }
        public int CpfFunc { get; set; }
        public int TelefoneFunc  { get; set; }
        public string CargoFunc { get; set; }
        public double SalarioFunc { get; set; }
        public string EnderecoFunc { get; set; }
        public int VAuxilioAlimentacao { get; set; }
        public int VAuxilioTransporte { get; set; }
        public int VAuxlioRefeicao { get; set; }
        public int Funcional { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        
        public DateTime Inicio { get; set; }
        public DateTime Fim { get; set; }
    }
}

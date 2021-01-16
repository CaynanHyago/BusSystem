using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferenciasDeObjetos
{
   public class Relatorio
    {
        public int CodRelatorio { get; set; }
        public DateTime DiaHora { get; set; }
        public string Linha { get; set; }
        public string Tabela { get; set; }
        public int CodFiscal { get; set; }
        public int CodMotorista { get; set; }
        public string NomeFiscal { get; set; }
        public string NomeMotorista { get; set; }
        public int Numero { get; set; }
    }
}

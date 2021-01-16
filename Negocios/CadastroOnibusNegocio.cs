using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConectaBancoDados;
using TransferenciasDeObjetos;
using System.Data;
using System.Data.SqlClient;

namespace Negocios
{
    public class CadastroOnibusNegocio
    {
        AcessaDadosSQL acessaDadosSQL = new AcessaDadosSQL();
        public OnibusColecao ConsultaOnibusNumero()
        {
            try
            {
                OnibusColecao onibusColecao = new OnibusColecao();
                DataTable dataTableOnibus = acessaDadosSQL.ExecutaConsulta(System.Data.CommandType.StoredProcedure, "uspConsultaOnibus");
                foreach (DataRow linha in dataTableOnibus.Rows)
                {
                    Onibus onibus = new Onibus();
                    onibus.Numero = Convert.ToString(linha["Numero"]);

                    onibusColecao.Add(onibus);
                }

                return onibusColecao;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

    }
}

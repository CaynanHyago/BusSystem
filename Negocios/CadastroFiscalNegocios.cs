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
    public class CadastroFiscalNegocios
    {
        AcessaDadosSQL acessaDadosSQL = new AcessaDadosSQL();
        public string InserirFiscal(Fiscal fiscal)
        {
            try
            {
                //Limpeza dos parametros
                acessaDadosSQL.LimpaParametros();
                //Adiciona parametros
                acessaDadosSQL.AdicionaParametros("@Nome", fiscal.Nome);
                acessaDadosSQL.AdicionaParametros("@chapa", fiscal.Chapa);

                string retorno = acessaDadosSQL.ManipulaDados(System.Data.CommandType.StoredProcedure, "uspInserirFiscal").ToString();
                return retorno;
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
        public string ExcluirFiscal(Fiscal fiscal)
        {
            try
            {
                acessaDadosSQL.LimpaParametros();
                acessaDadosSQL.AdicionaParametros("@CodFiscal", fiscal.CodFiscal);

                string Retorno = acessaDadosSQL.ManipulaDados(System.Data.CommandType.StoredProcedure, "uspExcluirFiscal").ToString();
                return Retorno;
            }
            catch (Exception ex)
            {
                return ex.Message;

            }
        }
        public string AlterarFiscal(Fiscal fiscal)
        {
            try
            {
                acessaDadosSQL.LimpaParametros();
                acessaDadosSQL.AdicionaParametros("CodFiscal", fiscal.CodFiscal);
                acessaDadosSQL.AdicionaParametros("Nome", fiscal.Nome);
                acessaDadosSQL.AdicionaParametros("Chapa", fiscal.Chapa);

                string Retorno = acessaDadosSQL.ManipulaDados(System.Data.CommandType.StoredProcedure, "uspAlterarFiscal").ToString();
                return Retorno;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public FiscalColecao ConsultaFiscal(string Nome)
        {
            try
            {
                FiscalColecao fiscalColecao = new FiscalColecao();
                acessaDadosSQL.LimpaParametros();
                acessaDadosSQL.AdicionaParametros("@Nome", Nome);
                DataTable dataTableFiscal = acessaDadosSQL.ExecutaConsulta(System.Data.CommandType.StoredProcedure, "uspConsultaFiscal");
                foreach (DataRow linha in dataTableFiscal.Rows)
                {
                    Fiscal fiscal = new Fiscal();
                    fiscal.CodFiscal = Convert.ToInt32(linha["CodFiscal"]);
                    fiscal.Nome = Convert.ToString(linha["NomeFiscal"]);
                    fiscal.Chapa = Convert.ToInt32(linha["chapa"]);

                    fiscalColecao.Add(fiscal);
                }

                return fiscalColecao;
            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message);
            }
        }
        public FiscalColecao ConsultaFiscalNome()
        {
            try
            {
                FiscalColecao fiscalColecao = new FiscalColecao();
                DataTable dataTableFiscal = acessaDadosSQL.ExecutaConsulta(System.Data.CommandType.StoredProcedure, "uspConsultaFiscalNome");
                foreach (DataRow linha in dataTableFiscal.Rows)
                {
                    Fiscal fiscal = new Fiscal();
                    fiscal.Nome = Convert.ToString(linha["NomeFiscal"]);

                    fiscalColecao.Add(fiscal);
                }

                return fiscalColecao;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

    }
}

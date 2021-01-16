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
   public class RelatorioNegocio
    {
        AcessaDadosSQL acessaDadosSQL = new AcessaDadosSQL();
        public string InserirRelatorio(Relatorio relatorio)
        {
            try
            {
                //Limpeza dos parametros
                acessaDadosSQL.LimpaParametros();
                //Adiciona parametros
                
                acessaDadosSQL.AdicionaParametros("@DiaHora", relatorio.DiaHora);
                acessaDadosSQL.AdicionaParametros("@linha", relatorio.Linha);
                acessaDadosSQL.AdicionaParametros("@tabela", relatorio.Tabela);
                acessaDadosSQL.AdicionaParametros("@CodFiscal", relatorio.CodFiscal);
                acessaDadosSQL.AdicionaParametros("@CodMotorista", relatorio.CodMotorista);

                string retorno = acessaDadosSQL.ManipulaDados(System.Data.CommandType.StoredProcedure, "uspInserirRelatorio").ToString();
                return retorno;
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
        public string ExcluirRelatorio(Relatorio relatorio)
        {
            try
            {
                acessaDadosSQL.LimpaParametros();
                acessaDadosSQL.AdicionaParametros("@CodRelatorio", relatorio.CodRelatorio);

                string Retorno = acessaDadosSQL.ManipulaDados(System.Data.CommandType.StoredProcedure, "uspExcluirRelatorio").ToString();
                return Retorno;
            }
            catch (Exception ex)
            {
                return ex.Message;

            }
        }
        public string AlterarRelatorio(Relatorio relatorio)
        {
            try
            {
                acessaDadosSQL.AdicionaParametros("@CodMotorista", relatorio.CodMotorista);
                acessaDadosSQL.AdicionaParametros("@CodFiscal", relatorio.CodFiscal);
                acessaDadosSQL.AdicionaParametros("@CodRelatorio", relatorio.CodRelatorio);
                acessaDadosSQL.AdicionaParametros("@DiaHora", relatorio.DiaHora);
                acessaDadosSQL.AdicionaParametros("@linha", relatorio.Linha);
                acessaDadosSQL.AdicionaParametros("@tabela", relatorio.Tabela);

                string Retorno = acessaDadosSQL.ManipulaDados(System.Data.CommandType.StoredProcedure, "uspAlterarRelatorio").ToString();
                return Retorno;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public RelatorioColecao ConsultaRelatorio()
        {
            try
            {
                RelatorioColecao relatorioColecao = new RelatorioColecao();
                DataTable dataTableRelatorio = acessaDadosSQL.ExecutaConsulta(System.Data.CommandType.StoredProcedure, "uspConsultarRelatorio");
                foreach (DataRow linha in dataTableRelatorio.Rows)
                {
                    Relatorio relatorio = new Relatorio();
                    relatorio.CodRelatorio = Convert.ToInt32(linha["CodRelatorio"]);
                    relatorio.Linha = Convert.ToString(linha["linha"]);
                    relatorio.DiaHora = Convert.ToDateTime(linha["Dia/hora"]);
                    relatorio.Tabela = Convert.ToString(linha["tabela"]);
                    relatorio.NomeFiscal = Convert.ToString(linha["NomeFiscal"]);
                    relatorio.NomeMotorista = Convert.ToString(linha["NomeMotorista"]);
                    relatorio.Numero = Convert.ToInt32(linha["Numero"]);
                    relatorioColecao.Add(relatorio);
                }

                return relatorioColecao;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}

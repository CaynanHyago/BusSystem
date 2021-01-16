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
    public class CadastroMotoristaNegocios
    {
        AcessaDadosSQL acessaDadosSQL = new AcessaDadosSQL();
        public string InserirMotorista(Motorista motorista)
        {
            try
            {
                //Limpeza dos parametros
                acessaDadosSQL.LimpaParametros();
                //Adiciona parametros
                acessaDadosSQL.AdicionaParametros("@Nome", motorista.Nome);
                acessaDadosSQL.AdicionaParametros("@Chapa", motorista.Chapa);
                acessaDadosSQL.AdicionaParametros("@CodOnibus", motorista.CodOnibus);

                string retorno = acessaDadosSQL.ManipulaDados(System.Data.CommandType.StoredProcedure, "uspInserirMotorista").ToString();
                return retorno;
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
        public string ExcluirMotorista(Motorista motorista)
        {
            try
            {
                acessaDadosSQL.LimpaParametros();
                acessaDadosSQL.AdicionaParametros("@CodMotorista", motorista.CodMotorista);

                string Retorno = acessaDadosSQL.ManipulaDados(System.Data.CommandType.StoredProcedure, "uspExcluirMotorista").ToString();
                return Retorno;
            }
            catch (Exception ex)
            {
                return ex.Message;

            }
        }
        public string AlterarMotorista(Motorista motorista)
        {
            try
            {
                acessaDadosSQL.LimpaParametros();
                acessaDadosSQL.AdicionaParametros("CodMotorista", motorista.CodMotorista);
                acessaDadosSQL.AdicionaParametros("Nome", motorista.Nome);
                acessaDadosSQL.AdicionaParametros("Chapa", motorista.Chapa);
                acessaDadosSQL.AdicionaParametros("CodOnibus", motorista.CodOnibus);

                string Retorno = acessaDadosSQL.ManipulaDados(System.Data.CommandType.StoredProcedure, "uspAlterarMotorista").ToString();
                return Retorno;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public MotoristaColecao ConsultaMotorista(string Nome)
        {
            try
            {
                MotoristaColecao motoristaColecao = new MotoristaColecao();
                acessaDadosSQL.LimpaParametros();
                acessaDadosSQL.AdicionaParametros("@Nome", Nome);
                DataTable dataTableMotorista = acessaDadosSQL.ExecutaConsulta(System.Data.CommandType.StoredProcedure, "uspConsultaMotorista");
                foreach (DataRow linha in dataTableMotorista.Rows)
                {
                    Motorista motorista = new Motorista();
                    motorista.CodMotorista = Convert.ToInt32(linha["CodMotorista"]);
                    motorista.Nome = Convert.ToString(linha["NomeMotorista"]);
                    motorista.Chapa = Convert.ToInt32(linha["Chapa"]);
                    motorista.NumeroOnibus = Convert.ToInt32(linha["Numero"]);

                    motoristaColecao.Add(motorista);
                }

                return motoristaColecao;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public MotoristaColecao ConsultaMotoristaNome()
        {
            try
            {
                MotoristaColecao motoristas = new MotoristaColecao();
                DataTable dataTableFiscal = acessaDadosSQL.ExecutaConsulta(System.Data.CommandType.StoredProcedure, "uspConsultaMotoristaNome");
                foreach (DataRow linha in dataTableFiscal.Rows)
                {
                    Motorista motorista = new Motorista();
                    motorista.Nome = Convert.ToString(linha["NomeMotorista"]);

                    motoristas.Add(motorista);
                }

                return motoristas;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

    }
}

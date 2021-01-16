using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ConectaBancoDados
{
    //cria conexão com o BD
    public class AcessaDadosSQL
    {
        private SqlConnection CriaConexao()
        {
            return new SqlConnection(Properties.Settings.Default.conectaBDTCC);
        }
        //parametros de BD
        private SqlParameterCollection sqlParameterCollection = new SqlCommand().Parameters;
        //Limpando parametros
        public void LimpaParametros()
        {
            sqlParameterCollection.Clear();
        }
        //Adicionando Parametros
        public void AdicionaParametros(string nomeParametro, object valorParametro)
        {
            sqlParameterCollection.Add(new SqlParameter(nomeParametro, valorParametro));
        }

        //Preencher os dados na SQLCommand
        private SqlCommand PreencherSQLCommand(CommandType commandType, string minhaUSP)
        {
            try
            {
                //Criar e abrir a conexão
                SqlConnection sqlConnection = CriaConexao();
                sqlConnection.Open();
                //Criar e enviar os comandos ao BD
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandType = commandType;
                sqlCommand.CommandText = minhaUSP;
                //Definir o tempo de 'vida' da conexão (segundos)
                sqlCommand.CommandTimeout = 1800;
                //Adicionar os parametros da transação 
                foreach (SqlParameter item in sqlParameterCollection)
                {
                    sqlCommand.Parameters.Add(new SqlParameter(item.ParameterName, item.Value));
                }
                //Executar para sqlcomand
                return sqlCommand;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

            //Incluir, Alterar e Excluir
            public object ManipulaDados(CommandType commandType, string minhaUSP)
            {
                try
                {
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand = PreencherSQLCommand(commandType, minhaUSP);
                    return sqlCommand.ExecuteScalar();
                }
                catch (Exception ex)
                {

                    throw new Exception(ex.Message);
                }
            }
            // Consultas
            public DataTable ExecutaConsulta(CommandType commandType, string minhaUSP)
            {
                try
                {
                    //Criar o 'carrinho' de comandos
                    SqlCommand sqlCommand = PreencherSQLCommand(commandType, minhaUSP);
                    //Criar o 'tradutor' das informações do SQLServer
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                    //Criar a 'tabela'
                    DataTable dataTable = new DataTable();
                    //Preencher a tabela 'traduzida'
                    sqlDataAdapter.Fill(dataTable);
                    //Retorno dos dados
                    return dataTable;
                }
                catch (Exception ex)

                {

                    throw new Exception(ex.Message);
                }
            }
    }
}


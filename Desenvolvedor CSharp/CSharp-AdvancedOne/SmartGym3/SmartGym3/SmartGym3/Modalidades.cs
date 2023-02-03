using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGym3
{
    public class Modalidades
    {
        //O resultado da leitura deverá ser armazenado em uma variável, para que seja possível exibi-la. Por isso devemos instanciar a classe DataTable e utilizar um objeto DataTable, onde seu carregamento receberá como parâmetro o resultado da leitura no banco. 
		//registeredModalities = Modalidades cadastradas. 
        DataTable registeredModalities = new DataTable();
        public void SaveNewModalidade(int idPersonalTrainer, decimal valorMensalidade, string nomeModalidade)
        {
			try
			{
				//Vamos instanciar e criar o objeto de conexão com o banco de dados. 
				using (SqlConnection connectionWithSmartGymDB = new SqlConnection(SmartGymDBConnection.stringConnectionSmartGym))
				{
					//Abre a conexão com o banco de dados. 
					connectionWithSmartGymDB.Open();

					/*
					 * Vamos utilizar as classes StringBuilder e SqlCommand para criar a query responsável pela inserção das informações no banco de dados. 
					 * A classe StringBuilder nos permitirá escrever o código em várias linhas e realizar a sua concatenação por meio do método Append. 
					 * Enquanto a classe SqlCommand será a responsável por transformar esta string em uma Query entendível pelo banco de dados. 
					 */

					SqlCommand addNewModalidade = new SqlCommand();
					StringBuilder addNewModalidadeQuery = new StringBuilder();

					//Criando a string de inserção no banco de dados
					addNewModalidadeQuery.Append("INSERT INTO Modalidades ");
                    addNewModalidadeQuery.Append("(idPersonalTrainer, valorMensalidade, nomeModalidade) ");
                    addNewModalidadeQuery.Append("VALUES (@idPersonalTrainer, @valorMensalidade, @nomeModalidade)");

					//Vamos relacionar as colunas do banco de dados com os parâmetros que estão sendo recebidos pelo construtor do método.
					addNewModalidade.Parameters.Add(new SqlParameter("@idPersonalTrainer", idPersonalTrainer));
					addNewModalidade.Parameters.Add(new SqlParameter("@valorMensalidade", valorMensalidade));
					addNewModalidade.Parameters.Add(new SqlParameter("@nomeModalidade", nomeModalidade));

					//Agora vamos dizer ao método que a string que construimos é na verdade a query que deverá ser executada
					addNewModalidade.CommandText = addNewModalidadeQuery.ToString();

					//Vamos atribuir a conexão com o banco ao comando SQL
					addNewModalidade.Connection = connectionWithSmartGymDB;

					//Vamos solicitar que o comando sql seja executado
					addNewModalidade.ExecuteNonQuery();
                }
            }
			catch (Exception erro)
			{

				throw new Exception ("Ocorreu um erro ao executar o método SaveModalidade. Entre em contato com o Adminisstrador do Sistema!" + erro);
			}
        }

		public void UpdateModalidade(int idModalidade, int idPersonalTrainer, decimal valorMensalidade, string nomeModalidade)
		{
			try
			{
				//Vamos instanciar e criar o objeto de conexão com o banco de dados. 
				using (SqlConnection connectionWithSmartGymDB = new SqlConnection(SmartGymDBConnection.stringConnectionSmartGym))
				{
					//Abre a conexão com o banco de dados. 
					connectionWithSmartGymDB.Open();

					/*
					 * Vamos utilizar as classes StringBuilder e SqlCommand para criar a query responsável pela inserção das informações no banco de dados. 
					 * A classe StringBuilder nos permitirá escrever o código em várias linhas e realizar a sua concatenação por meio do método Append. 
					 * Enquanto a classe SqlCommand será a responsável por transformar esta string em uma Query entendível pelo banco de dados. 
					 */

					SqlCommand updateModalidade = new SqlCommand();
					StringBuilder updateModalidadeQuery = new StringBuilder();

					//Criando a string de inserção no banco de dados
					updateModalidadeQuery.Append("UPDATE Modalidades ");
					updateModalidadeQuery.Append("SET (idPersonalTrainer = @idPersonalTrainer, valorMensalidade = @valorMensalidade, nomeModalidade = @nomeModalidade) ");
					updateModalidadeQuery.Append("WHERE idModalidade = @idModalidade");

                    //Vamos relacionar as colunas do banco de dados com os parâmetros que estão sendo recebidos pelo construtor do método.
                    updateModalidade.Parameters.Add(new SqlParameter("@idModalidades", idModalidade));
                    updateModalidade.Parameters.Add(new SqlParameter("@idPersonalTrainer", idPersonalTrainer));
					updateModalidade.Parameters.Add(new SqlParameter("@valorMensalidade", valorMensalidade));
					updateModalidade.Parameters.Add(new SqlParameter("@nomeModalidade", nomeModalidade));

					//Agora vamos dizer ao método que a string que construimos é na verdade a query que deverá ser executada
					updateModalidade.CommandText = updateModalidadeQuery.ToString();

					//Vamos atribuir a conexão com o banco ao comando SQL
					updateModalidade.Connection = connectionWithSmartGymDB;

					//Vamos solicitar que o comando sql seja executado
					updateModalidade.ExecuteNonQuery();
				}
			}
			catch (Exception erro)
			{
				throw new Exception("Ocorreu um erro ao executar o método UpdateModalidade. Entre em contato com o Adminisstrador do Sistema! " + erro);
			}
		}

		//Método responsável por listar as informações no datagrid view do formulário
		//Vamos utilizar um DataTable para armazenar em memória estas informações
		public DataTable ListModalidades()
		{
			try
			{
                //Variável responsável por receber as informações da query de busca no banco de dados
                SqlCommand listModalidades = new SqlCommand();

                //Variável responsável por armazenar a query de busca de novo Coach
                StringBuilder listModalidadesQuery = new StringBuilder();

                //Iniciando a conexão com o banco de dados
                using (SqlConnection connectionWithDBSmartGym = new SqlConnection(SmartGymDBConnection.stringConnectionSmartGym))
				{
					//Abre a conexão com o banco
					connectionWithDBSmartGym.Open();

					//Instrução SQL responsável por retornar todas as informações guardadas na tabela Modalidades
					listModalidadesQuery.Append("SELECT Modalidades.idModalidade, Modalidades.nomeModalidade, Modalidades.valorMensalidade, Modalidades.IdPersonalTrainer, PersonalTrainer.NamePersonalTrainer ");
					//Realizando a junção da tabela Modalidades com a tabela Personal Trainer e adicionando uma condição que verifica se os dois valores consultados (em ambas as tabelas) são iguais. 
                    listModalidadesQuery.Append("FROM (Modalidades INNER JOIN PersonalTrainer ON Modalidades.idPersonalTrainer = PersonalTrainer.IdPersonalTrainer)");
                    listModalidadesQuery.Append("ORDER BY Modalidades.idModalidade DESC");

					//A string que construímos é a query que deverá ser executada
					listModalidades.CommandText = listModalidadesQuery.ToString();

					//O comando deverá ser executado atráves da ligação estabelecida pela string de conexão
					listModalidades.Connection = connectionWithDBSmartGym;

					//O método ExecuteNonQuery() é utilizado para realizar ações de inserção, alteração ou exclusão de informações em um banco de dados, por isso não é utilizado em querys onde será realizada apenas uma leitura. Para situações assim devemos utilizar o método ExecuteReader();
			
					//Vamos utilizar o objeto registeredModalities, em seu método Load, para assim que ele for carregado, realizar a analise dos dados.
					registeredModalities.Load(listModalidades.ExecuteReader());
					//Após realizar a leitura, devemos retorná-la 
					return registeredModalities;
                }

            }
			catch (Exception)
			{
				throw new Exception ("Ocorreu um erro com o método ListModalidades. Entre em contato com o administrador do sistema!");
			}
		}

		public void DeleteModality(int idModalidade)
		{
			try
			{
				//Variável responsável por receber as informações da query que apagará o registro no banco de dados
				SqlCommand deleteModality = new SqlCommand();

				//Variável responsável por armazenar a query de exclusão
				StringBuilder deleteModalityQuery = new StringBuilder();

				//Objeto da classe SqlConnection que realiza a conexão com o banco de dados
				using (SqlConnection connectionWithDBSmartGym = new SqlConnection(SmartGymDBConnection.stringConnectionSmartGym))
				{
					//Abre a conexão com o banco de dados
					connectionWithDBSmartGym.Open();

					//Query responsável por realizar a exclusão da modalidade no banco de dados
					deleteModalityQuery.Append("DELETE FROM Modalidades ");
                    deleteModalityQuery.Append("WHERE (idModalidade = @idModalidade");

					//Relacionando o parâmetro do método com a coluna da tabela
					deleteModality.Parameters.Add(new SqlParameter("@idModalidade", idModalidade));

					//Transforma a Query em um comando SQL
					deleteModality.CommandText = deleteModalityQuery.ToString();
					//Informa qual conexão com o banco deverá ser utilizada
					deleteModality.Connection = connectionWithDBSmartGym;
					//Executa a query
					deleteModality.ExecuteNonQuery();
                }
            }
			catch (Exception)
			{
				throw new Exception("Ocorreu um erro ao executar o método DeleteModality. Entre em contato com o administrador do sistema.");
			}
		}
    }
}

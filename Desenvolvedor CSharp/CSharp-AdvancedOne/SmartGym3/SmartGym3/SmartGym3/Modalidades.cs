using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGym3
{
    public class Modalidades
    {
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

		public void UpdateModalidee(int idModalidade, int idPersonalTrainer, decimal valorMensalidade, string nomeModalidade)
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
					updateModalidadeQuery.Append("SET idPersonalTrainer = @idPersonalTrainer, valorMensalidade = @valorMensalidade, nomeModalidade = @nomeModalidade) ");
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
				throw new Exception("Ocorreu um erro ao executar o método UpdateModalidade. Entre em contato com o Adminisstrador do Sistema!" + erro);
			}
		}
    }
}

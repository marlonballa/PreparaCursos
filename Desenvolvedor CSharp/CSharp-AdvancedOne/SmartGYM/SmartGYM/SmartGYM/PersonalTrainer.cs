using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartGYM
{
    public class PersonalTrainer
    {
		//Parâmetros deste método: São as informações que deverão ser armazenadas sobre os professores
        public void AddPersonalTrainer(string namePersonalTrainer, string addressPersonalTrainer, string districtPersonalTrainer, string cityPersonalTrainer, string cepPersonalTrainer, string cpfPersonalTrainer, decimal salaryPersonalTrainer, string phonePersonalTrainer, string comments)
        {
			try
			{
                //Instancia o objeto que será responsável por salvar o novo professor no banco de dados
				SqlCommand saveNewPersonalTrainer = new SqlCommand();

                //Query responsável por fazer a população dos dados na base,
                StringBuilder queryAddPersonalTrainer = new StringBuilder();

                //Estabelece a conexão com o banco de dados a partir da classe e do método de conexão
                using (SqlConnection connectionSmartGYM = new SqlConnection(SmartGYMConnection.stringConnectionSmartGYM))
                {
                    try
                    {
                        //Abre a conexão com o banco de dados
                        connectionSmartGYM.Open(); 

                        //Query de inserção das informações do professor na base de dados, com a Tabela que receberá as informações e as colunas que deverão ter registros inseridos 
                        queryAddPersonalTrainer.Append("INSERT INTO PersonalTrainer (NamePersonalTrainer, AddressPersonalTrainer, DistrictPersonalTrainer,");
                        queryAddPersonalTrainer.Append("CityPersonalTrainer, CEPPersonalTrainer, PhonePersonalTrainer, CPFPersonalTrainer,");                     
                        queryAddPersonalTrainer.Append("SalaryPersonalTrainer, Comments)");

                        //Valores vindos do front-end e que serão inseridos na tabela
                        //Estes valores devem ser iguais aos que estão como parâmetro no método de adição de novo professor
                        queryAddPersonalTrainer.Append("VALUES (@namePersonalTrainer, @addressPersonalTrainer, @districtPersonalTrainer");
                        queryAddPersonalTrainer.Append("@cityPersonalTrainer, @cepPersonalTrainer, @phonePersonalTrainer, @cpfPersonalTrainer, @salaryPersonalTrainer, @comments)");

                        //Relacionando os parâmetros do método com os respectivos valores da instrução SQL.
                        saveNewPersonalTrainer.Parameters.Add(new SqlParameter("@namePersonalTrainer", namePersonalTrainer));
                        saveNewPersonalTrainer.Parameters.Add(new SqlParameter("@adressPersonalTrainer", addressPersonalTrainer));
                        saveNewPersonalTrainer.Parameters.Add(new SqlParameter("@districtPersonalTrainer", districtPersonalTrainer));
                        saveNewPersonalTrainer.Parameters.Add(new SqlParameter("@cityPersonalTrainer", cityPersonalTrainer));
                        saveNewPersonalTrainer.Parameters.Add(new SqlParameter("@cepPersonalTrainer", cepPersonalTrainer));
                        saveNewPersonalTrainer.Parameters.Add(new SqlParameter("@phonePersonalTrainer", phonePersonalTrainer));
                        saveNewPersonalTrainer.Parameters.Add(new SqlParameter("@cpfPersonalTrainer", cpfPersonalTrainer));
                        saveNewPersonalTrainer.Parameters.Add(new SqlParameter("@salaryPersonalTrainer", salaryPersonalTrainer));
                        saveNewPersonalTrainer.Parameters.Add(new SqlParameter("@comments", comments));

                        //Informamos que a instrução SQL construida, deverá ser executada. Para isso realizamos a associação da instância de SqlCommand com a string de inserção
                        saveNewPersonalTrainer.CommandText = queryAddPersonalTrainer.ToString();
                        //Agora temos que especificar que o comando deverá ser executado atráves da conexão estabelecida pela string
                        saveNewPersonalTrainer.Connection = connectionSmartGYM;
                        //Para que as informações sejam inseridas no banco de dados, é necessário determinar que o nosso comando sql seja executado
                        //Neste caso utilizaremos o método ExecuteNonQuery, que permite que instrução INSERT, DELETE, UPDATE, sejam executadas.
                        saveNewPersonalTrainer.ExecuteNonQuery();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Houve um erro no processo de conexão com o banco de dados");
                    }
                }
            }
			catch (Exception)
			{
				throw new Exception("Ocorreu um erro ao salvar as informações. Por favor, entre em contato com o desenvolvedor do programa!");
			}

        }
    }
}

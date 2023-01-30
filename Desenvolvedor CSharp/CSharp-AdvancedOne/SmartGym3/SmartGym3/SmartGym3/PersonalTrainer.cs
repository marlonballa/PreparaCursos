using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGym3
{
    public class PersonalTrainer
    {
        /**
         * Método responsável por receber as informações do front-end e armazená-las no banco de dados. 
         */
        public void SaveNewCoach(string namePersonalTrainer, string addressPersonalTrainer, string districtPersonalTrainer, string cityPersonalTrainer, string cepPersonalTrainer, string phonePersonalTrainer, string cpfPersonalTrainer, decimal salaryPersonalTrainer, string comments)
        {
            /**
             * Utilizaremos a classe SqlCommand para realizar o CRUD em nosso BD. Esta classe é utilizada sempre que existir uma Query ou Story Procedure.
             */
            try
            {
                //Variável responsável por receber as informações da query de inserção no banco de dados
                SqlCommand addNewCoach = new SqlCommand();

                //Variável responsável por armazenar a query de inserção de novo Coach
                StringBuilder addNewCoachQuery = new StringBuilder();


                //Objeto da classe SqlConnection que realiza a conexão com o banco de dados
                using (SqlConnection connectionWithDBSmartGym = new SqlConnection(SmartGymDBConnection.stringConnectionSmartGym))
                {
                    //Abre a conexão com o banco de dados
                    connectionWithDBSmartGym.Open();

                    //A query de inserção será executada após a abertura da conexão com o banco de dados
                    //Vale lembrar que estamos criando uma query, por isso os parâmetros devem ser exatamente iguais as colunas da tabela no banco de dados. 
                    addNewCoachQuery.Append("INSERT INTO PersonalTrainer (NamePersonalTrainer, AddressPersonalTrainer, DistrictPersonalTrainer,");
                    addNewCoachQuery.Append("CityPersonalTrainer, CEPPersonalTrainer, PhonePersonalTrainer,");
                    addNewCoachQuery.Append("CPFPersonalTrainer, SalaryPersonalTrainer, Comments)");
                    addNewCoachQuery.Append("VALUES (@NamePersonalTrainer, @AddressPersonalTrainer, @DistrictPersonalTrainer, @CityPersonalTrainer, @CEPPersonalTrainer, @PhonePersonalTrainer, @CPFPersonalTrainer, @SalaryPersonalTrainer, @Comments)");

                    //Quando criamos o método - SaveNewCoach - indicamos os parâmetros que devem ser salvos. Agora, devemos relacionar estes parâmetros com os valores da instrução SQL.
                    //Para que possamos relacionar um valor da query com um parâmetro do método, devemos utilizar a class SqlParameter
                    addNewCoach.Parameters.Add(new SqlParameter("@NamePersonalTrainer", namePersonalTrainer));
                    addNewCoach.Parameters.Add(new SqlParameter("@AddressPersonalTrainer", addressPersonalTrainer));
                    addNewCoach.Parameters.Add(new SqlParameter("@DistrictPersonalTrainer", districtPersonalTrainer));
                    addNewCoach.Parameters.Add(new SqlParameter("@CityPersonalTrainer", cityPersonalTrainer));
                    addNewCoach.Parameters.Add(new SqlParameter("@CEPPersonalTrainer", cepPersonalTrainer));
                    addNewCoach.Parameters.Add(new SqlParameter("@PhonePersonalTrainer", phonePersonalTrainer));
                    addNewCoach.Parameters.Add(new SqlParameter("@CPFPersonalTrainer", cpfPersonalTrainer));
                    addNewCoach.Parameters.Add(new SqlParameter("@SalaryPersonalTrainer", salaryPersonalTrainer));
                    addNewCoach.Parameters.Add(new SqlParameter("@Comments", comments));

                    //Devemos indicar que a instrução SQL addNewCoachQuery é o comando que deverá ser executado.
                    addNewCoach.CommandText = addNewCoachQuery.ToString();
                    //Agora devemos especificar que este comando deverá ser executado átraves da conexão estabelecida
                    addNewCoach.Connection = connectionWithDBSmartGym;
                    //Para que as informações sejam inseridas no banco de dados, é necessário determinar que o query de inserção seja executada
                    //Para isso vamos utilizar o método ExecuteNonQuery, que permite a execução de instruçãos Insert, Delete e UpDate
                    addNewCoach.ExecuteNonQuery();
                }
            }
            catch (Exception erro)
            {
                throw new Exception("Ocorreu um erro ao tentar executar esta operação. Por favor, tente novamente mais tarde." + erro);
            }
        }

        /**
         * Método responsávle por alterar as informações dos Coaches
         */

        public void UpdateCoachInformations(int idPersonalTrainer, string namePersonalTrainer, string addressPersonalTrainer, string districtPersonalTrainer, string cityPersonalTrainer, string cepPersonalTrainer, string phonePersonalTrainer, string cpfPersonalTrainer, decimal salaryPersonalTrainer, string comments)
        {
            try
            {
                //Variável responsável por receber as informações da query de inserção no banco de dados
                SqlCommand updateCoachInformations = new SqlCommand();

                //Variável responsável por armazenar a query de inserção de novo Coach
                StringBuilder updateCoachInformationsQuery = new StringBuilder();


                //Objeto da classe SqlConnection que realiza a conexão com o banco de dados
                using (SqlConnection connectionWithDBSmartGym = new SqlConnection(SmartGymDBConnection.stringConnectionSmartGym))
                {
                    //Abre a conexão com o banco de dados
                    connectionWithDBSmartGym.Open();

                    //A query de inserção será executada após a abertura da conexão com o banco de dados
                    //Vale lembrar que estamos criando uma query, por isso os parâmetros devem ser exatamente iguais as colunas da tabela no banco de dados. 
                    updateCoachInformationsQuery.Append("UPDATE PersonalTrainer SET NamePersonalTrainer = @NamePersonalTrainer, AddressPersonalTrainer = @AddressPersonalTrainer, DistrictPersonalTrainer = @DistrictPersonalTrainer,");
                    updateCoachInformationsQuery.Append(" CityPersonalTrainer = @CityPersonalTrainer, CEPPersonalTrainer = @CEPPersonalTrainer, PhonePersonalTrainer = @PhonePersonalTrainer,");
                    updateCoachInformationsQuery.Append(" CPFPersonalTrainer = @CPFPersonalTrainer, SalaryPersonalTrainer = @SalaryPersonalTrainer, Comments = @Comments");
                    updateCoachInformationsQuery.Append(" Where (IdPersonalTrainer = @IdPersonalTrainer)");

                    //Quando criamos o método - SaveNewCoach - indicamos os parâmetros que devem ser salvos. Agora, devemos relacionar estes parâmetros com os valores da instrução SQL.
                    //Para que possamos relacionar um valor da query com um parâmetro do método, devemos utilizar a class SqlParameter
                    updateCoachInformations.Parameters.Add(new SqlParameter("@IdPersonalTrainer", idPersonalTrainer));
                    updateCoachInformations.Parameters.Add(new SqlParameter("@NamePersonalTrainer", namePersonalTrainer));
                    updateCoachInformations.Parameters.Add(new SqlParameter("@AddressPersonalTrainer", addressPersonalTrainer));
                    updateCoachInformations.Parameters.Add(new SqlParameter("@DistrictPersonalTrainer", districtPersonalTrainer));
                    updateCoachInformations.Parameters.Add(new SqlParameter("@CityPersonalTrainer", cityPersonalTrainer));
                    updateCoachInformations.Parameters.Add(new SqlParameter("@CEPPersonalTrainer", cepPersonalTrainer));
                    updateCoachInformations.Parameters.Add(new SqlParameter("@PhonePersonalTrainer", phonePersonalTrainer));
                    updateCoachInformations.Parameters.Add(new SqlParameter("@CPFPersonalTrainer", cpfPersonalTrainer));
                    updateCoachInformations.Parameters.Add(new SqlParameter("@SalaryPersonalTrainer", salaryPersonalTrainer));
                    updateCoachInformations.Parameters.Add(new SqlParameter("@Comments", comments));

                    //Devemos indicar que a instrução SQL addNewCoachQuery é o comando que deverá ser executado.
                    updateCoachInformations.CommandText = updateCoachInformationsQuery.ToString();
                    //Agora devemos especificar que este comando deverá ser executado átraves da conexão estabelecida
                    updateCoachInformations.Connection = connectionWithDBSmartGym;
                    //Para que as informações sejam inseridas no banco de dados, é necessário determinar que o query de inserção seja executada
                    //Para isso vamos utilizar o método ExecuteNonQuery, que permite a execução de instruçãos Insert, Delete e UpDate
                    updateCoachInformations.ExecuteNonQuery();
                }
            }
            catch (Exception erro)
            {
                throw new Exception("Ocorreu um erro no método UpdateCoachInformations. Por favor, tente novamente mais tarde." + erro);
            }
        }
        public DataTable ListCoaches()
        {
            /*
             * Vamos colher as informações do banco de dados e armazenálas no objeto que será responsável por mostrá-las na tela. Por isso, devemos retornar os dados armazenadas na tabela, para que seja possível listá-los. 
             */
            try
            {
                //Variável responsável por receber as informações da query de inserção no banco de dados
                SqlCommand listCoaches = new SqlCommand();

                //Variável responsável por armazenar a query de inserção de novo Coach
                StringBuilder listCoachesQuery = new StringBuilder();

                //Variável responsável por armazenar as informações retornadas pelo banco, no select, em memórias. As quais serão listadas no DataGridView
                DataTable listCoachesDataTable = new DataTable();

                //Objeto da classe SqlConnection que realiza a conexão com o banco de dados
                using (SqlConnection connectionWithDBSmartGym = new SqlConnection(SmartGymDBConnection.stringConnectionSmartGym))
                {
                    connectionWithDBSmartGym.Open();

                    //Busca as informações no banco de dados
                    listCoachesQuery.Append("SELECT * FROM PersonalTrainer");
                    listCoachesQuery.Append(" ORDER BY idPersonalTrainer DESC");

                    //Transformando em string os comandos acima
                    listCoaches.CommandText= listCoachesQuery.ToString();
                    //A ligação dos comandos SQL é a string de conexão
                    listCoaches.Connection = connectionWithDBSmartGym;

                    //O objeto listCoachesDataTable realizará a leitura das informações retornadas na query e a armazenará em memória.
                    listCoachesDataTable.Load(listCoaches.ExecuteReader());

                    return listCoachesDataTable;
                }

            }
            catch (Exception erro)
            {
                throw new Exception("Ocorreu um erro no método ListCoaches. Caso o problema persista, entre em contato com o Administrador do Sistema. " + erro);

            }
        }
    }
}

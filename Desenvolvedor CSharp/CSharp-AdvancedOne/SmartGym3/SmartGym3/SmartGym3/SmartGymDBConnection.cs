using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGym3
{
    public class SmartGymDBConnection
    {
        //Atributo que armazena a string de conexão com o banco de dados
        private static string connectWithSmartGym = @"DATA SOURCE=DESKTOP-CTIOBN5\MARLONBALLA; Initial Catalog=SmartGYM; User ID=sa; Password=Marlon1993*";
        //Método acessor de leitura da string de conexão
        public static string stringConnectionSmartGym
        {
            get { return connectWithSmartGym; } 
        }
    }
}

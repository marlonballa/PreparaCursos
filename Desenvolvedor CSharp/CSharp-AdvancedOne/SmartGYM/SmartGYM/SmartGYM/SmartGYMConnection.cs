using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGYM
{
    public class SmartGYMConnection
    {
        //String de conexão com a base de dados, privada e estática para evitar acesso e alteração de suas informações
        private static string connectionDBSmartGym = @"Data Source=DESKTOP-CTIOBN5\MARLONBALLA; Initial Catalog=SmartGYM; User ID=sa; Password=Marlon1993*"; 

        //Método responsável por permitir o acesso a string de conexão 
        public static string stringConnectionSmartGYM
        {
            get { return connectionDBSmartGym; }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingSupplies
{
    public class ConnectionBuildingSupplies
    {
        //Armazena a string de Conexão que permitirá acessaro banco de dados
        private static string connectionDBBuildingSupplies = @"Data Source=DESKTOP-CTIOBN5\MARLONBALLA; Initial Catalog=BuildingSupplies; User ID=sa; Password=Marlon1993*";

        //Método que permite o acesso a string de conexão com o Banco de Dados
        public static string returnStringConnectionBuildingSupplies
        {
            get { return connectionDBBuildingSupplies; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Namespace's que contém as classes que manipulam dados
using System.Data;
//O namespace System.Data.SqlClient contém classes específicas para trabalhar com o SQLServer
using System.Data.SqlClient;

//Para usar as propriedades do projeto utilizamos o namespace AcessoBancoDados.Properties
using AcessoBancoDados.Properties;
namespace AcessoBancoDados
{
    public class Class1
    {

        private SqlConnection criarConexao()
        {
            //A classe SqlConnnection está organizada dentro do namespace System.Data.SqlClient
            return new SqlConnection(Settings.Default.stringConexao);
        }

        //A classe System.Data.SqlParameterCollection representa uma coleção de parâmetros associados com um 
        //System.Data.SqlClient.SqlCommand
        private SqlParameterCollection sqlParameterCollection = new SqlCommand().Parameters;

        public void LimparParametros()
        {
            sqlParameterCollection.Clear();
        }

        public void AdicionarParametros(string nomeParametro, object valorParametro)
        {
            sqlParameterCollection.Add(new SqlParameter(nomeParametro, valorParametro));
        }


    }
}

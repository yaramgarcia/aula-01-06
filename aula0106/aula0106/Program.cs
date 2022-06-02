using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace aula0106
{
    class Program
    {
        static void Main(string[] args)
        {
            MySqlConnection conexao = new MySqlConnection ("server=localhost;database=des;uid=root;password=");
            try
            {
                conexao.Open();
            }
            catch(MySqlException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Ocorreu um erro, fale com o Pedro!");
                Environment.Exit(0);
            }
            string sql = "select * from login";
            MySqlCommand cmd = new MySqlCommand(sql,conexao);
            MySqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                Console.WriteLine("Lista de login");

            } else
            {
                Console.WriteLine("Sem dados para exibição");
            }
        }
    }
}

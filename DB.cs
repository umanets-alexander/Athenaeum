using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;

namespace Athenaeum
{
    public class DB
    {
        //создание файла БД
        public static void CreateFile(string filename)
        {
            string databaseName = Path.GetFileNameWithoutExtension(filename);
            using (var connection = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=tempdb; Integrated Security=true;User Instance=True;"))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = String.Format("create database {0} on primary (name={0}, filename='{1}')", databaseName, filename);
                    command.ExecuteNonQuery();
                    command.CommandText = String.Format("exec sp_detach_db '{0}', 'true'", databaseName);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}

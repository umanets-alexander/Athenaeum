using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Athenaeum
{
    public class SqlQuery
    {

        static string filepath = AthenaeumForm.filePath;
        static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + filepath + ";Integrated Security=True";
        static SqlConnection sqlConnection = new SqlConnection(connectionString);
        static string BookTable = "table BookTable (ISBN bigint not null, copyright int not null, storage int not null, author bigint not null, name nvarchar(50) not null, number_pages int not null, genre bigint not null, number_stock int not null, number_issued int default((0)) null, age int not null, release_date int not null, translate_date int not null, translate int not null, description nvarchar(1000) null, primary key clustered(ISBN asc))";
        static string CopyrightTable = "table CopyrightTable (id int identity (1,1) not null, name nvarchar(50) not null, city nvarchar(50) not null, primary key clustered(id asc))";
        static string StorageTable = "table StorageTable (id int identity (1,1) not null, name nvarchar(50) not null, primary key clustered(id asc))";
        static string ListAuthorTable = "table ListAuthorTable (id int identity (1,1) not null, ISBN bigint not null, author int not null, primary key clustered(id asc))";
        static string AuthorTable = "table AuthorTable (id int identity (1,1) not null, name nvarchar(100) not null, primary key clustered(id asc))";
        static string ListGenreTable = "table ListGenreTable (id int identity (1,1) not null, ISBN bigint not null, genre int not null, primary key clustered(id asc))";
        static string GenreTable = "table GenreTable (id int identity (1,1) not null, name nvarchar(50) not null, primary key clustered(id asc))";
        static string TranslateTable = "table TranslateTable (id int identity (1,1) not null, name nvarchar(100) not null, primary key clustered(id asc))";
        static string IssuingTable = "table IssuingTable (id int identity (1,1) not null, librian_issue bigint not null, librian_return bigint null, subscriber bigint not null, ISBN bigint not null, date_issue datetime not null, date_return datetime null, primary key clustered(id asc))";
        static string SubscriberTable = "table SubscriberTable (id int identity (1,1) not null, surname nvarchar(100) not null, name nvarchar(100) not null, patronymic nvarchar(100) null, date_birthday datetime not null, home_Address nvarchar(300) null, passport nvarchar(100) null, place_work nvarchar(100) null, telephone nvarchar(20) null, primary key clustered(id asc))";
        static string LibrianTable = "table LibrianTable (id int identity (1,1) not null, surname nvarchar(100) not null, name nvarchar(100) not null, patronymic nvarchar(100) null, primary key clustered(id asc))";

        public static void CreateTable()
        {
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("create " + BookTable + "; create " + CopyrightTable + "; create " + StorageTable +
                "; create " + ListAuthorTable + "; create " + AuthorTable + "; create " + ListGenreTable + "; create " + GenreTable +
                "; create " + TranslateTable + "; create " + IssuingTable + "; create " + SubscriberTable + "; create " + LibrianTable + ";", sqlConnection);
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public static void UpdateCategory(string namecategory)
        {
            sqlConnection.Open();
            SqlDataReader sqlReader = null;
            CategoryForm.list_table.Rows.Clear();
            SqlCommand cmd = new SqlCommand("", sqlConnection); ;
            if (namecategory == "Genre")
                cmd = new SqlCommand("select * from GenreTable order by name", sqlConnection);
            else if (namecategory == "Storage")
                cmd = new SqlCommand("select * from StorageTable order by name", sqlConnection);
            else if (namecategory == "Author")
                cmd = new SqlCommand("select * from AuthorTable order by name", sqlConnection);
            else if (namecategory == "Translate")
                cmd = new SqlCommand("select * from TranslateTable order by name", sqlConnection);
            else if (namecategory == "Copyright")
                cmd = new SqlCommand("select * from CopyrightTable order by name", sqlConnection);
            try
            {
                sqlReader = cmd.ExecuteReader();
                while (sqlReader.Read())
                {
                    if (namecategory == "Copyright")
                        CategoryForm.list_table.Rows.Add(Convert.ToString(sqlReader["id"]), Convert.ToString(sqlReader["name"]), Convert.ToString(sqlReader["city"]));
                    else
                        CategoryForm.list_table.Rows.Add(Convert.ToString(sqlReader["id"]), Convert.ToString(sqlReader["name"]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null)
                    sqlReader.Close();
            }
            sqlConnection.Close();
        }

        public static void AddCategory(string namecategory, string textcategory_one, string textcategory_two)
        {
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("", sqlConnection); ;
            if (namecategory == "Genre")
                cmd = new SqlCommand("insert into GenreTable (name) values (@name)", sqlConnection);
            else if (namecategory == "Storage")
                cmd = new SqlCommand("insert into StorageTable (name) values (@name)", sqlConnection);
            else if (namecategory == "Author")
                cmd = new SqlCommand("insert into AuthorTable (name) values (@name)", sqlConnection);
            else if (namecategory == "Translate")
                cmd = new SqlCommand("insert into TranslateTable (name) values (@name)", sqlConnection);
            else if (namecategory == "Copyright")
                cmd = new SqlCommand("insert into CopyrightTable (name, city) values (@name, @city)", sqlConnection);
            if (namecategory == "Copyright")
            {
                cmd.Parameters.AddWithValue("name", textcategory_one);
                cmd.Parameters.AddWithValue("city", textcategory_two);
            }
            else
                cmd.Parameters.AddWithValue("name", textcategory_one);
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public static void EditingCategory(string namecategory, string textcategory_one, string textcategory_two)
        {
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("", sqlConnection); ;
            if (namecategory == "Genre")
                cmd = new SqlCommand("update GenreTable set name=@name where id=@id", sqlConnection);
            else if (namecategory == "Storage")
                cmd = new SqlCommand("update StorageTable set name=@name where id=@id", sqlConnection);
            else if (namecategory == "Author")
                cmd = new SqlCommand("update AuthorTable set name=@name where id=@id", sqlConnection);
            else if (namecategory == "Translate")
                cmd = new SqlCommand("update TranslateTable set name=@name where id=@id", sqlConnection);
            else if (namecategory == "Copyright")
                cmd = new SqlCommand("update CopyrightTable set name=@name, city=@city where id=@id", sqlConnection);
            if (namecategory == "Copyright")
            {
                cmd.Parameters.AddWithValue("name", textcategory_one);
                cmd.Parameters.AddWithValue("city", textcategory_two);
                cmd.Parameters.AddWithValue("id", CategoryForm.list_table[0, CategoryForm.list_table.CurrentRow.Index].Value.ToString());
            }
            else
            {
                cmd.Parameters.AddWithValue("name", textcategory_one);
                cmd.Parameters.AddWithValue("id", CategoryForm.list_table[0,CategoryForm.list_table.CurrentRow.Index].Value.ToString());
            }
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public static void DeleteCategory(string namecategory, int key)
        {
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("", sqlConnection); ;
            if (namecategory == "Genre")
                cmd = new SqlCommand("delete from GenreTable where id=@id", sqlConnection);
            else if (namecategory == "Storage")
                cmd = new SqlCommand("delete from StorageTable where id=@id", sqlConnection);
            else if (namecategory == "Author")
                cmd = new SqlCommand("delete from AuthorTable where id=@id", sqlConnection);
            else if (namecategory == "Translate")
                cmd = new SqlCommand("delete from TranslateTable where id=@id", sqlConnection);
            else if (namecategory == "Copyright")
                cmd = new SqlCommand("delete from CopyrightTable where id=@id", sqlConnection);
            cmd.Parameters.AddWithValue("id", key);
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }
    }
}

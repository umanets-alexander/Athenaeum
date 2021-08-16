using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Athenaeum
{
    public partial class AthenaeumForm : Form
    {
        //файл БД хранитс в папке database
        public static string filePath = Path.GetFullPath(@"database\athenaeum.mdf");
        
        public AthenaeumForm()
        {
            InitializeComponent();
            //позиция окна при запуске - по центру экрана
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void AthenaeumForm_Shown(object sender, EventArgs e)
        {
            //скачивание всех иконок и картинок необходимых для полноценной работы
            ImageFile.DownloadImageGitHub();
            //проверяем существует ли файл БД
            if (File.Exists(filePath) == false)
            {
                //создаём директорию database
                Directory.CreateDirectory("database");
                string fullPath = Path.GetFullPath(@"database");
                var filename = System.IO.Path.Combine(fullPath, "athenaeum.mdf");
                //создаём файл БД
                DB.CreateFile(filename);
                //создаём таблицы в БД
                SqlQuery.CreateTable();
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        //открываем окно для просмотра списка издательства
        private void издательстваToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryForm Category;
            Category = new CategoryForm();
            //заполняем новую форму необходимыми элементами
            Category.Release_form();
            //заполняем необходимыми свойствами форму
            Category.Copyright();
            //запускаем окно просмотра
            Category.Show();
            //выполняем запрос на загрузку данных БД
            SqlQuery.UpdateCategory("Copyright");
        }

        //открываем окно для просмотра списка мест хранения книг
        private void местаХраненияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryForm Category;
            Category = new CategoryForm();
            Category.Release_form();
            Category.Storage();
            Category.Show();
            SqlQuery.UpdateCategory("Storage");
        }

        //открываем окно для просмотра списка авторов
        private void авторыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryForm Category;
            Category = new CategoryForm();
            Category.Release_form();
            Category.Author();
            Category.Show();
            SqlQuery.UpdateCategory("Author");
        }

        //открываем окно для просмотра списка жанра книг
        private void жанрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryForm Category;
            Category = new CategoryForm();
            Category.Release_form();
            Category.Genre();
            Category.Show();
            SqlQuery.UpdateCategory("Genre");

        }

        //открываем окно для просмотра списка переводчиков книг
        private void переводчикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryForm Category;
            Category = new CategoryForm();
            Category.Release_form();
            Category.Translate();
            Category.Show();
            SqlQuery.UpdateCategory("Translate");
        }

        //открываем окно для просмотра списка абонентов библиотеки
        private void абонентыToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void читателиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InformationForm Information;
            Information = new InformationForm();
            Information.Release_form();
            Information.Readers();
            Information.Show();
            SqlQuery.UpdateInformation("Readers");
        }
    }
}

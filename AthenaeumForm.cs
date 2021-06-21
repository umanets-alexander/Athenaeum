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

        public static string filePath = Path.GetFullPath(@"database\athenaeum.mdf");
        
        public AthenaeumForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void AthenaeumForm_Shown(object sender, EventArgs e)
        {
            if (File.Exists(filePath) == false)
            {
                Directory.CreateDirectory("database");
                string fullPath = Path.GetFullPath(@"database");
                var filename = System.IO.Path.Combine(fullPath, "athenaeum.mdf");
                DB.CreateFile(filename);
                SqlQuery.CreateTable();
            }
        }

        private void типИздательстваToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void издательстваToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryForm Category;
            Category = new CategoryForm();
            Category.Release_form();
            Category.Copyright();
            Category.Show();
            SqlQuery.UpdateCategory("Copyright");
        }

        private void местаХраненияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryForm Category;
            Category = new CategoryForm();
            Category.Release_form();
            Category.Storage();
            Category.Show();
            SqlQuery.UpdateCategory("Storage");
        }

        private void авторыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryForm Category;
            Category = new CategoryForm();
            Category.Release_form();
            Category.Author();
            Category.Show();
            SqlQuery.UpdateCategory("Author");
        }

        private void жанрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryForm Category;
            Category = new CategoryForm();
            Category.Release_form();
            Category.Genre();
            Category.Show();
            SqlQuery.UpdateCategory("Genre");

        }

        private void переводчикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryForm Category;
            Category = new CategoryForm();
            Category.Release_form();
            Category.Translate();
            Category.Show();
            SqlQuery.UpdateCategory("Translate");
        }

        private void абонентыToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

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

namespace Athenaeum
{
    public partial class MessageForm : Form
    {
        public MessageForm()
        {
            InitializeComponent();
            this.Icon = new Icon(Path.GetFullPath(@"icon\message.ico"));
            btn_yes.Image = Image.FromFile(Path.GetFullPath(@"icon\message-yes.png"));
            btn_no.Image = Image.FromFile(Path.GetFullPath(@"icon\message-no.png"));
            pictureBox1.Image = Image.FromFile(Path.GetFullPath(@"icon\message-warning.png"));
        }

        private void btn_no_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void btn_yes_click(string text, string name, int id)
        {
            if (text == "CopyrightDelete")
            {
                labeltext.Text = "Вы действительно хотите удалить запись издательства " + name + "?";
                this.Text = "Удаление записи издательства " + name;
                btn_yes.Click += (object senders, EventArgs se) =>
                {
                    SqlQuery.DeleteCategory("Copyright", id);
                    SqlQuery.UpdateCategory("Copyright");
                    Close();
                };
            }
            else if (text == "StorageDelete")
            {
                labeltext.Text = "Вы действительно хотите удалить запись места хранения " + name + "?";
                this.Text = "Удаление записи места хранения " + name;
                btn_yes.Click += (object senders, EventArgs se) =>
                {
                    SqlQuery.DeleteCategory("Storage", id);
                    SqlQuery.UpdateCategory("Storage");
                    Close();
                };
            }
            else if (text == "AuthorDelete")
            {
                labeltext.Text = "Вы действительно хотите удалить запись автора " + name + "?";
                this.Text = "Удаление записи автора " + name;
                btn_yes.Click += (object senders, EventArgs se) =>
                {
                    SqlQuery.DeleteCategory("Author", id);
                    SqlQuery.UpdateCategory("Author");
                    Close();
                };
            }
            else if (text == "GenreDelete")
            {
                labeltext.Text = "Вы действительно хотите удалить запись жанра " + name + "?";
                this.Text = "Удаление записи жанра " + name;
                btn_yes.Click += (object senders, EventArgs se) =>
                {
                    SqlQuery.DeleteCategory("Genre", id);
                    SqlQuery.UpdateCategory("Genre");
                    Close();
                };
            }
            else if (text == "TranslateDelete")
            {
                labeltext.Text = "Вы действительно хотите удалить запись переводчика " + name + "?";
                this.Text = "Удаление записи переводчика " + name;
                btn_yes.Click += (object senders, EventArgs se) =>
                {
                    SqlQuery.DeleteCategory("Translate", id);
                    SqlQuery.UpdateCategory("Translate");
                    Close();
                };
            }
        }
    }
}

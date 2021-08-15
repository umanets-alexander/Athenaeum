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
            //задаём иконку для окна
            this.Icon = new Icon(Path.GetFullPath(@"icon\message.ico"));
            //задаём изображения для сообщения и кнопок
            btn_yes.Image = Image.FromFile(Path.GetFullPath(@"icon\message-yes.png"));
            btn_no.Image = Image.FromFile(Path.GetFullPath(@"icon\message-no.png"));
            pictureBox1.Image = Image.FromFile(Path.GetFullPath(@"icon\message-warning.png"));
        }

        //закрытие окна уведомления
        private void btn_no_Click(object sender, EventArgs e)
        {
            Close();
        }

        //у каждой процедуры уведомления о удалении свой вариант удаления записи
        public void btn_yes_click(string text, string name, int id)
        {
            //проверяем чья процедура для удаления записи
            if (text == "CopyrightDelete")
            {
                //выводим текст в окне об удалении записи
                labeltext.Text = "Вы действительно хотите удалить запись издательства " + name + "?";
                //выводим заголовок окна удаления записи
                this.Text = "Удаление записи издательства " + name;
                //задаём действие кнопки подтверждения удаления записи
                btn_yes.Click += (object senders, EventArgs se) =>
                {
                    //отправляем запрос на удаление записи
                    SqlQuery.DeleteCategory("Copyright", id);
                    //обновляем список БД
                    SqlQuery.UpdateCategory("Copyright");
                    //возвращаемся к просмотру записей закрывая окно удаления записи
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

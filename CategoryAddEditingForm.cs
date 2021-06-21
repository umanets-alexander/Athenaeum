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
    public partial class CategoryAddEditingForm : Form
    {

        Button btn_add = new Button();
        Button btn_editing = new Button();
        Button btn_close = new Button();
        Label label_one = new Label();
        Label label_two = new Label();
        public static TextBox textbox_one = new TextBox();
        public static TextBox textbox_two = new TextBox();

        public CategoryAddEditingForm()
        {
            InitializeComponent();
            this.Icon = new Icon(Path.GetFullPath(@"icon\category-add-and-editing.ico"));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Size = new Size(414, 126);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public void Release_form()
        {
            btn_add.Size = btn_editing.Size = btn_close.Size = new Size(40, 40);
            btn_add.Text = btn_editing.Text = btn_close.Text = "";
            btn_add.Image = Image.FromFile(Path.GetFullPath(@"icon\category-add.png"));
            btn_editing.Image = Image.FromFile(Path.GetFullPath(@"icon\category-editing.png"));
            btn_close.Image = Image.FromFile(Path.GetFullPath(@"icon\category-close.png"));
            btn_add.Location = new Point(300, 35);
            btn_editing.Location = new Point(300, 35);
            btn_close.Location = new Point(346, 35);
            label_one.Text = "";
            label_one.AutoSize = true;
            label_one.Location = new Point(13,9);
            textbox_one.Text = "";
            textbox_one.Size = new Size(287,24);
            textbox_one.Location = new Point(99,6);
            this.Controls.Add(btn_close);
            this.Controls.Add(label_one);
            this.Controls.Add(textbox_one);
            btn_close.Click += (object senders, EventArgs se) =>
            {
                this.Close();
            };
        }

        public void StorageAddEditing()
        {
            label_one.Text = "Название:";
            if (this.Text == "Добавление категории выборки -  Места хранения")
            {
                this.Controls.Add(btn_add);
                btn_add.Click += (object senders, EventArgs se) =>
                {
                    SqlQuery.AddCategory("Storage", textbox_one.Text, null);
                    SqlQuery.UpdateCategory("Storage");
                    this.Close();
                };
            }
                else
            {
                this.Controls.Add(btn_editing);
                btn_editing.Click += (object senders, EventArgs se) =>
                {
                    SqlQuery.EditingCategory("Storage", textbox_one.Text, null);
                    SqlQuery.UpdateCategory("Storage");
                    this.Close();
                };
            }
        }

        public void AuthorAddEditing()
        {
            label_one.Text = "Автор:";
            textbox_one.Size = new Size(313, 24);
            textbox_one.Location = new Point(73, 6);
            if (this.Text == "Добавление категории выборки - Авторы")
            {
                this.Controls.Add(btn_add);
                btn_add.Click += (object senders, EventArgs se) =>
                {
                    SqlQuery.AddCategory("Author", textbox_one.Text, null);
                    SqlQuery.UpdateCategory("Author");
                    this.Close();
                };
            }
            else
            {
                this.Controls.Add(btn_editing);
                btn_editing.Click += (object senders, EventArgs se) =>
                {
                    SqlQuery.EditingCategory("Author", textbox_one.Text, null);
                    SqlQuery.UpdateCategory("Author");
                    this.Close();
                };
            }
        }

        public void GenreAddEditing()
        {
            label_one.Text = "Название:";
            if (this.Text == "Добавление категории выборки - Жанры")
            {
                this.Controls.Add(btn_add);
                btn_add.Click += (object senders, EventArgs se) =>
                {
                    SqlQuery.AddCategory("Genre", textbox_one.Text, null);
                    SqlQuery.UpdateCategory("Genre");
                    this.Close();
                };
            }
            else
            {
                this.Controls.Add(btn_editing);
                btn_editing.Click += (object senders, EventArgs se) =>
                {
                    SqlQuery.EditingCategory("Genre", textbox_one.Text, null);
                    SqlQuery.UpdateCategory("Genre");
                    this.Close();
                };
            }
        }

        public void TranslateAddEditing()
        {
            label_one.Text = "Переводчик:";
            textbox_one.Size = new Size(269, 24);
            textbox_one.Location = new Point(117, 6);
            if (this.Text == "Добавление категории выборки - Переводчики")
            {
                this.Controls.Add(btn_add);
                btn_add.Click += (object senders, EventArgs se) =>
                {
                    SqlQuery.AddCategory("Translate", textbox_one.Text, null);
                    SqlQuery.UpdateCategory("Translate");
                    this.Close();
                };
            }
            else
            {
                this.Controls.Add(btn_editing);
                btn_editing.Click += (object senders, EventArgs se) =>
                {
                    SqlQuery.EditingCategory("Translate", textbox_one.Text, null);
                    SqlQuery.UpdateCategory("Translate");
                    this.Close();
                };
            }
        }

        public void CopyrightAddEditing()
        {
            this.Size = new Size(414, 156);
            label_one.Text = "Название:";
            label_two.Text = "Город";
            label_two.AutoSize = true;
            label_two.Location = new Point(13, 39);
            textbox_two.Text = "";
            textbox_two.Size = new Size(287, 24);
            textbox_two.Location = new Point(99, 36);
            btn_add.Location = new Point(300, 66);
            btn_editing.Location = new Point(300, 66);
            btn_close.Location = new Point(346, 66);
            this.Controls.Add(label_two);
            this.Controls.Add(textbox_two);
            if (this.Text == "Добавление категории выборки - Издательства")
            {
                this.Controls.Add(btn_add);
                btn_add.Click += (object senders, EventArgs se) =>
                {
                    SqlQuery.AddCategory("Copyright", textbox_one.Text, textbox_two.Text);
                    SqlQuery.UpdateCategory("Copyright");
                    this.Close();
                };
            }
            else
            {
                this.Controls.Add(btn_editing);
                btn_editing.Click += (object senders, EventArgs se) =>
                {
                    SqlQuery.EditingCategory("Copyright", textbox_one.Text, textbox_two.Text);
                    SqlQuery.UpdateCategory("Copyright");
                    this.Close();
                };
            }
        }

        private void CategoryAddEditingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Controls.Clear();
        }
    }
}

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
    public partial class CategoryForm : Form
    {
        Button btn_add = new Button();
        Button btn_editing = new Button();
        Button btn_delete = new Button();
        Button btn_close = new Button();
        public static DataGridView list_table = new DataGridView();
        CategoryAddEditingForm CategoryAddEditing;
        MessageForm MessageWarning;

        public CategoryForm()
        {
            InitializeComponent();
            this.Icon = new Icon(Path.GetFullPath(@"icon\category.ico"));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Size = new Size(452, 477);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public void Release_form()
        {
            btn_add.Size = btn_editing.Size = btn_delete.Size = btn_close.Size = new Size(40, 40);
            btn_add.Text = btn_editing.Text = btn_delete.Text = btn_close.Text = "";
            btn_add.Image = Image.FromFile(Path.GetFullPath(@"icon\category-add.png"));
            btn_editing.Image = Image.FromFile(Path.GetFullPath(@"icon\category-editing.png"));
            btn_delete.Image = Image.FromFile(Path.GetFullPath(@"icon\category-delete.png"));
            btn_close.Image = Image.FromFile(Path.GetFullPath(@"icon\category-close.png"));
            btn_add.Location = new Point(247, 388);
            btn_editing.Location = new Point(293, 388);
            btn_delete.Location = new Point(339, 388);
            btn_close.Location = new Point(385, 388);
            list_table.Size = new Size(413, 370);
            list_table.Location = new Point(12, 12);
            list_table.RowHeadersVisible = false;
            list_table.AllowUserToAddRows = false;
            list_table.AllowUserToDeleteRows = false;
            list_table.ReadOnly = false;
            this.Controls.Add(btn_add);
            this.Controls.Add(btn_editing);
            this.Controls.Add(btn_delete);
            this.Controls.Add(btn_close);
            btn_close.Click += (object senders, EventArgs se) =>
            {
                this.Close();
            };
        }

        public void Copyright()
        {
            this.Text = "Управление категориями выборки - Издательства";
            list_table.Columns.Add("id", "Номер");
            list_table.Columns.Add("name", "Название");
            list_table.Columns.Add("city", "Город");
            list_table.Columns[0].Visible = false;
            list_table.Columns[1].Width = 200;
            this.Controls.Add(list_table);
            list_table.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            btn_add.Click += (object senders, EventArgs se) =>
            {
                CategoryAddEditing = new CategoryAddEditingForm();
                CategoryAddEditing.Release_form();
                CategoryAddEditing.Text = "Добавление категории выборки - Издательства";
                CategoryAddEditing.CopyrightAddEditing();
                CategoryAddEditing.Show();
            };
            btn_editing.Click += (object senders, EventArgs se) =>
            {
                CategoryAddEditing = new CategoryAddEditingForm();
                CategoryAddEditing.Release_form();
                CategoryAddEditing.Text = "Изменение категории выборки - Издательства";
                CategoryAddEditing.CopyrightAddEditing();
                CategoryAddEditing.Show();
                CategoryAddEditingForm.textbox_one.Text = list_table[1, list_table.CurrentRow.Index].Value.ToString();
                CategoryAddEditingForm.textbox_two.Text = list_table[2, list_table.CurrentRow.Index].Value.ToString();
            };
            btn_delete.Click += (object senders, EventArgs se) =>
            {
                MessageWarning = new MessageForm();
                MessageWarning.btn_yes_click("CopyrightDelete", list_table[1, list_table.CurrentRow.Index].Value.ToString(), Convert.ToInt32(list_table[0, list_table.CurrentRow.Index].Value));
                MessageWarning.Show();
            };
        }

        public void Storage()
        {
            this.Text = "Управление категориями выборки - Места хранения";
            list_table.Columns.Add("id", "Номер");
            list_table.Columns[0].Visible = false;
            list_table.Columns.Add("name", "Название места хранения");
            list_table.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.Controls.Add(list_table);
            btn_add.Click += (object senders, EventArgs se) =>
            {
                CategoryAddEditing = new CategoryAddEditingForm();
                CategoryAddEditing.Release_form();
                CategoryAddEditing.Text = "Добавление категории выборки -  Места хранения";
                CategoryAddEditing.StorageAddEditing();
                CategoryAddEditing.Show();
            };
            btn_editing.Click += (object senders, EventArgs se) =>
            {
                CategoryAddEditing = new CategoryAddEditingForm();
                CategoryAddEditing.Release_form();
                CategoryAddEditing.Text = "Изменение категории выборки -  Места хранения";
                CategoryAddEditing.StorageAddEditing();
                CategoryAddEditing.Show();
                CategoryAddEditingForm.textbox_one.Text = list_table[1, list_table.CurrentRow.Index].Value.ToString();
            };
            btn_delete.Click += (object senders, EventArgs se) =>
            {
                MessageWarning = new MessageForm();
                MessageWarning.btn_yes_click("StorageDelete", list_table[1, list_table.CurrentRow.Index].Value.ToString(), Convert.ToInt32(list_table[0, list_table.CurrentRow.Index].Value));
                MessageWarning.Show();
            };
        }

        public void Author()
        {
            this.Text = "Управление категориями выборки - Авторы";
            list_table.Columns.Add("id", "Номер");
            list_table.Columns[0].Visible = false;
            list_table.Columns.Add("name", "ФИО автора");
            list_table.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.Controls.Add(list_table);
            btn_add.Click += (object senders, EventArgs se) =>
            {
                CategoryAddEditing = new CategoryAddEditingForm();
                CategoryAddEditing.Release_form();
                CategoryAddEditing.Text = "Добавление категории выборки - Авторы";
                CategoryAddEditing.AuthorAddEditing();
                CategoryAddEditing.Show();
            };
            btn_editing.Click += (object senders, EventArgs se) =>
            {
                CategoryAddEditing = new CategoryAddEditingForm();
                CategoryAddEditing.Release_form();
                CategoryAddEditing.Text = "Изменение категории выборки - Авторы";
                CategoryAddEditing.AuthorAddEditing();
                CategoryAddEditing.Show();
                CategoryAddEditingForm.textbox_one.Text = list_table[1, list_table.CurrentRow.Index].Value.ToString();
            };
            btn_delete.Click += (object senders, EventArgs se) =>
            {
                MessageWarning = new MessageForm();
                MessageWarning.btn_yes_click("AuthorDelete", list_table[1, list_table.CurrentRow.Index].Value.ToString(), Convert.ToInt32(list_table[0, list_table.CurrentRow.Index].Value));
                MessageWarning.Show();
            };
        }

        public void Genre()
        {
            this.Text = "Управление категориями выборки - Жанры";
            list_table.Columns.Add("id", "Номер");
            list_table.Columns[0].Visible = false;
            list_table.Columns.Add("name", "Жанр");
            list_table.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.Controls.Add(list_table);
            btn_add.Click += (object senders, EventArgs se) =>
            {
                CategoryAddEditing = new CategoryAddEditingForm();
                CategoryAddEditing.Release_form();
                CategoryAddEditing.Text = "Добавление категории выборки - Жанры";
                CategoryAddEditing.GenreAddEditing();
                CategoryAddEditing.Show();
            };
            btn_editing.Click += (object senders, EventArgs se) =>
            {
                CategoryAddEditing = new CategoryAddEditingForm();
                CategoryAddEditing.Release_form();
                CategoryAddEditing.Text = "Изменение категории выборки - Жанры";
                CategoryAddEditing.GenreAddEditing();
                CategoryAddEditing.Show();
                CategoryAddEditingForm.textbox_one.Text = list_table[1, list_table.CurrentRow.Index].Value.ToString();
            };
            btn_delete.Click += (object senders, EventArgs se) =>
            {
                MessageWarning = new MessageForm();
                MessageWarning.btn_yes_click("GenreDelete", list_table[1, list_table.CurrentRow.Index].Value.ToString(), Convert.ToInt32(list_table[0, list_table.CurrentRow.Index].Value));
                MessageWarning.Show();
            };
        }

        public void Translate()
        {
            this.Text = "Управление категориями выборки - Переводчики";
            list_table.Columns.Add("id", "Номер");
            list_table.Columns[0].Visible = false;
            list_table.Columns.Add("name", "ФИО/наименование");
            list_table.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.Controls.Add(list_table);
            btn_add.Click += (object senders, EventArgs se) =>
            {
                CategoryAddEditing = new CategoryAddEditingForm();
                CategoryAddEditing.Release_form();
                CategoryAddEditing.Text = "Добавление категории выборки - Переводчики";
                CategoryAddEditing.TranslateAddEditing();
                CategoryAddEditing.Show();
            };
            btn_editing.Click += (object senders, EventArgs se) =>
            {
                CategoryAddEditing = new CategoryAddEditingForm();
                CategoryAddEditing.Release_form();
                CategoryAddEditing.Text = "Изменение категории выборки - Переводчики";
                CategoryAddEditing.TranslateAddEditing();
                CategoryAddEditing.Show();
                CategoryAddEditingForm.textbox_one.Text = list_table[1, list_table.CurrentRow.Index].Value.ToString();
            };
            btn_delete.Click += (object senders, EventArgs se) =>
            {
                MessageWarning = new MessageForm();
                MessageWarning.btn_yes_click("TranslateDelete", list_table[1, list_table.CurrentRow.Index].Value.ToString(), Convert.ToInt32(list_table[0, list_table.CurrentRow.Index].Value));
                MessageWarning.Show();
            };
        }

        private void CategoryForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            list_table.Columns.Clear();
            this.Controls.Clear();
        }
    }
}

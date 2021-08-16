using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Athenaeum
{
    public partial class InformationForm : Form
    {
        //добавляем компоненты кнопок добавление/редактирование/удаление/закрытие
        Button btn_add = new Button();
        Button btn_editing = new Button();
        Button btn_delete = new Button();
        Button btn_close = new Button();
        public static DataGridView list_table = new DataGridView();

        public InformationForm()
        {
            InitializeComponent();
            //задаём иконку окна и свойства окна
            this.Icon = new Icon(Path.GetFullPath(@"icon\category.ico"));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Size = new Size(663, 438);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        //релиз формы, а именно её создание всех элементов окна, кнопок и их иконки
        public void Release_form()
        {
            btn_add.Size = btn_editing.Size = btn_delete.Size = btn_close.Size = new Size(40, 40);
            btn_add.Text = btn_editing.Text = btn_delete.Text = btn_close.Text = "";
            btn_add.Image = Image.FromFile(Path.GetFullPath(@"icon\category-add.png"));
            btn_editing.Image = Image.FromFile(Path.GetFullPath(@"icon\category-editing.png"));
            btn_delete.Image = Image.FromFile(Path.GetFullPath(@"icon\category-delete.png"));
            btn_close.Image = Image.FromFile(Path.GetFullPath(@"icon\category-close.png"));
            btn_add.Location = new Point(457, 347);
            btn_editing.Location = new Point(503, 347);
            btn_delete.Location = new Point(549, 347);
            btn_close.Location = new Point(595, 347);
            list_table.Size = new Size(623, 329);
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

        //задание свойств окна для категории издательства
        public void Readers()
        {
            //задаём заголовок окна
            this.Text = "Данные читателей библиотеки";
            //создаём заголовки столбцов
            list_table.Columns.Add("id", "Номер");
            list_table.Columns.Add("name", "ФИО");
            list_table.Columns.Add("date", "Дата рождения");
            list_table.Columns.Add("address", "Адрес");
            list_table.Columns.Add("pass", "№ паспорта");
            list_table.Columns.Add("work", "Место работы");
            list_table.Columns.Add("tel", "Номер телефона");
            //делаем первый заголовок столбца номеров невидимым
            list_table.Columns[0].Visible = false;
            //задаём ширину столбцам
            list_table.Columns[1].Width = 150;
            list_table.Columns[2].Width = 95;
            list_table.Columns[3].Width = 100;
            list_table.Columns[4].Width = 80;
            list_table.Columns[5].Width = 85;
            //реализуем компонент таблицы БД
            this.Controls.Add(list_table);
            //задаём автоматическую ширину последнего заголовка
            list_table.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //задаём действие для кнопки добавления новой записи
            /*btn_add.Click += (object senders, EventArgs se) =>
            {
                CategoryAddEditing = new CategoryAddEditingForm();
                //реализуем форму добавления/редактирования формы
                CategoryAddEditing.Release_form();
                //задаём заголовок окну
                CategoryAddEditing.Text = "Добавление категории выборки - Издательства";
                //задаём процедуру добавления/редактирования записи
                CategoryAddEditing.CopyrightAddEditing();
                //запускаем окно
                CategoryAddEditing.Show();
            };
            //задаём действие для кнопки редактирования записи
            btn_editing.Click += (object senders, EventArgs se) =>
            {
                CategoryAddEditing = new CategoryAddEditingForm();
                //реализуем форму добавления/редактирования формы
                CategoryAddEditing.Release_form();
                //задаём заголовок окну
                CategoryAddEditing.Text = "Изменение категории выборки - Издательства";
                //задаём процедуру добавления/редактирования записи
                CategoryAddEditing.CopyrightAddEditing();
                //запускаем окно
                CategoryAddEditing.Show();
                //в поле текста вставляем необходимые данные для изменения
                CategoryAddEditingForm.textbox_one.Text = list_table[1, list_table.CurrentRow.Index].Value.ToString();
                CategoryAddEditingForm.textbox_two.Text = list_table[2, list_table.CurrentRow.Index].Value.ToString();
            };
            //задаём действие для кнопки удаления записи
            btn_delete.Click += (object senders, EventArgs se) =>
            {
                MessageWarning = new MessageForm();
                //задаём данные для уведомления об удалении записи
                MessageWarning.btn_yes_click("CopyrightDelete", list_table[1, list_table.CurrentRow.Index].Value.ToString(), Convert.ToInt32(list_table[0, list_table.CurrentRow.Index].Value));
                //запускаем уведомления об удалении записи
                MessageWarning.Show();
            };*/
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void InformationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            list_table.Columns.Clear();
            this.Controls.Clear();
        }
    }
}

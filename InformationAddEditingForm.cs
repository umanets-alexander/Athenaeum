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
    public partial class InformationAddEditingForm : Form
    {
        Button btn_add = new Button();
        Button btn_editing = new Button();
        Button btn_close = new Button();
        Label label_one = new Label();
        Label label_two = new Label();
        Label label_three = new Label();
        Label label_four = new Label();
        Label label_five = new Label();
        Label label_six = new Label();
        Label label_seven = new Label();
        Label label_eight = new Label();
        public static TextBox textbox_one = new TextBox();
        public static TextBox textbox_two = new TextBox();
        public static TextBox textbox_three = new TextBox();
        public static TextBox textbox_four = new TextBox();
        public static TextBox textbox_five = new TextBox();
        public static DateTimePicker dateTime = new DateTimePicker();
        public static RichTextBox richTextBox_one = new RichTextBox();
        public static RichTextBox richTextBox_two = new RichTextBox();

        public InformationAddEditingForm()
        {
            InitializeComponent();
            this.Icon = new Icon(Path.GetFullPath(@"icon\category-add-and-editing.ico"));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public void ReadersAddEditing()
        {
            btn_add.Size = btn_editing.Size = btn_close.Size = new Size(40, 40);
            btn_add.Text = btn_editing.Text = btn_close.Text = "";
            btn_add.Image = Image.FromFile(Path.GetFullPath(@"icon\category-add.png"));
            btn_editing.Image = Image.FromFile(Path.GetFullPath(@"icon\category-editing.png"));
            btn_close.Image = Image.FromFile(Path.GetFullPath(@"icon\category-close.png"));
            btn_add.Location = new Point(300, 394);
            btn_editing.Location = new Point(300, 394);
            btn_close.Location = new Point(346, 394);
            label_one.Text = "Фамилия:";
            label_one.AutoSize = true;
            label_one.Location = new Point(13, 9);
            label_two.Text = "Имя:";
            label_two.AutoSize = true;
            label_two.Location = new Point(13, 43);
            label_three.Text = "Отчество:";
            label_three.AutoSize = true;
            label_three.Location = new Point(13, 73);
            label_four.Text = "Дата рождения:";
            label_four.AutoSize = true;
            label_four.Location = new Point(13, 105);
            label_five.Text = "Домашний адрес:";
            label_five.AutoSize = true;
            label_five.Location = new Point(13, 133);
            label_six.Text = "Номер паспорта:";
            label_six.AutoSize = true;
            label_six.Location = new Point(13, 235);
            label_seven.Text = "Место работы:";
            label_seven.AutoSize = true;
            label_seven.Location = new Point(13, 265);
            label_eight.Text = "Номер телефона:";
            label_eight.AutoSize = true;
            label_eight.Location = new Point(13, 367);
            textbox_one.Text = "";
            textbox_one.Size = new Size(289, 24);
            textbox_one.Location = new Point(97, 6);
            textbox_two.Text = "";
            textbox_two.Size = new Size(289, 24);
            textbox_two.Location = new Point(97, 40);
            textbox_three.Text = "";
            textbox_three.Size = new Size(289, 24);
            textbox_three.Location = new Point(97, 70);
            textbox_four.Text = "";
            textbox_four.Size = new Size(234, 24);
            textbox_four.Location = new Point(152, 232);
            textbox_five.Text = "";
            textbox_five.Size = new Size(234, 24);
            textbox_five.Location = new Point(152, 364);
            dateTime.Format = DateTimePickerFormat.Custom;
            dateTime.CustomFormat = "dd.MM.yyyy";
            dateTime.Size = new Size(234, 24);
            dateTime.Location = new Point(152, 100);
            richTextBox_one.Size = new Size(234, 96);
            richTextBox_one.Location = new Point(152, 130);
            richTextBox_two.Size = new Size(234, 96);
            richTextBox_two.Location = new Point(152, 262);
            this.Size = new Size(414, 484);
            this.Controls.Add(btn_close);
            this.Controls.Add(label_one);
            this.Controls.Add(label_two);
            this.Controls.Add(label_three);
            this.Controls.Add(label_four);
            this.Controls.Add(label_five);
            this.Controls.Add(label_six);
            this.Controls.Add(label_seven);
            this.Controls.Add(label_eight);
            this.Controls.Add(textbox_one);
            this.Controls.Add(textbox_two);
            this.Controls.Add(textbox_three);
            this.Controls.Add(textbox_four);
            this.Controls.Add(textbox_five);
            this.Controls.Add(dateTime);
            this.Controls.Add(richTextBox_one);
            this.Controls.Add(richTextBox_two);
            btn_close.Click += (object senders, EventArgs se) =>
            {
                this.Close();
            };
            if (this.Text == "Добавление данных -  Читатели")
            {
                this.Controls.Add(btn_add);
                btn_add.Click += (object senders, EventArgs se) =>
                {
                    SqlQuery.AddInformation("Readers", textbox_one.Text, textbox_two.Text, textbox_three.Text, dateTime.Value.ToString("dd.MM.yyyy"), richTextBox_one.Text, textbox_four.Text, richTextBox_two.Text, textbox_five.Text);
                    SqlQuery.UpdateInformation("Readers");
                    this.Close();
                };
            }

        }

        private void InformationAddEditingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Controls.Clear();
        }
    }
}

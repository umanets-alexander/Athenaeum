
namespace Athenaeum
{
    partial class AthenaeumForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.управлениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.издательстваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.местаХраненияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.жанрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.авторыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.переводчикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.абонентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.читателиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.библиотекариToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.получитьИнформациюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.популярныйАвторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.популярныйЖанрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.книгиПользующиесяНаименьшейПопулярностьюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.должникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.абонентыНеПользующиесяУслугойToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem,
            this.управлениеToolStripMenuItem,
            this.абонентыToolStripMenuItem,
            this.получитьИнформациюToolStripMenuItem,
            this.файлToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // управлениеToolStripMenuItem
            // 
            this.управлениеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.издательстваToolStripMenuItem,
            this.местаХраненияToolStripMenuItem,
            this.жанрToolStripMenuItem,
            this.авторыToolStripMenuItem,
            this.переводчикиToolStripMenuItem});
            this.управлениеToolStripMenuItem.Name = "управлениеToolStripMenuItem";
            this.управлениеToolStripMenuItem.Size = new System.Drawing.Size(211, 20);
            this.управлениеToolStripMenuItem.Text = "Управление категориями выборки";
            // 
            // издательстваToolStripMenuItem
            // 
            this.издательстваToolStripMenuItem.Name = "издательстваToolStripMenuItem";
            this.издательстваToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.издательстваToolStripMenuItem.Text = "Издательства";
            this.издательстваToolStripMenuItem.Click += new System.EventHandler(this.издательстваToolStripMenuItem_Click);
            // 
            // местаХраненияToolStripMenuItem
            // 
            this.местаХраненияToolStripMenuItem.Name = "местаХраненияToolStripMenuItem";
            this.местаХраненияToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.местаХраненияToolStripMenuItem.Text = "Места хранения";
            this.местаХраненияToolStripMenuItem.Click += new System.EventHandler(this.местаХраненияToolStripMenuItem_Click);
            // 
            // жанрToolStripMenuItem
            // 
            this.жанрToolStripMenuItem.Name = "жанрToolStripMenuItem";
            this.жанрToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.жанрToolStripMenuItem.Text = "Жанры";
            this.жанрToolStripMenuItem.Click += new System.EventHandler(this.жанрToolStripMenuItem_Click);
            // 
            // авторыToolStripMenuItem
            // 
            this.авторыToolStripMenuItem.Name = "авторыToolStripMenuItem";
            this.авторыToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.авторыToolStripMenuItem.Text = "Авторы";
            this.авторыToolStripMenuItem.Click += new System.EventHandler(this.авторыToolStripMenuItem_Click);
            // 
            // переводчикиToolStripMenuItem
            // 
            this.переводчикиToolStripMenuItem.Name = "переводчикиToolStripMenuItem";
            this.переводчикиToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.переводчикиToolStripMenuItem.Text = "Переводчики";
            this.переводчикиToolStripMenuItem.Click += new System.EventHandler(this.переводчикиToolStripMenuItem_Click);
            // 
            // абонентыToolStripMenuItem
            // 
            this.абонентыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.читателиToolStripMenuItem,
            this.библиотекариToolStripMenuItem});
            this.абонентыToolStripMenuItem.Name = "абонентыToolStripMenuItem";
            this.абонентыToolStripMenuItem.Size = new System.Drawing.Size(139, 20);
            this.абонентыToolStripMenuItem.Text = "Управление данными";
            this.абонентыToolStripMenuItem.Click += new System.EventHandler(this.абонентыToolStripMenuItem_Click);
            // 
            // читателиToolStripMenuItem
            // 
            this.читателиToolStripMenuItem.Name = "читателиToolStripMenuItem";
            this.читателиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.читателиToolStripMenuItem.Text = "Читатели";
            this.читателиToolStripMenuItem.Click += new System.EventHandler(this.читателиToolStripMenuItem_Click);
            // 
            // библиотекариToolStripMenuItem
            // 
            this.библиотекариToolStripMenuItem.Name = "библиотекариToolStripMenuItem";
            this.библиотекариToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.библиотекариToolStripMenuItem.Text = "Библиотекари";
            // 
            // получитьИнформациюToolStripMenuItem
            // 
            this.получитьИнформациюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.популярныйАвторToolStripMenuItem,
            this.популярныйЖанрToolStripMenuItem,
            this.книгиПользующиесяНаименьшейПопулярностьюToolStripMenuItem,
            this.должникиToolStripMenuItem,
            this.абонентыНеПользующиесяУслугойToolStripMenuItem});
            this.получитьИнформациюToolStripMenuItem.Name = "получитьИнформациюToolStripMenuItem";
            this.получитьИнформациюToolStripMenuItem.Size = new System.Drawing.Size(144, 20);
            this.получитьИнформациюToolStripMenuItem.Text = "Вывести информацию";
            // 
            // популярныйАвторToolStripMenuItem
            // 
            this.популярныйАвторToolStripMenuItem.Name = "популярныйАвторToolStripMenuItem";
            this.популярныйАвторToolStripMenuItem.Size = new System.Drawing.Size(360, 22);
            this.популярныйАвторToolStripMenuItem.Text = "Популярный автор";
            // 
            // популярныйЖанрToolStripMenuItem
            // 
            this.популярныйЖанрToolStripMenuItem.Name = "популярныйЖанрToolStripMenuItem";
            this.популярныйЖанрToolStripMenuItem.Size = new System.Drawing.Size(360, 22);
            this.популярныйЖанрToolStripMenuItem.Text = "Популярный жанр";
            // 
            // книгиПользующиесяНаименьшейПопулярностьюToolStripMenuItem
            // 
            this.книгиПользующиесяНаименьшейПопулярностьюToolStripMenuItem.Name = "книгиПользующиесяНаименьшейПопулярностьюToolStripMenuItem";
            this.книгиПользующиесяНаименьшейПопулярностьюToolStripMenuItem.Size = new System.Drawing.Size(360, 22);
            this.книгиПользующиесяНаименьшейПопулярностьюToolStripMenuItem.Text = "Книги пользующиеся наименьшей популярностью";
            // 
            // должникиToolStripMenuItem
            // 
            this.должникиToolStripMenuItem.Name = "должникиToolStripMenuItem";
            this.должникиToolStripMenuItem.Size = new System.Drawing.Size(360, 22);
            this.должникиToolStripMenuItem.Text = "Должники";
            // 
            // абонентыНеПользующиесяУслугойToolStripMenuItem
            // 
            this.абонентыНеПользующиесяУслугойToolStripMenuItem.Name = "абонентыНеПользующиесяУслугойToolStripMenuItem";
            this.абонентыНеПользующиесяУслугойToolStripMenuItem.Size = new System.Drawing.Size(360, 22);
            this.абонентыНеПользующиесяУслугойToolStripMenuItem.Text = "Абоненты не пользующиеся услугой";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьБДToolStripMenuItem,
            this.загрузитьБДToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(34, 20);
            this.файлToolStripMenuItem.Text = "БД";
            // 
            // сохранитьБДToolStripMenuItem
            // 
            this.сохранитьБДToolStripMenuItem.Name = "сохранитьБДToolStripMenuItem";
            this.сохранитьБДToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.сохранитьБДToolStripMenuItem.Text = "Сохранить БД";
            // 
            // загрузитьБДToolStripMenuItem
            // 
            this.загрузитьБДToolStripMenuItem.Name = "загрузитьБДToolStripMenuItem";
            this.загрузитьБДToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.загрузитьБДToolStripMenuItem.Text = "Загрузить БД";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // AthenaeumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AthenaeumForm";
            this.Text = "Библиотека";
            this.Shown += new System.EventHandler(this.AthenaeumForm_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьБДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьБДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem управлениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem издательстваToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem местаХраненияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem жанрToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem авторыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem абонентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem получитьИнформациюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem популярныйАвторToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem популярныйЖанрToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem книгиПользующиесяНаименьшейПопулярностьюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem должникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem абонентыНеПользующиесяУслугойToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem переводчикиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem читателиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem библиотекариToolStripMenuItem;
    }
}


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
        public InformationForm()
        {
            InitializeComponent();
            btn_add.Image = Image.FromFile(Path.GetFullPath(@"icon\category-add.png"));
            btn_editing.Image = Image.FromFile(Path.GetFullPath(@"icon\category-editing.png"));
            btn_delete.Image = Image.FromFile(Path.GetFullPath(@"icon\category-delete.png"));
            btn_close.Image = Image.FromFile(Path.GetFullPath(@"icon\category-close.png"));
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

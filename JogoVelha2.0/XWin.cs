using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoVelha2._0
{
    public partial class XWin : Form
    {
        public XWin()
        {
            InitializeComponent();
        }

        private void BntRecomecar_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApp
{
    
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        public string TText
        {
            set
            {
                textBoxform1.Text = value;
            }
        }

        private void открытьВторуюФормуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();

            if (textBoxform1.Text == "")
            {
                MessageBox.Show("Вы не указали путь к файлу ");

            }
            else
            {
                frm.TText = textBoxform1.Text;
                frm.ShowDialog();
            }

        }
    }
}

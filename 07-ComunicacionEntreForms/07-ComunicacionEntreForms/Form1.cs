using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace _07_ComunicacionEntreForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        StringBuilder _sb;
        private void button1_Click(object sender, EventArgs e)
        {
            _sb = new();
            _sb.AppendLine("Linea 1");
            var form2 = new Form2(_sb);
            form2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_sb.ToString());
        }
    }
}

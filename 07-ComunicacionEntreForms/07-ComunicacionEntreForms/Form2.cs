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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(StringBuilder sb) : this()
        {
            Sb = sb;
        }

        public StringBuilder Sb { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            Sb.AppendLine("Linea 2");
            var form3 = new Form3(Sb);
            form3.ShowDialog();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07_ComunicacionEntreForms
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public Form3(StringBuilder sb): this()
        {
            Sb = sb;
        }

        private StringBuilder Sb { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            Sb.AppendLine("Linea 3");            
        }
    }
}

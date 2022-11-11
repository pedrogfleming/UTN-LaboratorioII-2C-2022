using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class RelojeroForm : Form
    {
        public RelojeroForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                AsignarHora();
            });
        }
        public void AsignarHora()
        {
            while (true)
            {
                Thread.Sleep(1000);
                if (this.lblHora.InvokeRequired)
                {
                    #region Usando MethoInoker
                    //this.lblHora.BeginInvoke((MethodInvoker)delegate ()
                    //{
                    //    this.lblHora.Text = DateTime.UtcNow.ToString();
                    //});
                    #endregion
                    #region Usando Action
                    Action ac = new Action(() =>
                    {
                        this.lblHora.Text = DateTime.UtcNow.ToString();
                    });

                    var result = this.lblHora.BeginInvoke(ac);
                    #endregion
                }
                else
                {
                    this.lblHora.Text = DateTime.UtcNow.ToString();
                }
            }
        }
    }
}

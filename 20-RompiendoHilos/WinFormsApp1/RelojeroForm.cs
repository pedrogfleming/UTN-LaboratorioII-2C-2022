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
        CancellationTokenSource tokenSource;
        CancellationToken token;
        public RelojeroForm()
        {
            tokenSource = new CancellationTokenSource();
            CancellationToken token = tokenSource.Token;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                AsignarHora();
            },this.token);
        }
        public void AsignarHora()
        {
            while (!tokenSource.IsCancellationRequested)
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

                    this.lblHora.BeginInvoke(ac);
                    #endregion
                }
                else
                {
                    this.lblHora.Text = DateTime.UtcNow.ToString();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tokenSource.Cancel();
            MessageBox.Show("Cancelado");

        }

        private void btnReanudar_Click(object sender, EventArgs e)
        {
            tokenSource = new CancellationTokenSource();
            CancellationToken token = tokenSource.Token;
            Task.Run(() =>
            {
                AsignarHora();
            }, this.token);
        }
    }
}

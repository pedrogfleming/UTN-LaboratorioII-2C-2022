namespace WinFormsApp1
{
    partial class RelojeroForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblHora = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnReanudar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(87, 44);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(59, 25);
            this.lblHora.TabIndex = 0;
            this.lblHora.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(66, 112);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 31);
            this.textBox1.TabIndex = 1;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(319, 75);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 34);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnReanudar
            // 
            this.btnReanudar.Location = new System.Drawing.Point(319, 12);
            this.btnReanudar.Name = "btnReanudar";
            this.btnReanudar.Size = new System.Drawing.Size(112, 34);
            this.btnReanudar.TabIndex = 3;
            this.btnReanudar.Text = "Reanudar";
            this.btnReanudar.UseVisualStyleBackColor = true;
            this.btnReanudar.Click += new System.EventHandler(this.btnReanudar_Click);
            // 
            // RelojeroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 184);
            this.Controls.Add(this.btnReanudar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblHora);
            this.Name = "RelojeroForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnReanudar;
    }
}

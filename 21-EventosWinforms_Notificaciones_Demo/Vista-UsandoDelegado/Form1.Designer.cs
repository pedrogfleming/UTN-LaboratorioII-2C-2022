namespace Vista
{
    partial class Form1
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
            this.lbNotificaciones = new System.Windows.Forms.Label();
            this.btnAbrirForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNotificaciones
            // 
            this.lbNotificaciones.AutoSize = true;
            this.lbNotificaciones.Location = new System.Drawing.Point(35, 21);
            this.lbNotificaciones.Name = "lbNotificaciones";
            this.lbNotificaciones.Size = new System.Drawing.Size(143, 25);
            this.lbNotificaciones.TabIndex = 0;
            this.lbNotificaciones.Text = "Notificaciones(0)";
            this.lbNotificaciones.Click += new System.EventHandler(this.lbNotificaciones_Click);
            // 
            // btnAbrirForm
            // 
            this.btnAbrirForm.Location = new System.Drawing.Point(35, 101);
            this.btnAbrirForm.Name = "btnAbrirForm";
            this.btnAbrirForm.Size = new System.Drawing.Size(143, 44);
            this.btnAbrirForm.TabIndex = 1;
            this.btnAbrirForm.Text = "Abrir otro form";
            this.btnAbrirForm.UseVisualStyleBackColor = true;
            this.btnAbrirForm.Click += new System.EventHandler(this.btnAbrirForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAbrirForm);
            this.Controls.Add(this.lbNotificaciones);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNotificaciones;
        private System.Windows.Forms.Button btnAbrirForm;
    }
}

namespace Vista
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtxNotificacion = new System.Windows.Forms.RichTextBox();
            this.btnEnviarNotificacion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtxNotificacion
            // 
            this.rtxNotificacion.Location = new System.Drawing.Point(36, 23);
            this.rtxNotificacion.Name = "rtxNotificacion";
            this.rtxNotificacion.Size = new System.Drawing.Size(714, 343);
            this.rtxNotificacion.TabIndex = 0;
            this.rtxNotificacion.Text = "";
            // 
            // btnEnviarNotificacion
            // 
            this.btnEnviarNotificacion.Location = new System.Drawing.Point(36, 391);
            this.btnEnviarNotificacion.Name = "btnEnviarNotificacion";
            this.btnEnviarNotificacion.Size = new System.Drawing.Size(714, 34);
            this.btnEnviarNotificacion.TabIndex = 1;
            this.btnEnviarNotificacion.Text = "Enviar";
            this.btnEnviarNotificacion.UseVisualStyleBackColor = true;
            this.btnEnviarNotificacion.Click += new System.EventHandler(this.btnEnviarNotificacion_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEnviarNotificacion);
            this.Controls.Add(this.rtxNotificacion);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxNotificacion;
        private System.Windows.Forms.Button btnEnviarNotificacion;
    }
}
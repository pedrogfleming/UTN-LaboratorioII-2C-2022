namespace ChatView
{
    partial class ForoForm
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
            this.lstPublicacion = new System.Windows.Forms.ListBox();
            this.btnSimularInteracion = new System.Windows.Forms.Button();
            this.btnTercerUsuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstPublicacion
            // 
            this.lstPublicacion.FormattingEnabled = true;
            this.lstPublicacion.ItemHeight = 25;
            this.lstPublicacion.Location = new System.Drawing.Point(54, 28);
            this.lstPublicacion.Name = "lstPublicacion";
            this.lstPublicacion.Size = new System.Drawing.Size(655, 479);
            this.lstPublicacion.TabIndex = 0;
            this.lstPublicacion.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstPublicacion_MouseDoubleClick);
            // 
            // btnSimularInteracion
            // 
            this.btnSimularInteracion.Location = new System.Drawing.Point(740, 28);
            this.btnSimularInteracion.Name = "btnSimularInteracion";
            this.btnSimularInteracion.Size = new System.Drawing.Size(120, 102);
            this.btnSimularInteracion.TabIndex = 1;
            this.btnSimularInteracion.Text = "Simular interaccion";
            this.btnSimularInteracion.UseVisualStyleBackColor = true;
            this.btnSimularInteracion.Click += new System.EventHandler(this.btnSimularInteracion_Click);
            // 
            // btnTercerUsuario
            // 
            this.btnTercerUsuario.Location = new System.Drawing.Point(740, 154);
            this.btnTercerUsuario.Name = "btnTercerUsuario";
            this.btnTercerUsuario.Size = new System.Drawing.Size(120, 108);
            this.btnTercerUsuario.TabIndex = 2;
            this.btnTercerUsuario.Text = "Simular tercer Usuario";
            this.btnTercerUsuario.UseVisualStyleBackColor = true;
            this.btnTercerUsuario.Click += new System.EventHandler(this.btnTercerUsuario_Click);
            // 
            // ForoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 550);
            this.Controls.Add(this.btnTercerUsuario);
            this.Controls.Add(this.btnSimularInteracion);
            this.Controls.Add(this.lstPublicacion);
            this.Name = "ForoForm";
            this.Text = "ForoForm";
            this.Load += new System.EventHandler(this.ForoForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstPublicacion;
        private System.Windows.Forms.Button btnSimularInteracion;
        private System.Windows.Forms.Button btnTercerUsuario;
    }
}
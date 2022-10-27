namespace _16_SalaDeChat
{
    partial class ChatForm
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
            this.rtxMensajeAEnviar = new System.Windows.Forms.RichTextBox();
            this.btnEnviarMensaje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtxMensajeAEnviar
            // 
            this.rtxMensajeAEnviar.Location = new System.Drawing.Point(12, 12);
            this.rtxMensajeAEnviar.Name = "rtxMensajeAEnviar";
            this.rtxMensajeAEnviar.Size = new System.Drawing.Size(595, 426);
            this.rtxMensajeAEnviar.TabIndex = 0;
            this.rtxMensajeAEnviar.Text = "";
            // 
            // btnEnviarMensaje
            // 
            this.btnEnviarMensaje.Location = new System.Drawing.Point(625, 13);
            this.btnEnviarMensaje.Name = "btnEnviarMensaje";
            this.btnEnviarMensaje.Size = new System.Drawing.Size(163, 425);
            this.btnEnviarMensaje.TabIndex = 1;
            this.btnEnviarMensaje.Text = "Enviar";
            this.btnEnviarMensaje.UseVisualStyleBackColor = true;
            this.btnEnviarMensaje.Click += new System.EventHandler(this.btnEnviarMensaje_Click);
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEnviarMensaje);
            this.Controls.Add(this.rtxMensajeAEnviar);
            this.Name = "ChatForm";
            this.Text = "Usuario";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxMensajeAEnviar;
        private System.Windows.Forms.Button btnEnviarMensaje;
    }
}
namespace _19_MultiHilo_PreCarga_Winform
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
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.dgv3 = new System.Windows.Forms.DataGridView();
            this.dgv4 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv4)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv2
            // 
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Location = new System.Drawing.Point(29, 226);
            this.dgv2.Name = "dgv2";
            this.dgv2.RowHeadersWidth = 62;
            this.dgv2.RowTemplate.Height = 33;
            this.dgv2.Size = new System.Drawing.Size(728, 225);
            this.dgv2.TabIndex = 0;
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(29, 12);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowHeadersWidth = 62;
            this.dgv1.RowTemplate.Height = 33;
            this.dgv1.Size = new System.Drawing.Size(728, 196);
            this.dgv1.TabIndex = 1;
            // 
            // dgv3
            // 
            this.dgv3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv3.Location = new System.Drawing.Point(841, 12);
            this.dgv3.Name = "dgv3";
            this.dgv3.RowHeadersWidth = 62;
            this.dgv3.RowTemplate.Height = 33;
            this.dgv3.Size = new System.Drawing.Size(794, 204);
            this.dgv3.TabIndex = 2;
            // 
            // dgv4
            // 
            this.dgv4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv4.Location = new System.Drawing.Point(843, 232);
            this.dgv4.Name = "dgv4";
            this.dgv4.RowHeadersWidth = 62;
            this.dgv4.RowTemplate.Height = 33;
            this.dgv4.Size = new System.Drawing.Size(792, 219);
            this.dgv4.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1658, 476);
            this.Controls.Add(this.dgv4);
            this.Controls.Add(this.dgv3);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.dgv2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv2;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.DataGridView dgv3;
        private System.Windows.Forms.DataGridView dgv4;
    }
}

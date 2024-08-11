namespace JogoVelha2._0
{
    partial class XWin
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
            this.BntRecomecar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BntRecomecar
            // 
            this.BntRecomecar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.BntRecomecar.Location = new System.Drawing.Point(304, 256);
            this.BntRecomecar.Name = "BntRecomecar";
            this.BntRecomecar.Size = new System.Drawing.Size(191, 50);
            this.BntRecomecar.TabIndex = 4;
            this.BntRecomecar.Text = "Recomeçar";
            this.BntRecomecar.UseVisualStyleBackColor = true;
            this.BntRecomecar.Click += new System.EventHandler(this.BntRecomecar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(255, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 51);
            this.label1.TabIndex = 3;
            this.label1.Text = "X VENCEU!!!!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // XWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BntRecomecar);
            this.Controls.Add(this.label1);
            this.Name = "XWin";
            this.Text = "Xwin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BntRecomecar;
        private System.Windows.Forms.Label label1;
    }
}
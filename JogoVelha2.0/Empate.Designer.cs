﻿namespace JogoVelha2._0
{
    partial class Empate
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
            this.label1 = new System.Windows.Forms.Label();
            this.BntRecomecar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(265, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 51);
            this.label1.TabIndex = 7;
            this.label1.Text = "EMPATOU!!!";
            // 
            // BntRecomecar
            // 
            this.BntRecomecar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.BntRecomecar.Location = new System.Drawing.Point(311, 243);
            this.BntRecomecar.Name = "BntRecomecar";
            this.BntRecomecar.Size = new System.Drawing.Size(191, 50);
            this.BntRecomecar.TabIndex = 6;
            this.BntRecomecar.Text = "Recomeçar";
            this.BntRecomecar.UseVisualStyleBackColor = true;
            // 
            // Empate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BntRecomecar);
            this.Name = "Empate";
            this.Text = "Empate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BntRecomecar;
    }
}
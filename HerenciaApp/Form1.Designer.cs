﻿
namespace HerenciaApp
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
            this.Animalbt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Animalbt
            // 
            this.Animalbt.Location = new System.Drawing.Point(17, 18);
            this.Animalbt.Name = "Animalbt";
            this.Animalbt.Size = new System.Drawing.Size(87, 39);
            this.Animalbt.TabIndex = 0;
            this.Animalbt.Text = "button1";
            this.Animalbt.UseVisualStyleBackColor = true;
            this.Animalbt.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Animalbt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Animalbt;
    }
}


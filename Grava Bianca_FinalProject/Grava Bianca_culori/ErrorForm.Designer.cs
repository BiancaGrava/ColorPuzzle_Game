﻿namespace Grava_Bianca_culori
{
    partial class ErrorForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaShell;
            this.button1.BackgroundImage = global::Grava_Bianca_culori.Properties.Resources.ErrorMessage;
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(26, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(598, 344);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.SeaShell;
            this.buttonClose.BackgroundImage = global::Grava_Bianca_culori.Properties.Resources.back;
            this.buttonClose.Location = new System.Drawing.Point(643, 357);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(161, 101);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // ErrorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(816, 470);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonClose);
            this.Name = "ErrorForm";
            this.Text = "ErrorForm";
            this.Load += new System.EventHandler(this.ErrorForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button button1;
    }
}
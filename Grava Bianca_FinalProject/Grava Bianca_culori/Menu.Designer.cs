﻿namespace Grava_Bianca_culori
{
    partial class Menu
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
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.GhostWhite;
            this.button1.BackgroundImage = global::Grava_Bianca_culori.Properties.Resources.level11;
            this.button1.Location = new System.Drawing.Point(112, 32);
            this.button1.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 119);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.GhostWhite;
            this.button2.BackgroundImage = global::Grava_Bianca_culori.Properties.Resources.level2;
            this.button2.Location = new System.Drawing.Point(20, 154);
            this.button2.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 119);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.GhostWhite;
            this.button4.BackgroundImage = global::Grava_Bianca_culori.Properties.Resources.level3;
            this.button4.Location = new System.Drawing.Point(478, 94);
            this.button4.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(171, 109);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackgroundImage = global::Grava_Bianca_culori.Properties.Resources.back;
            this.buttonClose.Location = new System.Drawing.Point(794, 135);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(127, 94);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(27F, 53F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Grava_Bianca_culori.Properties.Resources.fairy1;
            this.ClientSize = new System.Drawing.Size(1013, 330);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonClose;
    }
}


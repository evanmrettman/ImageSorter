﻿namespace ImageHelper
{
    partial class formMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.cbModeSelection = new System.Windows.Forms.ComboBox();
            this.btnConfirmConfig = new System.Windows.Forms.Button();
            this.panel_imageSorter = new System.Windows.Forms.Panel();
            this.flpOutputFolders = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnChangeInput = new System.Windows.Forms.Button();
            this.txtInputFolder = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel_imageCropper = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel_imageDeleter = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel_imageDupeDeleter = new System.Windows.Forms.Panel();
            this.tsslError = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.panel_imageSorter.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel_imageCropper.SuspendLayout();
            this.panel_imageDeleter.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(857, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Current Mode Type";
            // 
            // cbModeSelection
            // 
            this.cbModeSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModeSelection.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbModeSelection.FormattingEnabled = true;
            this.cbModeSelection.Location = new System.Drawing.Point(12, 40);
            this.cbModeSelection.Name = "cbModeSelection";
            this.cbModeSelection.Size = new System.Drawing.Size(121, 21);
            this.cbModeSelection.TabIndex = 3;
            this.cbModeSelection.SelectedIndexChanged += new System.EventHandler(this.cbModeSelection_SelectedIndexChanged);
            // 
            // btnConfirmConfig
            // 
            this.btnConfirmConfig.Location = new System.Drawing.Point(140, 28);
            this.btnConfirmConfig.Name = "btnConfirmConfig";
            this.btnConfirmConfig.Size = new System.Drawing.Size(132, 33);
            this.btnConfirmConfig.TabIndex = 4;
            this.btnConfirmConfig.Text = "Start";
            this.btnConfirmConfig.UseVisualStyleBackColor = true;
            this.btnConfirmConfig.Click += new System.EventHandler(this.btnConfirmConfig_Click);
            // 
            // panel_imageSorter
            // 
            this.panel_imageSorter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_imageSorter.Controls.Add(this.flpOutputFolders);
            this.panel_imageSorter.Controls.Add(this.label3);
            this.panel_imageSorter.Controls.Add(this.btnChangeInput);
            this.panel_imageSorter.Controls.Add(this.txtInputFolder);
            this.panel_imageSorter.Controls.Add(this.label2);
            this.panel_imageSorter.Location = new System.Drawing.Point(12, 67);
            this.panel_imageSorter.Name = "panel_imageSorter";
            this.panel_imageSorter.Size = new System.Drawing.Size(260, 168);
            this.panel_imageSorter.TabIndex = 5;
            // 
            // flpOutputFolders
            // 
            this.flpOutputFolders.AutoScroll = true;
            this.flpOutputFolders.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flpOutputFolders.Location = new System.Drawing.Point(-1, 60);
            this.flpOutputFolders.Name = "flpOutputFolders";
            this.flpOutputFolders.Size = new System.Drawing.Size(260, 107);
            this.flpOutputFolders.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Output Folders";
            // 
            // btnChangeInput
            // 
            this.btnChangeInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeInput.Location = new System.Drawing.Point(233, 19);
            this.btnChangeInput.Name = "btnChangeInput";
            this.btnChangeInput.Size = new System.Drawing.Size(22, 22);
            this.btnChangeInput.TabIndex = 3;
            this.btnChangeInput.Text = "_";
            this.btnChangeInput.UseVisualStyleBackColor = true;
            this.btnChangeInput.Click += new System.EventHandler(this.btnChangeInput_Click);
            // 
            // txtInputFolder
            // 
            this.txtInputFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInputFolder.Location = new System.Drawing.Point(3, 20);
            this.txtInputFolder.Name = "txtInputFolder";
            this.txtInputFolder.ReadOnly = true;
            this.txtInputFolder.Size = new System.Drawing.Size(224, 20);
            this.txtInputFolder.TabIndex = 1;
            this.txtInputFolder.Text = "No input folder selected.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Input Folder";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslError});
            this.statusStrip1.Location = new System.Drawing.Point(0, 392);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(857, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel_imageCropper
            // 
            this.panel_imageCropper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_imageCropper.Controls.Add(this.button2);
            this.panel_imageCropper.Controls.Add(this.button1);
            this.panel_imageCropper.Controls.Add(this.textBox2);
            this.panel_imageCropper.Controls.Add(this.label5);
            this.panel_imageCropper.Controls.Add(this.label4);
            this.panel_imageCropper.Controls.Add(this.textBox1);
            this.panel_imageCropper.Location = new System.Drawing.Point(315, 40);
            this.panel_imageCropper.Name = "panel_imageCropper";
            this.panel_imageCropper.Size = new System.Drawing.Size(260, 168);
            this.panel_imageCropper.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(233, 56);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(22, 22);
            this.button2.TabIndex = 9;
            this.button2.Text = "_";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(233, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 22);
            this.button1.TabIndex = 6;
            this.button1.Text = "_";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(3, 57);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(224, 20);
            this.textBox2.TabIndex = 8;
            this.textBox2.Text = "No input folder selected.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Output Folder";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Input Folder";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(3, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(224, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "No input folder selected.";
            // 
            // panel_imageDeleter
            // 
            this.panel_imageDeleter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_imageDeleter.Controls.Add(this.button3);
            this.panel_imageDeleter.Controls.Add(this.textBox3);
            this.panel_imageDeleter.Controls.Add(this.label6);
            this.panel_imageDeleter.Location = new System.Drawing.Point(581, 40);
            this.panel_imageDeleter.Name = "panel_imageDeleter";
            this.panel_imageDeleter.Size = new System.Drawing.Size(260, 168);
            this.panel_imageDeleter.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(233, 16);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(22, 22);
            this.button3.TabIndex = 10;
            this.button3.Text = "_";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Location = new System.Drawing.Point(3, 17);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(224, 20);
            this.textBox3.TabIndex = 10;
            this.textBox3.Text = "No input folder selected.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Input Folder";
            // 
            // panel_imageDupeDeleter
            // 
            this.panel_imageDupeDeleter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_imageDupeDeleter.Location = new System.Drawing.Point(315, 214);
            this.panel_imageDupeDeleter.Name = "panel_imageDupeDeleter";
            this.panel_imageDupeDeleter.Size = new System.Drawing.Size(260, 168);
            this.panel_imageDupeDeleter.TabIndex = 6;
            // 
            // tsslError
            // 
            this.tsslError.Name = "tsslError";
            this.tsslError.Size = new System.Drawing.Size(51, 17);
            this.tsslError.Text = "No Error";
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 414);
            this.Controls.Add(this.panel_imageDupeDeleter);
            this.Controls.Add(this.panel_imageDeleter);
            this.Controls.Add(this.panel_imageCropper);
            this.Controls.Add(this.panel_imageSorter);
            this.Controls.Add(this.btnConfirmConfig);
            this.Controls.Add(this.cbModeSelection);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "formMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "formName";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel_imageSorter.ResumeLayout(false);
            this.panel_imageSorter.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel_imageCropper.ResumeLayout(false);
            this.panel_imageCropper.PerformLayout();
            this.panel_imageDeleter.ResumeLayout(false);
            this.panel_imageDeleter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbModeSelection;
        private System.Windows.Forms.Button btnConfirmConfig;
        private System.Windows.Forms.Panel panel_imageSorter;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Panel panel_imageCropper;
        private System.Windows.Forms.Panel panel_imageDeleter;
        private System.Windows.Forms.Panel panel_imageDupeDeleter;
        private System.Windows.Forms.Button btnChangeInput;
        private System.Windows.Forms.TextBox txtInputFolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flpOutputFolders;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripStatusLabel tsslError;
    }
}

﻿namespace UIFormRDMO
{
    partial class Form1
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
            this.PathField = new System.Windows.Forms.TextBox();
            this.GetPath = new System.Windows.Forms.Button();
            this.PathLabel = new System.Windows.Forms.Label();
            this.StartCompareBtn = new System.Windows.Forms.Button();
            this.ClearListsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PathField
            // 
            this.PathField.Location = new System.Drawing.Point(82, 75);
            this.PathField.Name = "PathField";
            this.PathField.Size = new System.Drawing.Size(315, 20);
            this.PathField.TabIndex = 0;
            // 
            // GetPath
            // 
            this.GetPath.Location = new System.Drawing.Point(82, 117);
            this.GetPath.Name = "GetPath";
            this.GetPath.Size = new System.Drawing.Size(117, 33);
            this.GetPath.TabIndex = 1;
            this.GetPath.Text = "Выбрать путь";
            this.GetPath.UseVisualStyleBackColor = true;
            this.GetPath.Click += new System.EventHandler(this.GetPath_Click);
            // 
            // PathLabel
            // 
            this.PathLabel.AllowDrop = true;
            this.PathLabel.AutoEllipsis = true;
            this.PathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.PathLabel.Location = new System.Drawing.Point(82, 41);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new System.Drawing.Size(315, 22);
            this.PathLabel.TabIndex = 2;
            this.PathLabel.UseCompatibleTextRendering = true;
            // 
            // StartCompareBtn
            // 
            this.StartCompareBtn.Location = new System.Drawing.Point(82, 183);
            this.StartCompareBtn.Name = "StartCompareBtn";
            this.StartCompareBtn.Size = new System.Drawing.Size(117, 33);
            this.StartCompareBtn.TabIndex = 3;
            this.StartCompareBtn.Text = "Начать сравнение";
            this.StartCompareBtn.UseVisualStyleBackColor = true;
            this.StartCompareBtn.Click += new System.EventHandler(this.StartCompareBtn_Click);
            // 
            // ClearListsBtn
            // 
            this.ClearListsBtn.Location = new System.Drawing.Point(82, 252);
            this.ClearListsBtn.Name = "ClearListsBtn";
            this.ClearListsBtn.Size = new System.Drawing.Size(117, 33);
            this.ClearListsBtn.TabIndex = 4;
            this.ClearListsBtn.Text = "Очистить списки";
            this.ClearListsBtn.UseVisualStyleBackColor = true;
            this.ClearListsBtn.Click += new System.EventHandler(this.ClearListsBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ClearListsBtn);
            this.Controls.Add(this.StartCompareBtn);
            this.Controls.Add(this.PathLabel);
            this.Controls.Add(this.GetPath);
            this.Controls.Add(this.PathField);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button StartCompareBtn;

        private System.Windows.Forms.Button ClearListsBtn;

        private System.Windows.Forms.Label PathLabel;

        private System.Windows.Forms.Button GetPath;

        private System.Windows.Forms.TextBox PathField;

        #endregion
    }
}
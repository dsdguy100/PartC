﻿
namespace PartC
{
    partial class CustomAssignments
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AssignmentTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Test = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblFormat = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AssignmentTitle,
            this.DueDate});
            this.dataGridView1.Location = new System.Drawing.Point(174, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(452, 348);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // AssignmentTitle
            // 
            this.AssignmentTitle.HeaderText = "Assignment Name";
            this.AssignmentTitle.Name = "AssignmentTitle";
            this.AssignmentTitle.Width = 210;
            // 
            // DueDate
            // 
            this.DueDate.HeaderText = "DueDate";
            this.DueDate.Name = "DueDate";
            this.DueDate.Width = 300;
            // 
            // Test
            // 
            this.Test.AutoSize = true;
            this.Test.Location = new System.Drawing.Point(75, 388);
            this.Test.Name = "Test";
            this.Test.Size = new System.Drawing.Size(35, 13);
            this.Test.TabIndex = 1;
            this.Test.Text = "label1";
            this.Test.Click += new System.EventHandler(this.Test_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(361, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "btnTest";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblFormat
            // 
            this.lblFormat.AutoSize = true;
            this.lblFormat.Location = new System.Drawing.Point(430, 4);
            this.lblFormat.Name = "lblFormat";
            this.lblFormat.Size = new System.Drawing.Size(180, 13);
            this.lblFormat.TabIndex = 3;
            this.lblFormat.Text = "Enter Date in: dd:hr:min (ie 01:09:30)";
            // 
            // CustomAssignments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFormat);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Test);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CustomAssignments";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.CustomAssignments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Test;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn AssignmentTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn DueDate;
        private System.Windows.Forms.Label lblFormat;
    }
}
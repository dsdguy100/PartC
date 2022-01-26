﻿
namespace PartC
{
    partial class Homepage
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
            this.components = new System.ComponentModel.Container();
            this.lblHWTracker = new System.Windows.Forms.Label();
            this.AddCustom = new System.Windows.Forms.Button();
            this.btnNotify = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnPull = new System.Windows.Forms.Button();
            this.lblTester = new System.Windows.Forms.Label();
            this.RecievePop = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHWTracker
            // 
            this.lblHWTracker.AutoSize = true;
            this.lblHWTracker.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHWTracker.Location = new System.Drawing.Point(258, 42);
            this.lblHWTracker.Name = "lblHWTracker";
            this.lblHWTracker.Size = new System.Drawing.Size(264, 36);
            this.lblHWTracker.TabIndex = 0;
            this.lblHWTracker.Text = "Homework Tracker";
            // 
            // AddCustom
            // 
            this.AddCustom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCustom.Location = new System.Drawing.Point(433, 144);
            this.AddCustom.Name = "AddCustom";
            this.AddCustom.Size = new System.Drawing.Size(243, 65);
            this.AddCustom.TabIndex = 1;
            this.AddCustom.Text = "Insert Custom Assignments";
            this.AddCustom.UseVisualStyleBackColor = true;
            this.AddCustom.Click += new System.EventHandler(this.AddCustom_Click);
            // 
            // btnNotify
            // 
            this.btnNotify.Location = new System.Drawing.Point(286, 296);
            this.btnNotify.Name = "btnNotify";
            this.btnNotify.Size = new System.Drawing.Size(199, 64);
            this.btnNotify.TabIndex = 2;
            this.btnNotify.Text = "Start/Stop Timer";
            this.btnNotify.UseVisualStyleBackColor = true;
            this.btnNotify.Click += new System.EventHandler(this.btnNotify_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(753, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // btnPull
            // 
            this.btnPull.Location = new System.Drawing.Point(307, 366);
            this.btnPull.Name = "btnPull";
            this.btnPull.Size = new System.Drawing.Size(157, 23);
            this.btnPull.TabIndex = 4;
            this.btnPull.Text = "Load Assignments";
            this.btnPull.UseVisualStyleBackColor = true;
            this.btnPull.Click += new System.EventHandler(this.btnPull_Click);
            // 
            // lblTester
            // 
            this.lblTester.AutoSize = true;
            this.lblTester.Location = new System.Drawing.Point(709, 428);
            this.lblTester.Name = "lblTester";
            this.lblTester.Size = new System.Drawing.Size(28, 13);
            this.lblTester.TabIndex = 5;
            this.lblTester.Text = "Test";
            // 
            // RecievePop
            // 
            this.RecievePop.AutoSize = true;
            this.RecievePop.Location = new System.Drawing.Point(527, 255);
            this.RecievePop.Name = "RecievePop";
            this.RecievePop.Size = new System.Drawing.Size(104, 17);
            this.RecievePop.TabIndex = 6;
            this.RecievePop.Text = "Windows Popup";
            this.RecievePop.UseVisualStyleBackColor = true;
            this.RecievePop.CheckedChanged += new System.EventHandler(this.RecievePop_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(527, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "How would you like to be notified";
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RecievePop);
            this.Controls.Add(this.lblTester);
            this.Controls.Add(this.btnPull);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNotify);
            this.Controls.Add(this.AddCustom);
            this.Controls.Add(this.lblHWTracker);
            this.Name = "Homepage";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Homepage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHWTracker;
        private System.Windows.Forms.Button AddCustom;
        private System.Windows.Forms.Button btnNotify;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPull;
        private System.Windows.Forms.Label lblTester;
        private System.Windows.Forms.CheckBox RecievePop;
        private System.Windows.Forms.Label label2;
    }
}


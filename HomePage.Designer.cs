
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage));
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
            this.recieveBox = new System.Windows.Forms.CheckBox();
            this.FiveBefore = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TenBefore = new System.Windows.Forms.CheckBox();
            this.HourBefore = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblHWTracker
            // 
            this.lblHWTracker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHWTracker.AutoSize = true;
            this.lblHWTracker.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblHWTracker.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHWTracker.Location = new System.Drawing.Point(258, 42);
            this.lblHWTracker.Name = "lblHWTracker";
            this.lblHWTracker.Size = new System.Drawing.Size(264, 36);
            this.lblHWTracker.TabIndex = 0;
            this.lblHWTracker.Text = "Homework Tracker";
            // 
            // AddCustom
            // 
            this.AddCustom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AddCustom.BackColor = System.Drawing.SystemColors.Highlight;
            this.AddCustom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCustom.Location = new System.Drawing.Point(264, 93);
            this.AddCustom.Name = "AddCustom";
            this.AddCustom.Size = new System.Drawing.Size(243, 65);
            this.AddCustom.TabIndex = 1;
            this.AddCustom.Text = "Insert Custom Assignments";
            this.AddCustom.UseVisualStyleBackColor = false;
            this.AddCustom.Click += new System.EventHandler(this.AddCustom_Click);
            // 
            // btnNotify
            // 
            this.btnNotify.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNotify.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnNotify.Location = new System.Drawing.Point(286, 296);
            this.btnNotify.Name = "btnNotify";
            this.btnNotify.Size = new System.Drawing.Size(199, 64);
            this.btnNotify.TabIndex = 2;
            this.btnNotify.Text = "Start/Stop Timer";
            this.btnNotify.UseVisualStyleBackColor = false;
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
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(450, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Current Time:";
            // 
            // btnPull
            // 
            this.btnPull.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPull.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnPull.Location = new System.Drawing.Point(307, 366);
            this.btnPull.Name = "btnPull";
            this.btnPull.Size = new System.Drawing.Size(157, 23);
            this.btnPull.TabIndex = 4;
            this.btnPull.Text = "Load Assignments";
            this.btnPull.UseVisualStyleBackColor = false;
            this.btnPull.Click += new System.EventHandler(this.btnPull_Click);
            // 
            // lblTester
            // 
            this.lblTester.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTester.AutoSize = true;
            this.lblTester.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblTester.Location = new System.Drawing.Point(202, 248);
            this.lblTester.Name = "lblTester";
            this.lblTester.Size = new System.Drawing.Size(414, 13);
            this.lblTester.TabIndex = 5;
            this.lblTester.Text = "Once all options are selected press \"Load Assignments\" then press \"Start/Stop Tim" +
    "er\"";
            this.lblTester.Click += new System.EventHandler(this.lblTester_Click);
            // 
            // RecievePop
            // 
            this.RecievePop.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RecievePop.AutoSize = true;
            this.RecievePop.BackColor = System.Drawing.SystemColors.Highlight;
            this.RecievePop.Location = new System.Drawing.Point(552, 141);
            this.RecievePop.Name = "RecievePop";
            this.RecievePop.Size = new System.Drawing.Size(104, 17);
            this.RecievePop.TabIndex = 6;
            this.RecievePop.Text = "Windows Popup";
            this.RecievePop.UseVisualStyleBackColor = false;
            this.RecievePop.CheckedChanged += new System.EventHandler(this.RecievePop_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(549, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "How Would You Like To Be Notified";
            // 
            // recieveBox
            // 
            this.recieveBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.recieveBox.AutoSize = true;
            this.recieveBox.BackColor = System.Drawing.SystemColors.Highlight;
            this.recieveBox.Location = new System.Drawing.Point(552, 165);
            this.recieveBox.Name = "recieveBox";
            this.recieveBox.Size = new System.Drawing.Size(112, 17);
            this.recieveBox.TabIndex = 9;
            this.recieveBox.Text = "Application Popup";
            this.recieveBox.UseVisualStyleBackColor = false;
            this.recieveBox.CheckedChanged += new System.EventHandler(this.recieveBox_CheckedChanged);
            // 
            // FiveBefore
            // 
            this.FiveBefore.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FiveBefore.AutoSize = true;
            this.FiveBefore.BackColor = System.Drawing.SystemColors.Highlight;
            this.FiveBefore.Location = new System.Drawing.Point(35, 141);
            this.FiveBefore.Name = "FiveBefore";
            this.FiveBefore.Size = new System.Drawing.Size(80, 17);
            this.FiveBefore.TabIndex = 10;
            this.FiveBefore.Text = "Five Before";
            this.FiveBefore.UseVisualStyleBackColor = false;
            this.FiveBefore.CheckedChanged += new System.EventHandler(this.FiveBefore_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(35, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "When Would You Like To Be Notified";
            // 
            // TenBefore
            // 
            this.TenBefore.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TenBefore.AutoSize = true;
            this.TenBefore.BackColor = System.Drawing.SystemColors.Highlight;
            this.TenBefore.Location = new System.Drawing.Point(35, 165);
            this.TenBefore.Name = "TenBefore";
            this.TenBefore.Size = new System.Drawing.Size(79, 17);
            this.TenBefore.TabIndex = 12;
            this.TenBefore.Text = "Ten Before";
            this.TenBefore.UseVisualStyleBackColor = false;
            this.TenBefore.CheckedChanged += new System.EventHandler(this.TenBefore_CheckedChanged);
            // 
            // HourBefore
            // 
            this.HourBefore.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.HourBefore.AutoSize = true;
            this.HourBefore.BackColor = System.Drawing.SystemColors.Highlight;
            this.HourBefore.Location = new System.Drawing.Point(35, 188);
            this.HourBefore.Name = "HourBefore";
            this.HourBefore.Size = new System.Drawing.Size(83, 17);
            this.HourBefore.TabIndex = 13;
            this.HourBefore.Text = "Hour Before";
            this.HourBefore.UseVisualStyleBackColor = false;
            this.HourBefore.CheckedChanged += new System.EventHandler(this.HourBefore_CheckedChanged);
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HourBefore);
            this.Controls.Add(this.TenBefore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FiveBefore);
            this.Controls.Add(this.recieveBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RecievePop);
            this.Controls.Add(this.lblTester);
            this.Controls.Add(this.btnPull);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNotify);
            this.Controls.Add(this.AddCustom);
            this.Controls.Add(this.lblHWTracker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Homepage";
            this.Text = "Velvet Room";
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
        private System.Windows.Forms.CheckBox recieveBox;
        private System.Windows.Forms.CheckBox FiveBefore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox TenBefore;
        private System.Windows.Forms.CheckBox HourBefore;
    }
}


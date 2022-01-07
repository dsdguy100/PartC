
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
            this.lblHWTracker = new System.Windows.Forms.Label();
            this.AddCustom = new System.Windows.Forms.Button();
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
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddCustom);
            this.Controls.Add(this.lblHWTracker);
            this.Name = "Homepage";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHWTracker;
        private System.Windows.Forms.Button AddCustom;
    }
}



namespace ACME_CALC_V._2
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
            this.listAns = new System.Windows.Forms.ListBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.SubBtn = new System.Windows.Forms.Button();
            this.MultBtn = new System.Windows.Forms.Button();
            this.DivBtn = new System.Windows.Forms.Button();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listAns
            // 
            this.listAns.FormattingEnabled = true;
            this.listAns.ItemHeight = 20;
            this.listAns.Location = new System.Drawing.Point(161, 229);
            this.listAns.Name = "listAns";
            this.listAns.Size = new System.Drawing.Size(449, 164);
            this.listAns.TabIndex = 0;
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(161, 120);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(94, 75);
            this.AddBtn.TabIndex = 1;
            this.AddBtn.Text = "+";
            this.AddBtn.UseVisualStyleBackColor = true;
            // 
            // SubBtn
            // 
            this.SubBtn.Location = new System.Drawing.Point(279, 120);
            this.SubBtn.Name = "SubBtn";
            this.SubBtn.Size = new System.Drawing.Size(94, 75);
            this.SubBtn.TabIndex = 2;
            this.SubBtn.Text = "-";
            this.SubBtn.UseVisualStyleBackColor = true;
            // 
            // MultBtn
            // 
            this.MultBtn.Location = new System.Drawing.Point(400, 120);
            this.MultBtn.Name = "MultBtn";
            this.MultBtn.Size = new System.Drawing.Size(94, 75);
            this.MultBtn.TabIndex = 3;
            this.MultBtn.Text = "*";
            this.MultBtn.UseVisualStyleBackColor = true;
            // 
            // DivBtn
            // 
            this.DivBtn.Location = new System.Drawing.Point(516, 120);
            this.DivBtn.Name = "DivBtn";
            this.DivBtn.Size = new System.Drawing.Size(94, 75);
            this.DivBtn.TabIndex = 4;
            this.DivBtn.Text = "/";
            this.DivBtn.UseVisualStyleBackColor = true;
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(161, 60);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(222, 27);
            this.txt1.TabIndex = 5;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(400, 60);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(210, 27);
            this.txt2.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.DivBtn);
            this.Controls.Add(this.MultBtn);
            this.Controls.Add(this.SubBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.listAns);
            this.Name = "Form1";
            this.Text = "ACME CALC V2.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listAns;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button SubBtn;
        private System.Windows.Forms.Button MultBtn;
        private System.Windows.Forms.Button DivBtn;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
    }
}


namespace login_and_registration
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
            this.bunifuCustomTextbox1 = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.bunifuCustomTextbox2 = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomTextbox3 = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // bunifuCustomTextbox1
            // 
            this.bunifuCustomTextbox1.BorderColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomTextbox1.Location = new System.Drawing.Point(209, 65);
            this.bunifuCustomTextbox1.Multiline = true;
            this.bunifuCustomTextbox1.Name = "bunifuCustomTextbox1";
            this.bunifuCustomTextbox1.Size = new System.Drawing.Size(143, 20);
            this.bunifuCustomTextbox1.TabIndex = 1;
            this.bunifuCustomTextbox1.TextChanged += new System.EventHandler(this.bunifuCustomTextbox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(240, 168);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "button1";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // bunifuCustomTextbox2
            // 
            this.bunifuCustomTextbox2.BorderColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomTextbox2.Location = new System.Drawing.Point(209, 65);
            this.bunifuCustomTextbox2.Multiline = true;
            this.bunifuCustomTextbox2.Name = "bunifuCustomTextbox2";
            this.bunifuCustomTextbox2.Size = new System.Drawing.Size(143, 20);
            this.bunifuCustomTextbox2.TabIndex = 1;
            this.bunifuCustomTextbox2.TextChanged += new System.EventHandler(this.bunifuCustomTextbox1_TextChanged);
            // 
            // bunifuCustomTextbox3
            // 
            this.bunifuCustomTextbox3.BorderColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomTextbox3.Location = new System.Drawing.Point(209, 123);
            this.bunifuCustomTextbox3.Multiline = true;
            this.bunifuCustomTextbox3.Name = "bunifuCustomTextbox3";
            this.bunifuCustomTextbox3.Size = new System.Drawing.Size(143, 20);
            this.bunifuCustomTextbox3.TabIndex = 1;
            this.bunifuCustomTextbox3.TextChanged += new System.EventHandler(this.bunifuCustomTextbox1_TextChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(248, 214);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(40, 13);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Signup";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(249)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(482, 283);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuCustomTextbox3);
            this.Controls.Add(this.bunifuCustomTextbox2);
            this.Controls.Add(this.bunifuCustomTextbox1);
            this.Controls.Add(this.button2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WindowsFormsControlLibrary1.BunifuCustomTextbox bunifuCustomTextbox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox bunifuCustomTextbox2;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox bunifuCustomTextbox3;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}


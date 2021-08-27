namespace sutterrøv
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.forgotpass_btn = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.App_Close = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.App_mini = new System.Windows.Forms.Label();
            this.account_txt = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.Nulstill_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // forgotpass_btn
            // 
            this.forgotpass_btn.AutoSize = true;
            this.forgotpass_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.forgotpass_btn.ForeColor = System.Drawing.Color.White;
            this.forgotpass_btn.Location = new System.Drawing.Point(108, 365);
            this.forgotpass_btn.Name = "forgotpass_btn";
            this.forgotpass_btn.Size = new System.Drawing.Size(84, 13);
            this.forgotpass_btn.TabIndex = 6;
            this.forgotpass_btn.Text = "Glemt din kode?";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(76, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // App_Close
            // 
            this.App_Close.AutoSize = true;
            this.App_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.App_Close.ForeColor = System.Drawing.Color.White;
            this.App_Close.Location = new System.Drawing.Point(284, 15);
            this.App_Close.Name = "App_Close";
            this.App_Close.Size = new System.Drawing.Size(18, 18);
            this.App_Close.TabIndex = 18;
            this.App_Close.Text = "X";
            this.App_Close.Click += new System.EventHandler(this.App_Close_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.App_mini);
            this.panel1.Controls.Add(this.App_Close);
            this.panel1.Location = new System.Drawing.Point(-9, -7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 48);
            this.panel1.TabIndex = 19;
            // 
            // App_mini
            // 
            this.App_mini.AutoSize = true;
            this.App_mini.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.App_mini.ForeColor = System.Drawing.Color.White;
            this.App_mini.Location = new System.Drawing.Point(263, 15);
            this.App_mini.Name = "App_mini";
            this.App_mini.Size = new System.Drawing.Size(16, 18);
            this.App_mini.TabIndex = 19;
            this.App_mini.Text = "_";
            // 
            // account_txt
            // 
            this.account_txt.Location = new System.Drawing.Point(76, 263);
            this.account_txt.Name = "account_txt";
            this.account_txt.Size = new System.Drawing.Size(151, 20);
            this.account_txt.TabIndex = 20;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(76, 326);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(151, 20);
            this.textBox2.TabIndex = 21;
            // 
            // login_btn
            // 
            this.login_btn.Location = new System.Drawing.Point(76, 401);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(151, 23);
            this.login_btn.TabIndex = 22;
            this.login_btn.Text = "Log ind";
            this.login_btn.UseVisualStyleBackColor = true;
            // 
            // Nulstill_btn
            // 
            this.Nulstill_btn.Location = new System.Drawing.Point(76, 446);
            this.Nulstill_btn.Name = "Nulstill_btn";
            this.Nulstill_btn.Size = new System.Drawing.Size(151, 23);
            this.Nulstill_btn.TabIndex = 23;
            this.Nulstill_btn.Text = "Nulstille";
            this.Nulstill_btn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(73, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Brugernavn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(73, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Kodeord";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(302, 584);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nulstill_btn);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.account_txt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.forgotpass_btn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label forgotpass_btn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox password_txt;
      
       
        private System.Windows.Forms.PictureBox pictureBox1;
     
        private System.Windows.Forms.Label App_Close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label App_mini;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox account_txt;
        private System.Windows.Forms.Button Nulstill_btn;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}


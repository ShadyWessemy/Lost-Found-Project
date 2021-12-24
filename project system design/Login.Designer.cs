
namespace project_system_design
{
    partial class Login
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
            this.adminbutton = new System.Windows.Forms.Button();
            this.usertext = new System.Windows.Forms.TextBox();
            this.usernamelabel = new System.Windows.Forms.Label();
            this.passlabel = new System.Windows.Forms.Label();
            this.passtext = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adminbutton
            // 
            this.adminbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.adminbutton.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.adminbutton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.adminbutton.Location = new System.Drawing.Point(331, 330);
            this.adminbutton.Name = "adminbutton";
            this.adminbutton.Size = new System.Drawing.Size(145, 58);
            this.adminbutton.TabIndex = 19;
            this.adminbutton.Text = "Login";
            this.adminbutton.UseVisualStyleBackColor = false;
            this.adminbutton.Click += new System.EventHandler(this.adminbutton_Click);
            // 
            // usertext
            // 
            this.usertext.Location = new System.Drawing.Point(375, 186);
            this.usertext.Multiline = true;
            this.usertext.Name = "usertext";
            this.usertext.Size = new System.Drawing.Size(234, 35);
            this.usertext.TabIndex = 22;
            // 
            // usernamelabel
            // 
            this.usernamelabel.AutoSize = true;
            this.usernamelabel.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.usernamelabel.Location = new System.Drawing.Point(190, 186);
            this.usernamelabel.Name = "usernamelabel";
            this.usernamelabel.Size = new System.Drawing.Size(150, 27);
            this.usernamelabel.TabIndex = 23;
            this.usernamelabel.Text = "Admin name";
            // 
            // passlabel
            // 
            this.passlabel.AutoSize = true;
            this.passlabel.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.passlabel.Location = new System.Drawing.Point(190, 252);
            this.passlabel.Name = "passlabel";
            this.passlabel.Size = new System.Drawing.Size(122, 27);
            this.passlabel.TabIndex = 24;
            this.passlabel.Text = "Password";
            // 
            // passtext
            // 
            this.passtext.Location = new System.Drawing.Point(375, 255);
            this.passtext.Multiline = true;
            this.passtext.Name = "passtext";
            this.passtext.PasswordChar = '*';
            this.passtext.Size = new System.Drawing.Size(234, 35);
            this.passtext.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(299, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 27);
            this.label1.TabIndex = 26;
            this.label1.Text = "Admin Login";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button2.Location = new System.Drawing.Point(357, 523);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 62);
            this.button2.TabIndex = 27;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(770, 597);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passtext);
            this.Controls.Add(this.passlabel);
            this.Controls.Add(this.usernamelabel);
            this.Controls.Add(this.usertext);
            this.Controls.Add(this.adminbutton);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lost-Found Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button adminbutton;
        private System.Windows.Forms.TextBox usertext;
        private System.Windows.Forms.Label usernamelabel;
        private System.Windows.Forms.Label passlabel;
        private System.Windows.Forms.TextBox passtext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}

namespace project_system_design
{
    partial class Preview
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
            this.kind2label = new System.Windows.Forms.Label();
            this.kind2res = new System.Windows.Forms.Label();
            this.name2label = new System.Windows.Forms.Label();
            this.name2res = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.deliverbutton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kind2label
            // 
            this.kind2label.AutoSize = true;
            this.kind2label.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kind2label.Location = new System.Drawing.Point(341, 47);
            this.kind2label.Name = "kind2label";
            this.kind2label.Size = new System.Drawing.Size(148, 27);
            this.kind2label.TabIndex = 2;
            this.kind2label.Text = "Kind of Lost";
            // 
            // kind2res
            // 
            this.kind2res.AutoSize = true;
            this.kind2res.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kind2res.Location = new System.Drawing.Point(353, 86);
            this.kind2res.Name = "kind2res";
            this.kind2res.Size = new System.Drawing.Size(50, 24);
            this.kind2res.TabIndex = 9;
            this.kind2res.Text = "kind";
            // 
            // name2label
            // 
            this.name2label.AutoSize = true;
            this.name2label.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.name2label.Location = new System.Drawing.Point(317, 174);
            this.name2label.Name = "name2label";
            this.name2label.Size = new System.Drawing.Size(203, 27);
            this.name2label.TabIndex = 10;
            this.name2label.Text = "Lost owner name";
            // 
            // name2res
            // 
            this.name2res.AutoSize = true;
            this.name2res.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.name2res.Location = new System.Drawing.Point(365, 215);
            this.name2res.Name = "name2res";
            this.name2res.Size = new System.Drawing.Size(63, 24);
            this.name2res.TabIndex = 11;
            this.name2res.Text = "Name";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(12, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 69);
            this.button1.TabIndex = 12;
            this.button1.Text = "Receive Lost Items";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // deliverbutton
            // 
            this.deliverbutton.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deliverbutton.Location = new System.Drawing.Point(290, 367);
            this.deliverbutton.Name = "deliverbutton";
            this.deliverbutton.Size = new System.Drawing.Size(216, 69);
            this.deliverbutton.TabIndex = 14;
            this.deliverbutton.Text = "Home Delivery";
            this.deliverbutton.UseVisualStyleBackColor = true;
            this.deliverbutton.Click += new System.EventHandler(this.deliverbutton_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button2.Location = new System.Drawing.Point(374, 498);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 62);
            this.button2.TabIndex = 25;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(562, 367);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(216, 69);
            this.button3.TabIndex = 26;
            this.button3.Text = "Receive prices";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Preview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(804, 572);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.deliverbutton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.name2res);
            this.Controls.Add(this.name2label);
            this.Controls.Add(this.kind2res);
            this.Controls.Add(this.kind2label);
            this.Name = "Preview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lost-Found";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label kind2label;
        private System.Windows.Forms.Label kind2res;
        private System.Windows.Forms.Label name2label;
        private System.Windows.Forms.Label name2res;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button deliverbutton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}
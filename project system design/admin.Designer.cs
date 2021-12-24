
namespace project_system_design
{
    partial class admin
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
            this.kind1label = new System.Windows.Forms.Label();
            this.kind1combo = new System.Windows.Forms.ComboBox();
            this.gov1label = new System.Windows.Forms.Label();
            this.gov1combo = new System.Windows.Forms.ComboBox();
            this.name1label = new System.Windows.Forms.Label();
            this.name1text = new System.Windows.Forms.TextBox();
            this.no1label = new System.Windows.Forms.Label();
            this.no1text = new System.Windows.Forms.TextBox();
            this.searchbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kind1label
            // 
            this.kind1label.AutoSize = true;
            this.kind1label.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kind1label.Location = new System.Drawing.Point(12, 67);
            this.kind1label.Name = "kind1label";
            this.kind1label.Size = new System.Drawing.Size(141, 27);
            this.kind1label.TabIndex = 11;
            this.kind1label.Text = "Kind of lost";
            // 
            // kind1combo
            // 
            this.kind1combo.DropDownHeight = 120;
            this.kind1combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kind1combo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kind1combo.FormattingEnabled = true;
            this.kind1combo.IntegralHeight = false;
            this.kind1combo.ItemHeight = 24;
            this.kind1combo.Items.AddRange(new object[] {
            "بطاقة رقم قومي",
            "بطاقة تحقيق شخصية",
            "كارنيهات نوادي – كارنيهات أنشطة مختلفة",
            "كارت فيزا – بطاقات ائتمان مختلفة",
            "رخصة قيادة / سلاح / أخري",
            "جواز سفر مصري",
            "جواز سفر أجنبي",
            "تحقيق شخصية / عسكرية / شرطة / امن قومي / رقابة إدارية"});
            this.kind1combo.Location = new System.Drawing.Point(12, 97);
            this.kind1combo.Name = "kind1combo";
            this.kind1combo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.kind1combo.Size = new System.Drawing.Size(459, 32);
            this.kind1combo.TabIndex = 12;
            // 
            // gov1label
            // 
            this.gov1label.AutoSize = true;
            this.gov1label.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gov1label.Location = new System.Drawing.Point(13, 142);
            this.gov1label.Name = "gov1label";
            this.gov1label.Size = new System.Drawing.Size(151, 27);
            this.gov1label.TabIndex = 13;
            this.gov1label.Text = "Governorate";
            // 
            // gov1combo
            // 
            this.gov1combo.DropDownHeight = 120;
            this.gov1combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gov1combo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gov1combo.FormattingEnabled = true;
            this.gov1combo.IntegralHeight = false;
            this.gov1combo.ItemHeight = 24;
            this.gov1combo.Items.AddRange(new object[] {
            "القاهرة",
            "الجيزة",
            "الاسكندرية",
            "الاسماعيلية",
            "السويس",
            "بورسعيد",
            "قنا",
            "كفر الشيخ",
            "اسيوط",
            "دمنهور",
            "المنوفية",
            "القليوبية",
            "الشرقية",
            "الغربية",
            "دمياط",
            "مطروح",
            "البحيرة",
            "بني سويف",
            "الوادي الجديد",
            "المنيا",
            "الفيوم",
            "سوهاج",
            "شمال سيناء",
            "جنوب سيناء",
            "البجر الأحمر",
            "الأقصر",
            "أسوان"});
            this.gov1combo.Location = new System.Drawing.Point(13, 183);
            this.gov1combo.Name = "gov1combo";
            this.gov1combo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gov1combo.Size = new System.Drawing.Size(459, 32);
            this.gov1combo.TabIndex = 14;
            // 
            // name1label
            // 
            this.name1label.AutoSize = true;
            this.name1label.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.name1label.Location = new System.Drawing.Point(13, 236);
            this.name1label.Name = "name1label";
            this.name1label.Size = new System.Drawing.Size(203, 27);
            this.name1label.TabIndex = 15;
            this.name1label.Text = "Lost owner name";
            // 
            // name1text
            // 
            this.name1text.Location = new System.Drawing.Point(15, 275);
            this.name1text.Multiline = true;
            this.name1text.Name = "name1text";
            this.name1text.Size = new System.Drawing.Size(403, 42);
            this.name1text.TabIndex = 16;
            // 
            // no1label
            // 
            this.no1label.AutoSize = true;
            this.no1label.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.no1label.Location = new System.Drawing.Point(15, 334);
            this.no1label.Name = "no1label";
            this.no1label.Size = new System.Drawing.Size(110, 27);
            this.no1label.TabIndex = 17;
            this.no1label.Text = "ID of lost";
            // 
            // no1text
            // 
            this.no1text.Location = new System.Drawing.Point(13, 364);
            this.no1text.Multiline = true;
            this.no1text.Name = "no1text";
            this.no1text.Size = new System.Drawing.Size(403, 43);
            this.no1text.TabIndex = 18;
            // 
            // searchbutton
            // 
            this.searchbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchbutton.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.searchbutton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.searchbutton.Location = new System.Drawing.Point(315, 530);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(205, 62);
            this.searchbutton.TabIndex = 19;
            this.searchbutton.Text = "Enter";
            this.searchbutton.UseVisualStyleBackColor = false;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(284, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 35);
            this.label1.TabIndex = 21;
            this.label1.Text = "Lost Data Entry";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(15, 421);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 27);
            this.label2.TabIndex = 22;
            this.label2.Text = "Special Entity";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownHeight = 120;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.ItemHeight = 24;
            this.comboBox1.Items.AddRange(new object[] {
            "قوات مسلحة ",
            "الداخلية",
            "جهات قضائية",
            "لا يوجد"});
            this.comboBox1.Location = new System.Drawing.Point(15, 465);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox1.Size = new System.Drawing.Size(268, 32);
            this.comboBox1.TabIndex = 23;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button2.Location = new System.Drawing.Point(706, 530);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 62);
            this.button2.TabIndex = 24;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(828, 616);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchbutton);
            this.Controls.Add(this.no1text);
            this.Controls.Add(this.no1label);
            this.Controls.Add(this.name1text);
            this.Controls.Add(this.name1label);
            this.Controls.Add(this.gov1combo);
            this.Controls.Add(this.gov1label);
            this.Controls.Add(this.kind1combo);
            this.Controls.Add(this.kind1label);
            this.Name = "admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lost-Found Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label kind1label;
        private System.Windows.Forms.ComboBox kind1combo;
        private System.Windows.Forms.Label gov1label;
        private System.Windows.Forms.ComboBox gov1combo;
        private System.Windows.Forms.Label name1label;
        private System.Windows.Forms.TextBox name1text;
        private System.Windows.Forms.Label no1label;
        private System.Windows.Forms.TextBox no1text;
        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
    }
}
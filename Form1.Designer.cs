namespace WebDriverApplication
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.languageTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.expectionTextBox = new System.Windows.Forms.TextBox();
            this.logListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "Получить данные";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // countryTextBox
            // 
            this.countryTextBox.Location = new System.Drawing.Point(40, 42);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(209, 20);
            this.countryTextBox.TabIndex = 2;
            this.countryTextBox.Text = "Romania";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Страна";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Язык";
            // 
            // languageTextBox
            // 
            this.languageTextBox.Location = new System.Drawing.Point(40, 81);
            this.languageTextBox.Name = "languageTextBox";
            this.languageTextBox.Size = new System.Drawing.Size(209, 20);
            this.languageTextBox.TabIndex = 4;
            this.languageTextBox.Text = "English";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Предполагаемое колличество вакансий";
            // 
            // expectionTextBox
            // 
            this.expectionTextBox.Location = new System.Drawing.Point(40, 120);
            this.expectionTextBox.Name = "expectionTextBox";
            this.expectionTextBox.Size = new System.Drawing.Size(209, 20);
            this.expectionTextBox.TabIndex = 6;
            this.expectionTextBox.Text = "0";
            // 
            // logListBox
            // 
            this.logListBox.FormattingEnabled = true;
            this.logListBox.Location = new System.Drawing.Point(277, 22);
            this.logListBox.Name = "logListBox";
            this.logListBox.Size = new System.Drawing.Size(276, 199);
            this.logListBox.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 238);
            this.Controls.Add(this.logListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.expectionTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.languageTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.countryTextBox);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Web Driver Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox languageTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox expectionTextBox;
        private System.Windows.Forms.ListBox logListBox;
    }
}


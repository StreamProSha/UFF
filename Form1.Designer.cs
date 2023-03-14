namespace PTA
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
            this.textBox_acc = new System.Windows.Forms.TextBox();
            this.textBox_zpacc = new System.Windows.Forms.TextBox();
            this.textBox_week = new System.Windows.Forms.TextBox();
            this.textBox_percentages = new System.Windows.Forms.TextBox();
            this.label_acc = new System.Windows.Forms.Label();
            this.label_zpacc = new System.Windows.Forms.Label();
            this.label_week = new System.Windows.Forms.Label();
            this.checkBox_percentages = new System.Windows.Forms.CheckBox();
            this.label_ezhweek = new System.Windows.Forms.Label();
            this.textBox_prime = new System.Windows.Forms.TextBox();
            this.checkBox_prime = new System.Windows.Forms.CheckBox();
            this.label_allacc = new System.Windows.Forms.Label();
            this.label_gbals = new System.Windows.Forms.Label();
            this.label_balsreal = new System.Windows.Forms.Label();
            this.label_ballans = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(263, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Посчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_acc
            // 
            this.textBox_acc.Location = new System.Drawing.Point(13, 14);
            this.textBox_acc.Name = "textBox_acc";
            this.textBox_acc.Size = new System.Drawing.Size(100, 20);
            this.textBox_acc.TabIndex = 1;
            // 
            // textBox_zpacc
            // 
            this.textBox_zpacc.Location = new System.Drawing.Point(13, 41);
            this.textBox_zpacc.Name = "textBox_zpacc";
            this.textBox_zpacc.Size = new System.Drawing.Size(100, 20);
            this.textBox_zpacc.TabIndex = 2;
            // 
            // textBox_week
            // 
            this.textBox_week.Location = new System.Drawing.Point(13, 67);
            this.textBox_week.Name = "textBox_week";
            this.textBox_week.Size = new System.Drawing.Size(100, 20);
            this.textBox_week.TabIndex = 3;
            // 
            // textBox_percentages
            // 
            this.textBox_percentages.Enabled = false;
            this.textBox_percentages.Location = new System.Drawing.Point(13, 119);
            this.textBox_percentages.Name = "textBox_percentages";
            this.textBox_percentages.Size = new System.Drawing.Size(100, 20);
            this.textBox_percentages.TabIndex = 4;
            this.textBox_percentages.Text = "0";
            // 
            // label_acc
            // 
            this.label_acc.AutoSize = true;
            this.label_acc.Location = new System.Drawing.Point(116, 18);
            this.label_acc.Name = "label_acc";
            this.label_acc.Size = new System.Drawing.Size(75, 13);
            this.label_acc.TabIndex = 5;
            this.label_acc.Text = "Кол-во Акков";
            // 
            // label_zpacc
            // 
            this.label_zpacc.AutoSize = true;
            this.label_zpacc.Location = new System.Drawing.Point(116, 45);
            this.label_zpacc.Name = "label_zpacc";
            this.label_zpacc.Size = new System.Drawing.Size(110, 13);
            this.label_zpacc.TabIndex = 6;
            this.label_zpacc.Text = "Средняя цена кейса";
            // 
            // label_week
            // 
            this.label_week.AutoSize = true;
            this.label_week.Location = new System.Drawing.Point(116, 70);
            this.label_week.Name = "label_week";
            this.label_week.Size = new System.Drawing.Size(105, 13);
            this.label_week.TabIndex = 7;
            this.label_week.Text = "Недель просчитать";
            // 
            // checkBox_percentages
            // 
            this.checkBox_percentages.AutoSize = true;
            this.checkBox_percentages.Location = new System.Drawing.Point(119, 119);
            this.checkBox_percentages.Name = "checkBox_percentages";
            this.checkBox_percentages.Size = new System.Drawing.Size(119, 17);
            this.checkBox_percentages.TabIndex = 9;
            this.checkBox_percentages.Text = "Процент на вывод";
            this.checkBox_percentages.UseVisualStyleBackColor = true;
            this.checkBox_percentages.CheckedChanged += new System.EventHandler(this.checkBox_percentages_CheckedChanged);
            // 
            // label_ezhweek
            // 
            this.label_ezhweek.AutoSize = true;
            this.label_ezhweek.Location = new System.Drawing.Point(260, 50);
            this.label_ezhweek.Name = "label_ezhweek";
            this.label_ezhweek.Size = new System.Drawing.Size(116, 13);
            this.label_ezhweek.TabIndex = 10;
            this.label_ezhweek.Text = "Еженедельный доход";
            // 
            // textBox_prime
            // 
            this.textBox_prime.Enabled = false;
            this.textBox_prime.Location = new System.Drawing.Point(13, 93);
            this.textBox_prime.Name = "textBox_prime";
            this.textBox_prime.Size = new System.Drawing.Size(100, 20);
            this.textBox_prime.TabIndex = 12;
            this.textBox_prime.Text = "0";
            // 
            // checkBox_prime
            // 
            this.checkBox_prime.AutoSize = true;
            this.checkBox_prime.Location = new System.Drawing.Point(119, 93);
            this.checkBox_prime.Name = "checkBox_prime";
            this.checkBox_prime.Size = new System.Drawing.Size(125, 17);
            this.checkBox_prime.TabIndex = 13;
            this.checkBox_prime.Text = "Цена прайма закуп";
            this.checkBox_prime.UseVisualStyleBackColor = true;
            this.checkBox_prime.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label_allacc
            // 
            this.label_allacc.AutoSize = true;
            this.label_allacc.Location = new System.Drawing.Point(260, 37);
            this.label_allacc.Name = "label_allacc";
            this.label_allacc.Size = new System.Drawing.Size(97, 13);
            this.label_allacc.TabIndex = 14;
            this.label_allacc.Text = "Кол-во Аккаунтов";
            // 
            // label_gbals
            // 
            this.label_gbals.AutoSize = true;
            this.label_gbals.Location = new System.Drawing.Point(260, 63);
            this.label_gbals.Name = "label_gbals";
            this.label_gbals.Size = new System.Drawing.Size(69, 13);
            this.label_gbals.TabIndex = 15;
            this.label_gbals.Text = "Всего денег";
            // 
            // label_balsreal
            // 
            this.label_balsreal.AutoSize = true;
            this.label_balsreal.Location = new System.Drawing.Point(260, 89);
            this.label_balsreal.Name = "label_balsreal";
            this.label_balsreal.Size = new System.Drawing.Size(58, 13);
            this.label_balsreal.TabIndex = 16;
            this.label_balsreal.Text = "Выведено";
            // 
            // label_ballans
            // 
            this.label_ballans.AutoSize = true;
            this.label_ballans.Location = new System.Drawing.Point(260, 76);
            this.label_ballans.Name = "label_ballans";
            this.label_ballans.Size = new System.Drawing.Size(44, 13);
            this.label_ballans.TabIndex = 17;
            this.label_ballans.Text = "Баланс";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 148);
            this.Controls.Add(this.label_ballans);
            this.Controls.Add(this.label_balsreal);
            this.Controls.Add(this.label_gbals);
            this.Controls.Add(this.label_allacc);
            this.Controls.Add(this.checkBox_prime);
            this.Controls.Add(this.textBox_prime);
            this.Controls.Add(this.label_ezhweek);
            this.Controls.Add(this.checkBox_percentages);
            this.Controls.Add(this.label_week);
            this.Controls.Add(this.label_zpacc);
            this.Controls.Add(this.label_acc);
            this.Controls.Add(this.textBox_percentages);
            this.Controls.Add(this.textBox_week);
            this.Controls.Add(this.textBox_zpacc);
            this.Controls.Add(this.textBox_acc);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Калькулятор Фермера";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_acc;
        private System.Windows.Forms.TextBox textBox_zpacc;
        private System.Windows.Forms.TextBox textBox_week;
        private System.Windows.Forms.TextBox textBox_percentages;
        private System.Windows.Forms.Label label_acc;
        private System.Windows.Forms.Label label_zpacc;
        private System.Windows.Forms.Label label_week;
        private System.Windows.Forms.CheckBox checkBox_percentages;
        private System.Windows.Forms.Label label_ezhweek;
        private System.Windows.Forms.TextBox textBox_prime;
        private System.Windows.Forms.CheckBox checkBox_prime;
        private System.Windows.Forms.Label label_allacc;
        private System.Windows.Forms.Label label_gbals;
        private System.Windows.Forms.Label label_balsreal;
        private System.Windows.Forms.Label label_ballans;
    }
}


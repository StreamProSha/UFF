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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button_bat_open = new System.Windows.Forms.Button();
            this.textBox_name_bat = new System.Windows.Forms.TextBox();
            this.label_name_bat = new System.Windows.Forms.Label();
            this.button_bat_create = new System.Windows.Forms.Button();
            this.textBox_cfg = new System.Windows.Forms.TextBox();
            this.label_name_cfg = new System.Windows.Forms.Label();
            this.checkBox_cfg = new System.Windows.Forms.CheckBox();
            this.textBox_pass = new System.Windows.Forms.TextBox();
            this.label_pass = new System.Windows.Forms.Label();
            this.label_login = new System.Windows.Forms.Label();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(256, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Посчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_acc
            // 
            this.textBox_acc.Location = new System.Drawing.Point(6, 6);
            this.textBox_acc.Name = "textBox_acc";
            this.textBox_acc.Size = new System.Drawing.Size(100, 20);
            this.textBox_acc.TabIndex = 1;
            // 
            // textBox_zpacc
            // 
            this.textBox_zpacc.Location = new System.Drawing.Point(6, 33);
            this.textBox_zpacc.Name = "textBox_zpacc";
            this.textBox_zpacc.Size = new System.Drawing.Size(100, 20);
            this.textBox_zpacc.TabIndex = 2;
            // 
            // textBox_week
            // 
            this.textBox_week.Location = new System.Drawing.Point(6, 59);
            this.textBox_week.Name = "textBox_week";
            this.textBox_week.Size = new System.Drawing.Size(100, 20);
            this.textBox_week.TabIndex = 3;
            // 
            // textBox_percentages
            // 
            this.textBox_percentages.Enabled = false;
            this.textBox_percentages.Location = new System.Drawing.Point(6, 111);
            this.textBox_percentages.Name = "textBox_percentages";
            this.textBox_percentages.Size = new System.Drawing.Size(100, 20);
            this.textBox_percentages.TabIndex = 4;
            this.textBox_percentages.Text = "0";
            // 
            // label_acc
            // 
            this.label_acc.AutoSize = true;
            this.label_acc.Location = new System.Drawing.Point(109, 10);
            this.label_acc.Name = "label_acc";
            this.label_acc.Size = new System.Drawing.Size(75, 13);
            this.label_acc.TabIndex = 5;
            this.label_acc.Text = "Кол-во Акков";
            // 
            // label_zpacc
            // 
            this.label_zpacc.AutoSize = true;
            this.label_zpacc.Location = new System.Drawing.Point(109, 37);
            this.label_zpacc.Name = "label_zpacc";
            this.label_zpacc.Size = new System.Drawing.Size(110, 13);
            this.label_zpacc.TabIndex = 6;
            this.label_zpacc.Text = "Средняя цена кейса";
            // 
            // label_week
            // 
            this.label_week.AutoSize = true;
            this.label_week.Location = new System.Drawing.Point(109, 62);
            this.label_week.Name = "label_week";
            this.label_week.Size = new System.Drawing.Size(105, 13);
            this.label_week.TabIndex = 7;
            this.label_week.Text = "Недель просчитать";
            // 
            // checkBox_percentages
            // 
            this.checkBox_percentages.AutoSize = true;
            this.checkBox_percentages.Location = new System.Drawing.Point(112, 111);
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
            this.label_ezhweek.Location = new System.Drawing.Point(253, 42);
            this.label_ezhweek.Name = "label_ezhweek";
            this.label_ezhweek.Size = new System.Drawing.Size(116, 13);
            this.label_ezhweek.TabIndex = 10;
            this.label_ezhweek.Text = "Еженедельный доход";
            // 
            // textBox_prime
            // 
            this.textBox_prime.Enabled = false;
            this.textBox_prime.Location = new System.Drawing.Point(6, 85);
            this.textBox_prime.Name = "textBox_prime";
            this.textBox_prime.Size = new System.Drawing.Size(100, 20);
            this.textBox_prime.TabIndex = 12;
            this.textBox_prime.Text = "0";
            // 
            // checkBox_prime
            // 
            this.checkBox_prime.AutoSize = true;
            this.checkBox_prime.Location = new System.Drawing.Point(112, 85);
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
            this.label_allacc.Location = new System.Drawing.Point(253, 29);
            this.label_allacc.Name = "label_allacc";
            this.label_allacc.Size = new System.Drawing.Size(97, 13);
            this.label_allacc.TabIndex = 14;
            this.label_allacc.Text = "Кол-во Аккаунтов";
            // 
            // label_gbals
            // 
            this.label_gbals.AutoSize = true;
            this.label_gbals.Location = new System.Drawing.Point(253, 55);
            this.label_gbals.Name = "label_gbals";
            this.label_gbals.Size = new System.Drawing.Size(69, 13);
            this.label_gbals.TabIndex = 15;
            this.label_gbals.Text = "Всего денег";
            // 
            // label_balsreal
            // 
            this.label_balsreal.AutoSize = true;
            this.label_balsreal.Location = new System.Drawing.Point(253, 81);
            this.label_balsreal.Name = "label_balsreal";
            this.label_balsreal.Size = new System.Drawing.Size(58, 13);
            this.label_balsreal.TabIndex = 16;
            this.label_balsreal.Text = "Выведено";
            // 
            // label_ballans
            // 
            this.label_ballans.AutoSize = true;
            this.label_ballans.Location = new System.Drawing.Point(253, 68);
            this.label_ballans.Name = "label_ballans";
            this.label_ballans.Size = new System.Drawing.Size(44, 13);
            this.label_ballans.TabIndex = 17;
            this.label_ballans.Text = "Баланс";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(419, 167);
            this.tabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox_acc);
            this.tabPage1.Controls.Add(this.label_ballans);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label_balsreal);
            this.tabPage1.Controls.Add(this.textBox_zpacc);
            this.tabPage1.Controls.Add(this.label_gbals);
            this.tabPage1.Controls.Add(this.textBox_week);
            this.tabPage1.Controls.Add(this.label_allacc);
            this.tabPage1.Controls.Add(this.textBox_percentages);
            this.tabPage1.Controls.Add(this.checkBox_prime);
            this.tabPage1.Controls.Add(this.label_acc);
            this.tabPage1.Controls.Add(this.textBox_prime);
            this.tabPage1.Controls.Add(this.label_zpacc);
            this.tabPage1.Controls.Add(this.label_ezhweek);
            this.tabPage1.Controls.Add(this.label_week);
            this.tabPage1.Controls.Add(this.checkBox_percentages);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(411, 141);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Калькулятор";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button_bat_open);
            this.tabPage2.Controls.Add(this.textBox_name_bat);
            this.tabPage2.Controls.Add(this.label_name_bat);
            this.tabPage2.Controls.Add(this.button_bat_create);
            this.tabPage2.Controls.Add(this.textBox_cfg);
            this.tabPage2.Controls.Add(this.label_name_cfg);
            this.tabPage2.Controls.Add(this.checkBox_cfg);
            this.tabPage2.Controls.Add(this.textBox_pass);
            this.tabPage2.Controls.Add(this.label_pass);
            this.tabPage2.Controls.Add(this.label_login);
            this.tabPage2.Controls.Add(this.textBox_login);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(411, 141);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Батник";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button_bat_open
            // 
            this.button_bat_open.Location = new System.Drawing.Point(266, 44);
            this.button_bat_open.Name = "button_bat_open";
            this.button_bat_open.Size = new System.Drawing.Size(100, 63);
            this.button_bat_open.TabIndex = 30;
            this.button_bat_open.Text = "Запустить батник";
            this.button_bat_open.UseVisualStyleBackColor = true;
            this.button_bat_open.Click += new System.EventHandler(this.button_bat_open_Click);
            // 
            // textBox_name_bat
            // 
            this.textBox_name_bat.Location = new System.Drawing.Point(266, 19);
            this.textBox_name_bat.Name = "textBox_name_bat";
            this.textBox_name_bat.Size = new System.Drawing.Size(100, 20);
            this.textBox_name_bat.TabIndex = 29;
            // 
            // label_name_bat
            // 
            this.label_name_bat.AutoSize = true;
            this.label_name_bat.Location = new System.Drawing.Point(266, 3);
            this.label_name_bat.Name = "label_name_bat";
            this.label_name_bat.Size = new System.Drawing.Size(101, 13);
            this.label_name_bat.TabIndex = 28;
            this.label_name_bat.Text = "Название батника";
            // 
            // button_bat_create
            // 
            this.button_bat_create.Location = new System.Drawing.Point(121, 74);
            this.button_bat_create.Name = "button_bat_create";
            this.button_bat_create.Size = new System.Drawing.Size(125, 33);
            this.button_bat_create.TabIndex = 27;
            this.button_bat_create.Text = "Добавить в батник";
            this.button_bat_create.UseVisualStyleBackColor = true;
            this.button_bat_create.Click += new System.EventHandler(this.button_bat_create_Click);
            // 
            // textBox_cfg
            // 
            this.textBox_cfg.Enabled = false;
            this.textBox_cfg.Location = new System.Drawing.Point(121, 48);
            this.textBox_cfg.Name = "textBox_cfg";
            this.textBox_cfg.Size = new System.Drawing.Size(100, 20);
            this.textBox_cfg.TabIndex = 26;
            // 
            // label_name_cfg
            // 
            this.label_name_cfg.AutoSize = true;
            this.label_name_cfg.Location = new System.Drawing.Point(120, 32);
            this.label_name_cfg.Name = "label_name_cfg";
            this.label_name_cfg.Size = new System.Drawing.Size(103, 13);
            this.label_name_cfg.TabIndex = 25;
            this.label_name_cfg.Text = "Название конфига";
            // 
            // checkBox_cfg
            // 
            this.checkBox_cfg.AutoSize = true;
            this.checkBox_cfg.Location = new System.Drawing.Point(121, 9);
            this.checkBox_cfg.Name = "checkBox_cfg";
            this.checkBox_cfg.Size = new System.Drawing.Size(139, 17);
            this.checkBox_cfg.TabIndex = 24;
            this.checkBox_cfg.Text = "Использовать конфиг";
            this.checkBox_cfg.UseVisualStyleBackColor = true;
            this.checkBox_cfg.CheckedChanged += new System.EventHandler(this.checkBox_cfg_CheckedChanged);
            // 
            // textBox_pass
            // 
            this.textBox_pass.Location = new System.Drawing.Point(8, 87);
            this.textBox_pass.Name = "textBox_pass";
            this.textBox_pass.Size = new System.Drawing.Size(100, 20);
            this.textBox_pass.TabIndex = 23;
            // 
            // label_pass
            // 
            this.label_pass.AutoSize = true;
            this.label_pass.Location = new System.Drawing.Point(15, 71);
            this.label_pass.Name = "label_pass";
            this.label_pass.Size = new System.Drawing.Size(88, 13);
            this.label_pass.TabIndex = 22;
            this.label_pass.Text = "Введите пароль";
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.Location = new System.Drawing.Point(17, 32);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(81, 13);
            this.label_login.TabIndex = 21;
            this.label_login.Text = "Введите логин";
            // 
            // textBox_login
            // 
            this.textBox_login.Location = new System.Drawing.Point(8, 48);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(100, 20);
            this.textBox_login.TabIndex = 20;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(8, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Путь к Steam.exe";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 178);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Калькулятор Фермера";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox_cfg;
        private System.Windows.Forms.Label label_name_cfg;
        private System.Windows.Forms.CheckBox checkBox_cfg;
        private System.Windows.Forms.TextBox textBox_pass;
        private System.Windows.Forms.Label label_pass;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.Button button_bat_create;
        private System.Windows.Forms.TextBox textBox_name_bat;
        private System.Windows.Forms.Label label_name_bat;
        private System.Windows.Forms.Button button_bat_open;
    }
}


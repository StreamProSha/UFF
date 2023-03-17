using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace PTA
{
    public partial class Form1 : Form           
    {
        private string[] lines;
        private string SteamPath;
        public Form1()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
        }
        public void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("Data"))
            {
                lines = File.ReadAllLines("Data");
                if (lines.Length >= 0)
                    using (StreamReader reader = new StreamReader("Data"))
                    {
                        textBox_acc.Text = lines[0];
                        textBox_zpacc.Text = lines[1];
                        textBox_week.Text = lines[2];
                        textBox_prime.Text = lines[3];
                        textBox_percentages.Text = lines[4];
                        SteamPath = lines[5];
                        textBox_cfg.Text = lines[6];
                    }
            }
        }
        public void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            using (StreamWriter data = new StreamWriter("Data", false))
            {
                data.WriteLine(textBox_acc.Text);
                data.WriteLine(textBox_zpacc.Text);
                data.WriteLine(textBox_week.Text);
                data.WriteLine(textBox_prime.Text);
                data.WriteLine(textBox_percentages.Text);
                data.WriteLine(SteamPath);
                data.WriteLine(textBox_cfg.Text);
            }

        }
        public void button1_Click(object sender, EventArgs e)      
        {
            int week = Convert.ToInt32(textBox_week.Text);
            int acc = Convert.ToInt32(textBox_acc.Text);
            int weeks = 0;
            float zpacc = (float)Convert.ToDouble(textBox_zpacc.Text);
            float perc = (float)Convert.ToDouble(textBox_percentages.Text);
            float prime = (float)Convert.ToDouble(textBox_prime.Text);
            float bals = 0;
            float gbals = 0;
            float reals = 0;
            float zp = acc * zpacc;
            

            while (weeks < week)
            {
                if (checkBox_prime.Checked && checkBox_percentages.Checked && textBox_percentages.Text != "0") //выводим и покупаем прайм
                {
                    zp = acc * zpacc;
                    gbals += zp;
                    reals += zp / 100 * perc;
                    bals -= zp / 100 * perc;
                    bals += zp;
                    while (bals >= prime)
                    {
                        bals -= prime;
                        acc++;
                        zp = acc * zpacc;
                    }

                }

                else if (checkBox_prime.Checked && !checkBox_percentages.Checked) //покупаем прайм, вывод остановлен
                {
                    gbals += zp;
                    bals += zp;
                    while (bals >= prime)
                    {
                        bals -= prime;
                        acc++;
                        zp = acc * zpacc;
                    }
                }

                else if (!checkBox_prime.Checked && checkBox_percentages.Checked && textBox_percentages.Text != "0") //не покупаем прайм, вывод включен
                {
                    zp = acc * zpacc;
                    gbals += zp;
                    reals += zp / 100 * perc;
                    bals -= zp / 100 * perc;
                    bals += zp;
                }

                else if (!checkBox_prime.Checked && !checkBox_percentages.Checked)  // всё выключено
                {
                    gbals += zp;
                    bals += zp;
                }
                weeks++;
            }

            label_allacc.Text = "Кол-во акков: " + Convert.ToString(acc);
            label_ezhweek.Text = "Еженедельный доход: " + Convert.ToString(zp);
            label_gbals.Text = "Всего заработано : " + Convert.ToString(gbals);
            label_ballans.Text = "Остаток баланса: " + Convert.ToString(bals);
            label_balsreal.Text = "Выведено: " + Convert.ToString(reals);
        }

        private void checkBox_percentages_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox_percentages.Checked)
            {
                textBox_percentages.Enabled = false;
                textBox_percentages.Text = "0";
            }
            else
            {
                textBox_percentages.Enabled = true;
                if (File.Exists("Data"))
                    textBox_percentages.Text = lines[4];
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox_prime.Checked)
            {
                textBox_prime.Enabled = false;
                textBox_prime.Text = "0";
            }
            else
            {
                textBox_prime.Enabled = true;
                if (File.Exists("Data"))
                    textBox_prime.Text = lines[3];
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                SteamPath = Convert.ToString(openFileDialog.FileName);
            }
        }

        private void checkBox_cfg_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_cfg.Checked)
            {
                textBox_cfg.Enabled = true;
                textBox_cfg.Text = lines[6];
            }

            else
            {
                textBox_cfg.Enabled = false; 
                textBox_cfg.Text = "0";
            }
        }

        private void button_bat_create_Click(object sender, EventArgs e)
        {
            string login = Convert.ToString(textBox_login.Text);
            string pass = Convert.ToString(textBox_pass.Text);
            string name_bat = Convert.ToString(textBox_name_bat.Text);
            string name_cfg = Convert.ToString("+exec " + textBox_cfg.Text + ".cfg");
            if (!checkBox_cfg.Checked)
                name_cfg = "";
            string text_bat = string.Format("Start {0} -noreactlogin -login {1} \"{2}\" -language russian -no-browser -applaunch 730 -low -nohltv -nosound -novid -window -w 640 -h 480 -x 0 -y 0  -console {3}", SteamPath, login, pass, name_cfg + Environment.NewLine);
            using (StreamWriter bat = new StreamWriter(Convert.ToString(name_bat) + ".bat", true))
            {               
                    bat.Write(text_bat);                  
            }
        }

        private void button_bat_open_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Convert.ToString(textBox_name_bat.Text));
        }
        
    }   
        
}

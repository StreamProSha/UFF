using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTA
{
    public partial class Form1 : Form       
    {
        public Form1()
        {

            InitializeComponent();
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
                textBox_percentages.Enabled = true;     
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox_prime.Checked)
            {
                textBox_prime.Enabled = false;
                textBox_prime.Text = "0";
            }
            else
                textBox_prime.Enabled = true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace красивый_запуск
{
    public partial class Устный_счёт : Form
    {
        int count;
        int min = 1;
        int max = 10;
        int count_max = 12;
        string mode = "";

        Random rnd = new Random();
        string answer;

        public Устный_счёт()
        {
            InitializeComponent();
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            start("plus");
        }

        private void start(string my_mode)
        {
            mode = my_mode;
            button_plus.Visible = false;
            button_minus.Visible = false;
            button_mult.Visible = false;
            button_divs.Visible = false;
            label_think.Enabled = true;
            text_answer.Enabled = true;
            text_max.Enabled = false;
            text_answer.Focus();
            progress.Visible = true;
            progress.Minimum = 0;
            progress.Maximum = count_max;
            progress.Value = 0;
            count = 0;
            try
            {
                max = Convert.ToInt16(text_max.Text);
            }
            catch
            {
                max = 10;
                text_max.Text = max.ToString();
            }
            think();
        }

        private void think()
        {

            int a, b;
            a = rnd.Next(min, max + 1);
            b = rnd.Next(min, max + 1);
            if (mode == "plus")
            {
                label_think.Text = a.ToString() + "+" + b.ToString() + "=";
                answer = (a + b).ToString();
            }
            if (mode == "minus")
            {
                if (a < b)
                {
                    int x = a;
                    a = b;
                    b = x;

                }
                label_think.Text = a.ToString() + "-" + b.ToString() + "=";
                answer = (a - b).ToString();
            }
            if (mode == "mult")
            {
                label_think.Text = a.ToString() + "×" + b.ToString() + "=";
                answer = (a * b).ToString();
            }
            if (mode == "divs")
            {
                label_think.Text = (a * b).ToString() + ":" + b.ToString() + "=";
                answer = (a).ToString();
            }
            count++;
        }

        private void text_answer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (text_answer.Text == answer)
                {
                    progress.Value = count;
                    if (count == count_max)
                        gamewins();
                    else
                    {
                        text_answer.Text = "";
                        think();
                    }
                }

                else
                {
                    gameover();
                }
            }
        }

        private void gameover()
        {
            text_answer.Text = answer;
            done();
        }

        private void gamewins()
        {
            MessageBox.Show("Вы победили, ура!!!", "Победа");
            done();
        }

        private void done()
        {
            button_plus.Visible = true;
            button_minus.Visible = true;
            button_mult.Visible = true;
            button_divs.Visible = true;
            progress.Visible = false;
            label_think.Enabled = false;
            text_answer.Enabled = false;
            text_max.Enabled = true;
            button_plus.Focus();
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            start("minus");
        }

        private void button_mult_Click(object sender, EventArgs e)
        {
            start("mult");
        }

        private void button_divs_Click(object sender, EventArgs e)
        {
            start("divs");
        }
    }
}

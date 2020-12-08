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
    public partial class Заставка : Form
    {
        public Заставка()
        {
            InitializeComponent();
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.Opacity += 03;
            if (this.Opacity == 1)
            {
                timer.Stop();
            }
        }
    }
}

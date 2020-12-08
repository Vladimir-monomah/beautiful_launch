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
    public partial class BiautifulPicture : Form
    {
        public BiautifulPicture()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Устный_счёт открыть = new Устный_счёт();
            открыть.ShowDialog();
            this.Hide();
        }
        
    }
}

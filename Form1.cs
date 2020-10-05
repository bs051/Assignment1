

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class Form1 : Form
    {
        CompleteAssement1.LogicClass logic = new CompleteAssement1.LogicClass();
        public Form1()
        {
            InitializeComponent();
        }

        private void loadButton(object sender, EventArgs e)
        {
            logic.loadBullet();
        
        }

        private void SpinChamber(object sender, EventArgs e)
        {
            logic.spinBullet();
        }
        private void ShootBullet(object sender, EventArgs e)
        {
            logic.ShootBullet();
        }

        private void Play_Again_Click(object sender, EventArgs e)
        {
            logic.PlayAgain();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}


using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public class Class1
    {
        int Bullet = 0;
        int Chances = 2;

        public object LoadBt { get; internal set; }

        public void GunShootBt()
        {
            //If the bullet is in the barrel, shoot it at head
            if (Bullet == 5)
            {
                MessageBox.Show("You are dead!");
            }
            else
            {
                MessageBox.Show("The revolver just rotated");
                Bullet = Bullet + 1;
            }
        }
        internal void textBox1()
        {
            throw new NotImplementedException();
        }

        public int textBox1 = AddNumber(1, 2);
        {
private static int AddNumber(int v1, int v2)
        {
            throw new NotImplementedException();
        }

        int output = 1 + 2;
        readonly Return output;
    }
    public void LoadBt()
    {
        Bullet = 0;
    }
    public void Spinbt()
    {
        Random rand = new Random();
        int Var1 = rand.Next(10, 15);
        Debug.WriteLine("*****************************");
        Debug.WriteLine(Var1);
        Debug.WriteLine("*****************************");


    }


    public void ShootAwayBt()
    {
        //if I have chances
        if (Chances > 0)
        {
            if (Bullet == 5)
            {
                MessageBox.Show("You survived");

            }
            else
            {
                MessageBox.Show("The revolver just rotated");
                Bullet = Bullet + 1;
            }
        }
        //If I don't have any chances left
        else
        {
            MessageBox.Show("You are dead!");

        }

        Chances = Chances - 1;
    }

    internal void SpinBt()
    {
        throw new NotImplementedException();
    }
}
}

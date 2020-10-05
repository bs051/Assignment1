

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Media;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompleteAssement1
{
    public class LogicClass
    {
        int Bullet = 0;
        int Chances = 2;
        int SpinBullet = 10;
        int Score = 0;
        public void loadBullet()
        {
            //Random place to load bullet into chamber
            Random rand = new Random();
            int Var1 = rand.Next(1, 6);
            Bullet = Var1;
            MessageBox.Show("Bullet Loaded into Chamber ");
        }
        public void spinBullet()
        {
            //if bullet not loaded then message to load bullet with click load bullet button and retrun
            if(Bullet==0)
            {
                MessageBox.Show("Please Load Bullet");
                return;
            }
            //Select Random number to spin chamber in random place in the gun
            Random rand = new Random();
            int Var1 = rand.Next(1, 6);
            SpinBullet = Var1;
            MessageBox.Show("Chamber Spinned");
        }
        public void PlayAgain()
        {
            //Reset all states and start game
            this.Bullet = 0;
            this.Chances = 2;
            this.SpinBullet = 10;
            Score = 0;
            MessageBox.Show("Game Start Again");
        }
        public void ShootBullet()
        {
            //Before click shoot button first load bullet then spin chamber should be done
            if(SpinBullet==10)
            {
                MessageBox.Show("Please Spin the chamber first and then load bullet into chamber before fire bullet");
                return;
            }
            //if I have chances
            if (Chances > 0)
            {
                //Play Shound of Gun Shoot
                SoundPlayer sound = new SoundPlayer(Assignment1.Properties.Resources.Gun);
                sound.Play();

                //if bullet place in gun and spin chamber to the smae position then your game over and you are survived and get score.
                if (Bullet == SpinBullet)
                {
                    Score += 100;
                    MessageBox.Show("You survived.\n Game End . \nYour Score : "+Score+ (Score==100?"\n \nYou Won ":"You Loss"));
                    PlayAgain();
                }
                else
                {
                    MessageBox.Show("The revolver just rotated");
                    SpinBullet += 1;
                    Score -= 1;
                }
            }
            //If I don't have any chances left
            else
            {
                MessageBox.Show("You are dead! Game End\n Your Score : "+Score+"\n You Loss Game");
            }

            Chances = Chances - 1;
        }
    }

}

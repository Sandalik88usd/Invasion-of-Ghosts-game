using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Gun
    {
        public static void Shoot(int hor, int ver)
        {
            int horGun; int verGun;
            switch (PlayGame.playerPosition)
            {
                case 1:
                    horGun = hor + 10; verGun = ver + 3;
                    for (int i = 0; i <= 20; i++)
                    {
                        Animation.WriteAt(" o", horGun++, verGun);
                        Thread.Sleep(50);
                    }
                    Animation.WriteAt(" ", horGun, verGun);
                    break;
                case 2:
                     horGun = hor;  verGun = ver + 3;
                    for (int i = 0; i <= 20; i++)
                    {
                        Animation.WriteAt("o ", horGun--, verGun);
                        Thread.Sleep(50);
                    }
                    Animation.WriteAt("  ", horGun, verGun);
                    break;
                case 3:
                    horGun = hor + 8; verGun = ver + 1;
                    for (int i = 0; i <= 10; i++)
                    {
                        Animation.WriteAt(" ", horGun, verGun + 1);
                        Animation.WriteAt("o", horGun, verGun--);
                        Thread.Sleep(100);
                    }
                    Animation.WriteAt(" ", horGun, verGun + 1);
                    break;
                case 4:
                    horGun = hor; verGun = ver + 3;
                    for (int i = 0; i <= 10; i++)
                    {
                        Animation.WriteAt(" ", horGun, verGun - 1);
                        Animation.WriteAt("o", horGun, verGun++);
                        Thread.Sleep(100);
                    }
                    Animation.WriteAt(" ", horGun, verGun - 1);
                    break;
            }
        }
    }
}

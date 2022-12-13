using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Do
{
    internal class Gun
    {
        public static int horGun;
        public static int verGun;
        public static int[] horGunHitBox = new int[21];
        public static int[] verGunHitBox = new int[11];
        public static void Shoot(int hor, int ver)
        {
            switch (PlayGame.playerPosition)
            {
                case 1:
                    horGun = hor + 10; verGun = ver + 3;
                    for (int i = 0; i <= 20; i++)
                    {
                        Animation.WriteAt(" o", horGun++, verGun);
                        Thread.Sleep(50);
                        horGunHitBox[i] = horGun;
                    }
                    Animation.WriteAt(" ", horGun, verGun);
                    break;
                case 2:
                    horGun = hor; verGun = ver + 3;
                    for (int i = 0; i <= 20; i++)
                    {
                        Animation.WriteAt("o ", horGun--, verGun);
                        Thread.Sleep(50);
                        horGunHitBox[i] = horGun;
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
                        verGunHitBox[i] = verGun;
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
                        verGunHitBox[i] = verGun;
                    }
                    Animation.WriteAt(" ", horGun, verGun - 1);
                    break;
            }
        }
    }
}

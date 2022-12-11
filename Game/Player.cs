using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Player
    {
        public static void WritePlayerWithGun(int hor, int ver)
        {
            switch (PlayGame.playerPosition)
            {
                case 1:
                    Animation.WriteAt("   ,--,  ", hor, ver);
                    Animation.WriteAt("   │ '│  ", hor, ver + 1);
                    Animation.WriteAt("   '─_'   ", hor, ver + 2);
                    Animation.WriteAt("   │|_)==o  ", hor, ver + 3);
                    Animation.WriteAt("   │__│     ", hor, ver + 4);
                    break;
                case 2:
                    Animation.WriteAt("     ,--,   ", hor, ver);
                    Animation.WriteAt("     │' │   ", hor, ver + 1);
                    Animation.WriteAt("     '_─'   ", hor, ver + 2);
                    Animation.WriteAt("  o==(_|│   ", hor, ver + 3);
                    Animation.WriteAt("     │__│   ", hor, ver + 4);
                    break;
                case 3:
                    Animation.WriteAt("  ,---,   ", hor, ver);
                    Animation.WriteAt("  │\\_/│  ", hor, ver + 1);
                    Animation.WriteAt(" ('|0|;)  ", hor, ver + 2);
                    Animation.WriteAt("  ├───┤   ", hor, ver + 3);
                    Animation.WriteAt("  │_|_│    ", hor, ver + 4);
                    break;
                case 4:
                    Animation.WriteAt("  ,,,,,  ", hor, ver);
                    Animation.WriteAt("  │'_'│  ", hor, ver + 1);
                    Animation.WriteAt(" \\o/──')   ", hor, ver + 2);
                    Animation.WriteAt("  ├───┤   ", hor, ver + 3);
                    Animation.WriteAt("  │_|_│  ", hor, ver + 4);
                    break;
            }

        }
    }
}

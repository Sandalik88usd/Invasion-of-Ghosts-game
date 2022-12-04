using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class GhostsMove
    {
        public static void GhostInHallway()
        {
            int hor = 150 ; int ver = 18;
            while (ver < 40)
            {
                Animation.WriteAt("        ", hor, ver++);
                Animation.WriteAt("  .-.   ", hor, ver++);
                Animation.WriteAt(" (* *)  ", hor, ver++);
                Animation.WriteAt(" / ° \\ ", hor, ver++);
                Animation.WriteAt("^(   \\^", hor, ver++);
                Animation.WriteAt("  \\ (_,", hor, ver++);
                Animation.WriteAt("   '-'", hor, ver++);
                Animation.WriteAt("         ", hor, ver++);
                ver -= 7;
                Thread.Sleep(700);
            }
        }
    }
}

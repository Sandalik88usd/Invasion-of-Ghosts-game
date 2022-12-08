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
        public static void GhostInHallway(ref int horGhost, ref int verGhost, ref int[] horGhostHitbox, ref int[] verGhostHitbox)
        {
            int horLong = horGhost;
            int verLong;
            for (int i = 0; i < horGhostHitbox.Length; i++)
            {
                horGhostHitbox[i] = horLong;
                horLong++;
            }
            while (true)
            {
                if (verGhost == 18)
                {
                    while (verGhost < 40)
                    {
                        Animation.WriteAt("        ", horGhost, verGhost++);
                        Animation.WriteAt("  .-.   ", horGhost, verGhost++);
                        Animation.WriteAt(" (* *)  ", horGhost, verGhost++);
                        Animation.WriteAt(" / ° \\ ", horGhost, verGhost++);
                        Animation.WriteAt("^(   \\^", horGhost, verGhost++);
                        Animation.WriteAt("  \\ (_,", horGhost, verGhost++);
                        Animation.WriteAt("   '-'", horGhost, verGhost++);
                        Animation.WriteAt("         ", horGhost, verGhost++);
                        verGhost -= 7;
                        Thread.Sleep(700);
                        verLong = verGhost;
                        for (int i = 0; i < verGhostHitbox.Length; i++)
                        {
                            verGhostHitbox[i] = verLong;
                            verLong++;
                        }
                    }
                }
                else if (verGhost > 35)
                {
                    while (verGhost != 18)
                    {
                        Animation.WriteAt("        ", horGhost, verGhost++);
                        Animation.WriteAt("  .-.   ", horGhost, verGhost++);
                        Animation.WriteAt(" (* *)  ", horGhost, verGhost++);
                        Animation.WriteAt(" / ° \\ ", horGhost, verGhost++);
                        Animation.WriteAt("^(   \\^", horGhost, verGhost++);
                        Animation.WriteAt("  \\ (_,", horGhost, verGhost++);
                        Animation.WriteAt("   '-'  ", horGhost, verGhost++);
                        Animation.WriteAt("         ", horGhost, verGhost++);
                        verGhost -= 9;
                        Thread.Sleep(700);
                        verLong = verGhost;
                        for (int i = 0; i < verGhostHitbox.Length; i++)
                        {
                            verGhostHitbox[i] = verLong;
                            verLong++;
                        }
                    }
                }
            }
        }
    }
}

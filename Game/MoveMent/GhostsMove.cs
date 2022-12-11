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
            int verLong = verGhost + 10;
            int ghostpose = 0;
            for (int i = 0; i < horGhostHitbox.Length; i++)
            {
                horGhostHitbox[i] = horLong;
                horLong++;
            }
            for (int i = 0; i < verGhostHitbox.Length; i++)
            {
                verGhostHitbox[i] = verLong;
                verLong++;
            }
            while (PlayGame.dethTriger == 0)
            {
                if (verGhost == 18)
                {
                    while (verGhost < 40 && PlayGame.dethTriger == 0)
                    {
                        Animation.GhostVerMove(horGhost, verGhost, ghostpose);
                        verGhost += 1;
                        ghostpose++;
                        if (ghostpose == 3)
                            ghostpose = 0;
                        Thread.Sleep(700);
                        //verLong = verGhost;
                        //for (int i = 0; i < verGhostHitbox.Length; i++)
                        //{
                        //    verGhostHitbox[i] = verLong;
                        //    verLong++;
                        //}
                    }
                }
                else if (verGhost > 35 && PlayGame.dethTriger == 0)
                {
                    while (verGhost != 18)
                    {
                        Animation.GhostVerMove(horGhost, verGhost, ghostpose);
                        ghostpose++;
                        verGhost -= 1;
                        if (ghostpose == 3)
                            ghostpose = 0;
                        Thread.Sleep(700);
                        //verLong = verGhost;
                        //for (int i = 0; i < verGhostHitbox.Length; i++)
                        //{
                        //    verGhostHitbox[i] = verLong;
                        //    verLong++;
                        //}
                    }
                }
            }
        }

    }
}

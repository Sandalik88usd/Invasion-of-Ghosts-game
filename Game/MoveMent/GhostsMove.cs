using Game.Rooms;
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
        public static int firstGhostLive = 1;
        public static int secondGhostLive = 1;
        public static void VerGhostMove(int horGhost, int verGhost, ref int[] horGhostHitbox, ref int[] verGhostHitbox, int maxVerCoordinate, int minVerCoordinate)
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
            while (PlayGame.dethTriger == 0 && firstGhostLive == 1 && PlayGame.roomTrigers == 0)
            {
                if (verGhost == minVerCoordinate)
                {
                    while (verGhost < maxVerCoordinate && PlayGame.dethTriger == 0 && firstGhostLive == 1 && PlayGame.roomTrigers == 0)
                    {
                        Animation.GhostVerMove(horGhost, verGhost, ghostpose);
                        verGhost++;
                        ghostpose++;
                        if (ghostpose == 3)
                            ghostpose = 0;
                        Thread.Sleep(700);
                        if (firstGhostLive == 0)
                        {
                            Animation.WriteAt(@"        ", horGhost, verGhost);
                            Animation.WriteAt(@"        ", horGhost, verGhost++);
                            Animation.WriteAt(@"        ", horGhost, verGhost++);
                            Animation.WriteAt(@"        ", horGhost, verGhost++);
                            Animation.WriteAt(@"        ", horGhost, verGhost++);
                            Animation.WriteAt(@"        ", horGhost, verGhost++);
                            Animation.WriteAt(@"        ", horGhost, verGhost++);
                        }
                        //verLong = verGhost;
                        //for (int i = 0; i < verGhostHitbox.Length; i++)
                        //{
                        //    verGhostHitbox[i] = verLong;
                        //    verLong++;
                        //}
                    }
                }
                else if (verGhost > 35 && PlayGame.dethTriger == 0 && firstGhostLive == 1 && PlayGame.roomTrigers == 0)
                {
                    while (verGhost != minVerCoordinate)
                    {
                        Animation.GhostVerMove(horGhost, verGhost, ghostpose);
                        ghostpose++;
                        verGhost--;
                        if (ghostpose == 3)
                            ghostpose = 0;
                        Thread.Sleep(700);
                        if (firstGhostLive == 0)
                        {
                            Animation.WriteAt(@"        ", horGhost, verGhost);
                            Animation.WriteAt(@"        ", horGhost, verGhost++);
                            Animation.WriteAt(@"        ", horGhost, verGhost++);
                            Animation.WriteAt(@"        ", horGhost, verGhost++);
                            Animation.WriteAt(@"        ", horGhost, verGhost++);
                            Animation.WriteAt(@"        ", horGhost, verGhost++);
                            Animation.WriteAt(@"        ", horGhost, verGhost++);
                        }
                    }
                }
                //if (firstGhostLive == 2)
                //{
                //    switch (PlayGame.roomTrigers)
                //    {
                //        case 0:
                //            Hallway.HallwayRoom();
                //            break;
                //        case 1:
                //            Kitchen.KitchenRoom();
                //            break;
                //    }
                //}
            }
        }
        public static void GhostInKitchen(int horGhost, int verGhost, ref int[] horGhostHitbox, ref int[] verGhostHitbox, int maxVerCoordinate, int minVerCoordinate)
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
            while (PlayGame.dethTriger == 0 && secondGhostLive == 1 && PlayGame.roomTrigers == 1)
            {
                if (verGhost == minVerCoordinate)
                {
                    while (verGhost < maxVerCoordinate && PlayGame.dethTriger == 0 && secondGhostLive == 1 && PlayGame.roomTrigers == 1)
                    {
                        Animation.GhostVerMove(horGhost, verGhost, ghostpose);
                        verGhost++;
                        ghostpose++;
                        if (ghostpose == 3)
                            ghostpose = 0;
                        Thread.Sleep(700);
                        if (secondGhostLive == 0)
                        {
                            Animation.WriteAt(@"        ", horGhost, verGhost);
                            Animation.WriteAt(@"        ", horGhost, verGhost++);
                            Animation.WriteAt(@"        ", horGhost, verGhost++);
                            Animation.WriteAt(@"        ", horGhost, verGhost++);
                            Animation.WriteAt(@"        ", horGhost, verGhost++);
                            Animation.WriteAt(@"        ", horGhost, verGhost++);
                            Animation.WriteAt(@"        ", horGhost, verGhost++);
                        }
                    }
                }
                else if (verGhost > 35 && PlayGame.dethTriger == 0 && secondGhostLive == 1 && PlayGame.roomTrigers == 1)
                {
                    while (verGhost != minVerCoordinate)
                    {
                        Animation.GhostVerMove(horGhost, verGhost, ghostpose);
                        ghostpose++;
                        verGhost--;
                        if (ghostpose == 3)
                            ghostpose = 0;
                        Thread.Sleep(700);
                        if (secondGhostLive == 0)
                        {
                            Animation.WriteAt(@"        ", horGhost, verGhost);
                            Animation.WriteAt(@"        ", horGhost, verGhost++);
                            Animation.WriteAt(@"        ", horGhost, verGhost++);
                            Animation.WriteAt(@"        ", horGhost, verGhost++);
                            Animation.WriteAt(@"        ", horGhost, verGhost++);
                            Animation.WriteAt(@"        ", horGhost, verGhost++);
                            Animation.WriteAt(@"        ", horGhost, verGhost++);
                        }
                    }
                }
            }

        }
    }
}

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
        public static int hallwayGhostLive = 1;
        public static int kitchenGhostLive = 2;
        public static int buthGhostLive = 2;
        public static int bedGhostLive = 2;
        static void FindGhostHitBox(int horGhost, int verGhost, ref int[] horGhostHitbox, ref int[] verGhostHitbox)
        {
            verGhost += 2;
            for (int i = 0; i < horGhostHitbox.Length; i++)
            {
                horGhostHitbox[i] = horGhost;
                horGhost++;
            }
            for (int i = 0; i < verGhostHitbox.Length; i++)
            {
                verGhostHitbox[i] = verGhost;
                verGhost++;
            }
        }
        public static void GhostMoveInHallway(int horGhost, int verGhost, ref int[] horGhostHitbox, ref int[] verGhostHitbox, int maxVerCoordinate, int minVerCoordinate)
        {
            Thread.Sleep(500);
            int ghostpose = 0;
            while (PlayGame.dethTriger == 0 && hallwayGhostLive == 1 && PlayGame.roomTrigers == 0)
            {
                if (verGhost == minVerCoordinate)
                {
                    while (verGhost < maxVerCoordinate && PlayGame.dethTriger == 0 && hallwayGhostLive == 1 && PlayGame.roomTrigers == 0)
                    {
                        Animation.GhostVerMove(horGhost, verGhost, ghostpose);
                        verGhost++;
                        FindGhostHitBox(horGhost, verGhost, ref horGhostHitbox, ref verGhostHitbox);
                        ghostpose++;
                        if (ghostpose == 3)
                            ghostpose = 0;
                        Thread.Sleep(700);
                        if (hallwayGhostLive == 0)
                        {
                            for (int i = 0; i < 8; i++)
                                Animation.WriteAt(@"        ", horGhost++, verGhost);
                            PlayGame.countOfDeadGhosts++;
                        }
                        //verLong = verGhost;
                        //for (int i = 0; i < verGhostHitbox.Length; i++)
                        //{
                        //    verGhostHitbox[i] = verLong;
                        //    verLong++;
                        //}
                    }
                }
                else if (verGhost > 35 && PlayGame.dethTriger == 0 && hallwayGhostLive == 1 && PlayGame.roomTrigers == 0)
                {
                    while (verGhost != minVerCoordinate && PlayGame.dethTriger == 0 && hallwayGhostLive == 1 && PlayGame.roomTrigers == 0)
                    {
                        Animation.GhostVerMove(horGhost, verGhost, ghostpose);
                        ghostpose++;
                        verGhost--;
                        FindGhostHitBox(horGhost, verGhost, ref horGhostHitbox, ref verGhostHitbox);
                        if (ghostpose == 3)
                            ghostpose = 0;
                        Thread.Sleep(700);
                        if (hallwayGhostLive == 0)
                        {
                            for (int i = 0; i < 8; i++)
                                Animation.WriteAt(@"        ", horGhost++, verGhost);
                            PlayGame.countOfDeadGhosts++;
                        }
                    }
                }
                //if (hallwayGhostLive == 2)
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
            Thread.Sleep(500);
            int ghostpose = 0;
            while (PlayGame.dethTriger == 0 && kitchenGhostLive == 1 && PlayGame.roomTrigers == 1)
            {
                if (verGhost == minVerCoordinate)
                {
                    while (verGhost < maxVerCoordinate && PlayGame.dethTriger == 0 && kitchenGhostLive == 1 && PlayGame.roomTrigers == 1)
                    {
                        Animation.GhostVerMove(horGhost, verGhost, ghostpose);
                        verGhost++;
                        ghostpose++;
                        FindGhostHitBox(horGhost, verGhost+2, ref horGhostHitbox, ref verGhostHitbox);
                        if (ghostpose == 3)
                            ghostpose = 0;
                        Thread.Sleep(700);
                        if (kitchenGhostLive == 0)
                        {
                            for(int i = 0; i < 8; i++)
                                Animation.WriteAt(@"        ", horGhost, verGhost++);
                            PlayGame.countOfDeadGhosts++;
                            break;
                        }
                    }
                }
                else if (verGhost > 35 && PlayGame.dethTriger == 0 && kitchenGhostLive == 1 && PlayGame.roomTrigers == 1)
                {
                    while (verGhost != minVerCoordinate && PlayGame.dethTriger == 0 && kitchenGhostLive == 1 && PlayGame.roomTrigers == 1)
                    {
                        Animation.GhostVerMove(horGhost, verGhost, ghostpose);
                        ghostpose++;
                        verGhost--;
                        FindGhostHitBox(horGhost, verGhost, ref horGhostHitbox, ref verGhostHitbox);
                        if (ghostpose == 3)
                            ghostpose = 0;
                        Thread.Sleep(700);
                        if (kitchenGhostLive == 0)
                        {
                            for (int i = 0; i < 8; i++)
                                Animation.WriteAt(@"        ", horGhost, verGhost++);
                            PlayGame.countOfDeadGhosts++;
                            break;
                        }
                    }
                }
            }

        }
        public static void GhostInButhRoom(int horGhost, int verGhost, ref int[] horGhostHitbox, ref int[] verGhostHitbox, int maxHorCoordinate, int minHorCoordinate)
        {
            Thread.Sleep(700);
            int ghostpose = 0;
            while (PlayGame.dethTriger == 0 && buthGhostLive == 1 && PlayGame.roomTrigers == 2)
            {
                if (horGhost == minHorCoordinate)
                {
                    while (horGhost < maxHorCoordinate && PlayGame.dethTriger == 0 && buthGhostLive == 1 && PlayGame.roomTrigers == 2)
                    {
                        Animation.GhostVerMove(horGhost, verGhost, ghostpose);
                        horGhost++;
                        ghostpose++;
                        FindGhostHitBox(horGhost, verGhost, ref horGhostHitbox, ref verGhostHitbox);
                        if (ghostpose == 3)
                            ghostpose = 0;
                        Thread.Sleep(500);
                        if (buthGhostLive == 0)
                        {
                            for (int i = 0; i < 8; i++)
                                Animation.WriteAt(@"        ", horGhost, verGhost++);
                            PlayGame.countOfDeadGhosts++;
                            break;
                        }
                    }
                }
                else if (horGhost > 35 && PlayGame.dethTriger == 0 && buthGhostLive == 1 && PlayGame.roomTrigers == 2)
                {
                    while (horGhost != minHorCoordinate)
                    {
                        Animation.GhostVerMove(horGhost, verGhost, ghostpose);
                        ghostpose++;
                        horGhost--;
                        FindGhostHitBox(horGhost, verGhost, ref horGhostHitbox, ref verGhostHitbox);
                        if (ghostpose == 3)
                            ghostpose = 0;
                        Thread.Sleep(500);
                        if (buthGhostLive == 0)
                        {
                            for (int i = 0; i < 8; i++)
                                Animation.WriteAt(@"        ", horGhost, verGhost++);
                            PlayGame.countOfDeadGhosts++;
                            break;
                        }
                    }
                }
            }

        }
        public static void GhostInBedRoom(int horGhost, int verGhost, ref int[] horGhostHitbox, ref int[] verGhostHitbox, int maxHorCoordinate, int minHorCoordinate)
        {
            Thread.Sleep(500);
            int ghostpose = 0;
            while (PlayGame.dethTriger == 0 && bedGhostLive == 1 && PlayGame.roomTrigers == 3)
            {
                if (horGhost == minHorCoordinate)
                {
                    while (horGhost < maxHorCoordinate && PlayGame.dethTriger == 0 && bedGhostLive == 1 && PlayGame.roomTrigers == 3)
                    {
                        Animation.GhostVerMove(horGhost, verGhost, ghostpose);
                        horGhost++;
                        ghostpose++;
                        FindGhostHitBox(horGhost, verGhost, ref horGhostHitbox, ref verGhostHitbox);
                        if (ghostpose == 3)
                            ghostpose = 0;
                        Thread.Sleep(500);
                        if (bedGhostLive == 0)
                        {
                            int verGhostPlace = verGhost;
                            for (int i = 0; i < 8; i++)
                                Animation.WriteAt(@"        ", horGhost, verGhostPlace++);
                            PlayGame.countOfDeadGhosts++;
                            break;
                        }
                    }
                }
                else if (horGhost > 35 && PlayGame.dethTriger == 0 && bedGhostLive == 1 && PlayGame.roomTrigers == 3)
                {
                    while (horGhost != minHorCoordinate && PlayGame.dethTriger == 0 && bedGhostLive == 1 && PlayGame.roomTrigers == 3)
                    {
                        Animation.GhostVerMove(horGhost, verGhost, ghostpose);
                        ghostpose++;
                        horGhost--;
                        FindGhostHitBox(horGhost, verGhost, ref horGhostHitbox, ref verGhostHitbox);
                        if (ghostpose == 3)
                            ghostpose = 0;
                        Thread.Sleep(500);
                        if (bedGhostLive == 0)
                        {
                            int verGhostPlace = verGhost;;
                            for (int i = 0; i < 8; i++)
                                Animation.WriteAt(@"        ", horGhost, verGhostPlace++);
                            PlayGame.countOfDeadGhosts++;
                            break;
                        }
                    }
                }
            }

        }
    }
}

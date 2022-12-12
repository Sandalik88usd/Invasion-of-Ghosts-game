using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class MoveMent
    {
        public static void LogicMoveMent(int hor, int ver, int pose, ConsoleKey key)
        {
            //if (key == ConsoleKey.RightArrow)
            //{
            //    horPlayer++;
            //    Animation.RunRight(pose, horPlayer, verPlayer, ref PlayGame.playerPosition);
            //    pose++;
            //}
            //else if (key == ConsoleKey.LeftArrow)
            //{
            //    horPlayer--;
            //    Animation.RunLeft(pose, horPlayer, verPlayer, ref PlayGame.playerPosition);
            //    pose++;
            //}
            //else if (key == ConsoleKey.UpArrow)
            //{
            //    verPlayer--;
            //    Animation.RunUp(pose, horPlayer, verPlayer, ref PlayGame.playerPosition);
            //    pose++;
            //}
            //else if (key == ConsoleKey.DownArrow)
            //{
            //    verPlayer++;
            //    Animation.RunUp(pose, horPlayer, verPlayer, ref PlayGame.playerPosition);
            //    pose++;
            //}

            switch (key)
            {
                case ConsoleKey.RightArrow:
                    hor++;
                    Animation.RunRight(pose, hor, ver, ref PlayGame.playerPosition);
                    pose++;
                    break;

                case ConsoleKey.LeftArrow:
                    hor--;
                    Animation.RunLeft(pose, hor, ver, ref PlayGame.playerPosition);
                    pose++;
                    break;

                case ConsoleKey.UpArrow:
                    ver--;
                    Animation.RunUp(pose, hor, ver, ref PlayGame.playerPosition);
                    pose++;
                    break;

                case ConsoleKey.DownArrow:
                    ver++;
                    Animation.RunDown(pose, hor, ver, ref PlayGame.playerPosition);
                    pose++;
                    break;
            }
        }
        public static void PlayerInHallwayAndVerGhost(int horPlayer, int verPlayer,int horGhost, int verGhost)
        {
            Thread threadPlayer = new Thread(() => MoveMentHallway.MoveMentInHallway(horPlayer, verPlayer, ref PlayGame.horGhostHitbox, ref PlayGame.horPlayerHitbox, ref PlayGame.verGhostHitbox, ref PlayGame.gunTriger));
            Thread threadGhostInHallway = new Thread(() => GhostsMove.VerGhostMove(horGhost, verGhost, ref PlayGame.horGhostHitbox, ref PlayGame.verGhostHitbox,40,18));
            if(GhostsMove.firstGhostLive != 0 && PlayGame.roomTrigers == 0)
            threadGhostInHallway.Start();
            Thread.Sleep(200);
            threadPlayer.Start();

        }
        public static void PlayerInKitchenAndVerGhost(int horPlayer, int verPlayer, int horGhost, int verGhost)
        {
            Thread threadPlayer = new Thread(() => MoveMentKitchen.MoveMentInKitchen(horPlayer, verPlayer, ref PlayGame.horGhostHitbox, ref PlayGame.horPlayerHitbox, ref PlayGame.verGhostHitbox, ref PlayGame.gunTriger));
            Thread threadGhostInKitchen= new Thread(() => GhostsMove.GhostInKitchen(horGhost, verGhost, ref PlayGame.horGhostHitbox, ref PlayGame.verGhostHitbox,40,23));
            if (GhostsMove.secondGhostLive != 0 && PlayGame.roomTrigers == 1)
                threadGhostInKitchen.Start();
            Thread.Sleep(200);
            threadPlayer.Start();

        }
    }
}

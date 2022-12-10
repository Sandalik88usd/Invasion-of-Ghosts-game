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
            //    hor++;
            //    Animation.RunRight(pose, hor, ver, ref PlayGame.PlayerPosition);
            //    pose++;
            //}
            //else if (key == ConsoleKey.LeftArrow)
            //{
            //    hor--;
            //    Animation.RunLeft(pose, hor, ver, ref PlayGame.PlayerPosition);
            //    pose++;
            //}
            //else if (key == ConsoleKey.UpArrow)
            //{
            //    ver--;
            //    Animation.RunUp(pose, hor, ver, ref PlayGame.PlayerPosition);
            //    pose++;
            //}
            //else if (key == ConsoleKey.DownArrow)
            //{
            //    ver++;
            //    Animation.RunUp(pose, hor, ver, ref PlayGame.PlayerPosition);
            //    pose++;
            //}

            switch (key)
            {
                case ConsoleKey.RightArrow:
                    hor++;
                    Animation.RunRight(pose, hor, ver, ref PlayGame.PlayerPosition);
                    pose++;
                    break;

                case ConsoleKey.LeftArrow:
                    hor--;
                    Animation.RunLeft(pose, hor, ver, ref PlayGame.PlayerPosition);
                    pose++;
                    break;

                case ConsoleKey.UpArrow:
                    ver--;
                    Animation.RunUp(pose, hor, ver, ref PlayGame.PlayerPosition);
                    pose++;
                    break;

                case ConsoleKey.DownArrow:
                    ver++;
                    Animation.RunDown(pose, hor, ver, ref PlayGame.PlayerPosition);
                    pose++;
                    break;
            }
        }
    }
}

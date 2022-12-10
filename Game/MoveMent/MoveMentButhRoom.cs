using Game.Rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Game
{
    internal class MoveMentButhRoom
    {
        public static void MoveMentInButhRoom(int hor, int ver, /*ref int[] horGhostHitbox, ref int[] horPlayerHitbox, ref int[] verGhostHitbox, ref int trigersInHallway,*/ ref int gunTriger)
        {
            //Animation.MainCharacterFaceOnScreen(57, 17);


            int[] xToilet = new int[81]; int[] yToilet = new int[15];
            int ixToilet = 38; int iyToilet = 7;

            for (int j = 0; j < xToilet.Length; j++)
                xToilet[j] = ixToilet++;
            for (int j = 0; j < yToilet.Length; j++)
                yToilet[j] = iyToilet++;



            int pose = 0;
            SetCursorPosition(hor, ver);
            ConsoleKey key = ReadKey(true).Key;
            int horLong; int verLong;
            while (key != ConsoleKey.Escape)
            {
                key = ReadKey(true).Key;
                if (pose == 3)
                    pose = 0;
                horLong = hor;
                verLong = ver + 6;
                //for (int i = 0; i < horPlayerHitbox.Length; i++)
                //{
                //    horPlayerHitbox[i] = horLong;
                //    horLong++;
                //    for (int j = 0; j < horGhostHitbox.Length; j++)
                //    {
                //        if (horGhostHitbox[j] == horPlayerHitbox[i] && verGhostHitbox[i] == verLong)
                //            GameOver.Deth();
                //    }
                //}

                for (int j = 0; j < yToilet.Length; j++)
                {
                    for (int i = 0; i < xToilet.Length; i++)
                    {
                        if (xToilet[i] + 1 == hor && ver == yToilet[j] + 1)
                            hor++;
                        if (xToilet[i] - 1 == hor && ver == yToilet[j] + 1)
                            hor--;
                        if (xToilet[i] == hor && ver == yToilet[j] + 2)
                            ver++;
                        if (xToilet[i] == hor && ver == yToilet[j])
                            ver--;
                    }
                }

                for (int j = 13; j < 26; j++)
                {
                    if (j == hor && ver == 16 && key == ConsoleKey.Enter)
                    {
                        BedRoom.PaintBedRoom();
                    }
                }
                for (int j = 170; j < 183; j++)
                {
                    if (j == hor && ver == 16 && key == ConsoleKey.Enter)
                    {
                        ButhRoom.PaintButhRoom();
                    }
                }
                if (ver == 16)
                    ver++;
                if (ver == 43)
                    ver--;
                //MoveMent.LogicMoveMent(hor, ver, pose,key);

                switch (key)
                {
                    case ConsoleKey.RightArrow:
                        hor++;
                        if (gunTriger == 0)
                            Animation.RunRight(pose, hor, ver, ref PlayGame.PlayerPosition);
                        else
                            Animation.RunRightWithGun(pose, hor, ver, ref PlayGame.PlayerPosition);
                        pose++;
                        break;

                    case ConsoleKey.LeftArrow:
                        hor--;
                        if (gunTriger == 0)
                            Animation.RunLeft(pose, hor, ver, ref PlayGame.PlayerPosition);
                        else
                            Animation.RunLeftWithGun(pose, hor, ver, ref PlayGame.PlayerPosition);
                        pose++;
                        break;

                    case ConsoleKey.UpArrow:
                        ver--;
                        if (gunTriger == 0)
                            Animation.RunUp(pose, hor, ver, ref PlayGame.PlayerPosition);
                        else
                            Animation.RunUpWithGun(pose, hor, ver, ref PlayGame.PlayerPosition);
                        pose++;
                        break;

                    case ConsoleKey.DownArrow:
                        ver++;
                        if (gunTriger == 0)
                            Animation.RunDown(pose, hor, ver, ref PlayGame.PlayerPosition);
                        else
                            Animation.RunDownWithGun(pose, hor, ver, ref PlayGame.PlayerPosition);
                        pose++;
                        break;
                }
            }
        }
    }
}

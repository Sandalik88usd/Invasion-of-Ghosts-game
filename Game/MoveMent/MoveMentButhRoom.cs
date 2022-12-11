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
            if (PlayGame.gunTriger == 0)
                Animation.MainCharacterFaceOnScreen(hor, ver);
            else
            {
                PlayGame.playerPosition = 4;
                Player.WritePlayerWithGun(hor, ver);
            }


            int[] xToilet = new int[16]; int[] yToilet = new int[12];
            int ixToilet = 4; int iyToilet = 6;
            int[] xSink = new int[45]; int[] ySink = new int[9];
            int ixSink = 61; int iySink = 13;
            int[] xButhWithGhosts = new int[47]; int[] yButhWithGhosts = new int[14];
            int ixButhWithGhosts = 9; int iyButhWithGhosts = 25;
            int[] xShover = new int[35]; int[] yShover = new int[20];
            int ixShover = 139; int iyShover = 23;

            for (int j = 0; j < xToilet.Length; j++)
                xToilet[j] = ixToilet++;
            for (int j = 0; j < yToilet.Length; j++)
                yToilet[j] = iyToilet++;

            for (int j = 0; j < xSink.Length; j++)
                xSink[j] = ixSink++;
            for (int j = 0; j < ySink.Length; j++)
                ySink[j] = iySink++;

            for (int j = 0; j < xButhWithGhosts.Length; j++)
                xButhWithGhosts[j] = ixButhWithGhosts++;
            for (int j = 0; j < yButhWithGhosts.Length; j++)
                yButhWithGhosts[j] = iyButhWithGhosts++;

            for (int j = 0; j < xShover.Length; j++)
                xShover[j] = ixShover++;
            for (int j = 0; j < yShover.Length; j++)
                yShover[j] = iyShover++;



            int pose = 0;
            SetCursorPosition(hor, ver);
            ConsoleKey key = ReadKey(true).Key;
            int horLong; int verLong;
            while (key != ConsoleKey.Escape && PlayGame.dethTriger == 0 && PlayGame.roomTrigers == 2)
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
                for (int j = 0; j < ySink.Length; j++)
                {
                    for (int i = 0; i < xSink.Length; i++)
                    {
                        if (xSink[i] + 1 == hor && ver == ySink[j] + 1)
                            hor++;
                        if (xSink[i] - 1 == hor && ver == ySink[j] + 1)
                            hor--;
                        if (xSink[i] == hor && ver == ySink[j] + 2)
                            ver++;
                        if (xSink[i] == hor && ver == ySink[j])
                            ver--;
                    }
                }
                for (int j = 0; j < yButhWithGhosts.Length; j++)
                {
                    for (int i = 0; i < xButhWithGhosts.Length; i++)
                    {
                        if (xButhWithGhosts[i] + 1 == hor && ver == yButhWithGhosts[j] + 1)
                            hor++;
                        if (xButhWithGhosts[i] - 1 == hor && ver == yButhWithGhosts[j] + 1)
                            hor--;
                        if (xButhWithGhosts[i] == hor && ver == yButhWithGhosts[j] + 2)
                            ver++;
                        if (xButhWithGhosts[i] == hor && ver == yButhWithGhosts[j])
                            ver--;
                    }
                }
                for (int j = 0; j < yShover.Length; j++)
                {
                    for (int i = 0; i < xShover.Length; i++)
                    {
                        if (xShover[i] + 1 == hor && ver == yShover[j] + 1)
                            hor++;
                        if (xShover[i] - 1 == hor && ver == yShover[j] + 1)
                            hor--;
                        if (xShover[i] == hor && ver == yShover[j] + 2)
                            ver++;
                        if (xShover[i] == hor && ver == yShover[j])
                            ver--;
                    }
                }

                for (int j = 170; j < 183; j++)
                {
                    if (j == hor && ver == 16 && key == ConsoleKey.Enter)
                    {
                        PlayGame.roomTrigers = 1;
                        Kitchen.KitchenRoom();
                        MoveMentKithen.MoveMentInKitchen(hor, ver, ref gunTriger);
                    }
                }
                if (ver == 16)
                    ver++;
                if (ver == 43)
                    ver--;
                if (hor == 1)
                    hor++;
                if (hor == 196)
                    hor--;
                //MoveMent.LogicMoveMent(hor, ver, pose,key);

                switch (key)
                {
                    case ConsoleKey.RightArrow:
                        hor++;
                        if (gunTriger == 0)
                            Animation.RunRight(pose, hor, ver, ref PlayGame.playerPosition);
                        else
                            Animation.RunRightWithGun(pose, hor, ver, ref PlayGame.playerPosition);
                        pose++;
                        break;

                    case ConsoleKey.LeftArrow:
                        hor--;
                        if (gunTriger == 0)
                            Animation.RunLeft(pose, hor, ver, ref PlayGame.playerPosition);
                        else
                            Animation.RunLeftWithGun(pose, hor, ver, ref PlayGame.playerPosition);
                        pose++;
                        break;

                    case ConsoleKey.UpArrow:
                        ver--;
                        if (gunTriger == 0)
                            Animation.RunUp(pose, hor, ver, ref PlayGame.playerPosition);
                        else
                            Animation.RunUpWithGun(pose, hor, ver, ref PlayGame.playerPosition);
                        pose++;
                        break;

                    case ConsoleKey.DownArrow:
                        ver++;
                        if (gunTriger == 0)
                            Animation.RunDown(pose, hor, ver, ref PlayGame.playerPosition);
                        else
                            Animation.RunDownWithGun(pose, hor, ver, ref PlayGame.playerPosition);
                        pose++;
                        break;
                }
            }
        }
    }
}

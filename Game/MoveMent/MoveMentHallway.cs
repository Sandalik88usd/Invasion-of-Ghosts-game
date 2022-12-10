using Game.Do;
using Game.Rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Game
{
    internal class MoveMentHallway
    {
        public static void MoveMentInHallway(int hor, int ver, ref int[] horGhostHitbox, ref int[] horPlayerHitbox, ref int[] verGhostHitbox, ref int trigersInHallway, ref int gunTriger )
        {
            //Animation.MainCharacterFaceOnScreen(57, 17);

            //int[] xSofa = new int[52]; int[] ySofa = new int[15];
            //int ixSofa = 76; int iySofa = 20;
            //int[] xTorchere = new int[23]; int[] yTorchere = new int[16];
            //int ixTorchere = 64; int iyTorchere = 20;
            //int[] xSmallTV = new int[25]; int[] ySmallTV = new int[16];
            //int ixSmallTV = 89; int iySmallTV = 31;
            //int[] xBookshelf = new int[29]; int[] yBookshelf = new int[33];
            //int ixBookshelf = 5; int iyBookshelf = 10;
            //int[] xAquarium = new int[34]; int[] yAquarium = new int[32];
            //int ixAquarium = 162; int iyAquarium = 15;
            int[] xSofa = new int[55]; int[] ySofa = new int[15];
            int ixSofa = 73; int iySofa = 20;
            int[] xTorchere = new int[26]; int[] yTorchere = new int[16];
            int ixTorchere = 61; int iyTorchere = 20;
            int[] xSmallTV = new int[28]; int[] ySmallTV = new int[16];
            int ixSmallTV = 86; int iySmallTV = 31;
            int[] xBookshelf = new int[32]; int[] yBookshelf = new int[33];
            int ixBookshelf = 8; int iyBookshelf = 10;
            int[] xAquarium = new int[37]; int[] yAquarium = new int[32];
            int ixAquarium = 159; int iyAquarium = 15;

            for (int j = 0; j < xSofa.Length; j++)
                xSofa[j] = ixSofa++;
            for (int j = 0; j < ySofa.Length; j++)
                ySofa[j] = iySofa++;

            for (int j = 0; j < xTorchere.Length; j++)
                xTorchere[j] = ixTorchere++;
            for (int j = 0; j < yTorchere.Length; j++)
                yTorchere[j] = iyTorchere++;

            for (int j = 0; j < xSmallTV.Length; j++)
                xSmallTV[j] = ixSmallTV++;
            for (int j = 0; j < ySmallTV.Length; j++)
                ySmallTV[j] = iySmallTV++;

            for (int j = 0; j < xBookshelf.Length; j++)
                xBookshelf[j] = ixBookshelf++;
            for (int j = 0; j < yBookshelf.Length; j++)
                yBookshelf[j] = iyBookshelf++;

            for (int j = 0; j < xAquarium.Length; j++)
                xAquarium[j] = ixAquarium++;
            for (int j = 0; j < yAquarium.Length; j++)
                yAquarium[j] = iyAquarium++;

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
                for (int i = 0; i < horPlayerHitbox.Length; i++)
                {
                    horPlayerHitbox[i] = horLong;
                    horLong++;
                    for (int j = 0; j < horGhostHitbox.Length; j++)
                    {
                        if (horGhostHitbox[j] == horPlayerHitbox[i] && verGhostHitbox[i] == verLong)
                            GameOver.Deth();
                    }
                }

                for (int j = 0; j < ySofa.Length; j++)
                {
                    for (int i = 0; i < xSofa.Length; i++)
                    {
                        if (xSofa[i] + 1 == hor && ver == ySofa[j] + 1)
                            hor++;
                        if (xSofa[i] - 1 == hor && ver == ySofa[j] + 1)
                            hor--;
                        if (xSofa[i] == hor && ver == ySofa[j] + 2)
                            ver++;
                        if (xSofa[i] == hor && ver == ySofa[j])
                            ver--;
                    }
                }
                for (int j = 0; j < yTorchere.Length; j++)
                {
                    for (int i = 0; i < xTorchere.Length; i++)
                    {
                        if (xTorchere[i] + 1 == hor && ver == yTorchere[j] + 1)
                            hor++;
                        if (xTorchere[i] - 1 == hor && ver == yTorchere[j] + 1)
                            hor--;
                        if (xTorchere[i] == hor && ver == yTorchere[j] + 2)
                            ver++;
                        if (xTorchere[i] == hor && ver == yTorchere[j])
                            ver--;
                    }
                }
                for (int j = 0; j < ySmallTV.Length; j++)
                {
                    for (int i = 0; i < xSmallTV.Length; i++)
                    {
                        if (xSmallTV[i] + 1 == hor && ver == ySmallTV[j] + 1)
                            hor++;
                        if (xSmallTV[i] - 1 == hor && ver == ySmallTV[j] + 1)
                            hor--;
                        if (xSmallTV[i] == hor && ver == ySmallTV[j] + 2)
                            ver++;
                        if (xSmallTV[i] == hor && ver == ySmallTV[j])
                            ver--;
                    }
                }
                for (int j = 0; j < yBookshelf.Length; j++)
                {
                    for (int i = 0; i < xBookshelf.Length; i++)
                    {
                        if (xBookshelf[i] + 1 == hor && ver == yBookshelf[j] + 1)
                            hor++;
                    }
                }
                for (int j = 0; j < yBookshelf.Length; j++)
                {
                    for (int i = 0; i < xAquarium.Length; i++)
                    {
                        if (xAquarium[i] - 1 == hor && ver == yAquarium[j] + 1)
                            hor--;
                    }
                }
                for (int j = 140; j < 153; j++)
                {
                    if (j == hor && ver == 16 && key == ConsoleKey.Enter)
                    {
                        Kitchen.KitchenRoom();
                        MoveMentKithen.MoveMentInKitchen(hor,ver,ref gunTriger);
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
                        if(gunTriger==0)
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

using Game.Rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks;
using static System.Console;

namespace Game
{
    internal class MoveMentBedRoom
    {
        public static void MoveMentInBedRoom(int hor, int ver, /*ref int[] horGhostHitbox, ref int[] horPlayerHitbox, ref int[] verGhostHitbox, ref int trigersInHallway,*/ ref int gunTriger)
        {
            if (PlayGame.gunTriger == 0)
                Animation.MainCharacterFaceOnScreen(hor, ver);
            else
            {
                PlayGame.playerPosition = 4;
                Player.WritePlayerWithGun(hor, ver);
            }


            int[] xSofaChair = new int[22]; int[] ySofaChair = new int[12];
            int ixSofaChair = 149; int iySofaChair = 15;
            int[] xPlazmaTV = new int[22]; int[] yPlazmaTV = new int[13];
            int ixPlazmaTV = 149; int iyPlazmaTV = 29;
            int[] xFirstBedTable = new int[26]; int[] yFirstBedTable = new int[14];
            int ixFirstBedTable = 57; int iyFirstBedTable = 30;
            int[] xSecondBedTable = new int[20]; int[] ySecondBedTable = new int[10];
            int ixSecondBedTable = 115; int iySecondBedTable = 32;
            int[] xBed = new int[31]; int[] yBed = new int[10];
            int ixBed = 86; int iyBed = 32;
            int[] xClothesShelfBack = new int[40]; int[] yClothesShelfBack = new int[22];
            int ixClothesShelfBack = 2; int iyClothesShelfBack = 21;

            for (int j = 0; j < xSofaChair.Length; j++)
                xSofaChair[j] = ixSofaChair++;
            for (int j = 0; j < ySofaChair.Length; j++)
                ySofaChair[j] = iySofaChair++;

            for (int j = 0; j < xPlazmaTV.Length; j++)
                xPlazmaTV[j] = ixPlazmaTV++;
            for (int j = 0; j < yPlazmaTV.Length; j++)
                yPlazmaTV[j] = iyPlazmaTV++;

            for (int j = 0; j < xFirstBedTable.Length; j++)
                xFirstBedTable[j] = ixFirstBedTable++;
            for (int j = 0; j < yFirstBedTable.Length; j++)
                yFirstBedTable[j] = iyFirstBedTable++;

            for (int j = 0; j < xSecondBedTable.Length; j++)
                xSecondBedTable[j] = ixSecondBedTable++;
            for (int j = 0; j < ySecondBedTable.Length; j++)
                ySecondBedTable[j] = iySecondBedTable++;

            for (int j = 0; j < xBed.Length; j++)
                xBed[j] = ixBed++;
            for (int j = 0; j < yBed.Length; j++)
                yBed[j] = iyBed++;

            for (int j = 0; j < xClothesShelfBack.Length; j++)
                xClothesShelfBack[j] = ixClothesShelfBack++;
            for (int j = 0; j < yClothesShelfBack.Length; j++)
                yClothesShelfBack[j] = iyClothesShelfBack++;


            int pose = 0;
            SetCursorPosition(hor, ver);
            ConsoleKey key = ReadKey(true).Key;
            int horLong; int verLong;
            while (key != ConsoleKey.Escape && PlayGame.dethTriger == 0 && PlayGame.roomTrigers == 3)
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

                for (int j = 0; j < ySofaChair.Length; j++)
                {
                    for (int i = 0; i < xSofaChair.Length; i++)
                    {
                        //if (xSofaChair[i] + 1 == hor && ver == ySofaChair[j] + 1)
                        //    hor++;
                        if (xSofaChair[i] - 1 == hor && ver == ySofaChair[j] + 1)
                            hor--;
                        //if (xSofaChair[i] == hor && ver == ySofaChair[j] + 2)
                        //    ver++;
                        //if (xSofaChair[i] == hor && ver == ySofaChair[j])
                        //    ver--;
                    }
                }
                for (int j = 0; j < yPlazmaTV.Length; j++)
                {
                    for (int i = 0; i < xPlazmaTV.Length; i++)
                    {
                        if (xPlazmaTV[i] + 1 == hor && ver == yPlazmaTV[j] + 1)
                            hor++;
                        if (xPlazmaTV[i] - 1 == hor && ver == yPlazmaTV[j] + 1)
                            hor--;
                        if (xPlazmaTV[i] == hor && ver == yPlazmaTV[j] + 2)
                            ver++;
                        if (xPlazmaTV[i] == hor && ver == yPlazmaTV[j])
                            ver--;
                    }
                }
                for (int j = 0; j < yFirstBedTable.Length; j++)
                {
                    for (int i = 0; i < xFirstBedTable.Length; i++)
                    {
                        if (xFirstBedTable[i] + 1 == hor && ver == yFirstBedTable[j] + 1)
                            hor++;
                        if (xFirstBedTable[i] - 1 == hor && ver == yFirstBedTable[j] + 1)
                            hor--;
                        if (xFirstBedTable[i] == hor && ver == yFirstBedTable[j] + 2)
                            ver++;
                        if (xFirstBedTable[i] == hor && ver == yFirstBedTable[j])
                            ver--;
                    }
                }
                for (int j = 0; j < ySecondBedTable.Length; j++)
                {
                    for (int i = 0; i < xSecondBedTable.Length; i++)
                    {
                        if (xSecondBedTable[i] + 1 == hor && ver == ySecondBedTable[j] + 1)
                            hor++;
                        if (xSecondBedTable[i] - 1 == hor && ver == ySecondBedTable[j] + 1)
                            hor--;
                        if (xSecondBedTable[i] == hor && ver == ySecondBedTable[j] + 2)
                            ver++;
                        if (xSecondBedTable[i] == hor && ver == ySecondBedTable[j])
                            ver--;
                    }
                }
                for (int j = 0; j < yBed.Length; j++)
                {
                    for (int i = 0; i < xBed.Length; i++)
                    {
                        if (xBed[i] + 1 == hor && ver == yBed[j] + 1)
                            hor++;
                        if (xBed[i] - 1 == hor && ver == yBed[j] + 1)
                            hor--;
                        if (xBed[i] == hor && ver == yBed[j] + 2)
                            ver++;
                        if (xBed[i] == hor && ver == yBed[j])
                            ver--;
                    }
                }
                for (int j = 0; j < yClothesShelfBack.Length; j++)
                {
                    for (int i = 0; i < xClothesShelfBack.Length; i++)
                    {
                        if (xClothesShelfBack[i] + 1 == hor && ver == yClothesShelfBack[j] + 1)
                            hor++;
                        if (xClothesShelfBack[i] - 1 == hor && ver == yClothesShelfBack[j] + 1)
                            hor--;
                        if (xClothesShelfBack[i] == hor && ver == yClothesShelfBack[j] + 2)
                            ver++;
                        if (xClothesShelfBack[i] == hor && ver == yClothesShelfBack[j])
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

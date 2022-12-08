using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Game
{
    internal class MoveMent
    {
        public static void LogicMoveMent(int hor,  int ver)
        {
            int pose = 0;
            Console.SetCursorPosition(hor, ver);
            ConsoleKey key = Console.ReadKey(true).Key;

            while (key != ConsoleKey.Enter)
            {
                key = Console.ReadKey(true).Key;
                if (pose == 3)
                    pose = 0;
                switch (key)
                    {
                        case ConsoleKey.RightArrow:
                            hor++;
                            Animation.RunRight(pose, hor, ver);
                            pose++;
                            //if (pose == 3)
                            //    pose = 0;
                            break;

                        case ConsoleKey.LeftArrow:
                            hor--;
                            Animation.RunLeft(pose, hor, ver);
                            pose++;
                            //if (pose == 3)
                            //    pose = 0;
                            break;

                        case ConsoleKey.UpArrow:
                            ver--;
                            Animation.RunUp(pose, hor, ver);
                            pose++;
                            //if (pose == 3)
                            //    pose = 0;
                            break;

                        case ConsoleKey.DownArrow:
                            ver++;
                            Animation.RunDown(pose, hor, ver);
                            pose++;
                            //if (pose == 3)
                            //    pose = 0;
                            break;
                    }
            }
        }
        public static void MoveMentHallway(int hor, int ver, ref int[] horGhostHitbox, ref int[] horPlayerHitbox, ref int[] verGhostHitbox)
        {
            int[] xSofa = new int[52]; int[] ySofa = new int[15];
            int ixSofa = 76; int iySofa = 20;
            int[] xTorchere = new int[23]; int[] yTorchere = new int[16];
            int ixTorchere = 64; int iyTorchere = 20;
            int[] xSmallTV = new int[25]; int[] ySmallTV = new int[16];
            int ixSmallTV = 89; int iySmallTV = 31;
            int[] xBookshelf = new int[29]; int[] yBookshelf = new int[33];
            int ixBookshelf = 5; int iyBookshelf = 10;
            int[] xAquarium = new int[34]; int[] yAquarium = new int[32];
            int ixAquarium = 162; int iyAquarium = 15;

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
            Console.SetCursorPosition(hor, ver);
            ConsoleKey key = Console.ReadKey(true).Key;
            int horLong; int verLong;
            while (key != ConsoleKey.Enter)
            {
                key = Console.ReadKey(true).Key;
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
                        //if (xBookshelf[i] + 1 == hor && ver == yBookshelf[j] + 1)
                        //    hor++;
                        if (xAquarium[i] - 1 == hor && ver == yAquarium[j] + 1)
                            hor--;
                        //if (xBookshelf[i] == hor && ver == yBookshelf[j] + 2)
                        //    ver++;
                        //if (xBookshelf[i] == hor && ver == yBookshelf[j])
                        //    ver--;
                    }
                }
                if (ver == 16)
                    ver++;
                if (ver == 43)
                    ver--;

                switch (key)
                {
                    case ConsoleKey.RightArrow:
                        hor++;
                        Animation.RunRight(pose, hor, ver);
                        pose++;
                        break;

                    case ConsoleKey.LeftArrow:
                        hor--;
                        Animation.RunLeft(pose, hor, ver);
                        pose++;
                        break;

                    case ConsoleKey.UpArrow:
                        ver--;
                        Animation.RunUp(pose, hor, ver);
                        pose++;
                        break;

                    case ConsoleKey.DownArrow:
                        ver++;
                        Animation.RunDown(pose, hor, ver);
                        pose++;
                        break;
                }
            }
        }
        public static void MoveMentWorkRoom(int hor, int ver, ref int trigers)
        {
            Animation.MainCharacterFaceOnScreen(hor, ver);
            ConsoleKey key = Console.ReadKey(true).Key;
            int[] xComputers = new int[68]; int[] yComputers = new int[18];
            int ixComputers = 17; int iyComputers = 19;
            int[] xChairs = new int[68];
            int[] xChairsSecond = new int[68];
            int[] yChairsSecond = new int[18];
            int[] xBigTable = new int[23]; int ixBigTable = 164;
            int[] xLongTable = new int[36]; int ixLongTable = 157; 
            int[] yLongTable = new int[13]; int iyLongTable = 26;
            int ixChairs = 19; int ixChairsSecond = 28; int iyCohairsSecond = 30;

            for (int j = 0; j < xLongTable.Length; j++)
                xLongTable[j] = ixLongTable++;
            for (int j = 0; j < yLongTable.Length; j++)
                yLongTable[j] = iyLongTable++;
            for (int j = 0; j < xBigTable.Length; j++)
                xBigTable[j] = ixBigTable++;
            for (int j = 0; j < xChairsSecond.Length; j++)
            {
                xChairsSecond[j] = ixChairsSecond++;
                if (j == 16 || j == 33 || j == 50)
                    ixChairsSecond += 13;
            }
            for (int j = 0; j < yChairsSecond.Length; j++)
                yChairsSecond[j] = iyCohairsSecond++;

            for (int j = 0; j < xComputers.Length; j++)
            { 
                xComputers[j] = ixComputers++;
                if (j == 16 || j == 33 || j == 50)
                   ixComputers += 13;
            }
            for(int j = 0; j < yComputers.Length; j++)
                yComputers[j] = iyComputers++;

            for (int j = 0; j < xChairs.Length; j++)
            {
                xChairs[j] = ixChairs++;
                if (j == 14 || j == 33 || j == 50)
                    ixChairs += 13;
            }
            int pose = 0;
            Console.SetCursorPosition(hor, ver);
            key = Console.ReadKey(true).Key;

                while (key != ConsoleKey.Escape)
                {
                    key = Console.ReadKey(true).Key;
                    for (int j = 0; j < yLongTable.Length; j++)
                    {
                        for (int i = 0; i < xLongTable.Length; i++)
                        {
                            if (xLongTable[i] - 1 == hor && ver == yLongTable[j] - 1 && key == ConsoleKey.Enter && trigers == 0)
                            {
                                CallToBoss.CallToBooss();
                                WorkRoom.PaintWorkRoom();
                                Thread.Sleep(500);
                                Animation.WriteAt("Go to the scaner and press Enter.", 95, 2);
                                trigers = 1;
                                MoveMentWorkRoom(hor, ver, ref trigers);
                            }
                            
                        }
                    }

                    for (int j = 0; j < xBigTable.Length; j++)
                    {
                        if (xBigTable[j] == hor && ver == 17 && key == ConsoleKey.Enter && trigers == 1)
                        {
                            trigers = 2;
                            Scaner.ScanerWork();
                            Animation.WriteAt("Press Enter to look at the papers.", 95, 2);
                            key = Console.ReadKey(true).Key;
                            if (key == ConsoleKey.Enter)
                                Scaner.LookAtThePAperInScaner();
                            WorkRoom.PaintWorkRoom();
                            Animation.WriteAt("Come back to the phone and call back to the Boss.", 89, 2);
                            MoveMentWorkRoom(hor, ver, ref trigers);
                            Animation.MainCharacterFaceOnScreen(hor, ver);
                        }
                    }

                    for (int j = 0; j < yLongTable.Length; j++)
                    {
                        for (int i = 0; i < xLongTable.Length; i++)
                        {
                            if (xLongTable[i] - 1 == hor && ver == yLongTable[j] - 1 && key == ConsoleKey.Enter && trigers == 2)
                            {
                                trigers = 3;
                                CallToBoss.SecondCallToBooss();
                                WorkRoom.PaintWorkRoom();
                                Thread.Sleep(500);
                                Animation.WriteAt("Go to the door and press Enter to go home.", 90, 2);
                                MoveMentWorkRoom(hor, ver, ref trigers);
                                Animation.MainCharacterFaceOnScreen(hor, ver);
                            }

                        }
                    }

                    for (int j = 109; j < 122; j++)
                    {
                        if (j == hor && ver == 16 && key == ConsoleKey.Enter && trigers == 3)
                        {
                            WayToHome.WindowOfWayToHome();
                        }
                    }

                for (int j = 0; j < yLongTable.Length; j++)
                {
                    for (int i = 0; i < xLongTable.Length; i++)
                    {
                        if (xLongTable[i] + 1 == hor && ver == yLongTable[j] + 1)
                            hor++;
                        if (xLongTable[i] - 1 == hor && ver == yLongTable[j] + 1)
                            hor--;
                        if (xLongTable[i] == hor && ver == yLongTable[j] + 2)
                            ver++;
                        if (xLongTable[i] == hor && ver == yLongTable[j])
                            ver--;
                    }
                }

                for (int i = 0; i < xComputers.Length; i++)
                    {
                        if (xComputers[i] == hor && ver == 18 || ver == 43 || xChairsSecond[i] == hor && ver == 29)
                            ver--;
                    }

                    for (int j = 0; j < yComputers.Length; j++)
                    {
                        for (int i = 0; i < xComputers.Length; i++)
                        {
                            if (xComputers[i] -1 == hor && ver == yComputers[j] || xChairsSecond[i] - 2 == hor && ver == yChairsSecond[j] || hor == 199)
                                hor--;
                        }
                    }

                    for (int j = 0; j < yComputers.Length-1; j++)
                    {
                        for (int i = 0; i < xComputers.Length; i++)
                        {
                            if (xComputers[i]+1 == hor && ver == yComputers[j] || xChairsSecond[i] == hor && ver == yChairsSecond[j] || hor == 1)
                                hor++;
                        }
                    }

                    for (int j = 0; j < xChairs.Length; j++)
                    {
                        if (xChairs[j] == hor && ver == 36 || ver == 16)
                            ver++;
                    }
                    for(int j = 0; j < xBigTable.Length; j++)
                    {
                        if (xBigTable[j] == hor && ver == 17)
                            ver++;
                    }
                    for (int j = 0; j < xBigTable.Length; j++)
                    {
                        if (xBigTable[j] == hor && ver == 17)
                            hor--;
                    }
                    if (pose == 3)
                        pose = 0;
                    switch (key)
                    {
                        case ConsoleKey.RightArrow:
                            hor++;
                            Animation.RunRight(pose, hor, ver);
                            pose++;
                            break;

                        case ConsoleKey.LeftArrow:
                            hor--;
                            Animation.RunLeft(pose, hor, ver);
                            pose++;
                            break;

                        case ConsoleKey.UpArrow:
                            ver--;
                            Animation.RunUp(pose, hor, ver);
                            pose++;
                            break;

                        case ConsoleKey.DownArrow:
                            ver++;
                            Animation.RunDown(pose, hor, ver);
                            pose++;
                            break;
                    }
                }
        }
    }

}


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
        public static void MoveMentWorkRoom(int hor, int ver, ref int trigers)
        {
            Animation.MainCharacterFaceOnScreen(hor, ver);
            ConsoleKey key = Console.ReadKey(true).Key;
            int[] xComputers = new int[68];
            int[] yComputers = new int[18];
            int[] xChairs = new int[68];
            int[] xChairsSecond = new int[68];
            int[] yChairsSecond = new int[18];
            int[] xBigTable = new int[23]; int ixBigTable = 164;
            int[] xLongTable = new int[36]; int ixLongTable = 157; 
            int[] yLongTable = new int[13]; int iyLongTable = 26;
            int ixComputers = 17; int iyComputers = 19;
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


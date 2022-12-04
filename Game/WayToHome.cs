using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Game
{
    internal class WayToHome
    {
        public static void WindowOfWayToHome()
        {
            Clear();
            CursorVisible = false;
            WindowWidth = 210;
            BufferWidth = 270;
            WindowHeight = 50;
            BufferHeight = 50;
            FrameOfRoom();
            ChooseCoordinateOfGras(ref xGrasOnTop, ref yGrasOnTop, ref xGrasOnBot, ref yGrasOnBot);
            Environment();
            CarAndGhostMove();
        }
        public static void FrameOfRoom()
        {
            for (int i = 0; i < 209; i++)
            {
                SetCursorPosition(i, 0);
                WriteLine("─");
                SetCursorPosition(i, 15);
                WriteLine("-");
                Animation.WriteAt("_", i, 30);
                Animation.WriteAt("-", i, 31);
                Animation.WriteAt("_", i, 41);
                SetCursorPosition(i, 48);
                WriteLine("─");
            }
            for (int i = 0; i < 49; i++)
            {
                SetCursorPosition(0, i);
                WriteLine("│");
                SetCursorPosition(208, i);
                WriteLine("│");
            }
            Animation.WriteAt("┌", 0, 0);
            Animation.WriteAt("┐", 208, 0);
            Animation.WriteAt("┘", 208, 48);
            Animation.WriteAt("└", 0, 48);
        }
        static void Environment()
        {
            for (int i = 4; i < 190; i += 48)
                Painter.Clouds(i, 1);
            Grasses(xGrasOnTop, yGrasOnTop, xGrasOnBot, yGrasOnBot);
            Painter.Tree(6,14);
            Painter.SmallTree(36,18);
            Painter.Bush(70,23);
            Painter.SmallTree(115, 21);
            Painter.Tree(180, 15);
            Painter.Bush(150, 13);
        }
        static int[] xGrasOnTop = new int[20];
        static int[] yGrasOnTop = new int[20];
        static int[] xGrasOnBot = new int[30];
        static int[] yGrasOnBot = new int[30];
        static void Grasses(int[] xGrasOnTop, int[] yGrasOnTop, int[] xGrasOnBot, int[] yGrasOnBot)
        {
            Random random = new Random();
            for (int i = 0; i < 20; i++)
                Painter.Grass(xGrasOnTop[i], yGrasOnTop[i]);
            //for (int i = 0; i < 5; i++)
            //    Painter.Flower(random.Next(2, 207), random.Next(16, 27));
            for (int i = 0; i < 30; i++)
                Painter.Grass(xGrasOnBot[i], yGrasOnBot[i]);
        }
        static int[] ChooseCoordinateOfGras(ref int[] xGrasOnTop, ref int[] yGrasOnTop, ref int[] xGrasOnBot, ref int[] yGrasOnBot)
        {
            Random random = new Random();
            for (int i = 0; i < 20; i++)
            {
                xGrasOnTop[i] = random.Next(2, 206);
                yGrasOnTop[i] = random.Next(16, 29);
            }
            for (int i = 0; i < 30; i++)
            {
                xGrasOnBot[i] = random.Next(2, 207);
                yGrasOnBot[i] = random.Next(42, 47);
            }
            return xGrasOnTop;
        }

        static void CarAndGhostMove()
        {
            int xCar = 2; int yCar = 32;
            int xGhost = 180; int yGhost = 17;
            int j = 1;
            while (xCar < 180)
            {
                for (int i = 1; i < 4; i++)
                {
                    Painter.Car(xCar, yCar, i);
                    Painter.Ghost(xGhost, yGhost, j);
                    j++;
                    xCar++;
                    xGhost--;
                    Thread.Sleep(50);
                    if (j == 3)
                        j = 1;
                    Environment();
                }
            }
            Hallway.HallwayRoom();
        }

        //static void CarMove()
        //{
        //    int x = 2; int y = 31;
        //    while (x < 190)
        //    {
        //        for (int i = 1; i < 4; i++)
        //        {
        //            Painter.Car(x, y, i);
        //            x++;
        //            Thread.Sleep(100);
        //        }
        //    }
        //}
        //static void GhostMove()
        //{
        //    int x = 190; int y = 20;
        //    while (x > 2)
        //    {
        //        for (int i = 1; i < 3; i++)
        //        {
        //            Painter.Ghost(x, y, i);
        //            x--;
        //            Thread.Sleep(100);
        //        }
        //    }

    }
}


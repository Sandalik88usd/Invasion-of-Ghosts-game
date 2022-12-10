using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Game.Rooms
{
    internal class WorkRoom
    {
        public static void FrameOfWorkRoom()
        {
            for (int i = 0; i < 209; i++)
            {
                SetCursorPosition(i, 0);
                WriteLine("-");
                SetCursorPosition(i, 15);
                WriteLine("=");
                SetCursorPosition(i, 48);
                WriteLine("-");
            }
            for (int i = 0; i < 49; i++)
            {
                SetCursorPosition(0, i);
                WriteLine("|");
                SetCursorPosition(208, i);
                WriteLine("|");
            }
        }
        public static void PaintWorkRoom()
        {
            Clear();
            CursorVisible = false;
            WindowWidth = 210;
            BufferWidth = 210;
            WindowHeight = 50;
            BufferHeight = 50;
            FrameOfWorkRoom();
            for (int i = 25; i <= 140; i += 30)
            {
                Animation.WriteAt("|------|", i, 27);
                Animation.WriteAt("|  --  |", i, 28);
                Animation.WriteAt("|------|", i, 29);

                Animation.WriteAt("  ____", i, 23);
                Animation.WriteAt(@" ||""""||", i, 24);
                Animation.WriteAt(" ||__||", i, 25);
                Animation.WriteAt(" [ -=.]`)", i, 26);

                Animation.WriteAt("  ___  ", i, 30);
                Animation.WriteAt(" |___|  ", i, 31);
                Animation.WriteAt(" |_ _| ", i, 32);
                Animation.WriteAt("   ║   ", i, 33);
                Animation.WriteAt(" |=║=| ", i, 34);
                Animation.WriteAt("  | |  ", i, 35);

                Animation.WriteAt(" |------|", i + 10, 44);
                Animation.WriteAt(" |______|", i + 10, 45);
                Animation.WriteAt(" |      |", i + 10, 46);

                Animation.WriteAt("   ____", i + 10, 40);
                Animation.WriteAt("  |    |", i + 10, 41);
                Animation.WriteAt("  |[--]|", i + 10, 42);
                Animation.WriteAt("('[____]", i + 10, 43);


                Animation.WriteAt("  ___  ", i + 10, 34);
                Animation.WriteAt(" |___|  ", i + 10, 35);
                Animation.WriteAt(" |_ _| ", i + 10, 36);
                Animation.WriteAt("   ║   ", i + 10, 37);
                Animation.WriteAt(" |===| ", i + 10, 38);
                Animation.WriteAt("  |'|  ", i + 10, 39);

            }
            for (int i = 0; i < 209; i++)
                Animation.WriteAt("=", i, 15);

            Painter.BigTable(171, 13);
            Painter.Scanner(174, 9, 1);
            Painter.PictureFrame(40, 3, 10);
            Painter.PictureInFrame(40, 3);
            Painter.Cactus(80, 3);
            Painter.Door(110, 6);
            Painter.Clock(140, 1, 1);
            Painter.LongTable(165, 35);
            Painter.Telephone(169, 36);
        }

    }
}

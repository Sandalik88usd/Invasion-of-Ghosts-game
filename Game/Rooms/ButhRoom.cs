using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Game.Rooms
{
    internal class ButhRoom
    {
        public static void PaintButhRoom()
        {
            Clear();
            CursorVisible = false;
            WindowWidth = 210;
            BufferWidth = 210;
            WindowHeight = 50;
            BufferHeight = 50;
            FrameOfButhRoom();
            Tile();
            Painter.DoorWC(170, 6);
            Painter.Towel(120, 8);
            Painter.Toilet(10, 6);
            Painter.ToiletPaper(28, 8);
            Painter.Rakovina(71, 13);
            Painter.ButhMiror(73, 1);
            Painter.ButhWithGhosts(20, 30);
            Painter.Shover(150, 29);
        }
        static void Tile()
        {
            for (int j = 1; j < 15; j += 4)
            {
                for (int i = 1; i < 208; i++)
                {
                    SetCursorPosition(i, j);
                    WriteLine("─");
                }
            }
            for (int j = 1; j < 15; j++)
            {
                for (int i = 0; i < 208; i += 8)
                {
                    SetCursorPosition(i, j);
                    WriteLine("│");
                }
            }
        }
        static void FrameOfButhRoom()
        {
            for (int i = 0; i < 209; i++)
            {
                SetCursorPosition(i, 0);
                WriteLine("─");
                SetCursorPosition(i, 15);
                WriteLine("─");
                SetCursorPosition(i, 48);
                WriteLine("─");
            }

            for (int i = 0; i < 208; i += 8)
            {
                SetCursorPosition(i, 15);
                WriteLine("┴");
            }
            for (int i = 0; i < 208; i += 8)
            {
                SetCursorPosition(i, 0);
                WriteLine("┬");
            }
            for (int i = 0; i < 49; i++)
            {
                SetCursorPosition(0, i);
                WriteLine("│");
                SetCursorPosition(208, i);
                WriteLine("│");
            }
            Animation.WriteAt("┌", 0, 0);
            Animation.WriteAt("└", 0, 48);
            Animation.WriteAt("┘", 208, 48);
            Animation.WriteAt("┐", 208, 0);
        }
    }
}

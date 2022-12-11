using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Game.Rooms
{
    internal class BedRoom
    {
        public static void PaintBedRoom()
        {
            Clear();
            CursorVisible = false;
            WindowWidth = 210;
            BufferWidth = 210;
            WindowHeight = 50;
            BufferHeight = 50;
            WorkRoom.FrameOfWorkRoom();
            Painter.Door(13, 6);
            Painter.GhostbustersPoster(80, 1);
            Painter.SofaChair(160, 17);
            Painter.PlazmaTV(160, 29);
            Painter.ClothesShelfBack(2, 26);
            Painter.Bed(86, 37);
            Painter.BedTable(68, 37);
            Painter.BedTable(120, 37);
            Painter.TableLamp(73, 35);
        }
    }
}

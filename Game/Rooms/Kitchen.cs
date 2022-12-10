using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Game.Rooms
{
    internal class Kitchen
    {
        public static void KitchenRoom()
        {
            Clear();
            CursorVisible = false;
            WindowWidth = 210;
            BufferWidth = 210;
            WindowHeight = 50;
            BufferHeight = 50;
            WorkRoom.FrameOfWorkRoom();
            Painter.Door(13, 6);
            Painter.Door(140, 6);
            Painter.DoorWC(170, 6);
            Painter.KitchenSurface(49, 7);
            Painter.RightShelf(37, 1);
            Painter.RightShelf(90, 1);
            Painter.KitchenTableWithChairs(130, 30);
            Painter.BackBigKitchenShelf(20, 34);
            ReadKey();
        }
    }
}

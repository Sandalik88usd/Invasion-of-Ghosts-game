using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Game
{
    internal class Hallway
    {
        public static void HallwayRoom()
        {
            Clear();
            CursorVisible = false;
            WindowWidth = 210;
            BufferWidth = 210;
            WindowHeight = 50;
            BufferHeight = 50;
            WorkRoom.FrameOfWorkRoom();
            Painter.Door(55,6);
            Painter.Door(140, 6);
            Painter.Window(95,3);
            Painter.Cactus(180, 4);
            Painter.Sofa(85, 25);
            Painter.Torchere(72, 25);
            Painter.SmallTV(98, 36);
            //Painter.ShoesStand(8, 13);
            Painter.Aquarium(170, 20);
            Painter.Bookshelf(5, 10);
            Animation.WriteAt("=====", 5, 15);
        }
    }
}

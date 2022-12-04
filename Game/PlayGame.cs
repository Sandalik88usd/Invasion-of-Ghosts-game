using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Game
{
    internal class PlayGame
    {
        public static void StartWorkRoom()
        {
            Clear();
            CursorVisible = false;
            BufferWidth = 210;
            WindowWidth = 210;
            BufferHeight = 50;
            WindowHeight = 50;
            //int hor = 43; int ver = 28;
            int hor = 120; int ver = 17;
            int pose = 0; int trigers = 1;
            FirstCutScene.PlayFirstCutScene();
            WorkRoom.FrameOfWorkRoom();
            WorkRoom.PaintWorkRoom();
            Hallway.HallwayRoom();
            MoveMent.MoveMentWorkRoom(hor, ver,ref trigers);
        }


    }
}

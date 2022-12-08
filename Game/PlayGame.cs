using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using static System.Console;
using System.Runtime.ConstrainedExecution;

namespace Game
{
    internal class PlayGame
    {
        public static Thread threadPlayer;
        public static Thread threadGhostInHallway;
        public static void StartWorkRoom()
        {
            Clear();
            CursorVisible = false;
            BufferWidth = 210;
            WindowWidth = 210;
            BufferHeight = 50;
            WindowHeight = 50;
            //int hor = 43; int ver = 28;
            int hor = 120; int ver = 18;
            int horGhost = 150; int verGhost = 18;
            int pose = 0; int trigers = 1;
            int[] horGhostHitbox = new int[8];
            int[] verGhostHitbox = new int[8];
            int[] horPlayerHitbox = new int[8];
            int[] verPlayerHitbox = new int[8];
            threadGhostInHallway = new Thread(() => GhostsMove.GhostInHallway(ref horGhost, ref verGhost, ref horGhostHitbox, ref verGhostHitbox));
            threadPlayer = new Thread(() => MoveMent.MoveMentHallway(hor, ver, ref horGhostHitbox, ref horPlayerHitbox, ref verGhostHitbox));
            //FirstCutScene.PlayFirstCutScene();
            //WorkRoom.FrameOfWorkRoom();
            // WorkRoom.PaintWorkRoom();
            //MoveMent.MoveMentWorkRoom(hor, ver, ref trigers);
            SecondCutScene.PlaySecondCutScene();
            //Hallway.HallwayRoom();


            //threadGhostInHallway.Start();
            //Thread.Sleep(200);
            threadPlayer.Start();

            //threadPlayer.Start();
            //Thread.Sleep(200);
            //threadGhostInHallway.Start();

        }


    }
}

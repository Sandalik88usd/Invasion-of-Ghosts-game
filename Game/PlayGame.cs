using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using static System.Console;
using System.Runtime.ConstrainedExecution;
using Game.Rooms;

namespace Game
{
    internal class PlayGame
    {
        public static Thread threadPlayer;
        public static Thread threadGhostInHallway;
        public static int PlayerPosition = 0;
        public static int trigersInHallway = 0;
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
            int pose = 0;
            int trigersInWorkRoom = 0;
            int[] horGhostHitbox = new int[8];
            int[] verGhostHitbox = new int[8];
            int[] horPlayerHitbox = new int[8];
            int[] verPlayerHitbox = new int[8];
            threadGhostInHallway = new Thread(() => GhostsMove.GhostInHallway(ref horGhost, ref verGhost, ref horGhostHitbox, ref verGhostHitbox));
            threadPlayer = new Thread(() => MoveMentHallway.MoveMentInHallway(hor, ver, ref horGhostHitbox, ref horPlayerHitbox, ref verGhostHitbox, ref PlayGame.trigersInHallway));
            //FirstCutScene.PlayFirstCutScene();
            //WorkRoom.FrameOfWorkRoom();
            // WorkRoom.PaintWorkRoom();
            //MoveMentWorkRoom.MoveMentInWorkRoom(hor, ver, ref trigersInWorkRoom);
            //SecondCutScene.PlaySecondCutScene();
            //Hallway.HallwayRoom();

            //Kitchen.KitchenRoom();
            //ButhRoom.PaintButhRoom();
            BedRoom.PaintBedRoom();

            //threadGhostInHallway.Start();
            //Thread.Sleep(200);
            //threadPlayer.Start();

            //threadPlayer.Start();
            //Thread.Sleep(200);
            //threadGhostInHallway.Start();

            //End.EndOfGame();

        }


    }
}

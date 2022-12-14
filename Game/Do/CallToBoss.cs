using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Game.Do
{
    internal class CallToBoss
    {
        public static void CallToBooss()
        {
            WindowOfCall();
            Animation.MainCharacter(18, 1);
            Animation.Boss(65, 1);
            int number = 0;
            Thread.Sleep(700);
            for (int j = 0; j < 3; j++)
            {
                Phrases(number++);
                for (int i = 0; i < 5; i++)
                    Animation.TalkingMouth(22, 7, 50);
                Phrases(number++);
                for (int i = 0; i < 5; i++)
                    Animation.TalkingMouth(69, 7, 50);
            }
        }
        public static void SecondCallToBooss()
        {
            WindowOfCall();
            Animation.MainCharacter(18, 1);
            Animation.Boss(65, 1);
            int number = 6;
            Thread.Sleep(700);
            for (int j = 0; j < 2; j++)
            {
                Phrases(number++);
                for (int i = 0; i < 5; i++)
                    Animation.TalkingMouth(22, 7, 50);
                Phrases(number++);
                for (int i = 0; i < 5; i++)
                    Animation.TalkingMouth(69, 7, 50);
            }
        }
        static void WindowOfCall()
        {
            Clear();
            CursorVisible = false;
            WindowWidth = 100;
            WindowHeight = 35;
            BufferWidth = 100;
            BufferHeight = 35;
            for (int i = 0; i < 98; i++)
            {
                Animation.WriteAt("═", i, 0);
                Animation.WriteAt("═", i, 33);
                Animation.WriteAt("═", i, 22);
            }
            for (int i = 1; i < 34; i++)
            {
                Animation.WriteAt("║", 0, i);
                Animation.WriteAt("║", 98, i);
            }
            for (int i = 1; i < 22; i++)
                Animation.WriteAt("║", 49, i);

            Animation.WriteAt("╚", 0, 33);
            Animation.WriteAt("╝", 98, 33);
            Animation.WriteAt("╔", 0, 0);
            Animation.WriteAt("╗", 98, 0);
            Animation.WriteAt("╩", 49, 22);
            Animation.WriteAt("╦", 49, 0);
        }
        static void Phrases(int number)
        {
            int y = 25;
            int x = 7;
            switch (number)
            {
                case 0:
                    Animation.WriteAt("Billy: Hey boss, it's me Billy", x, y);
                    break;
                case 1:
                    Animation.WriteAt("Boss: Something happened?", x, y + 1);
                    break;
                case 2:
                    Animation.WriteAt("Billy: Yes, computer doesn't work, maybe some malwary.", x, y + 2);
                    break;
                case 3:
                    Animation.WriteAt("Boss: This is bad. Then scan your papers and go home. I will call the master tomorrow.", x, y + 3);
                    break;
                case 4:
                    Animation.WriteAt("Billy: Okay, I'll do that.", x, y + 4);
                    break;
                case 5:
                    Animation.WriteAt("Boss: Goodbay", x, y + 5);
                    break;
                case 6:
                    Animation.WriteAt("Billy: The scanner doesn't work either, looks like malware is on our network.", x, y);
                    break;
                case 7:
                    Animation.WriteAt("Boss: It is very sad. Okay, you can go home tomorrow, the master will fix everything.", x, y + 1);
                    break;
                case 8:
                    Animation.WriteAt("Billy: Ok boss see you tomorrow.", x, y + 2);
                    break;
                case 9:
                    Animation.WriteAt("Boss: Bye.", x, y + 3);
                    break;
            }
        }
    }
}

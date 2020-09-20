using System;
using System.Threading;

namespace TestAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            string playerName;
            int playerAge;
            string playerGender;
            string awnser;

            Console.ForegroundColor = ConsoleColor.White;
            SlowWriter.Write("| WELCOME PLAYER, TO THE ENDLESS WORLD OF ");
            Thread.Sleep(800);
            RainbowText.Write("I M A G I N A T I O N!");
            Console.ForegroundColor = ConsoleColor.White;
            SlowWriter.Write(" |");
            Thread.Sleep(2000);
            SlowWriter.Write(" .");
            Thread.Sleep(100);
            SlowWriter.Write(".");
            Thread.Sleep(100);
            SlowWriter.Write(".");
            Thread.Sleep(1000);
            SlowWriter.Write(" well I say endless but I really mean bound to the constraints of my main programmers coding abilities. *ugh-hm*");
            Thread.Sleep(2000);
            Console.ForegroundColor = ConsoleColor.Cyan;
            SlowWriter.Write("\n\nAnyhow");
            Thread.Sleep(1000);
            SlowWriter.Write(" .");
            Thread.Sleep(100);
            SlowWriter.Write(".");
            Thread.Sleep(100);
            SlowWriter.Write(".");
            Thread.Sleep(1000);
            SlowWriter.Write(" Welcome!");
            Thread.Sleep(1000);
            SlowWriter.Write("\nThis is a textbased adventure game, design to flex the development teams skills in programming,");
            Thread.Sleep(1000);
            SlowWriter.Write(" and give you an adventure of a lifetime ofcourse!");
            Thread.Sleep(1500);
            SlowWriter.Write("\nWhat is your name player? ");
            Console.ForegroundColor = ConsoleColor.White;
            playerName = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            SlowWriter.Write("Ahh, so your name is " + playerName + ". ");
            Thread.Sleep(500);
            SlowWriter.Write("That was my grandfathers name you know, an interesting man to say the least. ");
            Thread.Sleep(1000);
            SlowWriter.Write("Well then " + playerName);
            Thread.Sleep(500);
            SlowWriter.Write(", what is your age? ");
            Console.ForegroundColor = ConsoleColor.White;
            playerAge = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Cyan;
            SlowWriter.Write("Ahaa! Your " + playerAge + " years old! Same as me! Good on you. ");
            Thread.Sleep(1000);
            SlowWriter.Write("One more thing, ");
            Thread.Sleep(500);
            SlowWriter.Write("with all that long flowing hair I can´t tell if you´re a male or a female, ");
            Thread.Sleep(500);
            SlowWriter.Write("what are you? ");
            Console.ForegroundColor = ConsoleColor.White;
            playerGender = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Cyan;

            if (playerGender.Trim().ToLower() == "male")
            {
                SlowWriter.Write("I see, a manly man. ");
                Thread.Sleep(500);
                SlowWriter.Write("*cough* ");
                Thread.Sleep(1000);
                SlowWriter.Write("(I'll make sure not to damage your ego...)");
            }

            else if (playerGender.Trim().ToLower() == "female")
            {
                SlowWriter.Write("I see, a pretty lady. ");
                Thread.Sleep(500);
                SlowWriter.Write("You won't be the princess in this castle though, this will be some hard work... ");
            }

            else
            {
                SlowWriter.Write("I see, I'm sorry for my ignorance, I should have gathered. ");
                Thread.Sleep(500);
                SlowWriter.Write("Well, you will fit in this story quite nicely... ");
                //If neither male nor female is choosen, this is the return
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Thread.Sleep(1500);
            SlowWriter.Write("\n\nOur story begins in a far of land, the sun setting to an orange hue. ");
            Thread.Sleep(500);
            SlowWriter.Write("You are standing in a forrest with a fork in the road, one path leading towards a big castle and one towards the sea.");
            Thread.Sleep(500);
            SlowWriter.Write("\nWhich way do you go? ");

        path1:
            Console.ForegroundColor = ConsoleColor.White;
            awnser = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Cyan;

            if (awnser.Trim().ToLower() == "sea")
            {
                SlowWriter.Write("You continue towards the crushing waves of the seashore. ");
            }

            else if (awnser.Trim().ToLower() == "castle")
            {
                SlowWriter.Write("You continue towards the magestic looking castle, towering over your head. ");
            }

            else
            {
                SlowWriter.Write("You really need to learn the kings english " + playerName + ", please try to awnser more clearly. To the sea, or the castle? ");

                goto path1;
                //Go brack to start of path if no correct way is choosen
            }

            Console.ReadLine();
        }
    }

    public class SlowWriter
    {

        public static void Write(string text)
        {
            Random rnd = new Random();
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(rnd.Next(30, 60));
            }
        }
    }

    public class RainbowText
    {

        public static void Write(string text)
        {
            Random rnd = new Random();
            Random r = new Random();
            foreach (char c in text)
            {
                Console.ForegroundColor = (ConsoleColor)r.Next(0, 16);
                Console.Write(c);
                Thread.Sleep(rnd.Next(30, 60));
            }
        }
    }
}

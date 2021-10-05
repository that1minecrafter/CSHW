using System;

namespace IfChallenge2
{
    class Program
    {
        static int highscore = 300;
        static string highscorePlayer = "meep";

        static void Main(string[] args)
        {
            CheckHighscore(250, "bob");
            CheckHighscore(315, "joe");
            CheckHighscore(350, "meep");

            Console.Read();
        }
        public static void CheckHighscore(int score, string playerName)
        {
            if(score > highscore)
            {
                highscore = score;
                highscorePlayer = playerName;

                Console.WriteLine("new highscore is: " + score);
                Console.WriteLine("the highscore is now held by: " + playerName); 

            }else
            {
                Console.WriteLine("highscore couldn't be beaten! it is still " + score + " and is held by: " + highscorePlayer);
            }
        }
    }
}

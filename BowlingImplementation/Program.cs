using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingImplementation
{
    class Program
    {
        
        static void Main(string[] args)

        {

            int totlalScore = 0;
            int frametracker = 0;
            for (int framecount = 1; framecount <=10; framecount++)
            {
                frametracker++; 
                CalculateScoreEachFrame totalScore = new CalculateScoreEachFrame(frametracker);
                var ScoreInFrame = totalScore.Score();
                Console.WriteLine("You score in frame " + frametracker + " is " + ScoreInFrame);
                totlalScore += ScoreInFrame;
                Console.WriteLine("Total score is : " + totlalScore);
                Console.WriteLine("********************************");


            }
            Console.WriteLine();
            Console.WriteLine("press any key to exit . . .");
            Console.ReadKey(true);



            

        }
    }
}

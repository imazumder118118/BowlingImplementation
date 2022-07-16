using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingImplementation
{
    public class CalculateScoreEachFrame
    {
        private int _frametracker;
        public CalculateScoreEachFrame(int frametracker)
        {
            _frametracker = frametracker;

        }
        public int Score ()
        {
            int TotalScore = 0;
            string outcome = String.Empty;

            Frame frame = new Frame();
            Console.WriteLine("How many pins down in 1st shot ?");
            frame.FirstShotResult = Console.ReadLine();

            while (!validateEntry(Convert.ToInt32(frame.FirstShotResult)))
            {
                Console.WriteLine("Invalid Entry, try again !");
                frame.FirstShotResult = Console.ReadLine();

            }
            Console.WriteLine("How many pins down in 2nd shot ?");
            frame.SecondShotResult = Console.ReadLine();
            while(!validateEntry(Convert.ToInt32(frame.SecondShotResult)))
            {
                Console.WriteLine("Invalid Entry, try again !");
                frame.SecondShotResult = Console.ReadLine();
            }
                
            if (frame.IsStrike(frame.FirstShotResult))

                outcome = "Strike";

            if (frame.IsSpare(frame))

                outcome = "Spare";

            if (frame.IsOpenFrame(frame))

                outcome = "OpenFrame";


            switch (outcome)
            {
                case "Strike":
                    Console.WriteLine("How many pins down in 3rd shot ?");
                    frame.ThridShotResult = Console.ReadLine();
                    while (!validateEntry(Convert.ToInt32(frame.ThridShotResult)))
                    {
                        Console.WriteLine("Invalid Entry,try again ! ");
                        frame.ThridShotResult = Console.ReadLine();
                    }
                       
                    Strike strike = new Strike();
                    TotalScore += strike.ExecuteScore(Convert.ToInt32(frame.SecondShotResult), Convert.ToInt32(frame.ThridShotResult));
                    break;

                case "Spare":
                    Console.WriteLine("How many pins down in 3rd shot ?");
                    frame.ThridShotResult = Console.ReadLine();
                    while (!validateEntry(Convert.ToInt32(frame.ThridShotResult)))
                    {
                        Console.WriteLine("Invalid Entry,try again ! ");
                        frame.ThridShotResult = Console.ReadLine();
                    }
                    Spare spare = new Spare();
                    TotalScore = spare.ExecuteScore(Convert.ToInt32(frame.ThridShotResult));
                    break;

                case "OpenFrame":

                    OpenFrame openframe = new OpenFrame();
                    var response = openframe.IsMatch10thFrame(_frametracker);
                    if (!String.IsNullOrEmpty(response))
                    {
                        Console.WriteLine(response);
                    }
                    TotalScore = openframe.ExecuteScore(Convert.ToInt32(frame.FirstShotResult), Convert.ToInt32(frame.SecondShotResult));
                    break;
                

                 
            }
            return TotalScore;
        }

        public bool validateEntry(int val)
        {
            if (val > 10)
                return false;
            else return true;
        }


        }
}

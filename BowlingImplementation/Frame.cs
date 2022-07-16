using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingImplementation
{
    public class Frame 
    {
        public string  FirstShotResult;
        public string  SecondShotResult;
        public string  ThridShotResult;
        public int frametracker;

        //Rule for Strike 

        public bool IsStrike(string FirstShotResult)
        {

            if (Convert.ToInt32(FirstShotResult) == 10)
            {
                Console.WriteLine("****This is strike*****");
                return true;
            }
            else return false;
        }
        //Rule for Spare 
        public bool IsSpare(Frame objFrame)
        {
          
            int result = Convert.ToInt32(objFrame.FirstShotResult) + Convert.ToInt32(objFrame.SecondShotResult);
            if (result == 10)
            {
                Console.WriteLine("****This is Spare*****");
                return true;
            }
                
            else return false;
        }
        //Rule for OpenFrame
        public bool IsOpenFrame(Frame objFrame)
        {
            int result = Convert.ToInt32(objFrame.FirstShotResult) + Convert.ToInt32(objFrame.SecondShotResult);
            if (result < 10)
            {
                Console.WriteLine("****This is OpenFrame*****");
                return true;

            }
           
            else return false;
        }


    }
}

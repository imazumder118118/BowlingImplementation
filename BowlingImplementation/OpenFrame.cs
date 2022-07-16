using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingImplementation
{
    class OpenFrame
    {
        

        public int ExecuteScore(int firstshot,int secondshot)
        {
            int _CurrentScore = firstshot + secondshot;
            return _CurrentScore;
        }

        public string  IsMatch10thFrame(int nthframe)
        {
            string response = "";
            if (nthframe == 10)
                response = "Game Over";
            return response;
           
        }
    }
}

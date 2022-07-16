using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BowlingImplementation
{
    public class Strike 
   {

        public int ExecuteScore(int ValueOfSecondShot,int ValueOfThridShot )
        {
            int _CurrentScore = 10 + ValueOfSecondShot + ValueOfThridShot;
            return _CurrentScore;
        }

        public bool IsMatch()
        {
            throw new NotImplementedException();
        }
    }
}

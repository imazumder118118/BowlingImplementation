using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingImplementation
{
    public class Spare
    {
        public int ExecuteScore( int ValueOfThridShot)
        {
            int _CurrentScore =  10 +  ValueOfThridShot;
            return _CurrentScore;
        }

        public bool IsMatch()
        {
            throw new NotImplementedException();
        }
    }
}

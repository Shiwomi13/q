using System;
using System.Collections.Generic;
using System.Text;

namespace Al
{
    class LinearEquation
    {
        protected List<float> X1;
        public List<float> LiEq(float a, float b)
        {

            if (a == 0)
                return null;
              
            return X1 = new List<float>() { -b / a };         

        }
    }
}

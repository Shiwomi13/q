using Aleksandrov;
using System;
using System.Collections.Generic;

namespace Al
{
    class QuadraticEquation : LinearEquation, EquationInterface
    {

        public List<float> Solve(float a, float b, float c)
        {
            float D = SearchDiscriminate(a, b, c);

            if (a == 0)
            {
                return LiEq(b, c);
            }

            if (D < 0)
            {
                return null;
            }

            if (D == 0)
            {
                return X1 = new List<float>(){
                    (-b) / (2 * a)
                };
            }
              
            D = (float)Math.Sqrt(D);

            return X1 = new List<float>() {
                (-b + D) / (2 * a),
                (-b - D) / (2 * a)
            };

        }

        protected float SearchDiscriminate(float a, float b, float c)
        {
            return b * b - (4 * a * c);
        }
    }
}

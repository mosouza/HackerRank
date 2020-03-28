using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
            
            var inputDimesional = Convert.ToInt32(Console.ReadLine());

            var d1 = 0;
            var d2 = inputDimesional - 1;

            var d1Result = 0;
            var d2Result = 0;
            var result = 0;

            for (var i = 0; i < inputDimesional; i++)
            {
                var inputValues = Console.ReadLine().Split(new char[] { ' ' });

                d1Result += Convert.ToInt32(inputValues[d1]);
                d2Result += Convert.ToInt32(inputValues[d2]);

                d1++;
                d2--;
            }

            result = System.Math.Abs(d1Result - d2Result);

            Console.Write("{0}", result);
        
        
        }
    }


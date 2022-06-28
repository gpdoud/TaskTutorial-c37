using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTutorial {
    internal class Utility {

        public ulong max { get; set; }
        public int fact { get; set; }

        public int Factorial() {
            int answer = 1;
            for(int i = 2; i <= fact; i++) {
                answer *= i;
            }
            return answer;
        }

        public ulong SumToMax() {
            ulong sum = 0;
            for (ulong i = 1; i <= max; i++) {
                sum += i;
            }
            return sum;
        }
    }
}

using System;
using System.Linq;

namespace OddOccurrencesInArray {
    class Solution {
        public int solution(int[] A) {
            return A.Aggregate((x, y) => x ^ y);
        }
    }

    class MainClass {
        public static void Main(string[] args) {
            var sol = new Solution();
            var values = new int[] { 9, 3, 9, 3, 9, 7, 7, 7, 9 };
            Console.WriteLine(sol.solution(values));
        }
    }
}

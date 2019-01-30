using System;

namespace GirubaSumDLL
{
    public class Class1
    {
        public int AddTwoNumbers(int a, int b) {
            return a + b;
        }

        public int AddThreeNumbers(int a, int b, int c) {
            return a + b + c;
        }

        public int AddNumbersInRange(int endNumber) {
            int sum = 0;
            for (int i = 0; i <= endNumber; i++) {
                sum += i;
            }

            return sum;
        }
    }
}

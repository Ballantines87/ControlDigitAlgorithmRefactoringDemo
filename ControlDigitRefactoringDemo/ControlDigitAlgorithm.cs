using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDigitRefactoringDemo
{
    class ControlDigitAlgorithm
    {
        private Func<long, IEnumerable<int>> GetDigitsof { get; }
        private IEnumerable<int> MultiplyingFactors { get; }
        private int Modulo { get; }


        public ControlDigitAlgorithm(
            Func<long, IEnumerable<int>> getDigitsOf,
            IEnumerable<int> multiplyingFactors,
            int modulo)
        {
            GetDigitsof = getDigitsOf;
            MultiplyingFactors = multiplyingFactors;
            Modulo = modulo;

        }


        public int GetControlDigit(long number)
        {
            return GetDigitsof(number)
                .Zip(MultiplyingFactors, (a, b) => a * b)
                .Sum()
                % Modulo;
        }



    }
}

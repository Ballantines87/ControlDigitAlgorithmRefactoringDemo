using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDigitRefactoringDemo
{
    static class ControlDigitAlgorithmsFactory
    {
        public static ControlDigitAlgorithm ForAccountingDepartment
            => new ControlDigitAlgorithm(x => x.DigitsFromLowest(),
                multiplyingFactors, 7);


        public static ControlDigitAlgorithm ForSalesDepartment
            => new ControlDigitAlgorithm(x => x.DigitsFromHighest(),
                multiplyingFactors, 9);


        private static IEnumerable<int> multiplyingFactors
        {
            get
            {
                int factor = 3;
                while (true)
                {
                    yield return factor;
                    factor = 4 - factor;
                }
            }
        }
    }



}

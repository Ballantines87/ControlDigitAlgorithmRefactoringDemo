using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ControlDigitRefactoringDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            int controlDigit = 
                ControlDigitAlgorithmsFactory.ForAccountingDepartment
                .GetControlDigit(12345);

            Console.ReadLine();
        }
 

    }
}

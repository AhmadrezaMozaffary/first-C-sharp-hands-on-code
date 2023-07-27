using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc.Core;

public class Calculator
{
    double _output = 0;

    private void printOnScreen(string msg = "calculated")
    {
        Console.WriteLine("Output " + msg + " and final result is " + _output + " .");
    }

    public void plus(double increaseBy)
    {
        _output += increaseBy;


        printOnScreen(" increases by " + increaseBy);

    }

    public void minus(double decreaseBy) {
        _output -= decreaseBy;

        printOnScreen(" decerases by " + decreaseBy);
    }

    public void multiply(double multiplyBy) {
        _output *= multiplyBy;

        printOnScreen(" multiples by " + multiplyBy);
    }

    public void divide(double divideBy)
    {
        _output /= divideBy;

        printOnScreen(" divides by " + divideBy);
    }

    public void printResult() {
        printOnScreen();
    }

    public void Clear() { 
        _output = 0;
        Console.WriteLine(" -- Screen was cleared ! ");
    }

}

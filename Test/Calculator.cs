using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc.Core;

public class Calculator
{
    double _output = 0;

    private void PrintOnScreen(string msg = "calculated")
    {
        Console.WriteLine("Output " + msg + " and final result is " + _output + " .");
    }

    public void Plus(double increaseBy)
    {
        _output += increaseBy;

        PrintOnScreen(" increases by " + increaseBy);

    }

    public void Minus(double decreaseBy) {
        _output -= decreaseBy;

        PrintOnScreen(" decerases by " + decreaseBy);
    }

    public void Multiply(double multiplyBy) {
        _output *= multiplyBy;

        PrintOnScreen(" multiples by " + multiplyBy);
    }

    public void Divide(double divideBy)
    {
        _output /= divideBy;

        PrintOnScreen(" divides by " + divideBy);
    }

    public void PrintResult() {
        PrintOnScreen();
    }

    public void Clear() { 
        _output = 0;
        Console.WriteLine(" -- Screen was cleared ! ");
    }

}

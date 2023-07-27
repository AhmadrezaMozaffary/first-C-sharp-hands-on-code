using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc.Core;

public class Calculator
{
     private double _output = 0;
    private char[] _validOperators = { '+', '-', '/', '*', '='};

    public void PrintCalculatorPanel()
    {
        Console.WriteLine("|-----------------------------------------|");
        Console.WriteLine("|------------------- " + _output + " -------------------|");
        Console.WriteLine("|-----------------------------------------|");

        GetUserInput();
        
    }

    private void GetUserInput()
    {
        do
        {
        Console.WriteLine(" > Enter a number ");
        var input =Double.Parse(Console.ReadLine()) ;

        Console.WriteLine(" > Enter operator symbol +, -, *, /, = ");
        Console.WriteLine(" X to terminate the program . ");
        var operatorSymbol = Char.Parse(Console.ReadLine());

            if (_validOperators.Contains(operatorSymbol))
            {
                DoCalculations(input, operatorSymbol);

            }
        } while (operatorSymbol != 'x' || operatorSymbol != 'X');

    }

    private void DoCalculations(double inputNumber, char inputSymbol)
    {
        if (inputNumber == null) throw new ArgumentNullException("Input is null");

         switch(inputSymbol)  {
            case '+': Plus(inputNumber); break;
            case '-': Minus(inputNumber); break;
            case '*': Multiply(inputNumber); break;
            case '/': Divide(inputNumber); break;
            case '=':
                PrintOnScreen();
                Clear();
                break;
            default: throw new InvalidOperationException("You have to choose one of the show operators !!!");

        }
    }

    private void PrintOnScreen(string msg = "calculated")
    {
        Console.WriteLine("Output " + msg + " and final result is " + _output + " .");
    }

    private void Plus(double increaseBy)
    {
        _output += increaseBy;

        PrintOnScreen(" increases by " + increaseBy);

    }

    private void Minus(double decreaseBy) {
        _output -= decreaseBy;

        PrintOnScreen(" decerases by " + decreaseBy);
    }

    private void Multiply(double multiplyBy) {
        _output *= multiplyBy;

        PrintOnScreen(" multiples by " + multiplyBy);
    }

    private void Divide(double divideBy)
    {
        _output /= divideBy;

        PrintOnScreen(" divides by " + divideBy);
    }

    private void PrintResult() {
        PrintOnScreen();
    }

    private void Clear() { 
        _output = 0;
        Console.WriteLine(" -- Screen was cleared ! ");
    }

}

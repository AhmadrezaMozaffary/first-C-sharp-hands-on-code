using Calc.Core;

var clc = new Calculator();
clc.PrintResult();// 0

clc.Plus(13.89); // 13.89
clc.Plus(0.11); // 14
clc.Multiply(2); // 28
clc.Divide(4); // 7
clc.Minus(10.5); // -3.5
clc.Minus(4); // -7.5
clc.Multiply(11);  // -82.5
clc.Minus(3.25); // - 85.75
clc.Multiply(-1); // 85.75
clc.Minus(0.75); // 85

clc.PrintResult(); // 85
clc.Clear();
clc.PrintResult(); // 0

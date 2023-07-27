using Calc.Core;

var clc = new Calculator();
clc.printResult();// 0

clc.plus(13.89); // 13.89
clc.plus(0.11); // 14
clc.multiply(2); // 28
clc.divide(4); // 7
clc.minus(10.5); // -3.5
clc.minus(4); // -7.5
clc.multiply(11);  // -82.5
clc.minus(3.25); // - 85.75
clc.multiply(-1); // 85.75
clc.minus(0.75); // 85

clc.printResult(); // 85
clc.Clear();
clc.printResult(); // 0

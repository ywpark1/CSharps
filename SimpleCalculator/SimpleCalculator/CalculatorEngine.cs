using System;

namespace SimpleCalculator {
    public class CalculatorEngine {
        public double Calculte (double argFirstNumber, string operation, double argSecondNumber) {
            double result;

            switch (operation.ToLower ()) {
                case "add":
                case "+":
                    result = argFirstNumber + argSecondNumber;
                    break;

                case "subtract":
                case "-":
                    result = argFirstNumber - argSecondNumber;
                    break;

                case "multiply":
                case "*":
                    result = argFirstNumber * argSecondNumber;
                    break;

                case "divide":
                case "/":
                    result = argFirstNumber / argSecondNumber;
                    break;
                default:
                    throw new InvalidOperationException ("Specified operation is not recognized");
            }

            return result;
        }
    }
}
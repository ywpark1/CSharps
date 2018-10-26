using System;

namespace SimpleCalculator {
    class SimpleCalculator {
        static void Main (string[] args) {
            try {
                InputConverter inputConverter = new InputConverter ();
                CalculatorEngine calculatorEngine = new CalculatorEngine ();

                double firstNumber = inputConverter.ConvertInputToNumeric (Console.ReadLine ());
                double secondNumber = inputConverter.ConvertInputToNumeric (Console.ReadLine ());

                string operation = Console.ReadLine ();

                double result = calculatorEngine.Calculte (firstNumber, operation, secondNumber);

                System.Console.WriteLine (result);
            } catch (Exception ex) {
                // TODO: start logging exceptions
                System.Console.WriteLine (ex.Message);
            }
        }
    }
}
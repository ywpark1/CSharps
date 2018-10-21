using System;

namespace SimpleStack {
    class Program {
        static void Main (string[] args) {
            Stack stack = new Stack ();

            try {
                stack.Push (1);
                stack.Push (2);
                stack.Push (3);

                Console.WriteLine (stack.Pop ());
                Console.WriteLine (stack.Pop ());
                Console.WriteLine (stack.Pop ());

                // Pop Empty stack
                stack.Pop ();
            } catch (InvalidOperationException e) {
                System.Console.WriteLine (e.Message);
            }

        }
    }
}
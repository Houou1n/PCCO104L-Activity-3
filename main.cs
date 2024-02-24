using System;

class Program {
  public static void Main (string[] args) {
    int n;

    do {
        Console.Write("Enter a number: ");
        if (!int.TryParse(Console.ReadLine(), out n) || n < 0) {
            Console.WriteLine("Invalid input. Please a VALID number.");
            continue;
        }

        if (n == 0) {
            Console.WriteLine("Closing Program...");
            return;
        }

        for (int i = 1; i <= n; i++) {
            for (int j = 1; j <= n - i; j++) {
                Console.Write(" ");
            }
            for (int k = 1; k <= 2 * i - 1; k++) {
                Console.Write("*");
            }
            Console.WriteLine();
        }

    } while (true);
  }
}
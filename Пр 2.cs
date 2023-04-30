using System; 

  

class Program { 

    static void Main(string[] args) { 

        Console.Write("Введіть число X: "); 

        int x = int.Parse(Console.ReadLine()); 

  

        if (x <= 1) { 

            Console.WriteLine("Помилка: число повинно бути більше 1"); 

            return; 

        } 

  

        int n = 2 * x; 

        int count = 0; 

  

        for (int i = x + 1; i < n; i++) { 

            if (IsPrime(i)) { 

                Console.WriteLine(i); 

                count++; 

            } 

        } 

  

        Console.WriteLine($"Знайдено {count} простих чисел в діапазоні ]{x}, {n}["); 

    } 

  

    static bool IsPrime(int number) { 

        if (number == 2) return true; 

        if (number % 2 == 0 || number == 1) return false; 

  

        int boundary = (int)Math.Floor(Math.Sqrt(number)); 

  

        for (int i = 3; i <= boundary; i += 2) { 

            if (number % i == 0) { 

                return false; 

            } 

        } 

  

        return true; 

    } 

} 
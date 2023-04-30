using System; 

  

class Program 

{ 

    static void Main() 

    { 

        string sentence = "This is a sentence with 10 words";  

  

        string[] array = new string[10];  

  

        string[] words = sentence.Split(' ');  

        for (int i = 0; i < words.Length; i++) 

        { 

            array[i] = words[i]; 

        } 

  

        Console.WriteLine("Array with 10 elements:");  

        for (int i = 0; i < array.Length; i++) 

        { 

            Console.WriteLine("Element {0}: {1}", i, array[i]); 

        } 

    } 

} 
// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("hello ,enter the first number of rnge: ");
        int first = int.Parse(Console.ReadLine()); ;
        Console.WriteLine("enter the last number of range:");
        int last = int.Parse(Console.ReadLine());


        Console.WriteLine("Prime numbers between " + first + " and " + last);
        Boolean flag = true; 

        
        for (int number = first; number <= last; number++)
        {
            
            for (int i = 2; i < number; i++)
            {
                if ((number % i) == 0)
                {
                    flag = false;
                    break;
                }
            }
            if (flag == true)
            {
                Console.WriteLine(number);
            }
            flag = true;
        }
    }
}




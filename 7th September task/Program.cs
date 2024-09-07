namespace _7th_September_task;
class Program
{
    static void Main(string[] args)
    {
        //Task 1 (Verilmiş 3 ədəddən hansının ən böyük olduğunu tapan proqram)

        int[] numbers = { 12, 33, 99 };

        int highestNumber = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > highestNumber)
            {
                highestNumber = numbers[i];
            }
        }
        Console.WriteLine($"The highest number is: {highestNumber}");

        //Task 2 (Verilmiş yazının içində A hərfinin olub olmadığını tapan proqram)

        string sentence = "Are you doing well?";
        

        if (sentence.Contains('A'))
        {
            Console.WriteLine("The sentence contains the letter A");
        }
        else
        {
            Console.WriteLine("There is no A in the sentence");
        }

        //Task 3(Verilmiş yazıda neçə A hərfinin olduğunu tapan proqram)

        string sentence1 = "Are you doing well?";
        int count = 0;

        foreach (char letter in sentence1)
        {
            if (letter == 'A')
            {
                count++;
            }
        }

        Console.WriteLine($"The sentence contains {count} A");

        //Task 4 (Verilmiş müsbət cüt ədədi kvadrata yüksəldən proqram. Daxil edilən ədə musbət və cüt olmadıqca yenidən daxil edilməlidir)
        int number;
        while (true)
        {
            Console.Write("Enter a positive and even number: ");
            number = Convert.ToInt32(Console.ReadLine());

            if (number > 0 && number % 2 == 0)
            {
                break;
            }

            Console.WriteLine("The number is not positive or even. Please try again.");
        }

        int squareOfNumber = number * number;
        Console.WriteLine("The square of the number is: " + squareOfNumber);

        //Task 5 (Verilmiş 5 uzunluqlu ədədlər siyahısındaki ədədlərin cəmini tapan proqram)
        int[] numbers1 = { 1, 2, 3, 4, 5 };
        int sum = 0;

       
        foreach (int number1 in numbers)
        {
            sum += number1;
        }

        Console.WriteLine("The sum of numbers is: " + sum);

        //Task 6 (Verilmiş təhsil növü dəyərinə əsasən o təhsilin saatını göstərən proqram.Əgər verilmiş dəyər "programming"dirsə console-da 400 saat, "design"dırsa 250 saat, "system"dirsə 200 saat, heç biri deyilsə "təhsil novu yanlisdir" yazılmalıdır console-da.)

        string educationType = "design"; 
        
        switch (educationType)
        {
            case "programming":
                Console.WriteLine("400 hours");
                break;
            case "design":
                Console.WriteLine("250 hours");
                break;
            case "system":
                Console.WriteLine("200 hours");
                break;
            default:
                Console.WriteLine("Enter the correct output(programming, design or system");
                break;
        }
    }
}


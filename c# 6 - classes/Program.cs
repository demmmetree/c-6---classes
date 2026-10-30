namespace c__6___classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //პირველი
            static double CalculateAverage(int score1, int score2, int score3)
            {
                return (score1 + score2 + score3) / 3.0;
            }

            static string GetGrade(double average)
            {
                if (average >= 91)
                    return "A";
                else if (average >= 81)
                    return "B";
                else if (average >= 71)
                    return "C";
                else if (average >= 61)
                    return "D";
                else if (average >= 51)
                    return "E";
                else
                    return "F";
            }

            static bool IsPassed(double average)
            {
                return average >= 51;
            }

            static void Main()
            {
                bool IsValidScore(int score)
                {
                    return score >= 0 && score <= 100;
                }

                Console.Write("შეიყვანეთ პირველი ქულა: ");
                int s1 = int.Parse(Console.ReadLine());

                Console.Write("შეიყვანეთ მეორე ქულა: ");
                int s2 = int.Parse(Console.ReadLine());

                Console.Write("შეიყვანეთ მესამე ქულა: ");
                int s3 = int.Parse(Console.ReadLine());
                if (!IsValidScore(s1) || !IsValidScore(s2) || !IsValidScore(s3))
                {
                    Console.WriteLine("შეცდომა: ქულა უნდა იყოს 0-დან 100-მდე!");
                    return;
                }

                double average = CalculateAverage(s1, s2, s3);
                string grade = GetGrade(average);
                bool passed = IsPassed(average);

                Console.WriteLine("საშუალო ქულა: " + average.ToString("F2"));
                Console.WriteLine("შეფასება: " + grade);

                if (passed)
                    Console.WriteLine("სტატუსი: ჩააბარა");
                else
                    Console.WriteLine("სტატუსი: ვერ ჩააბარა");

                //მეორე
                static bool IsEven(int number)
                {
                    return number % 2 == 0;
                }

                static bool IsPrime(int number)
                {
                    if (number < 2)
                        return false;

                    for (int i = 2; i * i <= number; i++)
                    {
                        if (number % i == 0)
                            return false;
                    }
                    return true;
                }

                static int CountDigits(int number)
                {
                    if (number == 0)
                        return 1; 

                    number = Math.Abs(number); 

                    int count = 0;
                    while (number > 0)
                    {
                        count++;
                        number = number / 10;
                    }
                    return count;
                }

                static int ReverseNumber(int number)
                {
                    int reversed = 0;

                    while (number > 0)
                    {
                        int digit = number % 10;          
                        reversed = reversed * 10 + digit; 
                        number = number / 10;             
                    }

                    return reversed;
                }

                static void Main()
                {
                    bool IsPositive(int n)
                    {
                        return n > 0;
                    }

                    Console.Write("შეიყვანეთ მთელი რიცხვი: ");
                    int number = int.Parse(Console.ReadLine());

                    if (IsPositive(number))
                        Console.WriteLine("რიცხვი დადებითია");
                    else if (number < 0)
                        Console.WriteLine("რიცხვი უარყოფითია");
                    else
                        Console.WriteLine("რიცხვი ნულია");

                    if (IsEven(number))
                        Console.WriteLine("რიცხვი ლუწია");
                    else
                        Console.WriteLine("რიცხვი კენტია");

                    if (IsPrime(number))
                        Console.WriteLine("რიცხვი მარტივია");
                    else
                        Console.WriteLine("რიცხვი მარტივი არ არის");

                    Console.WriteLine("ციფრების რაოდენობა: " + CountDigits(number));
                    Console.WriteLine("შებრუნებული რიცხვი: " + ReverseNumber(number));
                }
            }
    }
    }
}

using System;

namespace wee8_7_task.search; 
internal class Program
{
    static void Main()
    {
        DuplicatedIntegerCheck();
        CheckVowel();
    }

    public static void DuplicatedIntegerCheck()
    {
        bool toContinue = true;

        HashSet<int> set = new HashSet<int>();
        
        do
        {
           try
            {
                Console.WriteLine("please insert a number: "); 

                int value = Convert.ToInt32(Console.ReadLine());

                if (set.Contains(value))
                {
                    throw new ArgumentException("The number already exists");
                }

                set.Add(value);

                Console.WriteLine("Added successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("Continue? 0 to stop, any other number to continue"); 

            toContinue = Convert.ToInt32(Console.ReadLine()) != 0;

        }while (toContinue);
    }

    public static void CheckVowel()
    {
        HashSet<char> vowels = new HashSet<char>
        {
            'A','E','I','O','U',
            'a','e','i','o','u'
        };

        bool toContinue = true;

        do
        {
            try
            {
                Console.WriteLine("Please insert a string: ");

                string value = Console.ReadLine();

                bool hasVowel = false;

                foreach (char c in value)
                {
                    if (vowels.Contains(c))
                    {
                        hasVowel = true;
                        break;
                    }
                }

                if (!hasVowel)
                {
                    throw new ArgumentException("Your string does not contain vowels");
                }

                Console.WriteLine("String contains vowels");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("Continue? 0 to stop, any other number to continue");

            toContinue = Convert.ToInt32(Console.ReadLine()) != 0;

        } while (toContinue);
    }
}
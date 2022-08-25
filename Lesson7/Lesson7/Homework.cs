namespace Lesson7
{
    internal class Homework
    {
        class Program
        {
            public static void Main()
            {
                CompareText();
                AnalysisText();
                SortText();
                DublicateLetter();
            }

            static bool CompareText()
            {
                Console.WriteLine("Введіть, текст1");
                string? text1 = Console.ReadLine();
                Console.WriteLine("Введіть, текст2");
                string? text2 = Console.ReadLine();

                if (text1.Length == text2.Length)
                {
                    Console.WriteLine("Текст1 та текст2 мають однакову кількість символів");
                    return true;
                }
                else
                {
                    Console.WriteLine("Текст1 та текст2 мають різну кількість символів");
                    return false;
                }
            }

            static void AnalysisText()
            {
                Console.WriteLine("Введіть, будь-який, текст");
                string? text = Console.ReadLine();

                int sumLetter = 0;
                int sumDigit = 0;
                int sumSymbol = 0;

                foreach (char a in text)
                {
                    if (Char.IsLetter(a))
                    {
                        sumLetter++;
                    }
                    else if (Char.IsDigit(a))
                    {
                        sumDigit++;
                    }
                    else
                    {
                        sumSymbol++;
                    }
                }

                Console.WriteLine($"У введеному тексті налічується літер: {sumLetter}");
                Console.WriteLine($"У введеному тексті налічується цифр: {sumDigit}");
                Console.WriteLine($"У введеному тексті налічується спецсимволів: {sumSymbol}");
            }

            static string SortText()
            {
                Console.WriteLine("Введіть, текст в якому потрібно відсортувати літери від А до Я");
                string? text = Console.ReadLine();

                char[] sortText = text.ToArray();
                Array.Sort(sortText);

                Console.WriteLine($"Відсортовані літери від А до Я: {new string(sortText)}");
                return new string(sortText);
            }
            

            static char [] DublicateLetter()
            {
                Console.WriteLine("Введіть, будь-який, текст");
                string? text = Console.ReadLine();
                char[] arrayOfLetter = text.ToArray();
                var arrOfUniqueLetter = new char[] { };
                var arrOfDuplicateLetter = new char[] { };

                for (int i = 0; i < arrayOfLetter.Length; i++)
                {
                    var currentLetter = arrayOfLetter[i];

                    if (arrOfUniqueLetter.Contains(currentLetter))
                    {
                        if (!arrOfDuplicateLetter.Contains(currentLetter))
                        {
                            arrOfDuplicateLetter = arrOfDuplicateLetter.Append(currentLetter).ToArray();
                        }
                    }
                    else
                    {
                        arrOfUniqueLetter = arrOfUniqueLetter.Append(currentLetter).ToArray();
                    }
                }
                                
                for (int i = 0; i < arrOfDuplicateLetter.Length; i++)
                {
                    Console.Write(arrOfDuplicateLetter[i].ToString(), " ");                    
                }

                return arrOfDuplicateLetter;
            }
        }
    }
}


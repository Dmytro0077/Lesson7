////Приклад1
//static void DisplayArrayInt(int[] arr) => Console.WriteLine(string.Join(" ", arr));
//// Change the array by reversing its elements.
//static void ChangeArrayInt(int[] arr) => Array.Reverse(arr);
//static void ChangeArrayElementsInt(int[] arr)
//{
//    // Change the value of the first three array elements.
//    arr[0] = 8;
//    arr[1] = 9;
//    arr[2] = 10;
//}

//// Declare and initialize an array.
//int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };

//// Display the array elements.
//DisplayArrayInt(numbers);
//Console.WriteLine();
//// Reverse the array.
//ChangeArrayInt(numbers);
//// Display the array again to verify that it stays reversed.
//Console.WriteLine("Array weekDays after the call to ChangeArray:");
//DisplayArrayInt(numbers);
//Console.WriteLine();
//// Assign new values to individual array elements.
//ChangeArrayElementsInt(numbers);
//// Display the array again to verify that it has changed.
//Console.WriteLine("Array weekDays after the call to ChangeArrayElements:");
//DisplayArrayInt(numbers);


////Приклад2
//void Increment(int n)
//{
//    n++;
//    Console.WriteLine($"Число в методе Increment: {n}");
//}
//int number = 5;
//Console.WriteLine($"Число до метода Increment: {number}");
//Increment(number);
//Console.WriteLine($"Число после метода Increment: {number}");


////Приклад3
//string s1 = "hello";
//string s2 = new String('a', 6);
//string s3 = new String(new char[] { 'w', 'o', 'r', 'l', 'd' });
//string s4 = new String(new char[] { 'w', 'o', 'r', 'l', 'd' }, 1, 3);
//Console.WriteLine(s1);  // hello
//Console.WriteLine(s2);  // aaaaaaa
//Console.WriteLine(s3);  // world
//Console.WriteLine(s4);  // orl


////Приклад4
//string message = "hello";
//char firstChar = message[1];
//Console.WriteLine(firstChar);

//for (var i = 0; i < message.Length; i++)
//{
//    Console.WriteLine(message[i]);
//}
//foreach (var ch in message)
//{
//    Console.WriteLine(ch);
//}


////Приклад5
//string message1 = "hello";
//string message2 = "hello";
//Console.WriteLine(message1 == message2);


////Приклад6
//string s1 = "hello";
//string s2 = "world";
//string s3 = s1 + " " + s2;
//string s4 = string.Concat(s3, "!!!");
//Console.WriteLine(s4);


////Приклад7
//string s5 = "apple";
//string s6 = "a day";
//string s7 = "keeps";
//string s8 = "a doctor";
//string s9 = "away";
//string[] values = new string[] { s5, s6, s7, s8, s9 };
//string s10 = string.Join(" ", values);
//Console.WriteLine(s10);


////Приклад8
//string s1 = "hello";
//string s2 = "world";
//int result = string.Compare(s1, s2);
//if (result < 0)
//{
//    Console.WriteLine("String s1 before string s2");
//}
//else if (result > 0)
//{
//    Console.WriteLine("String s1 is after string s2");
//}
//else
//{
//    Console.WriteLine("Strings s1 and s2 are identical");
//}


////Приклад9
//string s1 = "hello world";

//char ch = 'o';
//int indexOfChar = s1.IndexOf(ch);
//Console.WriteLine(indexOfChar);

//string substring = "wor";
//int indexOfSubstring = s1.IndexOf(substring);
//Console.WriteLine(indexOfSubstring);


////Приклад10
//var files = new string[]
//{
//    "myapp.exe",
//    "forest.jpg",
//    "main.exe",
//    "book.pdf",
//    "river.png"
//};

//for (int i = 0; i < files.Length; i++)
//{
//    if (files[i].EndsWith(".exe"))
//        Console.WriteLine(files[i]);
//}

//for (int i = 0; i < files.Length; i++)
//{
//    if (files[i].StartsWith("main"))
//        Console.WriteLine(files[i]);
//}


////Приклад11
//string text = "And thus all happened in such manner";
//string[] words = text.Split(new char[] { ' ' });
//foreach (string s in words)
//{
//    Console.WriteLine(s);
//}


////Приклад12
//string text = "And thus all happened in such manner, And thus all happened in such manner";
//string[] words = text.Split(new char[] { ','});
//foreach (string s in words)
//{
//    Console.WriteLine(s);
//}


////Приклад13
//string text = "And thus all happened in such manner, And thus all happened in such manner";
//string[] words = text.Split(new char[] { ',', ' ' });
//foreach (string s in words)
//{
//    Console.WriteLine(s);
//}


////Приклад14
//using System.Text;
//StringBuilder sb = new StringBuilder();

//var sb1 = new StringBuilder("Hello World");
//Console.WriteLine(sb1.ToString());

//StringBuilder sb2 = new StringBuilder("Hello World");
//Console.WriteLine($"Length: {sb2.Length}");       // Довжина: 10
//Console.WriteLine($"Capacity: {sb2.Capacity}");    // Ємність

//var sb3 = new StringBuilder("Hello world");
//sb3.Append("!");
//sb3.Insert (11, "computer");
//Console.WriteLine(sb3);

//sb1.Replace("world", "universe");
//Console.WriteLine(sb1);

//sb1.Remove(7, 13);
//Console.WriteLine(sb1);
string str = "The quick brown fox jumps over the lazy dog.";
int number = 0;
number =str.Count(c => c == 'e');
Console.WriteLine($"The letter e appeared {number} times");

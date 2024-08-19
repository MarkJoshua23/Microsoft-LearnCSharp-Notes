string str = "The quick brown fox jumps over the lazy dog.";
int number = 0;
char[] charMessage = str.ToCharArray();
foreach (char c in charMessage){
    if (c == 'e'){
        number++;
    }
}
Console.WriteLine($"The letter e appeared {number} times");

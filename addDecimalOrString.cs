//add if decimal, concat if string
string[] values = ["12.3", "45", "ABC", "11", "DEF"];
decimal total = 0;
string letters = "";
foreach(string value in values){
    decimal numbers = 0;
    if(decimal.TryParse(value, out numbers)){
        total += numbers;
    }else{
        letters+=value;
    }
}
Console.WriteLine($"Letters: {letters}");
Console.WriteLine($"Numbers: {total}");

//orders are error if id length is not 4
string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string []split = orderStream.Split(",");
foreach(string s in split){
    if(s.Length != 4){
        Console.WriteLine($"{s}  - Error");
    } else{
        Console.WriteLine(s);
    }
}

for(int i = 1; i <= 100; i++){
    if(i % 3 == 0 && i % 5 == 0){
        Console.WriteLine($"{i} FizzBuzz");
    }else if(i % 3 ==0){
        Console.WriteLine($"{i} Fizz");
    }else if(i % 5 == 0){
        Console.WriteLine($"{i} Buzz");
    }else{
        Console.WriteLine(i);
    }
}

// second way
var map = new Dictionary<int, string>(){
    {3, "Fizz"},
    {5, "Buzz"},
    {7, "Bazz"},
};
for(int i = 1; i <= 100; i++){
    string output ="";
    foreach(var key in map){
        if(i % key.Key==0 ){
            output += key.Value;
        }
    }
    Console.WriteLine(string.IsNullOrEmpty(output) ? i.ToString() : output);
}

//reverse each word

string pangram = "The quick brown fox jumps over the lazy dog";
// expected output: ehT kciuq nworb xof spmuj revo eht yzal god
string[] split =  pangram.Split(' ');
string[]reversed = new string[split.Length];

for(int i=0;i<split.Length;i++){
    char []temp= split[i].ToCharArray();
    Array.Reverse(temp);
    reversed[i] = new string(temp);
}

string output =  String.Join(" ",reversed);
Console.WriteLine(output);

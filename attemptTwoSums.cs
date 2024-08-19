int [] numbers = [1,5,8,2,3];
List<int> finalNumbers = new List<int> ();
int target = 13;
foreach (int number in numbers) {
    for(int i=1; i<numbers.Length; i++) {
        if (number + numbers[i] == target){
            finalNumbers.Add (number);
            finalNumbers.Add(numbers[i]);
        }
    }
}
foreach (int number in finalNumbers) {
    Console.WriteLine (number);
}

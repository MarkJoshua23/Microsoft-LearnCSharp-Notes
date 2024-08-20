//reversing array using two pointers

int [] numbers = [1,2,3,4,5,6,7];
int pointer1 = 0;
int pointer2 = numbers.Length -1;

foreach(int num in numbers) {
    Console.WriteLine(num);
} 

while (pointer1 < pointer2) {
    int tempHolder = numbers[pointer1];
    numbers[pointer1] = numbers[pointer2];
    numbers[pointer2] = tempHolder;
    pointer1++;
    pointer2--;
}

foreach(int num in numbers) {
    Console.WriteLine(num);
}

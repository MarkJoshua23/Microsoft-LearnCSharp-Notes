// sum of all numbers from index 3 to 5
// using prefixsum

int [] numbers = [1,2,3,4,5,6,7];
int [] prefixSum = new int[numbers.Length];
int startIndex = 3;
int endIndex= 5;

prefixSum[0] = numbers[0];
for (int i = 1; i < numbers.Length; i++) {
    //currentIndex = previousindex + currentNumbersIndex
    prefixSum[i] = prefixSum[i-1]+numbers[i];
} // 1,3,6,10,15,21,28
//index 5 is 21
//minus the sum of numbers before the startIndex
int sum = prefixSum[endIndex] - prefixSum[startIndex-1];
Console.WriteLine(sum);

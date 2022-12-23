int[] numbers = {0, 7, 8, -2, -3};
int result = 0;
foreach (int number in numbers){
    if (number > 0){
        result++;
    }
}
Console.WriteLine($"count of numbers many null: {result}" );

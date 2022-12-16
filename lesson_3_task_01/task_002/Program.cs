int a = 452;
int sum = 0;

for (int i = a; i > 0; i = i / 10){
    sum = sum + i % 10;
}

Console.WriteLine(sum);
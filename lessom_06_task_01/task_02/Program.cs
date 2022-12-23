Console.WriteLine("input k1: ");
var k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("input b1: ");
var b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("input k2: ");
var k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("input b2: ");
var b2 = Convert.ToDouble(Console.ReadLine());

var x = -(b1 - b2) / (k1 - k2);
var y = k1 * x + b1;

x = Math.Round(x, 3);
y = Math.Round(y, 3);

Console.WriteLine($"across in point ({x};{y})");
Console.WriteLine("## Nullable Types ##\n");

int? i = null;
double? j = null;
bool? k = null;

Console.WriteLine(i);
Console.WriteLine(j);
Console.WriteLine(k);

int? a = null;
int b = a ?? 0;

Console.WriteLine(b);

int? x = 4;
int? y = 3;
int? z = x * y;

Console.WriteLine(z);

int? c = null;

if (c.HasValue)
{
    Console.WriteLine(c.Value);
}
else
{
    Console.WriteLine("c não possui um valor");
}
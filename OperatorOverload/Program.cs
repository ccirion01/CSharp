using OperatorOverload;

Calculator calc1 = new Calculator(100);
Calculator calc2 = new Calculator(50);

Calculator calc3 = calc1 + calc2;
Console.WriteLine("The calculator result is:");
calc3.Display();

////////////////////////////////////////
IncrementOverload unaryOverload = new IncrementOverload(100);
unaryOverload++;
Console.WriteLine("The increment overload result is:");
unaryOverload.Display();

////////////////////////////////////////
NegationOverload negationOverload = null;
Console.WriteLine("Negation overload:");

if (!negationOverload)
{
    Console.WriteLine("Object is null");
}
else
{
    Console.WriteLine("Object is not null");
}

negationOverload = new NegationOverload(100);
Console.WriteLine("Positive overload:");

if (+negationOverload)
{
    Console.WriteLine("Object is not null");
}
else
{
    Console.WriteLine("Object is null");
}
/* Instead of doing if (obj == null), you can do if (!obj) */

////////////////////////////////////////
EqualityOverload equalityOverload = new EqualityOverload(100);
EqualityOverload equalityOverload2 = new EqualityOverload(50);

bool areEqual = equalityOverload == equalityOverload2;
bool areDifferent = equalityOverload != equalityOverload2;

Console.WriteLine($"They are equal: {areEqual}");
Console.WriteLine($"They are different: {areDifferent}");
areEqual = equalityOverload.Equals(equalityOverload2);
Console.WriteLine($"They are equal based on Equals() method: {areEqual}");
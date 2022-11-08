using IEnumerator_IEnumerable;

List<string> months = new List<string>();
months.Add("January");
months.Add("February");
months.Add("March");
months.Add("April");
months.Add("May");
months.Add("June");
months.Add("July");
months.Add("August");
months.Add("September");
months.Add("October");
months.Add("November");
months.Add("December");

//create IEnumerable of string
IEnumerable<string> ienumerable = (IEnumerable<string>)months;

//If we want to retrieve all the items from this IEnumerable object, we can use a foreach loop.
//foreach (string month in ienumerable)
//{
//    Console.WriteLine(month);
//}

//Create IEnumerator of string by invoking the GetEnumerator() method.
IEnumerator<string> ienumerator = months.GetEnumerator();

//To retrieve all the items from the above IEnumerator object, we cannot use foreach loop. Instead of that we need to invoke MoveNext() Boolean method.  
//while (ienumerator.MoveNext())
//{
//    Console.WriteLine(ienumerator.Current);
//}

//Differences

void IEnumeratorMethodOne(IEnumerator<string> i)
{
    while (i.MoveNext())
    {
        Console.WriteLine(i.Current);

        if (i.Current == "June")
        {
            IEnumeratorMethodTwo(i);
        }
    }
}

void IEnumeratorMethodTwo(IEnumerator<string> i)
{
    while (i.MoveNext())
    {
        Console.WriteLine(i.Current);
    }
}

//IEnumeratorMethodOne(ienumerator);

//Example video
var infinite_enumerable = new MyInfiniteEnumerable();
foreach (int i in infinite_enumerable)
{
    Console.WriteLine($"I is {i}");
}

var infinite_enumerator = infinite_enumerable.GetEnumerator();
while (infinite_enumerator.MoveNext())
{
    Console.WriteLine($"I is {infinite_enumerator.Current}");
}

var infinite_enumerable2 = new MyInfiniteEnumerable();
foreach (int i in infinite_enumerable)
{
    Console.WriteLine($"I is {i}");
}
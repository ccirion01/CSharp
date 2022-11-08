namespace Delegates
{
    public class AnonymousMethodTest
    {
        private delegate void TestDelegate();

        private TestDelegate Test;

        private void Start()
        {
            Test = delegate () { Console.WriteLine("Anonymous delegate function"); };
            Test();
        }
    }
}

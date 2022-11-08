namespace Delegates
{
    public class LambdaTest
    {
        private delegate void TestVoidDelegate();
        private TestVoidDelegate VoidLambda;

        private delegate bool TestBoolDelegate(int i);
        private TestBoolDelegate BoolLambda;

        private void Start()
        {
            VoidLambda = () => { Console.WriteLine("Void lambda delegate"); };
            VoidLambda();

            //If it takes only one argument, the parenthesis are optional
            //If the body is only one line long, we can omit the brackets and the "return" keyword
            BoolLambda = i => i > 5;
            BoolLambda(1);
        }
    }
}

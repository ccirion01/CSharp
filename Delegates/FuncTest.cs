namespace Delegates
{
    public class FuncTest
    {
        private Func<bool> Func;
        private Func<int, bool> Func2;

        private void Start()
        {
            Func = () => { return false; };
            Func2 = (int i) => { return i < 5; };
        }
    }
}

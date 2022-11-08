namespace Delegates
{
    public class ActionTest
    {
        private Action Action;
        private Action<int, float> ActionIntFloat;

        private void Start()
        {
            Action = () => { Console.WriteLine("Test action"); };
            ActionIntFloat = (int i, float f) => { Console.WriteLine("Test int float action"); };
        }
    }
}

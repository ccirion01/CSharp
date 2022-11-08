namespace Delegates
{
    public class PredicateTest
    {
        private Predicate<string> Predicate;

        public PredicateTest()
        {
            Predicate = @string => @string.Length > 5;
            Predicate("test");
        }
    }
}

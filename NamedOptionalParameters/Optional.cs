namespace NamedOptionalParameters
{
    public enum XEnum
    {
        Value1
    }

    public class Optional
    {
        public static void ExampleMethod(
            int required,
            string optionalStr = "default string",
            XEnum optionalEnum = new(),
            XEnum optionalEnum2 = default(XEnum))
        {

        }
    }
}

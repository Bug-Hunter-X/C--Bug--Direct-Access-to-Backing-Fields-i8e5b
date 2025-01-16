public class ExampleClass{
    private int _value;

    public int Value
    {
        get { return _value; }
        set
        {
            // Add any validation or side effects here before updating the field
            if (value < 0)
            {
                throw new ArgumentException("Value cannot be negative.");
            }
            _value = value;
        }
    }

    public void ExampleMethod()
    {
        int x = Value; // Accessing the property (Correct way)
        //int y = _value; // Accessing the backing field directly (Incorrect)
    }
}
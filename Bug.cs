public class ExampleClass{
    private int _value;

    public int Value
    {
        get { return _value; }
        set { _value = value; }
    }

    public void ExampleMethod()
    {
        int x = Value; // Accessing the property
        int y = _value; // Accessing the backing field directly
    }
}
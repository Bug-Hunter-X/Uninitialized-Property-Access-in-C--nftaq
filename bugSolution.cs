public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Initialize MyProperty before accessing it
        MyProperty = 0; // Or some default value
        int value = MyProperty; 
    }
}
using CallStackExceptionHandlingLib; // To use Processor.
using static System.Console;

WriteLine("In Main");
Alpha();

void Alpha()
{
    WriteLine("In Alpha");
    Beta();
}

void Beta()
{
    try
    {
        WriteLine("In Beta");
        Processor.Gamma();
    }
    catch (Exception ex)
    {
        WriteLine($"Caught this: {ex.Message}");
        //throw ex; // Acts as if the exception happened in Beta.
        //throw; // This on the other hand includes all the information of the call stack.

        // This is the best way to throw an exception as it is like throw + a personalized message.
        throw new Exception("Something went wrong in Beta", ex);
    }
}
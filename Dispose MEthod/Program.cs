class Demo : IDisposable
{
    private bool _disposed=false;
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
        GC.SuppressFinalize(_disposed);
    }

    private void Dispose(bool v)
    {
        if (!_disposed)
        {
            if (_disposed)
            {//clean up managed objects

            }
            // Clean up Unmanaged objects
            _disposed=true;
        }       
    }
}
class Program
{
    static void Main()
    {
        Console.ReadLine();
    }
}
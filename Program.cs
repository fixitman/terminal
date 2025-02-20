using terminal;
using Terminal.Gui;

Application.Init();

try
{
    Console.WriteLine("starting");
    Application.Run(new MyView());
    Console.WriteLine("ending");

}
catch(Exception e)
{
    Console.WriteLine($"Exception caught: {e.Message}");
}
finally
{
    
    Console.WriteLine("shutting down");
    //Application.Shutdown();
}
using ConsoleApp1;

internal class Bistro : ILugar
{
    public Bistro()
    {
    }

    public Cafe FazerCafe()
    {
        return new Cafe();
    }
}
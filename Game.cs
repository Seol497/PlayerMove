namespace PlayerMove
{
    internal class Game
    {
        static void Main(string[] args)
        {
            Engine myEngine = new Engine();
            myEngine.Init();
            myEngine.Run();
        }
    }
}
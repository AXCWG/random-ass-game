namespace 文字游戏;

class Program
{
    static void Main(string[] args)
    {
        Thread 标题 = new Thread(() =>
        {
            Console.Clear();
            Thread.Sleep(100);
            Console.Write("文");
            Thread.Sleep(100);
            Console.Write("字");
            Thread.Sleep(100);
            Console.Write("游");
            Thread.Sleep(100);
            Console.WriteLine("戏");
            Thread.Sleep(500);
            Console.WriteLine("v0.1a");
            Thread.Sleep(500);
            
        });
        标题.Start();
    }
}
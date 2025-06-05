using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Main thread started.");

        Thread t1 = new Thread(() =>
        {
            Console.WriteLine("t1 started.");
            Thread t2 = new Thread(() =>
            {
                Console.WriteLine("t2 started.");
                try
                {
                    Thread.Sleep(5000);
                    Console.WriteLine("t2 completed.");
                }
                catch (ThreadInterruptedException)
                {
                    Console.WriteLine("t2 interrupted.");
                }
            });
        
            t2.Start();

            try
            {
                Thread.Sleep(2000);
                Console.WriteLine("t1 completed.");
            }
            catch (ThreadInterruptedException)
            {
                Console.WriteLine("t1 interrupted.");
            }
        });

        // Khởi động và ngắt t1 sau 1 giây
        t1.Start();
        Thread.Sleep(1000);
        t1.Interrupt(); // Ngắt t1

        // Giả lập main thread chạy một lúc rồi ngắt
        Thread.Sleep(1000); // Main thread chạy 1 giây
        Console.WriteLine("Main thread exiting...");
        // Environment.Exit(0); // Nếu uncomment dòng này, toàn bộ tiến trình sẽ ngắt
    }
}
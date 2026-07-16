using System;
using System.Threading.Tasks;

class ASYNC
{
    static async Task Main()
    {
        int result = await AddAsync(5, 3);

        Console.WriteLine(result);
    }

    static async Task<int> AddAsync(int a, int b)
    {
        await Task.Delay(1000); 
        return a + b;
    }
}
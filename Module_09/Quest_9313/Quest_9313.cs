using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_09.Quest_9313;

class Quest_9313
{

    delegate int RandomNumberDelegate();

    internal static void Run()
    {
        //RandomNumberDelegate randomNumberDelegate = RandomNumber;
        RandomNumberDelegate randomNumberDelegate = () => new Random().Next(0, 100);
        int result = randomNumberDelegate.Invoke();
        Console.WriteLine(result);
        Console.Read();
    }

    static int RandomNumber()
    {
        return new Random().Next(0, 100);
    }
}

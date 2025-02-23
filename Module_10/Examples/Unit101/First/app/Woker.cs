using Module_10.Examples.Unit101.First.app.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_10.Examples.Unit101.First.app
{
    internal class Woker : IWoker
    {

        internal required string Name { get; set; }

        internal ILogger Logger {get;}

        internal Woker( ILogger logger )
        {
            Logger = logger;
        }

        public void Work()
        {
            Logger.Event($"{Name} начал выполнение работы");
            Thread.Sleep(new TimeSpan(0, 0, 5));
            Logger.Event($"{Name} закончил выполнение работы");
        }
    }
}

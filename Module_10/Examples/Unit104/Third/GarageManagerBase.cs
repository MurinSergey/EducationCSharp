using Module_10.Examples.Unit104.Third.Building;
using Module_10.Examples.Unit104.Third.Interface;
using Module_10.Examples.Unit104.Third.Transport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_10.Examples.Unit104.Third
{
    class GarageManagerBase : IGarageManager<Car, Garage>
    {
        public void Add(Car transport)
        {
            throw new NotImplementedException();
        }

        public Garage GetInfo()
        {
            throw new NotImplementedException();
        }
    }
}

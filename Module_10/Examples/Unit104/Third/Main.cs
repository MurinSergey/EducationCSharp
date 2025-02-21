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
    class Main
    {
        internal static void Run()
        {
            /*
             * Базовая реализация
             * Все типы совпадают
             */
            IGarageManager<Car, Garage> garageManager = new GarageManagerBase();

            /*
             * Контрвариативность
             * В ожадаемый параметр in Bike мы можем передать объект Car, т.е. в специфичный тип передается более универсальный (в дочерный передается родительский)
             */
            IGarageManager<Bike, Garage> garageManager1 = new GarageManagerBase();

            /*
             * Ковариативность
             * В ожидаемый параметр out Parking мы можем передать объект Garage, т.е. в более универсальный тип передается более специфичный (в родитеский передается дочерний)
             */
            IGarageManager<Car, Parking> garageManager2 = new GarageManagerBase();

            /*
             * Контрвариативность и Ковариативность
             */
            IGarageManager<Bike, Parking> garageManager3 = new GarageManagerBase();

        }
    }
}

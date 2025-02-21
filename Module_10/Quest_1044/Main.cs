using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_10.Quest_1044
{
    class Main
    {
        internal static void Run()
        {

            IUpdater<User> updaterUser = new UserService();
            updaterUser.Update(new User());

            /*
             * Контрвариантность
             * Класс UserService оперирует универсальным типом User, но его можно положить в переменную более специфичного вида Account
             */
            IUpdater<Account> updaterAccount = new UserService();
            updaterAccount.Update(new Account());
        }
    }
}

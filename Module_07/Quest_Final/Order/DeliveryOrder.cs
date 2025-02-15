using Module_07.Quest_Final.Delivery;
using Module_07.Quest_Final.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Module_07.Quest_Final.Order
{
    public class DeliveryOrder<TDelivery> : Order where TDelivery : Delivery.Delivery 
    {
        /// <summary>
        /// Доставка для текущего заказа
        /// </summary>
        private TDelivery _delivery;

        public DeliveryOrder(TDelivery delivery, List<Product.Product> products) : base(products)
        {
            _delivery = delivery;
        }

        public override void PrintOrderInfo()
        {
            base.PrintOrderInfo();
            _delivery.PrintInfo();
        }

        public override void Run()
        {
            _delivery.Run();
        }
    }
}

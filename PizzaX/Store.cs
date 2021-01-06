using System;
using static com.pizzaworld.Orders.Order;
namespace com.pizzaworld.Orders
{
    public partial class Stores
    {
        private int StoreNo;
        private string Address;
        private static Stores[] _stores = new Stores[48];
        public static void Main(string[] arg)
        {
            //if (arg[0].compare("/s"))
            //{

            //}
            // else if (arg[0].compare("/f"){

            //}
            Stores store = new Stores("temp", 9999);
            Pizza.OnLoaded();
            Stores.OnCreated();
            store.processOrders(99U);
        }
        public void processOrders(uint unitno)
        {
            Order order = acceptOrder(unitno);
        }
        public Order acceptOrder(uint unitno)
        {
            Order order = Order.build(unitno);
            return order;
        }
        public static string[] getStores()
        {
            return new string[] { _stores[0].Address, _stores[1].Address };
        }
        public Stores(string arg0, short arg1)
        {
            this.Address = arg0;
            this.StoreNo = arg1;
        }
        public static void OnCreated()
        {
            _stores[0] = new Stores("11150 Research Blvd, Austin,TX 78759", 1);
            _stores[1] = new Stores("13764 Research Blvd.,Austin, TX", 1);
            _stores[2] = new Stores("2051 Cypress Creek Rd, Austin,TX", 2);
            _stores[3] = new Stores("13201 Pond Springs Rd.,Austin,TX", 3);
            _stores[4] = new Stores("13764 Research Blvd.,Austin, TX", 4);
        }
    }
}

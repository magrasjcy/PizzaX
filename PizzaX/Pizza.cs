using static com.pizzaworld.Orders.Topping;
using System;
//using ArgumentOutOfRangeException;
namespace  com.pizzaworld.Orders {
    public class Pizza {
        //  public   enum Topping : int { artichokes, anchovies, chicken, green_peppers, mushrooms, pepporoni, red_peppers };
       
        private static Pizza[] _pizza = new Pizza[48];
       private double _unitcost { get; set; }
        private static uint flag = 0;

        private uint crust;
       private uint _count { get; set; }
       private uint size;
       private Topping[] toppings;
       public Pizza( uint size, uint count,uint crust,Topping[] toppings, double cost) {
	      this.size=size;
	       this._count=count;
           this.crust = crust;
           this.toppings = toppings;
            this._unitcost = cost;
       }
        public uint getCount() { return this._count; }
        public double getUnitCost() {
            return this._unitcost;
        }
        public static double getpizzacost(uint arg0)
        {
            if (Pizza.flag==0) { ++Pizza.flag; Pizza.OnLoaded(); }
            if (arg0 < 24) return _pizza[arg0]._unitcost;
            else return 5.00;//throw new ArgumentOutOfRangeException();
        }
        public static Topping[] getToppings(uint arg0)
        {
            if (arg0 < 24)
                return new Topping[] { _pizza[arg0].toppings[0] };
            else return new Topping[0];
        }
        public static void print()
        {
            uint indx = 0;
            for(indx=0;indx<_pizza.Length-1;indx++)
            {
                if (indx<24) Console.WriteLine((indx+1)+" "+_pizza[indx].toString());
            }
        }
        static public void OnLoaded()
        {
          //  artichokes, anchovies, chicken, green_peppers, mushrooms, pepporoni, red_peppers };
        _pizza[0] = new Pizza(1, 1, 1,  new Topping[]{ Topping.artichokes }, 6.75d);
            _pizza[1] = new Pizza(2, 1, 1, new Topping[] { Topping.artichokes }, 8.75d);
            _pizza[2] = new Pizza(3, 1, 1, new Topping[] { Topping.artichokes }, 11.75d);
            _pizza[3] = new Pizza(1, 1, 2, new Topping[] { Topping.artichokes }, 6.75d);
            _pizza[4] = new Pizza(2, 1, 2, new Topping[] { Topping.artichokes }, 8.75d);
            _pizza[5] = new Pizza(3, 1, 2, new Topping[] { Topping.artichokes }, 11.75d);
            _pizza[6] = new Pizza(1, 1, 1, new Topping[] { Topping.anchovies}, 6.75d);
            _pizza[7] = new Pizza(2, 1, 1, new Topping[] { Topping.anchovies}, 8.75d);
            _pizza[8] = new Pizza(3, 1, 1, new Topping[] { Topping.anchovies }, 11.75d);
            _pizza[9] = new Pizza(1, 1, 2, new Topping[] { Topping.anchovies }, 6.75d);
            _pizza[10] = new Pizza(2, 1, 2, new Topping[] { Topping.anchovies  }, 8.75d);
            _pizza[11] = new Pizza(3, 1, 2, new Topping[] { Topping.anchovies }, 11.75d);
            _pizza[12] = new Pizza(1, 1, 1, new Topping[] { Topping.chicken }, 6.75d);
            _pizza[13] = new Pizza(2, 1, 1, new Topping[] { Topping.chicken  }, 8.75d);
            _pizza[14] = new Pizza(3, 1, 1, new Topping[] { Topping.chicken }, 11.75d);
            _pizza[15] = new Pizza(1, 1, 2, new Topping[] { Topping.chicken }, 6.75d);
            _pizza[16] = new Pizza(2, 1, 2, new Topping[] { Topping.chicken  }, 8.75d);
            _pizza[17] = new Pizza(3, 1, 2, new Topping[] { Topping.chicken }, 11.75d);
            _pizza[18] = new Pizza(1, 1, 1, new Topping[] { Topping.green_peppers }, 6.75d);
            _pizza[19] = new Pizza(2, 1, 1, new Topping[] { Topping.green_peppers  }, 8.75d);
            _pizza[20] = new Pizza(3, 1, 1, new Topping[] { Topping.green_peppers  }, 11.75d);
            _pizza[21] = new Pizza(1, 1, 2, new Topping[] { Topping.green_peppers  }, 6.75d);
            _pizza[22] = new Pizza(2, 1, 2, new Topping[] { Topping.green_peppers  }, 8.75d);
            _pizza[23] = new Pizza(3, 1, 2, new Topping[] { Topping.green_peppers   }, 11.75d);
        }
        public string toString()
        {
            string[] sizes = {"small","medium","large"};
            string[] crusts = { "thick", "medium", "thin" };
            string message = this._count +" "+ sizes[this.size-1]+" "+crusts[this.crust]+" "+this.toppings[0]+" pizza $"+this._unitcost;
            return message;
        }
    }
}

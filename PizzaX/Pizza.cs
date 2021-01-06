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
        private Topping[] halfToppings;
        private double _extracost { get; set; }
       public Pizza( uint size, uint count,uint crust,Topping[] toppings,Topping[] halfToppings, double cost,double extracost) {
	      this.size=size;
	       this._count=count;
           this.crust = crust;
           this.toppings = toppings;
            this._extracost = extracost;
            this._unitcost = cost;
            this.halfToppings = halfToppings;
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
        _pizza[0] = new Pizza(1, 1, 1,  new Topping[]{ Topping.artichokes },null, 6.75d,0);
            _pizza[1] = new Pizza(2, 1, 1, new Topping[] { Topping.artichokes }, null, 8.75d,0);
            _pizza[2] = new Pizza(3, 1, 1, new Topping[] { Topping.artichokes }, null, 11.75d,0);
            _pizza[3] = new Pizza(1, 1, 2, new Topping[] { Topping.artichokes }, null, 6.75d,0);
            _pizza[4] = new Pizza(2, 1, 2, new Topping[] { Topping.artichokes }, null, 8.75d,0);
            _pizza[5] = new Pizza(3, 1, 2, new Topping[] { Topping.artichokes }, null, 11.75d,0);
            _pizza[6] = new Pizza(1, 1, 1, new Topping[] { Topping.anchovies}, null, 6.75d,0);
            _pizza[7] = new Pizza(2, 1, 1, new Topping[] { Topping.anchovies}, null, 8.75d,0);
            _pizza[8] = new Pizza(3, 1, 1, new Topping[] { Topping.anchovies }, null, 11.75d,0);
            _pizza[9] = new Pizza(1, 1, 2, new Topping[] { Topping.anchovies }, null, 6.75d,0);
            _pizza[10] = new Pizza(2, 1, 2, new Topping[] { Topping.anchovies  }, null, 8.75d,0);
            _pizza[11] = new Pizza(3, 1, 2, new Topping[] { Topping.anchovies }, null, 11.75d,0);
            _pizza[12] = new Pizza(1, 1, 1, new Topping[] { Topping.chicken }, null, 6.75d,0);
            _pizza[13] = new Pizza(2, 1, 1, new Topping[] { Topping.chicken  }, null, 8.75d,0);
            _pizza[14] = new Pizza(3, 1, 1, new Topping[] { Topping.chicken }, null, 11.75d,0);
            _pizza[15] = new Pizza(1, 1, 2, new Topping[] { Topping.chicken }, null, 6.75d,0);
            _pizza[16] = new Pizza(2, 1, 2, new Topping[] { Topping.chicken }, null, 6.75d, 0);
            _pizza[17] = new Pizza(3, 1, 2, new Topping[] { Topping.chicken },null, 6.75d,0);
            _pizza[18] = new Pizza(1, 1, 1, new Topping[] { Topping.green_peppers },null, 6.75d,0);
            _pizza[19] = new Pizza(2, 1, 1, new Topping[] { Topping.green_peppers  },null, 8.75d,0);
            _pizza[20] = new Pizza(3, 1, 1, new Topping[] { Topping.green_peppers  },null, 11.75d,0);
            _pizza[21] = new Pizza(1, 1, 2, new Topping[] { Topping.green_peppers  },null, 6.75d,0);
            _pizza[22] = new Pizza(2, 1, 2, new Topping[] { Topping.green_peppers  },null, 8.75d,0);
            _pizza[23] = new Pizza(3, 1, 2, new Topping[] { Topping.green_peppers   },null, 11.75d,0);
        }
        public string toString()
        {
            
            string[] sizes = {"small","medium","large"};
            string[] crusts = { "thick", "medium", "thin" };
            string message = this._count + " " + sizes[this.size - 1] + " ";
            message +=crusts[this.crust]+" "+this.toppings[0]+" pizza $"+this._unitcost+this._extracost;
            return message;
        }
    }
}

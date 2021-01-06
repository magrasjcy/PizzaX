using NUnit.Framework;


namespace com.pizzaworld.Orders//PizzaX.Test
{
    public class Tests
    {
        private com.pizzaworld.Orders.Pizza[] _pizza;

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            com.pizzaworld.Orders.Topping topping = Topping.anchovies;
            com.pizzaworld.Orders.Pizza[] _pizza=new Pizza[3];
            _pizza[0]= new Pizza( 1, 1, 1, new Topping[] { Topping.anchovies },null, 6.75d ,0);
            _pizza[1] = new Pizza(3, 1, 3, new Topping[] { Topping.red_peppers, Topping.chicken },null, 9.00d,0);
            _pizza[2] = new Pizza(2, 1, 3, new Topping[] 
                { Topping.artichokes, Topping.green_peppers, Topping.mushrooms },null, 11.00d,0);
            Assert.Pass();
        }
        [Test]
        public void Test2()
        {
            com.pizzaworld.Orders.Topping topping = Topping.anchovies;
            com.pizzaworld.Orders.Pizza[] _pizza = new Pizza[3];
            _pizza[0] = new Pizza(1, 1, 1, new Topping[] { Topping.anchovies },null, 6.75d,0);
            _pizza[1] = new Pizza(3, 1, 3, new Topping[] { Topping.red_peppers, Topping.chicken },null, 9.00d,0);
            _pizza[2] = new Pizza(2, 1, 3, new Topping[]
                { Topping.artichokes, Topping.green_peppers, Topping.mushrooms },null, 11.00d,0);
            Pizza[] bill = new Pizza[3];
            bill[0] = new Pizza(2, 1, 3, new Topping[]
                 { Topping.artichokes, Topping.green_peppers, Topping.mushrooms },null, 11.00d,0);
            Order x= new  Order("Jake", "8420 Bozo, Austin,Tx", "3530493048340", 50.0d, bill
                 );
           // Order y= new public Order(string arg0, string arg1, string arg2, float arg3, Pizza[] arg4);
        }
    }
}
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
//using sqlcollection.sqlcollection;
using System.Data;

namespace com.pizzaworld.Orders
{
   public partial class Order {
		//	   public static JsonValue Parse(string jsonString)
		//public  interface InputFacetI {
		//   public string  getInput();
		//}
		private double _extracost = 0;
		private Topping[] halfTopping = new Topping[12];
		private Topping[] fullTopping = new Topping[12];
		private int htIndx = 0, ftIndx = 0;
		static class X
        {

        }
       public void getInput() {    
	    int index,sizeNo,countNo;
		double totalCost = 0D;
	
		string storeInput,userInput;
	    string input,finInput=" ";
		
		string sizeInput,countInput,pizzaInput,exTopInput=" ";
		do {
			Console.WriteLine("Enter your username:");
			userInput = Console.ReadLine();
		} while (userInput.Length == 0);
		string[] nearstores = Stores.getStores();

		do {
			for (int StoreNdx = 0; StoreNdx < nearstores.Length; StoreNdx++)
				{
					Console.WriteLine(StoreNdx+" "+nearstores[StoreNdx]);
				}
	        Console.WriteLine("Choose a location near you?");
	        storeInput=Console.ReadLine();
	    } while (storeInput[0]<'0' && storeInput[0]>'9') ;
		    
            do {
		if (finInput[0]=='D') {
					int delIndx = 1; uint udelIndx = 1;
		    for (udelIndx=1;udelIndx<this.arrayIdx;udelIndx++)  {
			    Console.WriteLine(udelIndx+" "+this.items[udelIndx-1]);
		    }
	            Console.WriteLine("which index pizza would you remove?");
                    input=Console.ReadLine();
                    Int32.TryParse(input,out delIndx);
					if(delIndx > 0)
					{
						totalCost -= this.items[delIndx].getUnitCost() * this.items[delIndx].getCount();
						for (udelIndx = (uint)delIndx; udelIndx <this.arrayIdx; udelIndx++) {
							this.items[udelIndx + 1] = this.items[udelIndx];
						}
						this.arrayIdx--;
						
					}
		}
				Pizza.print();
				do
				{
					Console.WriteLine("what pizza would you like? Extra Toppings below");
					input = Console.ReadLine();
					Int32.TryParse(input, out index);
				} while (index < 0 && index > 24);
				//do {
				//	Console.WriteLine("3=Thick,2=Medium,1=Thin");
				//	Console.WriteLine("what size pizza would you like?");

				//	sizeInput = Console.ReadLine();
				//	Int32.TryParse(sizeInput, out sizeNo);
				//} while (sizeNo<0 && sizeNo>3 );

				int parseOffset;
				do {
					int toppingIndx = 0;
					parseOffset = 2;
					for (;parseOffset< exTopInput.Length - 1; parseOffset += 2)
					{
						if (exTopInput[0] != 'H')
						{
							halfTopping[htIndx++] =(Topping)exTopInput[2 + parseOffset];
							this._extracost += 0.75D;
						}
						else if (exTopInput[0] != 'F')
						{
							fullTopping[ftIndx++] = (Topping)exTopInput[2 + parseOffset];
							this._extracost += 1.10D;
						}
					}
					Console.WriteLine("How many pizzas of this type & size would you like?");
					Console.WriteLine("Half Topping is $0.75, full is $1.10: specify multiple but all must be half or full");
					foreach (string topping in Enum.GetNames(typeof(Topping)))
					{
						Console.WriteLine(toppingIndx+" "+topping);toppingIndx++;
					}
					toppingIndx = 0;
					Console.WriteLine("A half pizza of extra topping, full extra topping, or None?(H/F/N) topping numbers using spaces");
					exTopInput = Console.ReadLine();
				} while (exTopInput[0]!='N' && exTopInput[0]!='F' && exTopInput[0]!='H');
				for (; exTopInput[0]!='N' && parseOffset < exTopInput.Length - 1; parseOffset += 2)
				{
					if (exTopInput[0] != 'H')
					{
						halfTopping[htIndx++] =(Topping) exTopInput[2 + parseOffset];
						this._extracost += 0.75D;
						Console.WriteLine("half topping" + (htIndx - 1));
;					}
					else if (exTopInput[0] != 'F')
					{
						fullTopping[ftIndx++] = (Topping)exTopInput[2 + parseOffset];
						this._extracost += 1.10D;
					}
				}


				Console.WriteLine("How many pizzas of this type & size would you like?");
                countInput=Console.ReadLine();
                Int32.TryParse(countInput,out countNo);
				totalCost +=countNo* (Pizza.getpizzacost((uint)index)+this._extracost);
				Console.WriteLine("$"+totalCost);
                do {
		      	Console.WriteLine("Is this pizza acceptable?(Y/N)");
                     pizzaInput=Console.ReadLine();
		     
		}while (pizzaInput[0]!='Y'&&pizzaInput[0]!='N');
		if (pizzaInput[0]=='Y') {
			sizeNo=0;
            Pizza pizza=new Pizza((uint)index,(uint)sizeNo,(uint)countNo, Pizza.getToppings((uint)index),halfTopping,this._extracost,
				   Pizza.getpizzacost((uint)index));//pizza type size count	
		    this.items[arrayIdx++]=pizza;
		}
                do {	
                   Console.WriteLine("Is this order accurate and complete?(C:omplete,M:ore,D:el");
                   finInput=Console.ReadLine();
	        } while(finInput[0]!='C'&& finInput[0]!='M'&&finInput[0]!='D');
	}   while ( finInput[0]!='C' && this.arrayIdx<12);
	}
        private uint arrayIdx {get;set;}   
        private ulong sequence
       	{ get;set;}
	private string address {get; set;} 
	private string name  {get; set;}
	private string payment {get;set;}
    private double amount {get;set;}
	private DateTime _timestamp {get;set;}
	private Pizza[]  items;
	private uint[] stores;
		public Order(string arg0, string arg1, string arg2, double arg3, Pizza[]arg4)
		{
			this.name = arg0;this.address = arg1;this.payment = arg2;
			this.amount = arg3; this.items = arg4;
			this._timestamp= DateTime.Now;
		}
		public static Order build(uint unitno) {

            Order order = new Order("", "", "", 0.0f,new Pizza[25]);


	 //   ShopData.getLocations(unitno);
	     order.items=new Pizza[25];
	    order.getInput();
	    // order.items=sizeInput;
	    // order.items=input;
	    return order;
	}
		void OnCreated()
		{
            //Pizza(uint size, uint count, uint crust, Topping[] toppings, double cost)

            //Order(string arg0, string arg1, string arg2, float arg3, Pizza[]arg4)
            System.Collections.Generic.List<Order> list = new List<Order>();
			SqlConnection connection = new SqlConnection("Data Source=(local);");
			string insertsql ="INSERT INTO Orders VALUES('jxcdrrd', '23 lunny av,Austin', '2343-23434-344-344f', 4, 'mushroom,chicken', DATETIME(2007 - 04 - 30 13:10:02))" ;
			string userpurchases = "select from Orders where name='%' order by timestamp";
			Order p;
			DateTime _ordertime;
			String Address;
			int itemsNo;
			SqlCommand cmd = new SqlCommand();//
{


	         connection.Open();
			using (SqlDataReader reader = cmd.ExecuteReader())
			{
				// Check is the reader has any rows at all before starting to read.
				if (reader.HasRows)
				{
					// Read advances to the next row.
					while (reader.Read())
					{
					
						// To avoid unexpected bugs access columns by name.
					//	_ordertime = reader.GetInt32(reader.GetOrdinal("ID"));
						Address = reader.GetString(reader.GetOrdinal("Address"));
						int paymentIndex = reader.GetOrdinal("payment");
						// If a column is nullable always check for DBNull...
						//if (!reader.IsDBNull(middleNameIndex))
					//	{
					//		p. = reader.GetString(middleNameIndex);
					//	}
					//  itemsStr = reader.GetString(reader.GetOrdinal("items"));
					//p = new Order("", "", "", double, Pizza[]);
	//						Name NVARCHAR(4000) NOT NULL,
	// Address NVARCHAR(40) NOT NULL,
	// payment NVARCHAR(4000) NOT NULL,
	// Stores NVARCHAR(20) NOT NULL,
	// items NVARCHAR(4000) NOT NULL,
	// ordertime DATETIME2 NOT NULL,
					}
				}
			}
		}
			
         }
	}
	
}


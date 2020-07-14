using system;
namespace Product
{
	 class Product
    {
        internal int productId;
        internal string productName;
        internal double price;
        internal string color;

        internal void Display()
        {
            Console.WriteLine("ID:" + productId + " " + productName + "-" + price + " " + color);
        }
		internal Product()
        {
            Console.WriteLine("Empty Object Initialization");
        }
        internal Product(int productId, string productName, double price, string color)
        {
            Console.WriteLine("Object Initialized");
            this.productId = productId;
            this.productName = productName;
            this.color = color;
            this.price = price;
                 
        }
    }
	class ProductMoodel
	{
		static void main(string[] args)
		{
			product1 = new product;
			product1.productID = 121;
			product1.productName = "Hard drive";
			product1.price = 3850;
			product1.color = "Blue";
			
			product1.Display();
			product2 = new product(123, "Pendrive", 450, "red");
			product2.Display();
			product1 = new product(124, "SDcard", 300, "black");
			product1.Display();
		}
	}
}
using system;
namespace Product
{
	 class Product
    {
        int productId;
        string productName;
        double price;
        string color;

        void Display()
        {
            Console.WriteLine("ID:" + productId + " " + productName + "-" + price + " " + color);
        }
		static void main(string[] args)
		{
			product1=new product;
			product1.productID = 121;
			product1.productName = "Hard drive";
			product1.price = 3850;
			product1.color = "Blue";
			
			product1.Display();
		}
    }
	class ProductMoodel
	{
		static void main(string[] args)
		{
			product1=new product;
			product1.productID = 121;
			product1.productName = "Hard drive";
			product1.price = 3850;
			product1.color = "Blue";
			
			product1.Display();
		}
	}
}
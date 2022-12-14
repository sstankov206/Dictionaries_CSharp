/* Write a program that keeps information about products and their prices. 
 * Each product has a name, a price and a quantity. If the product doesn’t 
 * exist yet, add it with its starting quantity.
 * 
 * If you receive a product, which already exists,increase its quantity by the 
 * input quantity and if its price is different, replace the price as well.
 * 
 * You will receive products’ names, prices and quantities on new lines.Until you 
 * receive the command "buy", keep adding items. When you do receive the command 
 * "buy", print the items with their names and total price of all the
 * products with that name. 
 * 
 * Input:
 * •Until you receive "buy", the products will be coming in the format: 
 * "{name} {price} {quantity}".
 * •The product data is always delimited by a single space.
 * 
 * Output:
 * •Print information about eachproductin the following format: 
 * "{productName} -> {totalPrice}"•
 * Format the average grade to the 2nd digit after the decimal separator.
 * 
 * INPUT: Beer 2.20 100
 *        IceTea 1.50 50
 *        NukaCola 3.30 80
 *        Water 1.00 500
 *        buy
 *        
 * OUTPUT: Beer -> 220.00
 *         IceTea -> 75.00
 *         NukaCola -> 264.00
 *         Water -> 500.00   
 *         
 * Solution by me, sstankov
 */

using System;
class Program
{
    static void Main()
    {
        //creating dictionary to store the products:
        var products = new Dictionary<string, Product>();

        //read input until input equal "buy":
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "buy")
            {
                break;
            }
            //split input by space:
            string[] splittedInput = input.Split();
            //set the name of the product via the array of input:
            string name = splittedInput[0];
            //set the price of the product via the array of input:
            double price = double.Parse(splittedInput[1]);
            //set the quantity of the product via the array of input:
            int quantity = int.Parse(splittedInput[2]);

            //creating new instance of the Product class:
            Product product = new Product(name, price, quantity);

            //check if product is contained in the dictionary:
            if (!products.ContainsKey(name))
            {
                products.Add(name, product); //add the product's name and it's properties (price/quantity)

            }
            else //if the product is not contained in the dictionary:
            {
                products[name].Price = price;
                products[name].Quantity += quantity; //add the product's name, price, and qty as a new key/value in the dictionary
            }
        }

        //iterate through the dictionary:
        foreach (var pair in products)
        {
            //print output:
            Console.WriteLine($"{pair.Key} -> {pair.Value.Price * pair.Value.Quantity:F2}");
        }
    }
}

class Product
{ //properties for the Product class:
    string name { get; set; }
    double price;
    int quantity { get; set; }

    //constructor:
    public Product(string name, double price, int quantity)
    {
        this.name = name;
        this.price = price;
        this.quantity = quantity;
    }

    public double Price
    {
        get
        {
            return price;
        }
        set
        {
            price = value;
        }
    }

    public int Quantity
    {
        get
        {
            return quantity;
        }
        set
        {
            quantity = value;
        }
    }

}


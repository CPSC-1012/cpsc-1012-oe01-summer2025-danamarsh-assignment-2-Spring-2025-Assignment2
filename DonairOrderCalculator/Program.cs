using System.ComponentModel.DataAnnotations;
/*
 * Purpose: To get orders from the customers and determine how much it will cost
 * Author: Jairaj Johal
 * Modified: June 16th 2025
 * 
 * Input: what size donair the customer would like, if they would like extra toppings, and the quantity of the order
 * Output: The subtotal, discount if applied, GST, and the order total. 
 */
namespace DonairOrderCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userAnswer;
            do
            {
                //declare variables
                string donairSize;
                double donairPrice = 0;
                int Quantity;
                string extraToppings;
                double extraToppingPrice = 0;
                bool isDonairSize = true;
                bool isExtraToppings = true;
                double orderSubtotal, discount, orderTotal, gst, discountTotal;
                
                





                do
                {
                    
                    Console.Write("What size donair would you like regular, large, or supreme: ");
                    donairSize = Console.ReadLine().ToLower().Trim();

                    switch (donairSize)
                    {
                        case "regular":
                            donairPrice = 6.50;
                            isDonairSize = true;
                            break;

                        case "large":
                            donairPrice = 8.00;
                            isDonairSize = true;
                            break;

                        case "supreme":
                            donairPrice = 9.50;
                            isDonairSize = true;
                            break;
                        default:
                            Console.WriteLine("Thats an invalid size please try again");
                            isDonairSize = false;
                            break;
                    }

                } while (!isDonairSize);




                do
                {
                    Console.Write("Would you like extra cheese, meat, both or none: ");
                    extraToppings = Console.ReadLine().ToLower().Trim();

                    switch (extraToppings)
                    {
                        case "extra cheese":
                            extraToppingPrice = 1.25;
                            isExtraToppings = true;
                            break;

                        case "extra meat":
                            extraToppingPrice = 2.00;
                            isExtraToppings = true;
                            break;

                        case "both":
                            extraToppingPrice = 3.25;
                            isExtraToppings = true;
                            break;

                        case "none":
                            isExtraToppings = true;
                            break;

                        default:
                            Console.Write("Sorry thats not a valid input please try again.\n");
                            isExtraToppings = false;
                            break;

                    }
                } while (!isExtraToppings);

                Console.Write("What is the quantity of your order: ");
                Quantity = int.Parse(Console.ReadLine());

                orderSubtotal = Quantity * (donairPrice + extraToppingPrice);



               

                discount = 0;

                if (orderSubtotal > 40)
                {
                    discount = orderSubtotal * 0.10;
                    discountTotal = orderSubtotal - discount;

                }
                else
                {
                    gst = orderSubtotal * 0.05;
                    orderTotal = orderSubtotal + gst;
                }


                gst = orderSubtotal * 0.05;
                discountTotal = orderSubtotal - discount;
                orderTotal = discountTotal + gst;



                Console.WriteLine($"Subtotal:       {orderSubtotal}");
                Console.WriteLine($"Discount:        {discount}");
                Console.WriteLine($"GST:             {gst}");
                Console.WriteLine($"Order Total:    {orderTotal}");


               
                Console.Write ("Press Q to exit or any other letter to continue: ");
                userAnswer = Console.ReadLine().ToUpper().Trim();

            } while (userAnswer != "Q");

            Console.WriteLine("Thank You for your Order Goodbye :)");
        }
    }
}

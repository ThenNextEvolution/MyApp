using System;
class HW
{
    public static void Main(String[] arg){


        decimal price,priceddiscount,discount  = 0;




        Console.WriteLine("what is price:");
        price = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine(price);


        if (price < 100){
            discount =(decimal)0.1;


        }
        else{
            discount =(decimal).14;
        }

        priceddiscount = decimal.Subtract(price,decimal.Multiply(price,discount));

        Console.WriteLine("The Discounted Price is: "+priceddiscount);

}

}


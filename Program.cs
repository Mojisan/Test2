using System;
class Program
{
    public static void Main(string[] args)
    {
        IDIACamp();
    }

    static void IDIACamp()
    {
        Water();
        Treasurer();
    }

    static void Water()
    {
        double Vtotal, VFill2;
        Console.Write("Input water max : ");
        double VMax = double.Parse(Console.ReadLine());
        Console.Write("Input volume of water added : ");
        double VFill = double.Parse(Console.ReadLine());
        Console.Write("Input volume of water added each cycle : ");
        double VDrink = double.Parse(Console.ReadLine());
        Console.WriteLine("----------------------");
        Console.Write("Input water filling time (Hr) : ");
        int TFill = int.Parse(Console.ReadLine());
        Console.Write("Input rest period (Hr) : ");
        int TDrink = int.Parse(Console.ReadLine());
        Console.Write("Input Activity period (Hr) : ");
        int TDay = int.Parse(Console.ReadLine());
        if (VDrink <= VMax && TDay >= TDrink && TDay >= TFill)
        {
            if ((TFill * VFill) >= VMax)
            {
                VFill2 = VMax ;
                Console.WriteLine("Overflow Water");
            }
            else
            {
                VFill2 = TFill * VFill;
            }
            if (TFill == TDrink && VFill == VDrink)
            {
                Vtotal = VFill;
            }
            else
            {
                Vtotal = VFill2 - (VDrink * TDrink);
            }
            if (Vtotal >= 0)
            {
                Console.WriteLine("Enough Water, {0} left", Vtotal);
            }
            else
            {
                Console.WriteLine("Not Enough Water");
            }
        }
    }
    static void Treasurer()
    {
        bool check = true;
        int i = 1;
        double[] bal = new double[3];
        double bill, L = 0;
        while (check)
        {
            while (i <= 3)
            {
                Console.Write("Input miscellaneous balance : ");
                bal[i - 1] = double.Parse(Console.ReadLine());
                i++;
            }
            Console.Write("Input bills : ");
            bill = double.Parse(Console.ReadLine());
            if (bill <= 0)
            {
                Console.Write("Balance 1 : {0}, Balance 2 : {1}, Balance 3 : {2}, ", bal[0], bal[1], bal[2]);
                if (L > 0)
                {
                    Console.Write("Left : {0}", L);
                }
                break;
            }
            else if (bill < bal[0])
            {
                bal[0] -= bill;
            }
            else if (bill > bal[0] && bill < bal[1])
            {
                bal[1] -= bill;
            }
            else if (bill > bal[0] && bill > bal[1] && bill < bal[2])
            {
                bal[2] -= bill;
            }
            else
            {
                L += bill;
            }
        }
    }
}
namespace ForLoop;
class Program
{
    static void Main(string[] args)
    {
        int count = int.Parse(Console.ReadLine());

        for (int i = 1; i < count; i++)
        {
            if(i % 2 == 1)
            {
                Console.WriteLine(i);
            }
        }

        /* Output :
           1
           3
           5
           .
           .        */

        //---------------------   

        int evenSum = 0;
        int oddSum = 0;

        for (int i = 1; i <= 1000; i++)
        {
            if( i % 2 == 1)
            {
                oddSum += i;
            }
            else
            {
                evenSum += i;
            }            
        }
        Console.WriteLine("Even sum = " + evenSum);
        Console.WriteLine("Odd sum = " + oddSum);

        // break  
        for (int i = 1; i < 6; i++)
        {
            if(i == 4)
            break;
            Console.WriteLine(i);
        } 
        /*  Output:
            1
            2
            3     */


        // continue
        for (int i = 1; i < 6; i++)
        {
            if(i == 4)
            continue;
            Console.WriteLine(i);
        } 
        /*  Output:
            1
            2
            3
            5
            6     */
    }
}

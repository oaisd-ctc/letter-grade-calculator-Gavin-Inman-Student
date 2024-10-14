Console.Clear();

Console.WriteLine("Enter Grade Percent (Dont Add The Percent Sign)");

string gradeValue = Console.ReadLine();

int Grade = int.Parse(gradeValue);
if (Grade >= 100)
{
    Console.WriteLine("A+, Good.");
} else {
    
    if (Grade >= 90)
    {
        Console.WriteLine("A, Medicore.");
    } else {
         
         if (Grade >= 80)
        {
            Console.WriteLine("B, Try Harder.");
        } else{
            if (Grade >= 70)
            {
                Console.WriteLine("C, Insufficient.");
            } else {
                if (Grade >= 60)
                {
                    Console.WriteLine("D, Horrible, Theres No Hope.");
                } else {
                    if (Grade <= 59)
                    {
                        Console.WriteLine("F, R.I.P. To The Familys Dreams For You.");
                    }
                }
            }
        } 
    }
}
        
       

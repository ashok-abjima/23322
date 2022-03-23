using System;
class Marksheet
{
    public string Name { get; set; }
    public int Rollno { get; set; }

    public int Science { get; set; }
    public int Biology { get; set; }
    public int Hindi { get; set; }

    public int TotalMark { get; set; }
    public int ObtainedMark { get; set; }
    public float Percentage { get; set; }

}

class Program
{
    static void Main(string[] args)
    {

        Marksheet[] arr = new Marksheet[1];


        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine("Enter Name,Enter RollNo,Science,Biology,Hindi");


            Marksheet ob = new Marksheet();
            ob.Name = Console.ReadLine();
            ob.Rollno = int.Parse(Console.ReadLine());
            ob.Science = int.Parse(Console.ReadLine());
            ob.Biology = int.Parse(Console.ReadLine());
            ob.Hindi = int.Parse(Console.ReadLine());
            ob.TotalMark = 600;
            ob.ObtainedMark = ob.Hindi + ob.Science + ob.Biology;
            ob.Percentage = (ob.ObtainedMark * 100) / ob.TotalMark;

            //ob.Percentage = (arr[2].ObtainedMark / (float)arr[2].TotalMark) * 100;

            arr[0] = ob;


            ////Marksheet ob1 = new Marksheet();
            //ob.Name = Console.ReadLine();
            //ob.Rollno = int.Parse(Console.ReadLine());
            //ob.Science = int.Parse(Console.ReadLine());
            //ob.Biology = int.Parse(Console.ReadLine());
            //ob.Hindi = int.Parse(Console.ReadLine());
            //ob.TotalMark = 500;
            //ob.ObtainedMark = ob.Hindi + ob.Science + ob.Biology;
            //ob.Percentage = (ob.ObtainedMark * 100) / ob.TotalMark;


            //arr[1] = ob; 
            //    Marksheet ob2 = new Marksheet();
            //ob2.Name = Console.ReadLine();
            //ob2.Rollno = int.Parse(Console.ReadLine());
            //ob2.Science = int.Parse(Console.ReadLine());
            //ob2.Biology = int.Parse(Console.ReadLine());
            //ob2.Hindi = int.Parse(Console.ReadLine());
            //ob2.TotalMark = 500;
            //ob2.ObtainedMark = ob2.Hindi + ob1.Science + ob2.Biology;
            //ob2.Percentage = (ob2.ObtainedMark * 100) / ob2.TotalMark;


            //arr[2] = ob2;
        
        }





        foreach (Marksheet item in arr)
        {

            Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7} ", item.Name, item.Rollno,item.Hindi,item.Science,item.Biology, item.TotalMark, item.ObtainedMark, item.Percentage);
        }
        Console.ReadKey();


    }
}
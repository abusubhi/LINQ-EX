using System;

public class Car
{
    public int Id { get; set; }
    public string Prand { get; set; }
    public string MadeIn{ get; set; }
}

class Program
{
    public static void Main(string[] args)
    {

        Car[] cars =
        {
            new Car { Id = 1,Prand = "Mitsobishe", MadeIn = "japan"},
            new Car { Id = 2,Prand = "Mirseids", MadeIn = "germany"},
            new Car { Id = 3,Prand = "BMW", MadeIn = "germany"},
            new Car { Id = 4,Prand = "Oudy", MadeIn = "germany"},

        };

        //var List = from item in cars 
        //           orderby item.Id select item;

        var List = cars.OrderByDescending(item => item.Id);
        foreach(var item in List)
        {
            Console.WriteLine(item.Id + " "+ item.Prand );
        }

        List<String> inf = new List<String>()
    { "moh" , "samer" , "khaled"};

        // var Result = inf.Where(item => item == "samer");

        var Result = from item in inf where item == "samer" select item;

        foreach(string item in Result)
        {
            Console.WriteLine (item);
        }



       // List<int> num = new List<int>()
       // { 1,2,3,4,5,6,7,8,9,10};


       // /*non-query*/
       // //  var Result = num.Where (item  => item > 6);


       // /*query syntax*/
       //// var Result = from item in num where item > 6 select item;

       // var Result = from item in num  where item >= 5 select item;

       // /*foreach to the non-query and to the query syntax */
       // foreach (int item in Result)
       // {
       //     Console.WriteLine(item);
       // }




    }
}
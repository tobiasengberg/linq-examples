﻿using ConsoleApp3;

Console.WriteLine("Hello, World!");

string ex1 = "This method is implemented by using deferred execution The immediate return value is an object that stores all the information that is required to perform the action The query represented by this method is not executed until the object is enumerated either by calling its GetEnumerator method directly or by using foreach in C# or For Each in Visual Basic";
string ex2 = "This method is implemented by using deferred execution stores all the information that is required calling its GetEnumerator";

string[] firstArray = ex1.Split(' ');
string[] secondArray = ex2.Split(' ');

//string[] longerWords = QueryMethods.GetBasic(firstArray);
//string[] longerWords = QueryMethods.GetOrdered(firstArray);
//string[] longerWords = QueryMethods.GetFewer(firstArray);
//string[] longerWords = QueryMethods.GetReverse(firstArray);
string[] longerWords = QueryMethods.GetOdd(firstArray, secondArray);
foreach (string word in longerWords)
{
    Console.Write(word + ", ");
}

Console.WriteLine();

List<int> numbers = new List<int>() { 45, 20, 30, 81, 55, 39, 95 };

double average = numbers.Average();
int sum = numbers.Sum();
int max = numbers.Max();

Console.WriteLine(max);

List<Arena> arenas = new List<Arena>();

arenas.Add(new Arena(1, "Gotham"));
arenas.Add(new Arena(2, "Borås"));
arenas.Add(new Arena(3, "Flen"));

List<Arena> newArenas = arenas
    .OrderByDescending(a => a.Id)
    .ToList();

// foreach (Arena arena in newArenas)
// {
//     Console.Write(arena.Place + ", ");
// }



string jsonData = 
    """ 
    [{"Id":1,"ReducedVenue":false,"Date":"2022-10-16T00:00:00","Performer":"Ondricka, Walsh and Morissette","BeginsAt":18,"FullCapacitySales":1832880},
{"Id":2,"ReducedVenue":false,"Date":"2023-07-09T00:00:00","Performer":"Ryan-Lynch","BeginsAt":12,"FullCapacitySales":1365810},
{"Id":3,"ReducedVenue":false,"Date":"2023-06-19T00:00:00","Performer":"Williamson Group","BeginsAt":12,"FullCapacitySales":1691580},
{"Id":4,"ReducedVenue":false,"Date":"2023-09-23T00:00:00","Performer":"Collier-Witting","BeginsAt":10,"FullCapacitySales":1913370},
{"Id":5,"ReducedVenue":true,"Date":"2023-11-21T00:00:00","Performer":"Hettinger-Greenholt","BeginsAt":20,"FullCapacitySales":1089590},
{"Id":6,"ReducedVenue":true,"Date":"2025-04-18T00:00:00","Performer":"Hansen Group","BeginsAt":13,"FullCapacitySales":1076040},
{"Id":7,"ReducedVenue":true,"Date":"2022-10-15T00:00:00","Performer":"Schmidt, Witting and Skiles","BeginsAt":17,"FullCapacitySales":2713630},
{"Id":8,"ReducedVenue":false,"Date":"2023-05-16T00:00:00","Performer":"Gibson, Hintz and Hagenes","BeginsAt":15,"FullCapacitySales":2050350},
{"Id":9,"ReducedVenue":false,"Date":"2024-05-12T00:00:00","Performer":"Kirlin LLC","BeginsAt":19,"FullCapacitySales":1203390},
{"Id":10,"ReducedVenue":true,"Date":"2025-09-01T00:00:00","Performer":"Weimann-Rippin","BeginsAt":14,"FullCapacitySales":1267490},
{"Id":11,"ReducedVenue":true,"Date":"2025-09-21T00:00:00","Performer":"Hilll-Farrell","BeginsAt":19,"FullCapacitySales":979280},
{"Id":12,"ReducedVenue":false,"Date":"2023-01-02T00:00:00","Performer":"Kuvalis Group","BeginsAt":14,"FullCapacitySales":2210270},
{"Id":13,"ReducedVenue":false,"Date":"2025-02-13T00:00:00","Performer":"Jakubowski, Hagenes and Brekke","BeginsAt":14,"FullCapacitySales":2411540},
{"Id":14,"ReducedVenue":true,"Date":"2024-05-09T00:00:00","Performer":"Kozey-Cruickshank","BeginsAt":13,"FullCapacitySales":2420460},
{"Id":15,"ReducedVenue":false,"Date":"2023-03-07T00:00:00","Performer":"Green, Krajcik and Beahan","BeginsAt":12,"FullCapacitySales":3146700},
{"Id":16,"ReducedVenue":false,"Date":"2024-08-22T00:00:00","Performer":"Gusikowski, Kertzmann and Stamm","BeginsAt":10,"FullCapacitySales":770840},
{"Id":17,"ReducedVenue":false,"Date":"2023-09-11T00:00:00","Performer":"Prosacco Group","BeginsAt":15,"FullCapacitySales":3107510},
{"Id":18,"ReducedVenue":true,"Date":"2023-01-13T00:00:00","Performer":"Stokes, Hackett and Wiza","BeginsAt":11,"FullCapacitySales":2138240},
{"Id":19,"ReducedVenue":true,"Date":"2023-03-17T00:00:00","Performer":"Nolan-Stehr","BeginsAt":12,"FullCapacitySales":2319230},
{"Id":20,"ReducedVenue":true,"Date":"2023-05-22T00:00:00","Performer":"Swift-Prosacco","BeginsAt":13,"FullCapacitySales":1660550},
{"Id":21,"ReducedVenue":true,"Date":"2023-12-02T00:00:00","Performer":"Boehm, Mohr and Kohler","BeginsAt":10,"FullCapacitySales":1736830},
{"Id":22,"ReducedVenue":true,"Date":"2024-04-21T00:00:00","Performer":"Cartwright, McDermott and Stracke","BeginsAt":18,"FullCapacitySales":1862910},
{"Id":23,"ReducedVenue":false,"Date":"2024-06-25T00:00:00","Performer":"Wunsch-Becker","BeginsAt":18,"FullCapacitySales":1736780},
{"Id":24,"ReducedVenue":true,"Date":"2025-06-28T00:00:00","Performer":"Lehner-Crist","BeginsAt":13,"FullCapacitySales":827960},
{"Id":25,"ReducedVenue":false,"Date":"2024-04-15T00:00:00","Performer":"Kutch, Schmitt and Schmitt","BeginsAt":18,"FullCapacitySales":1138840}] 
""";




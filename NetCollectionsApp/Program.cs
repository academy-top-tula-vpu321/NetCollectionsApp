using System.Collections;

ArrayList arrayList = new ArrayList();
Random random = new Random();

int size = 10;

for (int i = 0; i < size; i++)
    arrayList.Add(random.Next(99));

//arrayList[3] = 656.8787;
//arrayList[5] = "Hello world";
//arrayList[7] = false;

foreach(var item in arrayList)
    Console.Write($"{item} ");
Console.WriteLine();
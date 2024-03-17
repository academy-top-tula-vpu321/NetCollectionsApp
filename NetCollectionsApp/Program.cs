using NetCollectionsApp;
using System.Collections;
using System.Collections.Generic;


Random random = new();
List<int> nums = new();

for (int i = 0; i < 10; i++)
{
    nums.Add(random.Next(1, 99));
    Console.Write($"{nums[nums.Count - 1]} ");
}
Console.WriteLine();

Index index = 2;
Console.WriteLine(nums[index]);
index = ^2;
Console.WriteLine(nums[index]);

Range range = 2..;
foreach(int i in nums[^7..^3])
    Console.Write($"{i} ");
Console.WriteLine();
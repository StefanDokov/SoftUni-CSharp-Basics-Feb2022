﻿


int[] starter = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

Stack<int> nums = new Stack<int>(Console.ReadLine().Split(" ").Select(int.Parse));

while (starter[1] > 0)
{
    nums.Pop();
    starter[1]--;
}

if (nums.Count == 0)
{
    Console.WriteLine("0");
}
else if (nums.Contains(starter[2]))
{
    Console.WriteLine("true");
} else
{
    Console.WriteLine(nums.Min());
}


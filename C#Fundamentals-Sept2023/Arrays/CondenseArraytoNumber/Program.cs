



int[] nums = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();




while (nums.Length > 1)
{
    int[] condensed = new int[nums.Length - 1];

    for (int i = 0; i < condensed.Length; i++)
{
    condensed[i] = nums[i] + nums[i + 1];
}

   nums = condensed;
}



int sum  = 0;

foreach (int z in nums)
{
    sum += z;
}

Console.WriteLine(sum);
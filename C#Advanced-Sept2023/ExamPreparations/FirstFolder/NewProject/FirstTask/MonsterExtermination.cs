


Queue<int> monsters = new(Console.ReadLine()
    .Split(",", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));


Stack<int> soldiers = new(Console.ReadLine()
    .Split(",", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));

int monsterKills = 0;
int remainerDmg = 0;
int resist = 0;
while(monsters.Count > 0)
{
    

  
    int monsterArmor = monsters.Dequeue();
    if (soldiers.Count > 0)
    {
        int soldier = soldiers.Pop();
        resist = soldier + remainerDmg;
    }
    else if (soldiers.Count == 0 && remainerDmg > 0)
    {
        resist = remainerDmg;
    }
    else if (soldiers.Count == 0 && remainerDmg < 1)
    {
        Console.WriteLine("The soldier has been defeated.");
        break;
    }
  


    if (monsterArmor <= resist)
    {
        monsterKills++;
        
        remainerDmg = resist - monsterArmor;

        
        
    }
    else
    {
        
        monsters.Enqueue(monsterArmor - resist);
        remainerDmg = 0;
        
    }

   
}
if (monsters.Count == 0 && remainerDmg >= 0)
{
    Console.WriteLine("All monsters have been killed!");
    if (remainerDmg == 0)
    {
        Console.WriteLine("The soldier has been defeated.");
    }

}

Console.WriteLine($"Total monsters killed: {monsterKills}");




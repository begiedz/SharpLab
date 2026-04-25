int heroHealthPoints = 10;
int monsterHealthPoints = 10;

var random = new Random();

while (heroHealthPoints > 0 && monsterHealthPoints > 0)
{
    int roll = random.Next(1, 11);
    monsterHealthPoints -= roll;
    Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monsterHealthPoints} health.");

    if (monsterHealthPoints <= 0) continue;

    roll = random.Next(1, 11);
    heroHealthPoints -= roll;
    Console.WriteLine($"Hero was damaged and lost {roll} health and now has {heroHealthPoints} health.");

}

Console.WriteLine(heroHealthPoints > monsterHealthPoints ? "Hero wins!" : "Monster wins!");

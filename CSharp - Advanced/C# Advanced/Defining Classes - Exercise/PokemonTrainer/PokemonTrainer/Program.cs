using PokemonTrainer;

string command = Console.ReadLine();

List<Trainer> trainers = new();


while (command != "Tournament")
{
    string[] tokens = command.Split(" ",StringSplitOptions.RemoveEmptyEntries);

    Trainer trainer = trainers.SingleOrDefault(t => t.Name == tokens[0]);

    if (trainer == null)
    {
        trainer = new(tokens[0]);
        trainer.Pokemons.Add(new(tokens[1], tokens[2], int.Parse(tokens[3])));
        trainers.Add(trainer);
    }
    else
    {
        trainer.Pokemons.Add(new(tokens[1], tokens[2], int.Parse(tokens[3])));
    }
    command = Console.ReadLine();
}

 command = Console.ReadLine();

while (command != "End")
{
    foreach (var trainer in trainers)
    {
        trainer.CheckPokemon(command);
    }

    command = Console.ReadLine();
}

foreach (var trainer in trainers.OrderByDescending(t => t.NumberOfBadges))
{
    Console.WriteLine($"{trainer.Name} {trainer.NumberOfBadges} {trainer.Pokemons.Count}");
}
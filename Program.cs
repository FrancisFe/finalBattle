

using Core_Game;
using Core_Game.Interfaces;

Console.WriteLine("What game mode do you want to play");
Console.WriteLine("1- Human vs Human");
Console.WriteLine("2- Human vs Computer");
Console.WriteLine("3-Computer vs Computer");
int choice;
if ((!int.TryParse(Console.ReadLine(), out choice) && choice >= 1 && choice >= 3))
    choice = 2;


IPlayer p1 = (choice == 1 || choice == 2) ? new ConsolePlayer() : new ComputerIAPlayer();
IPlayer p2 = (choice == 1) ? new ConsolePlayer() : new ComputerIAPlayer();

Party partyHero = new Party(p1 , new List<Item>{new Potion(), new Potion(), new Potion()});
partyHero.AddCharacter(new Heroe(PreguntarNombre() ?? "THE TRUE PROGRAMMER"));



Party partyMonsters = new Party(p2, new List<Item> { new Potion() });
partyMonsters.AddCharacter(new Skeleton("SKELETON 1"));
List<Party> listMonsters = new List<Party>();
listMonsters.Add(partyMonsters);

Party partyMonsters2 = new Party(p2, new List<Item> { new Potion() });
partyMonsters2.AddCharacter(new Skeleton("SKELETON 2"));
partyMonsters2.AddCharacter(new Skeleton("SKELETON 3"));
listMonsters.Add(partyMonsters2);

Party partyBoss = new Party(p2, new List<Item> { new Potion() });
partyBoss.AddCharacter(new TheUncodedOne("The Uncoded One"));
listMonsters.Add(partyBoss);

Battle battle = new Battle(partyHero, listMonsters);
battle.Run();


string? PreguntarNombre(){
    Console.WriteLine("Cual es el nombre de nuestro heroe??");
    string? name = Console.ReadLine();
    return name;
}
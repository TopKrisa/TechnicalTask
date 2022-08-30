using TZ.Factories;
using TZ.Heroes;

Console.WriteLine("Солдат");

Hero solider = new Hero(new SoliderFactory());

solider.Attack();
solider.Move();

Console.WriteLine("Супергерой");

Hero superhero = new Hero(new SuperheroFactory());
superhero.Attack();
superhero.Move();

Console.WriteLine("Пехотинец");
Hero stormtooper = new Hero(new StormtooperFactory());
stormtooper.Attack();
stormtooper.Move();

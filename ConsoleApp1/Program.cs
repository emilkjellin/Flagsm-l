

int batman = 1000;
int joker = 1000;
Console.WriteLine("         _,    _   _    ,_");
Console.WriteLine("    .o888P     Y8o8Y     Y888o.");
Console.WriteLine("   d88888      88888      88888b");
Console.WriteLine("  d888888b_  _d88888b_  _d888888b");
Console.WriteLine("  8888888888888888888888888888888");
Console.WriteLine("  8888888888888888888888888888888");
Console.WriteLine("  YJGS8P'Y888P'Y888P'Y888P'Y8888P");
Console.WriteLine("   Y888   '8'   Y8P   '8'   888Y");
Console.WriteLine("    '8o          V          o8'");
Console.WriteLine("      `                     `");

while (batman > 0 && joker > 0)
{
Random generator = new Random();

 int batmandmg = generator.Next(50, 100);
 int jokerdmg = generator.Next(50, 100);

Console.WriteLine($"batman {batman}HP");
Console.WriteLine($"joker {joker}HP");
Console.WriteLine("NEXT ROUND, Press (Enter) to continue");

batman -= jokerdmg;
joker -= batmandmg;


//Console.WriteLine($"Batman took {jokerdmg}damage");
//Console.WriteLine($"Joker took {batmandmg}damage");


Console.ReadKey();




if(batman < 500 && batman > 50)
{
batman += 100;

}

if( batman < 500 && batman > 400 )
{

Console.WriteLine("Batman changed his armor to bullet prof. he generates HP per round");
}

if( joker < 500 && joker > 0)
{
jokerdmg += 20;
batman -= jokerdmg;

}

if (joker < 500 && joker > 400)
{

Console.WriteLine("Joker Felt like using his bigger guns, Joker now does more damage per round");

}
}





if(joker < 0)
{
Console.WriteLine("ofcourse blud lost to the mc💀");

}
if(batman < 0)
{
 Console.WriteLine("Joker finnaly won ");   

}


Console.ReadLine();
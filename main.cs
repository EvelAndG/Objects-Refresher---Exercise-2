using System;

class MainClass 
{
  public static void Main (string[] args)
	 {
		Alien firstAlien = new Alien();
		Alien secondAlien = new Alien();
		secondAlien.tentacleCount = 50;
		secondAlien.eyeBalls = 48;
		

		Console.WriteLine($"\nDisaster #1 - Alien Invasion \n\nAttention Humans:
		\nYou are now under our control.\nThere is no chance since our species has at least {firstAlien.tentacleCount} tentacles and {firstAlien.eyeBalls} eyeballs making us far superior."); 

		Console.WriteLine($"My name is Zargon, and I am the leader of the Alien Invasion force, because I am the strongest with {secondAlien.tentacleCount} tentacles and {secondAlien.eyeBalls} eyeballs.");


		Sharknado firstSharknado = new Sharknado();
		Sharknado secondSharknado = new Sharknado();
		secondSharknado.windForce = 200;
		secondSharknado.numOfSharks = 150;

		Console.WriteLine($"\nDisaster #2 - Sharknado \n\nHoly Toledo, Batman, is that a Sharknado forming in the distance?\nIt looks like there is at least {firstSharknado.numOfSharks} sharks in the waterspout.\nAs long as the wind force doesn't reach {firstSharknado.windForce} mph then we won't have a Sharknado.");

		Console.WriteLine($"\nOh no the wind has increased up to {secondSharknado.windForce} mph and there is now {secondSharknado.numOfSharks} sharks, which makes this one of the worst Sharknados I've ever seen!");
		
    
  }

	class Alien 
	{
		public int tentacleCount = 6;
		public int eyeBalls = 12;
	}

	class Sharknado
	{
		public int windForce = 100;
		public int numOfSharks = 50;

	}

	public class Virus 
	{
		public double deathRate {get; set;}
		public int populationEffected {get; set;}
				
	}

	
}
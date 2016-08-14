using System;

// To execute C#, please define "static void Main" on a class
// named Solution.

class Solution
{
    static void Main(string[] args)
    {
        ZFighter Vegeta = new ZFighter("Kakarot", 6000); //You are instantiating the blue print
        // Vegeta.Name = "Vegeta";
        //Vegeta.PowerLevel = 9000;
        //Console.WriteLine(Vegeta.ToString());
        Console.WriteLine(Vegeta);
        Console.WriteLine(Vegeta.kiBlast(2));
        Console.ReadLine();
    }
}

//Create a ZFighter class that for its constructor takes in a 
//Name and PowerLevel

//This class should have methods that call a "kiBlast" method and take in a parameter called "concentration". The return value of the kiblast should be an integer which should return concentration * powerLevel.

class ZFighter
{
    public string Name { get; set; }
    public int PowerLevel { get; set; }
    public ZFighter(string name, int powerLevel)
    {
        Name = name;
        PowerLevel = powerLevel;
    }

    public int kiBlast(int concentration)
    {
        //  return concentration * this.PowerLevel;
        int kiBlast = concentration * this.PowerLevel;
        return kiBlast;
    }


    override public string ToString()
    {
        string zFighter = "ZFighter " + this.Name +
                            " has a power level of " +
                            this.PowerLevel + ".";
        return zFighter;
    }

}
using UnityEngine;

public class Gladiator
{
    //AESTHETICS
    public string name { get; set; }
    //whatever we use for gladiator visuals
    
    //COMBAT STATS
    public int health { get; set; }
    public int dodge { get; set; }      // (chance to dodge)
    public int speed { get; set; }      // (how fast they move in the arena)
    //stats that affect weapons
    public int strength { get; set; }   // (extra damage)
    public int accuracy { get; set; }   // (extra accuracy)
    public int attackSpeed { get; set; } // (extra attack speed)
    public int wingspan { get; set; }   // (extra range)

    //GEAR      (lot to expand on here) 
    public Handheld leftHand { get; set; }
    public Handheld righthand { get; set; }
    //helmet    //all the armors should probably be their own armor subclasses
    //chest
    //legs


    //empty constructor used for generating a gladiator with random stats
    public Gladiator()
    {
        this.name = NameGenerator.generateName();

        int[] stats = Random.generateStats();
        this.health = stats[0];
        this.dodge = stats[1];
        this.speed = stats[2];
        this.strength = stats[3];
        this.accuracy = stats[4];
        this.attackSpeed = stats[5];
        this.wingspan = stats[6];

    }
    
    //parameterized constructor for creating a gladiator with specific stats (for testing)
    public Gladiator(string name, int health, int dodge, int speed, int strength, int accuracy, int attackSpeed, int wingspan)
    {
        this.name = name;
        this.health = health;
        this.dodge = dodge;
        this.speed = speed;
        this.strength = strength;
        this.accuracy = accuracy;
        this.attackSpeed = attackSpeed;
        this.wingspan = wingspan;
    }

    public override string ToString()
    {
        return $"Gladiator: {name}\n" +
               $"  Health: {health}\n" +
               $"  Dodge: {dodge}\n" +
               $"  Speed: {speed}\n" +
               $"  Strength: {strength}\n" +
               $"  Accuracy: {accuracy}\n" +
               $"  Attack Speed: {attackSpeed}\n" +
               $"  Wingspan: {wingspan}";
    }

}

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

    //GEAR      (add these once we have gear) 
    //left hand
    //right hand
    //helmet
    //chest
    //legs


    //empty constructor used for generating a gladiator with random stats
    public Gladiator()
    {
        this.name = "Name";
        this.health = 0;
        this.dodge = 0;
        this.speed = 0;
        this.strength = 0;
        this.accuracy = 0;
        this.attackSpeed = 0;
        this.wingspan = 0;
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
}

using UnityEngine;

public class Weapon : Handheld
{
    //combat stats
    public int damage { get; set; }
    public int accuracy { get; set; }
    public int attackSpeed { get; set; }
    public int range { get; set; }

    public Weapon(string name, int damage, int accuracy, int attackSpeed, int range, bool twoHanded) : base(name, twoHanded)
    {
        this.damage = damage;
        this.accuracy = accuracy;
        this.attackSpeed = attackSpeed;
        this.range = range;
    }

}

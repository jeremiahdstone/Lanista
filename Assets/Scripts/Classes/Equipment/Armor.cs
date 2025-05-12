using UnityEngine;

public class Armor : Equipment
{
    public int defense { get; set; }
    
    public Armor(string name, int defense) : base(name)
    {
        this.defense = defense;
    }

}

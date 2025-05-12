using UnityEngine;

public abstract class Equipment
{
    public string name { get; set; } 
    //description, durability, price, weight, anything else we want for all equipment

    public Equipment(string name)
    {
        this.name = name;
    }
}

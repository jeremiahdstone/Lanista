using UnityEngine;

public abstract class Handheld : Equipment   //for weapons/shields or anything that is held in the players hands
{
    //for equiping
    public bool twoHanded { get; set; } //if true, locks other hand

    public Handheld(string name, bool twoHanded) : base(name)
    {
        this.twoHanded = twoHanded;
    }

    

}

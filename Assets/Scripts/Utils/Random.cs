using UnityEngine;
using System;

// everything random should be routed through this class, so that we can use the same random seed for everything
public static class Random 
{
    public static int seed = System.DateTime.Now.Millisecond;    //TODO this can be set in ui to set the seed of a run

    public static System.Random random = new System.Random(seed);

    //returns a random int between min and max
    //NOTE: includes min, excludes max
    public static int Range(int max, int min = 0)
    {
        //due to the ugly way default parameters have to come after, im just gonna make sure min/max are right
        if (min > max)
        {
            int temp = min;
            min = max;
            max = temp;
        }
        return random.Next(min, max);
    }

    //returns an array containing all the stats, centered around 0, with a little bit of variation. 
    // these should all total to 0, so every character generated is balanced
    const int numStats = 7; //how many stats to make
    public static int[] generateStats()
    {
        int[] stats = new int[numStats];
        Array.Fill(stats, 0); //initialize the array to all 0s (we can change this to be the average)

        //we can tweak these to get more/less variation
        int additions = numStats*2;
        int subtractions = numStats*2;

        //subtract loop, randomly subtracts 1 from some stats
        for (int i = 0; i < subtractions; i++)
        {
            stats[Random.Range(numStats)]--;
        }

        //add loop, randomly adds 1 to some stats
        for (int i = 0; i < additions; i++)
        {
            stats[Random.Range(numStats)]++;
        }
        return stats;
    }
}

using UnityEngine;

// everything random should be routed through this class, so that we can use the same random seed for everything
public static class Random 
{
    public static int seed = System.DateTime.Now.Millisecond;    //TODO this can be set in ui to set the seed of a run

    public static System.Random random = new System.Random(seed);

    //returns a random int between min and max
    public static int Range(int max, int min = 0)
    {
        Debug.Log("USING CORRECT RANDOM CLASS");
        //due to the ugly way default parameters have to come after, im just gonna make sure min/max are right
        if (min > max)
        {
            int temp = min;
            min = max;
            max = temp;
        }
        return random.Next(min, max);
    }
}

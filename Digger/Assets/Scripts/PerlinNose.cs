using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerlinNose : MonoBehaviour {


    long seed;

    public PerlinNose(long seed)
    {
        this.seed = seed;
    }

    private int random(int x,int range)
    {
        return (int)((x + seed) ^ 5) % range;
    }

    public int getNoise(int x, int range)//0 100
    {

        int chunkSize = 16;

        int chunkIndex = x / chunkSize; //6

        float prog = (x % chunkSize) / (chunkSize * 1f); //0.375

        float left_random = random(chunkIndex, range);
        float right_random = random(chunkIndex+1, range);

        float noise = (1 - prog) * left_random + prog * right_random;

        return (int)Mathf.Round(noise);
    }
}

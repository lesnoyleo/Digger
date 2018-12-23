using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateOre : MonoBehaviour {

    // Use this for initialization
    public GameObject coalOre;
    void Start () {

        addOreSpawn();
    }




    public void addOreSpawn()
    {
        int minX = 0;
        int maxX = 100; //minX is one, so setting this to 16 says all of the x ranges can be used
        int chancesToSpawn = 200; //How many times our ore can spawn in one chunk
        int minY = 50; //how low the ore can spawn
        int maxY = 80; //how high the ore can spawn
        int maxPossY = minY + (maxY - 1);
        int diffBtwnMinMaxY = maxY - minY;

        for (int i = 0; i < chancesToSpawn; i++)
        {
            int posX = minX + Random.Range(1,maxX);
            int posY = minY + Random.Range(1,diffBtwnMinMaxY);


            Instantiate(coalOre, new Vector2(posX, posY), Quaternion.identity);
        }
    }
}

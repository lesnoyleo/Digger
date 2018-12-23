using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateWorld : MonoBehaviour {

    public GameObject dirtPrefab;
    public GameObject grassPrefab;
    public GameObject coalOre;

    int minX = 0;
    int maxX = 100;
    int minY = 0;
    int maxY = 100;

    PerlinNose noise;


    // Use this for initialization
    void Start () {
        noise = new PerlinNose(Random.Range(1000000,10000000));
        Regenerate();	
	}
	


    private void Regenerate()
    {

        for (int i = minX; i < maxX; i++)
        {
            int columnHeight = noise.getNoise(i-minX, maxY - minY);
            for (int j = minY; j < minY+ columnHeight; j++)
            {

                if (j == minY + columnHeight - 1)
                {
                    Instantiate(grassPrefab, new Vector2(i, j), Quaternion.identity);
                }


                if ((j > minY) && (j< columnHeight-5) && Random.Range(1,100)==50)
                {

                    Instantiate(coalOre, new Vector2(i, j), Quaternion.identity);
                }







            }
        }
    }
}

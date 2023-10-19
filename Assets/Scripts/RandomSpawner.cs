using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public GameObject Candy1, Candy2, Candy3, Candy4, Candy5, Candy6;
    int x = 0;

    void Update()
    {
        if(x <= 15) 
        {
            x++;
            float rng = Random.Range(1, 6);

            Vector2 randomSpawnPosition = new Vector2(Random.Range(-3, 4), 6);

            if (rng == 1)
            {
                Instantiate(Candy1, randomSpawnPosition, Quaternion.identity);
            }
            else if (rng == 2)
            {
                Instantiate(Candy2, randomSpawnPosition, Quaternion.identity);
            }
            else if (rng == 3)
            {
                Instantiate(Candy3, randomSpawnPosition, Quaternion.identity);
            }
            else if (rng == 4)
            {
                Instantiate(Candy4, randomSpawnPosition, Quaternion.identity);
            }
            else if (rng == 5)
            {
                Instantiate(Candy5, randomSpawnPosition, Quaternion.identity);
            }
            else if (rng == 6)
            {
                Instantiate(Candy6, randomSpawnPosition, Quaternion.identity);
            }
        }
    }
}

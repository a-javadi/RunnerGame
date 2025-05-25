using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldGenerator : MonoBehaviour
{
    public GameObject[] platforms;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 pos = new(0, 0, 0);
        for (int i = 0; i < 20; i++)
        {
            int platformsNumber = Random.Range(0 , platforms.Length);
            GameObject p = Instantiate(platforms[platformsNumber] , pos , Quaternion.identity);
            if(platforms[platformsNumber].CompareTag("stairsUp")) pos.y += 5;          
            else if (platforms[platformsNumber].CompareTag("stairsDown"))
            {
                pos.y -= 5;
                p.transform.Rotate(new Vector3(0, 180, 0));
                p.transform.position = pos;
            }
            pos.z -= 10;
        }
    }

}

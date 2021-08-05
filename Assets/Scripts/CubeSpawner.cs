using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public GameObject movingCube;
    private Vector3 pos;

    private void Start()
    {
        CubeSpawn();
    }

    void CubeSpawn()
    {
        int cubeSize = 0;
        for (int x = 0; x < 20; x++)
        {
            for (int y = 0; y < 1; y++)
            {
                for (int z = 0; z < 10; z++)
                {
                    GameObject cube = Instantiate(movingCube, transform);
                    cube.transform.localPosition = new Vector3(x, y, z);
                    cubeSize++;

                    if (cubeSize == ImageToCube.cubeCount)
                    {
                        return;
                    }

                }
            }
        }
    }
}

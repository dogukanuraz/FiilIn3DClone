using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageToCube : MonoBehaviour
{
    Vector3 blockPos = Vector3.zero;
    public Sprite sprite;
    public GameObject cube;
    [HideInInspector]
    public static int cubeCount = 0;

    

    void Awake()
    {
        int size =0;
        for (int i = 0; i < sprite.texture.width; i++)
        {
            for (int j = 0; j < sprite.texture.height; j++)
            {
                Color color = sprite.texture.GetPixel(i, j);

                if (color.a == 0)
                {
                    continue;
                }

                blockPos = new Vector3((i - (sprite.texture.width * .5f)), .5f, (j - (sprite.texture.height * .5f)));

                GameObject cubeObj = Instantiate(cube, transform);
                cubeObj.transform.localPosition = blockPos;

                cubeObj.GetComponent<Renderer>().material.color = color;
                cubeObj.transform.localScale = Vector3.one;
                size++;
            }
        }
        //Debug.Log(size);
        cubeCount = size;
    }
    

}




using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    

    [HideInInspector]public int  totalObjects;
    public static int objectInScene;
    public Transform objectsParents;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CountObjects());
    }

    IEnumerator CountObjects()
    {
        yield return new WaitForSeconds(1);
        totalObjects = objectsParents.childCount;
        objectInScene = totalObjects;
    }
}

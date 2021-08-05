using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    private Color firstColor;

    private void Start()
    {
        firstColor = gameObject.GetComponent<Renderer>().material.color;
        gameObject.GetComponent<Renderer>().material.color = Color.gray;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "MovingCube")
        {
            gameObject.GetComponent<Renderer>().material.color = firstColor;
            Destroy(other.gameObject);
            LevelManager.objectInScene--;
            Debug.Log(LevelManager.objectInScene);
            if (LevelManager.objectInScene == 0)
            {
                Debug.Log("Level Tamamlandý");
            }
            Destroy(this.GetComponent<BoxCollider>());

        }

    }

    

   
}

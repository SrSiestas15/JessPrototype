using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Map code is called");
        if (EnterRoom.collectedMap == 1 )
        {
            Debug.Log("Conditional Met");
            spriteRenderer.enabled = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}

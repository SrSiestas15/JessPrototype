using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterRoom : MonoBehaviour
{
    public static int collectedMap;

    // Start is called before the first frame update
    void Start()
    {
        EnterRoom.collectedMap = 1;
        Debug.Log("Collected Map: " + EnterRoom.collectedMap);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

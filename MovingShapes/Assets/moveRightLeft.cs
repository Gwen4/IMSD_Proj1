using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveRightLeft : MonoBehaviour
{
    // Start is called before the first frame update
    float changingXPos;
    float amp = 3f;
    float freq = 1.3f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //sine + cosine function = sin/cos(frequency)*amplitude
        //frequency = speed
        //amplitude = distance
        changingXPos = Mathf.Cos(Time.time * freq) * amp;

        transform.position = new Vector3(changingXPos,0,0);
    }
}

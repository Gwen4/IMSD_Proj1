using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveinCircle : MonoBehaviour
{
    // Start is called before the first frame update
    float changingYPos;
    float changingXPos;
    float amp = 5f;
    float freq = 2f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        changingXPos = Mathf.Cos(Time.time * freq) * amp;
        changingYPos = Mathf.Sin(Time.time * freq) * amp;

        transform.position = new Vector3(changingXPos,changingYPos,0);
    }
}

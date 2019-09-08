using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMovement : MonoBehaviour
{


    int randomXPositionThatIsLeftOrRight;

    int spinX = 5;
    int spinY = 10;
    int spinZ = 3;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        MoveTheSphereCloserToTheScreen();
        SpinSphereInPlace();


    }

    void MoveTheSphereCloserToTheScreen()
    {
        transform.position = transform.position + Vector3.back * Time.deltaTime * 5;

    }

    void SpinSphereInPlace()
    {
        transform.Rotate(spinX, spinY, spinZ);

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    float speed;
    public GameObject world;
    public float areaLimit = 10f;

    void Update()
    {
        speed += Time.deltaTime / 100;
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - speed);

        float distanceFromOrgin = Vector3.Distance(transform.position, Vector3.zero);
        Vector3 direction = transform.position - Vector3.zero;

        if(distanceFromOrgin >= areaLimit)
        {
            transform.position = Vector3.zero;
            world.transform.position += direction * -1;
        }
    }
}

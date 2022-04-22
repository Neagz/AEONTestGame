using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    
    public GameObject player; // объект за которым следовать
    [Range(0,360)]
    public float angle = 270;
    [Range(0, 180)]
    public float angle2 = 55;
    [Range(1,100)]
    public float distance = 3.7F;
 
    void Update()
    {
        Vector3 coord = player.transform.position;
        float a = Mathf.Deg2Rad * angle;
        float a2 = Mathf.Deg2Rad * angle2;
        float x = coord.x + Mathf.Cos(a) * distance;
        float z = coord.z + Mathf.Sin(a) * distance;
        float y = coord.y + Mathf.Cos(a2) * distance;
        transform.position = new Vector3(x, y, z);
        transform.LookAt(player.transform);

    }
}

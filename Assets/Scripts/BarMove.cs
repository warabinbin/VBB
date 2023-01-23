using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarMove : MonoBehaviour
{
    public float speed = 30f;

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if(this.transform.position.x >= -16.0f)
                this.transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (this.transform.position.x <= 14.0f)
                this.transform.position += Vector3.right * speed * Time.deltaTime;
        }
    }
}
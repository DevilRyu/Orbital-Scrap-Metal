using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircularMovement : MonoBehaviour
{
    Rigidbody2D rb2D;
    Vector2 position;
    Vector2 center;
    float angle = 0;
    float speed = (2 * Mathf.PI) / 12; //2*PI in degress is 360, so you get 5 seconds to complete a circle
    float radius =10;

    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        position = rb2D.transform.position;
        center = rb2D.transform.position;
    }
    
    void Update()
    {
        angle -= speed * Time.deltaTime;
        var offset = new Vector2(Mathf.Sin(angle), Mathf.Cos(angle)) * radius;
        transform.position = center + offset;
    }
}

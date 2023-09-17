using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{

    [SerializeField] float speed;
    
    void Update()
    {
        MoveWall();

        CheckPos();
    }

    void MoveWall()
    {
        transform.Translate(new Vector3(-1, 0, 0) * speed * Time.deltaTime);
    }

    void CheckPos()
    {
        if (transform.position.x <= -6f)
        {
            transform.position = new Vector3(9.5f, Random.Range(1.5f, 4.5f), 0);
        }
    }
}

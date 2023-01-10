using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeController : MonoBehaviour
{
    //public GameObject cube;

    //public Vector2 cubePosition;
    public float speed = 20.0f;

    // Start is called before the first frame update
    void Start()
    {
        //cubePosition.y = cube.transform.position.y;
        //cubePosition.x = cube.transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            print("Going Up");
            //cubePosition.y += 1;
            gameObject.transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            print("Going Right");
            //cubePosition.x += 1;
            gameObject.transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            print("Going Down");
            //cubePosition.y -= 1;
            gameObject.transform.Translate(Vector3.back * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            print("Going Left");
            //cubePosition.x -= 1;
            gameObject.transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        //cube.transform.position = cubePosition;
    }
}

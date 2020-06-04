using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatPlayer : MonoBehaviour
{
    Rigidbody rigid;
    void Start()
    {
        Cat kitty = new Cat("kitty");
        kitty.PlaySound();
        kitty.Go();

        rigid = GetComponent<Rigidbody>();
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Debug.Log("앞으로~");
            transform.position = new Vector3(
                transform.position.x,
                transform.position.y,
                transform.position.z + 3f * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.UpArrow))
            Debug.Log("뒤로~");
            transform.position = new Vector3(
                transform.position.x,
                transform.position.y,
                transform.position.z - 3f*Time.deltaTime);
        }
    }
}

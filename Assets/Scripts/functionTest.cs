using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class functionTest : MonoBehaviour
{
    public int A;
    public int B;
    public int C;
    public float speed;

    void letsAddStuff(int value1, int value2)
    {
        C = value1 + value2;
        Debug.Log(C);
    }

    // Start is called before the first frame update
    void Start()
    {
        letsAddStuff(A,B);
        letsAddStuff(2, 4);
    }

    // Update is called once per frame
    void Update()
    {
        inputPaddle(KeyCode.W, KeyCode.S);
        inputPaddle(KeyCode.UpArrow, KeyCode.DownArrow);
    }


    void inputPaddle(KeyCode up, KeyCode down)
    {
        if (Input.GetKey(up))
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        else if (Input.GetKey(down))
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
    }




















}

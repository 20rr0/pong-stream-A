using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    public float Xposition = 0f;
    public float Yposition = 0f;
    public float xSpeed = 1f;
    public float ySpeed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        //Xposition = Random.Range(-10.0f, 10.0f);
        transform.position = new Vector3(Xposition, Yposition, 0);

    }

    // Update is called once per frame
    void Update()
    {
        Xposition = Xposition + xSpeed * Time.deltaTime;
        Yposition = Yposition + ySpeed * Time.deltaTime;
        transform.position = new Vector3(Xposition, Yposition, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Auw! That hurts.");
        if (collision.gameObject.CompareTag("horizontalWall"))
        {
            ySpeed = ySpeed * -1f;
            Debug.Log("The ceilin or floor.");

        }else if (collision.gameObject.CompareTag("verticalWall"))
        {
            xSpeed = xSpeed * -1f;
            Debug.Log("The left or right wall.");
        }
    }
}

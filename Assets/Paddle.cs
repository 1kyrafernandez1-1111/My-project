using UnityEngine;

public class Paddle : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow) == true) //if the user is pressing the right arrow key
        {
            transform.Translate(0.01f, 0f, 0f);
        }
        
        
       if (Input.GetKey(KeyCode.LeftArrow) == true) //if the user is pressing the right arrow key
        {
            transform.Translate(-0.01f, -0f, -0f);
        }
        //Debug.Log(transform.position.x);

       if (Input.GetKey(KeyCode.Space) == true) //if the user is pressing the space key
        {
            GetComponent<AudioSource>().Play(); //get a reference to my audiosource component and play it
        }
    }
    
void OnCollisionEnter2D(Collision2D collision)
    {
        GetComponent<AudioSource>().Play(); //get a reference to my audiosource component and play it
    }

}

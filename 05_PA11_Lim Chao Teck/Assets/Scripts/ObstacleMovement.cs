using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    private float xSpeed = -4f;

    private bool Flag = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(xSpeed*Time.deltaTime, 0, 0f));
        if (transform.position.x < -8f)
        {
            Destroy(this.gameObject);
        }

        if (transform.position.x <= -7.5 && Flag == false)
        {
            Flag = true;
            GameManager.thisManager.UpdateScore();
        }
    }
}

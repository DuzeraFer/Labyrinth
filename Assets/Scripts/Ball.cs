using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public SceneController sceneController;
    Rigidbody rb;

    public float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector3(Input.acceleration.x * speed, 0, Input.acceleration.y * speed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Win"))
        {
            sceneController.nextScene();
        }

        if (collision.gameObject.CompareTag("KillObst"))
        {
            sceneController.restartScene();
        }
    }
}

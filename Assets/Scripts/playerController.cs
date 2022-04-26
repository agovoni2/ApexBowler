using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    private float speed = 20.0f;
    public GameObject playerCharacter;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
            transform.Translate(0, 0, 1 * Time.deltaTime * speed, Space.World);
        if (Input.GetKey("s"))
            transform.Translate(0, 0, -1 * Time.deltaTime * speed, Space.World);
        if (Input.GetKey("d"))
            transform.Translate(1 * Time.deltaTime * speed, 0, 0, Space.World);
        if (Input.GetKey("a"))
            transform.Translate(-1 * Time.deltaTime * speed, 0, 0, Space.World);

        // Snap to cardinal directions
        if (Input.GetKey("up"))
            transform.eulerAngles = new Vector3(0f, 90f, 0f);
        if (Input.GetKey("down"))
            transform.eulerAngles = new Vector3(0f, -90f, 0f);
        if (Input.GetKey("left"))
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
        if (Input.GetKey("right"))
            transform.eulerAngles = new Vector3(0f, 180f, 0f);

        // Snap to diagonals
        if (Input.GetKey("right") && Input.GetKey("up"))
            transform.eulerAngles = new Vector3(0f, 135f, 0f);
        if (Input.GetKey("right") && Input.GetKey("down"))
            transform.eulerAngles = new Vector3(0f, -135f, 0f);
        if (Input.GetKey("left") && Input.GetKey("up"))
            transform.eulerAngles = new Vector3(0f, 45f, 0f);
        if (Input.GetKey("left") && Input.GetKey("down"))
            transform.eulerAngles = new Vector3(0f, -45f, 0f);
    }
}

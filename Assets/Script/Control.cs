using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    public GameObject character;
    public float speed = 0.2f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Walk
        if (Input.GetKeyDown(KeyCode.W))
        {
            character.GetComponent<Animator>().SetBool("running", true);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            character.GetComponent<Animator>().SetBool("running", false);
        }
        // Back
        if (Input.GetKeyDown(KeyCode.S))
        {
            character.GetComponent<Animator>().SetBool("back", true);
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            character.GetComponent<Animator>().SetBool("back", false);
        }
        // Jump
        if (Input.GetKeyDown(KeyCode.Space))
        {
            character.GetComponent<Animator>().SetBool("jump", true);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            character.GetComponent<Animator>().SetBool("jump", false);
        }
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            character.transform.position +=  speed * character.transform.forward;
        }
        if (Input.GetKey(KeyCode.S))
        {
            character.transform.position -= speed * character.transform.forward;
        }
        if (Input.GetKey(KeyCode.A))
        {
            character.transform.position -= speed * character.transform.right;
        }
        if (Input.GetKey(KeyCode.D))
        {
            character.transform.position += speed * character.transform.right;
        }
        if (Input.GetKey(KeyCode.Q))
        {
            character.transform.position += speed * character.transform.up;
        }
        if (Input.GetKey(KeyCode.Z))
        {
            character.transform.position -= speed * character.transform.up;
        }
    }
}

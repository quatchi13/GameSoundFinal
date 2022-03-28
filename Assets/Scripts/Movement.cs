using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public TriggerCheck left;
    public TriggerCheck right;
    public TriggerCheck up;
    public TriggerCheck down;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D) && right.GetState())
        {
            transform.position += new Vector3(1,0,0);
        }
        else if (Input.GetKeyDown(KeyCode.A) && left.GetState())
        {
            transform.position -= new Vector3(1,0,0);
        }
        else if (Input.GetKeyDown(KeyCode.W) && up.GetState())
        {
            transform.position += new Vector3(0, 0, 1);
        }
        else if (Input.GetKeyDown(KeyCode.S) && down.GetState())
        {
            transform.position -= new Vector3(0, 0, 1);
        }
    }
}

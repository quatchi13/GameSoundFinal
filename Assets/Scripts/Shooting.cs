using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    
    public Transform bullettransform;
    public ConstantVelocity bulletvelocity;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow) && bullettransform.position.y > 10)
        {
            bullettransform.position = transform.position + new Vector3 (0, 1, 0);
            bulletvelocity.zspeed = 0;
            bulletvelocity.xspeed = 2;
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow) && bullettransform.position.y > 10)
        {
            bullettransform.position = transform.position + new Vector3(0, 1, 0);
            bulletvelocity.zspeed = 0;
            bulletvelocity.xspeed = -2;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow) && bullettransform.position.y > 10)
        {
            bullettransform.position = transform.position + new Vector3(0, 1, 0);
            bulletvelocity.xspeed = 0;
            bulletvelocity.zspeed = 2;

        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && bullettransform.position.y > 10)
        {
            bullettransform.position = transform.position + new Vector3(0, 1, 0);
            bulletvelocity.xspeed = 0;
            bulletvelocity.zspeed = -2;
        }
    }
}

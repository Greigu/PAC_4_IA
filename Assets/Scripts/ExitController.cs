using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitController : MonoBehaviour
{
    public GameObject door;
    private Renderer doorR;
    // Start is called before the first frame update
    void Start()
    {
       doorR = door.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if( gameObject.transform.position.x >= 1.50f)
        {
            Debug.Log("AAAAAAA");
            doorR.material.color = Color.green;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestFunctions : MonoBehaviour
{
    public GameObject cube;
    private Renderer cubeRenderer;
    // Start is called before the first frame update
    void Start()
    {
        cubeRenderer = cube.GetComponent<Renderer>();
    }

    public void InHover()
    {
        //Debug.Log("IN");
        cubeRenderer.material.color = Color.red;
    }

    public void OutHover()
    {
        //Debug.Log("OUT");
        cubeRenderer.material.color = Color.green;
    }

    public void OnClick()
    {
        Debug.Log("click");
        cubeRenderer.material.color = Color.blue;
    }


}

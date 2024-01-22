using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsController : MonoBehaviour
{
    public GameObject easyButton;
    public GameObject mediumButton;
    public GameObject hardButton;
    //
    private Renderer easyRend;
    private Renderer mediumRend;
    private Renderer hardRend;

    // Start is called before the first frame update
    void Start()
    {
        easyRend = easyButton.GetComponent<Renderer>();
        mediumRend = mediumButton.GetComponent<Renderer>();
        hardRend = hardButton.GetComponent<Renderer>();
        mediumRend.material.color = Color.green;
    }
    public void OnPressEasy()
    {
        easyRend.material.color = Color.green;
        mediumRend.material.color = Color.black;
        hardRend.material.color = Color.black;

    }
    public void OnPressMedium()
    {
        easyRend.material.color = Color.black;
        mediumRend.material.color = Color.green;
        hardRend.material.color = Color.black;
    }
    public void OnPressHard()
    {
        easyRend.material.color = Color.black;
        mediumRend.material.color = Color.black;
        hardRend.material.color = Color.green;
    }
}

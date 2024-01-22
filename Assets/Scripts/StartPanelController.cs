using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class StartPanelController : MonoBehaviour
{
    public GameObject startButton;
    public GameObject continueButton;
    public GameObject newButton;
    public GameObject lever;
    //
    private Renderer startRend;
    private Renderer newRend;
    private Renderer contRend;

    private bool isButtonActive;

    // Start is called before the first frame update
    void Start()
    {
        startRend = startButton.GetComponent<Renderer>();
        newRend = newButton.GetComponent<Renderer>();
        contRend = continueButton.GetComponent<Renderer>();
    }

    private void Update()
    {
        if(isButtonActive && lever.transform.position.y <= 0.30f)
        {
            startRend.material.color = Color.green;
        }
    }

    public void OnPressStart()
    {
        
        
    }
    public void OnPressNew()
    {
        Debug.Log("IN");
        newRend.material.color = Color.green;
        contRend.material.color = Color.black;
        isButtonActive = true;
    }
    public void OnPressContinue()
    {
        contRend.material.color = Color.green;
        newRend.material.color = Color.black;
        isButtonActive = true;
    }
    
}

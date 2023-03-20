using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public GameObject modal;
    public GameObject currentStep;
    private TextMeshProUGUI currentStepMsg;
    private string stepName;

    void Start()
    {
        modal.SetActive(false); 
    }

    void Update()
    {
        currentStepMsg = currentStep.GetComponent<TextMeshProUGUI>(); 
    }

    public void hideModal() 
    {
        modal.SetActive(false);
    }

    public void showModal(string step)
    {
        stepName = step;
        currentStepMsg.text = step;
        modal.SetActive(true);
    }

    public void Navigate(string key) 
    {
        SceneManager.LoadScene(stepName.ToLower()+"_"+key.ToLower());
    }

    public void CloseApp() 
    {
        Application.Quit();
    }
}

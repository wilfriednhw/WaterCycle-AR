using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogController : MonoBehaviour
{
    public string[] stringArray;
    public GameObject stepInfos;
    private TextMeshProUGUI textInput;


    private void Start() 
    {
        textInput = stepInfos.GetComponent<TextMeshProUGUI>(); // Récupérer l'objet graphique qui affiche les messages

        StartCoroutine(process());
    }

    private IEnumerator process()
    {
        int counter = 0;

        while (counter < stringArray.Length) {
            yield return new WaitForSeconds(5); // Attendre 5 secondes

            textInput.text = stringArray[counter]; // Afficher le texte suivant
            counter ++;
        }
    }
}

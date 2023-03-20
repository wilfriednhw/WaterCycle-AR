using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StepActionController : MonoBehaviour
{
   public GameObject island;
   public GameObject buttonPlay;
   public GameObject buttonPause;

   private AudioSource[] sounds;

   void Start ()
   {
      sounds = getSounds();
   }

   void Update() 
   {
      
   }

   public void Play()
   {
      Time.timeScale = 1;

      if (buttonPlay.activeSelf && !island.activeSelf)
      {
         island.SetActive(true); // Afficher l'ile
      }

      buttonPlay.SetActive(false);   // Cacher le bouton play
      buttonPause.SetActive(true); // Activer le bouton pause

      playSounds(); // Jouer les sons
   }

   public void Pause ()
   {
      buttonPlay.SetActive(true);  // Activer le bouton play
      buttonPause.SetActive(false);  // Cacher le bouton pause

      Time.timeScale = 0; // Figer la scene

      pauseSounds(); // Stopper les sons
   }

   private AudioSource[] getSounds()
   {
      return GameObject.FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
   }

   void pauseSounds()
   {
      if (sounds == null)
      {
         sounds = getSounds();
      }

      for (int i = 0; i < sounds.Length; i++)
      {
         sounds[i].Pause();
      }
   }

   void playSounds()
   {
      if (sounds == null)
      {
         sounds = getSounds();
      }

      for (int i = 0; i < sounds.Length; i++)
      {
         sounds[i].Play();
      }
   }

   public void BackToMenu()
   {
      SceneManager.LoadScene(0);
   }
}

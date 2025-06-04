using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField]float DelayCrash;
    [SerializeField]ParticleSystem CrashEffect;
    [SerializeField]AudioClip crashSFX;
    bool hasCrashed = false;
  public void OnTriggerEnter2D(Collider2D other)
  {
    if(other.tag == "Ground" && !hasCrashed)
    {
      hasCrashed = true;
      FindObjectOfType<PlayerController>().DisableControls();
      CrashEffect.Play();
      GetComponent<AudioSource>().PlayOneShot(crashSFX);
      Invoke("ReloadScene",DelayCrash);
    }
   
  }
  void ReloadScene()
  {
    SceneManager.LoadScene(0);
  }
}

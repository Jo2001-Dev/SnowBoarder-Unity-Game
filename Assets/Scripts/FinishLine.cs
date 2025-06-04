using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FinishLine : MonoBehaviour
{
    [SerializeField]float DelayFinish;
    [SerializeField]ParticleSystem finishEffect;
    bool haspassed = false;

  void OnTriggerEnter2D(Collider2D other)
  {
    if(other.tag == "Player" && !haspassed)
    {
      haspassed = true;
      finishEffect.Play();
      GetComponent<AudioSource>().Play();
      Invoke("ReloadScene",DelayFinish);
     
    }
   
  }
  void ReloadScene()
  {
    SceneManager.LoadScene(0);
  }
}

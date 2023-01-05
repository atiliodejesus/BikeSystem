using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlOfIn : MonoBehaviour
{
  public GameObject[] toActive;
  public GameObject[] toDesative;
  public bool inTrigger;

  bool inVehicle;
  void Update()
  {
    if (inTrigger)
    {
      if (Input.GetKey("f") && !inVehicle)
      {
        for (int t = 0; t < toActive.Length; t++)
        {
          toActive[t].SetActive(true);
        }
        for (int t = 0; t < toDesative.Length; t++)
        {
          toDesative[t].SetActive(false);
        }
        inVehicle = true;
      }
    }
    if (Input.GetKey("g") && inVehicle)
    {
      for (int t = 0; t < toActive.Length; t++)
      {
        toActive[t].SetActive(false);
      }
      for (int t = 0; t < toDesative.Length; t++)
      {
        toDesative[t].SetActive(true);
      }
      inVehicle = false;
    }
  }


  private void OnTriggerEnter(Collider other)
  {
    if (other.gameObject.tag == "Player")
    {
      inTrigger = true;
    }
  }
  private void OnTriggerExit(Collider other)
  {
    inTrigger = false;
  }
}

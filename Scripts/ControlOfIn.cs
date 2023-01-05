using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class ControlOfIn : MonoBehaviour
{
  public UnityEvent toActive;
  public UnityEvent toDesative;
  public GameObject player;
  public Transform target;
  public bool inTrigger;

  bool inVehicle;
  void Update()
  {
    if (inTrigger)
    {
      if (Input.GetKey("f") && !inVehicle)
      {
        toActive.Invoke();
        inVehicle = true;
        inTrigger = false;
      }
    }
    if (Input.GetKey("g") && inVehicle)
    {
      toDesative.Invoke();
      player.transform.position = target.position;
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

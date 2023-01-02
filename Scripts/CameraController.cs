// //********************** © KD-Studios 2023 ***************************\\
// //************* Desenvolvido Por: Atílio De Jesus *********************\\
// //******************* Bike System versão 0.1v **************************\\

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BikeSystem
{
  //Scrip da camera da moto
  public class CameraController : MonoBehaviour
  {

    public Transform[] target;
    public SelectControlle select;


    void Update()
    {
      transform.position = target[select.index].position;
      transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, target[select.index].localEulerAngles.y, transform.localEulerAngles.z);
    }
  }
}

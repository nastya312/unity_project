using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitColision : MonoBehaviour
{
   public string [] Ded;
    public GameObject player;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Типа урон");
    }
}

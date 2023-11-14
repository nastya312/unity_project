using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillColision : MonoBehaviour
{
    public GameObject player;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(player);
        Debug.Log("Умер");
    }
}

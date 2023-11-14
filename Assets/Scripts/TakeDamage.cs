using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TakeDamage : MonoBehaviour
{
    public Text text;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        PleyerController.health -=1;
    }
    
}

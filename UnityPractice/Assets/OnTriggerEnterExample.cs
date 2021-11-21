using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerEnterExample : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            LoadLevels.Load("WinScreen");
        }
    }
}

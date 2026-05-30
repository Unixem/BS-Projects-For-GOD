using System;
using UnityEngine;

public class DummyBoyScript1 : MonoBehaviour
{
    
    public GameObject UILoseText;
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("No Ding Dong");
        UILoseText.SetActive(true);
    }
}

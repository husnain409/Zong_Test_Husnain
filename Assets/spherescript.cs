using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HurricaneVR.Framework.Core;

public class spherescript : MonoBehaviour
{
    public GameObject UI,MainUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (HVRGrabbable.FindObjectOfType<HVRGrabbable>().IsHandGrabbed)
        {
            UI.SetActive(false);
            MainUI.SetActive(true);
        }
    }
}

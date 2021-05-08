using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Retry : MonoBehaviour {

    void OnMouseUpAsButton()
    {
        switch (gameObject.name)
        {
            case "Retry":
                Application.LoadLevel("play");
                break;
            case "Home":
                Application.LoadLevel("Main");
                break;
            case "S":
                Application.LoadLevel("mag");
                break;
            case "campaign":
                Application.LoadLevel("campaign");
                break;
        }
    }
}

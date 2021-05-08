
    using UnityEngine;
using System.Collections;

public class Buttons : MonoBehaviour
{

    public Sprite layer_blue, layer_red;
    public string action;

    void OnMouseUpAsButton() { 
        {
        switch (gameObject.name) {
            case "Play":
                Application.LoadLevel("play");
                break;
            case "Rating":
                Application.OpenURL("http://google.com");
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
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CaptureHandler : MonoBehaviour
{
    public GameObject go;
    static bool toggle = false;

    public void HideShowGameObject() {
        toggle = !toggle;
        go.SetActive(toggle);
    }

}

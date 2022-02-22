using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageTargetHandler : MonoBehaviour
{
    public GameObject snake;
    public GameObject rhino;
    public GameObject monkey;

    public void SetImageTargetSnake() {
        snake.SetActive(true);
        rhino.SetActive(false);
        monkey.SetActive(false);
    }
    public void SetImageTargetRhino() {
        snake.SetActive(false);
        rhino.SetActive(true);
        monkey.SetActive(false);
    }
    public void SetImageTargetMonkey() {
        snake.SetActive(false);
        rhino.SetActive(false);
        monkey.SetActive(true);
    }
}

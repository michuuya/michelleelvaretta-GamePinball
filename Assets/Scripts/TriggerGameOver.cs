using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerGameOver : MonoBehaviour
{
    public Collider bola;
    public GameObject gameOverCanvas;

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other == bola)
        {
            gameOverCanvas.SetActive(true);
        }
    }
}

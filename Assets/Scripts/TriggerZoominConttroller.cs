using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZoominConttroller : MonoBehaviour
{
    public Collider bola;
    public CameraController cameraController;
    public float length;

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other == bola)
        {
            cameraController.FollowTarget(bola.transform, length);
        }
    }
}

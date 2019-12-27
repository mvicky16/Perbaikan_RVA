using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraRotate : MonoBehaviour
{
    public float speed = 10;

    void Update(){
        transform.Rotate(0, speed * Time.deltaTime, 0);
    }
}

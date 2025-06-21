using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterGame : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        Debug.Log(other.name + " Enter Trigger");
        if (other.CompareTag("Player")) {
            Debug.Log("Enter Game");
            SceneManager.LoadScene("_Scene_1");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
        public GameObject roket;
    private void OnCollisionEnter2D(Collision2D other) {
        Destroy(roket, .5f);
       SceneManager.LoadScene(0);

    }
}

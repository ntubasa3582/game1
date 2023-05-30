using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamemOver : MonoBehaviour
{
    int _gameover = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_gameover == 5)
        {
            ChangeScene();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "gomi")
        {
            _gameover++;
            Debug.Log(_gameover);
        }
    }
    void ChangeScene()
    {
        SceneManager.LoadScene("GameOver");
    }
}

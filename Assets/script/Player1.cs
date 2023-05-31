using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player1 : MonoBehaviour
{

    [SerializeField] int _score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "gomi")
        {
            _score++;
            Debug.Log(_score);
            if( _score == 30)
            {
                ChangeScene();
            }
        }
    }
    void ChangeScene()
    {
        SceneManager.LoadScene("clear");
    }
}

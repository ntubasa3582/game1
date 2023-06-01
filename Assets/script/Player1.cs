using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player1 : MonoBehaviour
{

    [SerializeField] int _score = 0;
    [SerializeField] int _clear = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_score == _clear ||_score >= _clear)
        {
            ChangeScene();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "gomi")
        {
            _score++;
            Debug.Log(_score);
        }
        if (collision.gameObject.tag == "gomi2")
        {
            _score++;
            _score++;
            Debug.Log(_score);
        }
        if(collision.gameObject.tag == "sumaho")
        {
            _score--;
        }
    }
    void ChangeScene()
    {
        SceneManager.LoadScene("clear");
    }
}

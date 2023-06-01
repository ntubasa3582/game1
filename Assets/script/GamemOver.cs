using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GamemOver : MonoBehaviour
{
    [SerializeField] int _gameover;
    [SerializeField] int _gameovercount;
    //Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_gameover >= _gameovercount)
        {
            ChangeScene();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "gomi")
        {
            _gameover++;
            //Debug.Log(_gameover);
        }
        if (collision.gameObject.tag == "gomi2")
        {
            _gameover++;
            _gameover++;
            //Debug.Log(_gameover);
        }
    }
    void ChangeScene()
    {
        SceneManager.LoadScene("GameOver");
    }
    //ゲームオーバーの値をsceneに出す
}

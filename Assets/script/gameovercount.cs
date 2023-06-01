using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameovercount : MonoBehaviour
{
    [SerializeField] Text _text;
    int _score = 20;
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
            //Debug.Log("a");
            _score--;
            Destroy(collision.gameObject);
            _text.text = _score.ToString("0");
            Debug.Log(_score);
        }
        if (collision.gameObject.tag == "gomi2")
        {
            //Debug.Log("a");
            _score--;
            _score--;
            Destroy(collision.gameObject);
            _text.text = _score.ToString("0");
            Debug.Log(_score);
        }
        if(collision.gameObject.tag == "sumaho")
        {
            Destroy(collision.gameObject);
        }
    }
}

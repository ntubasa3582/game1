using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class player : MonoBehaviour
{
    [SerializeField] int _player;
    [SerializeField] Text _text;
    int _score = 0;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(this.transform.position.x > 10 || this.transform.position.x < -10)
        {
            transform.position = new Vector3(0f, transform.position.y, transform.position.z);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "gomi")
        {
            _score++;
            Destroy(collision.gameObject);
            _text.text = _score.ToString("00");
        }
        if (collision.gameObject.tag == "sumaho")
        {
           _score--;
            Destroy(collision.gameObject);
            _text.text = _score.ToString("00");
        }
        if (collision.gameObject.tag == "gomi2")
        {
            _score++;
            _score++;
            Destroy(collision.gameObject);
            _text.text = _score.ToString("00");
            _text.text = _score.ToString("00");
        }
    }
}

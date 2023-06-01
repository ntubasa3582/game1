using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameovercount : MonoBehaviour
{
    public AudioClip _sound1;
    AudioSource _audioSource;
    [SerializeField] Text _text;
    int _score = 20;
    // Start is called before the first frame update
    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
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
            _audioSource.PlayOneShot(_sound1);
            Destroy(collision.gameObject);
            _text.text = _score.ToString("0");
            //Debug.Log(_score);
        }
        if (collision.gameObject.tag == "gomi2")
        {
            //Debug.Log("a");
            _score--;
            _score--;
            _audioSource.PlayOneShot(_sound1);
            Destroy(collision.gameObject);
            _text.text = _score.ToString("0");
            //Debug.Log(_score);
        }
        if(collision.gameObject.tag == "sumaho")
        {
            Debug.Log("a");
            Destroy(collision.gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player1 : MonoBehaviour
{
    public AudioClip _sound1;
    public AudioSource _audioSource;
    [SerializeField] int _score = 0;
    [SerializeField] int _clear = 0;
    // Start is called before the first frame update
    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
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
            _audioSource.PlayOneShot(_sound1);
        }
        if (collision.gameObject.tag == "gomi2")
        {
            _score++;
            _score++;
            Debug.Log(_score);
            _audioSource.PlayOneShot(_sound1);
        }
        if(collision.gameObject.tag == "sumaho")
        {
            _score--;
            _audioSource.PlayOneShot(_sound1);
        }
    }
    void ChangeScene()
    {
        SceneManager.LoadScene("clear");
    }
}

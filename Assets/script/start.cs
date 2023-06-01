using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class start : MonoBehaviour
{
    public AudioClip _sound1;
    public AudioClip _sound2;
    AudioSource _audioSource;
    [SerializeField] Text _text;
    int _count = 0;
    // Start is called before the first frame update
    void Start()
    {
        //if(Input.GetKeyDown(KeyCode.Space)) 
        //{
        //    Debug.Log("a");
        //    _text.enabled = false;
        //}
        _audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(_count == 0)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                _audioSource.PlayOneShot(_sound1);
                Debug.Log("a");
                _text.enabled = false;
                _count++;
                _audioSource.PlayOneShot(_sound2, 4f);
            }
        }
    }
}

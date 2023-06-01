using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class koukaon : MonoBehaviour
{
    public AudioClip _sound1;
    public AudioSource _audioSource;
    Button _button;
    // Start is called before the first frame update
    void Start()
    {
        _button = GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        //if()
        //_audioSource.PlayOneShot(sound1);
    }
    public void ClickSound()
    {
        _audioSource.PlayOneShot(_sound1);
    }
}

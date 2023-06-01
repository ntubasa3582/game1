using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class start : MonoBehaviour
{
    [SerializeField] Text _text;
    // Start is called before the first frame update
    void Start()
    {
        //if(Input.GetKeyDown(KeyCode.Space)) 
        //{
        //    Debug.Log("a");
        //    _text.enabled = false;
        //}
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("a");
            _text.enabled = false;
        }
    }
}

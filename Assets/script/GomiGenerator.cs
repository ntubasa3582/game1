using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GomiGenerator : MonoBehaviour
{
    [SerializeField] GameObject _gomiprehub = default;
    [SerializeField] float _interval = 1f;
    [SerializeField] bool _generatorOnstart = true;
    [SerializeField] int _leftPos;
    [SerializeField] int _rightPos;
    [SerializeField] GameObject _yazirusi;
    [SerializeField] float _topPos;
    bool _switch;
    float _timer;
    // Start is called before the first frame update
    void Start()
    {
        if (_generatorOnstart)
        {
            _timer = _interval;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            _switch = true;
        }
        _timer += Time.deltaTime;
        int random = Random.Range(_leftPos, _rightPos);
        if(_switch == true) 
        {
            if (_timer > _interval)
            {
                _timer = 0f;
                var trashPos = new Vector3(random, transform.position.y, transform.position.z);
                var yazirusi = new Vector3(random, _topPos, transform.position.z);
                Instantiate(_gomiprehub, trashPos, Quaternion.identity);
                Instantiate(_yazirusi, yazirusi, Quaternion.identity);
            }
        }

    }
}

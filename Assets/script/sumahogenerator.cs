using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sumahogenerator : MonoBehaviour
{
    [SerializeField] GameObject _sumahoPrehub = default;
    [SerializeField] float _interval = 1f;
    [SerializeField] bool _generatorOnstart = true;
    [SerializeField] int _leftPos;
    [SerializeField] int _rightPos;
    bool _swich;
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
        if(Input.GetKeyUp(KeyCode.Space)) 
        {
            _swich = true;
        }
        _timer += Time.deltaTime;
        int random = Random.Range(_leftPos, _rightPos);
        if(_swich == true) 
        {
            if (_timer > _interval)
            {
                _timer = 0;
                var trashPos = new Vector3(random, transform.position.y, transform.position.z);
                Instantiate(_sumahoPrehub, trashPos, Quaternion.identity);

            }
        }

    }
}

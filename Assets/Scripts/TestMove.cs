using System.Collections;
using UnityEngine;

public class TestMove : MonoBehaviour
{
    //public float speed = 10f;

    //private Vector3 target;

    //private void Start()
    //{
    //    target = transform.position;
    //}
    //private void Update()
    //{
    //    if (Input.GetMouseButtonDown(0))
    //    {
    //        target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    //        target.z = transform.position.z;
    //    }
    //    transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
    //}

    public float _speed;
    private bool _move;
    public GameObject _point;
    public  Vector3 _target;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _target = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, transform.position.z)) ;
            if (_move==false)
            {
                _move = true;
                Instantiate(_point, _target, Quaternion.identity);
            }
        }
        if (_move == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, _target, _speed * Time.deltaTime);
        }
    }

}

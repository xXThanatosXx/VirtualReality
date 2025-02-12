using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shipposition : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform _player;
    [Range(0, 200)] public float _deltarot = 30f;
    [Range(0, 200)] public float _deltamov = 10f;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        rotar();
        mover();
    }

    void rotar()
    {
        if (Input.GetKey(KeyCode.Q))
            _player.Rotate(new Vector3(0f, _deltarot, 0f) * Time.deltaTime);
        else if (Input.GetKey(KeyCode.E))
            _player.Rotate(new Vector3(0f, -_deltarot, 0f) * Time.deltaTime);

    }

    private void mover()
    {
        if (Input.GetKey(KeyCode.W))
            _player.Translate(Vector3.back * _deltamov * Time.deltaTime);
        else if (Input.GetKey(KeyCode.S))
            _player.Translate(Vector3.forward * _deltamov * Time.deltaTime);
        else if (Input.GetKey(KeyCode.A))
            _player.Translate(Vector3.left * _deltamov * Time.deltaTime);
        else if (Input.GetKey(KeyCode.D))
            _player.Translate(Vector3.right * _deltamov * Time.deltaTime);

    }

}

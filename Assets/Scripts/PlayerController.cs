using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float _hInput;
    private float _vInput;
    private float _mouseX;

    private int _movementSpeedModifier = 10;
    private int _rotationSpeedModifier = 20;

    [SerializeField]
    float mouseSensitivity;

    private GameObject _myGun;

    // Start is called before the first frame update
    void Start()
    {
        _myGun = this.gameObject.transform.GetChild(2).gameObject;

    }

    // Update is called once per frame
    void Update()
    {
        _hInput = Input.GetAxis("Horizontal");
        _vInput = Input.GetAxis("Vertical");
        _mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;

        transform.Translate(Vector3.forward * _vInput * _movementSpeedModifier * Time.deltaTime);

        transform.Translate(Vector3.right * _hInput * _movementSpeedModifier * Time.deltaTime);

        transform.Rotate(Vector3.up * _mouseX * _rotationSpeedModifier * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            _myGun.GetComponent<Weapon>().Shoot();
        }
    }
}

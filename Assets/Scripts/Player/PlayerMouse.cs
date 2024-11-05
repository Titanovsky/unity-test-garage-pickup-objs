using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PlayerMouse : MonoBehaviour
{
    [SerializeField] private float _minAngleX = -90f; // for realistic look around
    [SerializeField] private float _maxAngleX = 90f;
    [SerializeField] private float _sens = 300f;

    private float _mouseX;
    private float _mouseY;
    private float _rotationX = 0f;
    private float _rotationY = 90f; // чтобы сразу смотрел на дверь

    public new Camera camera;

    private void Look()
    {
        _mouseX = Input.GetAxis("Mouse X") * _sens * Time.deltaTime;
        _mouseY = Input.GetAxis("Mouse Y") * _sens * Time.deltaTime;

        _rotationX -= _mouseY;
        _rotationX = Mathf.Clamp(_rotationX, _minAngleX, _maxAngleX);

        _rotationY += _mouseX;

        if (camera != null)
        {
            camera.transform.rotation = Quaternion.Euler(_rotationX, _rotationY, 0);
        }
    }

    private void PrepareLook()
    {
        if (camera == null)
            camera = GetComponentInChildren<Camera>(true);

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Start()
    {
        PrepareLook();
    }

    private void Update()
    {
        Look();
    }
}

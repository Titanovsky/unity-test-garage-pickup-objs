﻿using UnityEngine;

[RequireComponent(typeof(PlayerMouse))]
public class PlayerUse : MonoBehaviour
{
    [SerializeField] private float _hitDistance = 15f;

    [SerializeField] private PlayerMouse _mouse;

    private void TraceUse()
    {
        if (_mouse == null) return;
        if (!Input.GetKeyDown(KeyCode.E)) return;

        RaycastHit hit;

        if (Physics.Raycast(transform.position, _mouse.camera.transform.forward * _hitDistance, out hit, Mathf.Infinity))
        {
            if (hit.transform.TryGetComponent(out IUsed obj))
            {
                obj.Use();
            }
        }
    }

    private void Prepare()
    {
        if (_mouse == null)
            _mouse = GetComponent<PlayerMouse>();
    }

    private void Start()
    {
        Prepare();
    }

    private void Update()
    {
        TraceUse();
    }
}
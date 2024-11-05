using System.Collections;
using UnityEngine;

public class Garage : MonoBehaviour
{
    [SerializeField] private float _speedOpenUp = .2f;
    [SerializeField] private float _timeOpenUp = 1.25f;
    [SerializeField] private bool _shouldOpenOnStart = true;

    private bool _opening = false;
    private float _delayOnUpdate = .1f; // .1f for the good speed for open

    public IEnumerator StartOpen()
    {
        _opening = true;

        Debug.Log("The garage started open");

        yield return new WaitForSeconds(_timeOpenUp);

        EndOpen();
    }

    public void EndOpen()
    {
        _opening = false;

        Debug.Log("The garage opened");
    }

    private IEnumerator Open()
    {
        yield return new WaitForSeconds(_delayOnUpdate);

        transform.position += new Vector3(0f, .1f * _speedOpenUp, 0f); // .1f for the good speed for open
    }

    private void Start()
    {
        if (_shouldOpenOnStart)
            StartCoroutine(StartOpen());
    }

    private void Update() //? maybe use FixedUpdate instead of .1f delay
    {
        if (_opening)
            StartCoroutine(Open());
    }
}

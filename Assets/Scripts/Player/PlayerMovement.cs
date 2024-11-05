using UnityEngine;

[RequireComponent(typeof(CharacterController))]
[RequireComponent(typeof(PlayerMouse))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private CharacterController _char;
    [SerializeField] private PlayerMouse _mouse;

    [SerializeField] private float _speed = 25f;
    private Vector3 _dir;

    private void PrepareMovement()
    {
        if (_char == null)
            _char = GetComponent<CharacterController>();

        if (_mouse == null)
            _mouse = GetComponent<PlayerMouse>();
    }

    private void CheckInputs()
    {
        Vector3 forward = _mouse.camera.transform.forward;
        Vector3 right = _mouse.camera.transform.right;

        // каждый раздельно в случае одновременного нажатия
        if (Input.GetKey(KeyCode.W)) // не люблю switch, но здесь он подойдёт отлично
            _dir += forward;

        if (Input.GetKey(KeyCode.S))
            _dir += -forward;

        if (Input.GetKey(KeyCode.D))
            _dir += right;

        if (Input.GetKey(KeyCode.A))
            _dir += -right;
    }

    private void Move() // по сути можно туда накинуть аргумент, и сделать более масштабируемый контроллер, но не в этот раз
    {
        _char.Move(_dir * _speed * Time.deltaTime);

        _dir = Vector3.zero;
    }


    private void Start()
    {
        PrepareMovement();
    }

    private void Update()
    {
        CheckInputs();
        Move();
    }
}

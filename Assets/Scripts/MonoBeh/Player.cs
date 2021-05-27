using UnityEngine;

namespace GoodStart
{
    public class Player : MonoBehaviour
    {
        
        [SerializeField] private float _speed;
        [SerializeField] private float _hp;
        [SerializeField] private float _acceleration;

        [SerializeField] private string _horizontalAxis = "Horizontal";
        [SerializeField] private string _verticalAxis = "Vertical";

        private Camera _camera;

        private Ship _ship;

        [SerializeField] private Transform _barrel;

        private IInput input;


        private void Start()
        {
            _camera = Camera.main;
            var moveTransform = new AccelerationMove(transform, _speed, _acceleration);
            var rotation = new RotationShip(transform);
            _ship = new Ship(moveTransform, rotation);

            input = new StandartInput(_ship, _barrel);
        }
        
        private void FixedUpdate()
        {
            var direction = Input.mousePosition - _camera.WorldToScreenPoint(transform.position);
            _ship.Rotation(direction);

            _ship.Move(Input.GetAxis(_horizontalAxis), Input.GetAxis(_verticalAxis), Time.deltaTime);

            input.InputCheck();

        }


        private void OnCollisionEnter2D(Collision2D other)
        {
            if (_hp <= 0)
            {
                Destroy(gameObject);
            }
            else
            {
                _hp--;
            }
        }
    }
}
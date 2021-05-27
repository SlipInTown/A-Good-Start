using UnityEngine;

namespace GoodStart
{
    internal sealed class StandartInput : IInput
    {
        [SerializeField] private Rigidbody2D _bullet;
        
        [SerializeField] private KeyCode _fireButton = KeyCode.Mouse0;
        [SerializeField] private KeyCode _leftShift = KeyCode.LeftShift;

        private IBullet _shooting;

        private Ship _ship;

        public StandartInput(Ship ship,Transform _barrel)
        {
            _ship = ship;

            _shooting = new ShootingBullet(_bullet, _barrel);
        }

        public void InputCheck()
        {
            if (Input.GetKeyDown(_leftShift))
            {
                _ship.AddAcceleration();
            }

            if (Input.GetKeyUp(_leftShift))
            {
                _ship.RemoveAcceleration();
            }

            if (Input.GetKeyDown(_fireButton))
            {
                _shooting.Launch();
            }
        }
    }
}
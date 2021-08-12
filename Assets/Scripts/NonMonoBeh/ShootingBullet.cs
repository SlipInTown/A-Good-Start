using UnityEngine;

namespace GoodStart
{
    public class ShootingBullet : IBullet
    {
        [SerializeField] private Transform _barrel;

        private readonly Rigidbody2D bullet;

        private readonly Vector3 position;

        private readonly Quaternion rotation;

        [SerializeField] private float _force;

        public ShootingBullet(Rigidbody2D bullet, Transform _barrel)
        {
            this._barrel = _barrel;
            this.bullet = bullet;
            position = _barrel.position;
            rotation = _barrel.rotation;
        }
        public void Launch()
        {
            var temAmmunition = Object.Instantiate(bullet, position, rotation);
            temAmmunition.AddForce(_barrel.up * _force);
        }

        
    }
}
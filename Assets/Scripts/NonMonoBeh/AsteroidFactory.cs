using UnityEngine;

namespace GoodStart
{
    internal sealed class AsteroidFactory : IEnemyFactory
    {
        public EnemyExample Create(Health hp)
        {
            var enemy = Object.Instantiate(Resources.Load<ShipEnemy>("Enemy/Asteroid"));

            return enemy;
        }
    }
}
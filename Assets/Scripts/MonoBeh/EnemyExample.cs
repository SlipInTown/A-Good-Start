using UnityEngine;

namespace GoodStart
{
    internal abstract class EnemyExample : MonoBehaviour
    {
        public static IEnemyFactory Factory;
        public Health Health { get; private set; }

        public static ShipEnemy CreateShipEnemy(Health hp)
        {
            var enemy = new ShipEnemy();

            enemy.Health = hp;

            return enemy;
        }

        public static SpaceGarbage CreateSpaceGarbage(Health hp)
        {
            return new SpaceGarbage { Health = hp };
        }
    }
}


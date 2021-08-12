using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Object = UnityEngine.Object;

namespace GoodStart
{
    internal sealed class BulletPool
    {
        private readonly Dictionary<string, HashSet<Bullet>> _bulletPool;
        private readonly int _capacityPool;
        private Transform _rootPool;


        public BulletPool(int capacityPool)
        {
            _bulletPool = new Dictionary<string, HashSet<Bullet>>();
            _capacityPool = capacityPool;
            if (!_rootPool)
            {
                _rootPool = new GameObject(NameManager.POOL_AMMUNITION).transform;
            }
        }

        public Bullet GetEnemy(string type)
        {
            Bullet result;
            switch (type)
            {
                case "Bullet":
                    result = GetBullet(GetListBullets(type));
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, "Не предусмотрен в программе");
            }

            return result;
        }


        private HashSet<Bullet> GetListBullets(string type)
        {
            return _bulletPool.ContainsKey(type) ? _bulletPool[type] : _bulletPool[type] = new HashSet<Bullet>();
        }

        private Bullet GetBullet(HashSet<Bullet> enemies)
        {
            var enemy = enemies.FirstOrDefault(a => !a.gameObject.activeSelf);
            if (enemy == null)
            {
                var laser = Resources.Load<Bullet>("Bullet");
                for (var i = 0; i < _capacityPool; i++)
                {
                    var instantiate = Object.Instantiate(laser);
                    ReturnToPool(instantiate.transform);
                    enemies.Add(instantiate);
                }

                GetBullet(enemies);
            }
            enemy = enemies.FirstOrDefault(a => !a.gameObject.activeSelf);
            return enemy;
        }

        private void ReturnToPool(Transform transform)
        {
            transform.localPosition = Vector3.zero;
            transform.localRotation = Quaternion.identity;
            transform.gameObject.SetActive(false);
            transform.SetParent(_rootPool);
        }

    }
}
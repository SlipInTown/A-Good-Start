namespace GoodStart
{
    enum EnemyType
    {
        AlienBoss,
        Alien
    }

    internal sealed class AlienFactory
    {
        public IEnemyAttack Create(EnemyType type)
        {
            switch (type)
            {
                case EnemyType.Alien:
                    return new Alien { AttackDamage = 10};
                case EnemyType.AlienBoss:
                    return new AlienBoss { AttackDamage = 30 };
                default:
                    throw null;
            }
        }
    }
}


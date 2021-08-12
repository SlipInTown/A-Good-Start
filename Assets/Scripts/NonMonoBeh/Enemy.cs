namespace GoodStart
{
    internal class Enemy : IEnemy
    {
        public IEnemyAttack EnemyAttack { get; }

        public Enemy(IEnemyAttack EnemyAttack)
        {
            this.EnemyAttack = EnemyAttack;
        }
    }
}
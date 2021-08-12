namespace GoodStart
{
    internal class Alien : IEnemyAttack
    {
        public float AttackDamage { get; set; }

        public void AttackPlayer(IPlayer player)
        {
            player.Health.ChangeCurrentHealth(AttackDamage);
        }
    }

    internal sealed class Opponent : IOpponent
    {

        public Opponent(IEnemyAttack attack)
        {
            enemyAttack = attack;
        }

        public IEnemyAttack enemyAttack { get ; set ; }
    }

}
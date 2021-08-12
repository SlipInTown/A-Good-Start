namespace GoodStart
{
    internal class AlienBoss : IEnemyAttack, IEnemyBoss
    {
        public float AttackDamage { get ; set ; }

        private IPlayer Player;

        public void AttackPlayer(IPlayer tempPlayer)
        {
            Player = tempPlayer;
            tempPlayer.Health.ChangeCurrentHealth(AttackDamage);
        }

        public void SpecialAbility()
        {
            // do smth
        }
    }
}
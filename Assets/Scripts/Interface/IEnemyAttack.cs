namespace GoodStart
{
    internal interface IEnemyAttack
    {
        float AttackDamage { get; set; }
        void AttackPlayer(IPlayer player);
    }
}
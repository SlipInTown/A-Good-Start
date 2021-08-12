namespace GoodStart
{
    internal class EnemyFactory
    {
        private readonly AlienFactory _alienFactory;

        public EnemyFactory()
        {
            _alienFactory = new AlienFactory();
        }

        public Enemy Create(EnemyType type)
        {
            var tempo = new AlienFactory();
            return new Enemy(tempo.Create(type));
        }
    }
}

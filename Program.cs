namespace HomeWorkOOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player(100, 50, 10, 30);
            player.ShowStats();
        }
    }

    class Player
    {
        private int _health;
        private int _armor;
        private int _speed;
        private int _damage;

        public Player(int health, int armor, int speed, int damage)
        {
            _health = health;
            _armor = armor;
            _speed = speed;
            _damage = damage;
        }

        public void ShowStats()
        {
            Console.WriteLine("Здоровье: " + _health + "\nБроня: " + _armor + "\nСкорость передивижения: " + _speed + "\nУрон: " + _damage);
        }
    }
}
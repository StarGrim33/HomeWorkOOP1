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
        public Player(int health, int armor, int speed, int damage)
        {
            Health = health;
            Armor = armor;
            Speed = speed;
            Damage = damage;
        }

        private int Health;
        private int Armor;
        private int Speed;
        private int Damage;

        public void ShowStats()
        {
            Console.WriteLine("Здоровье: " + Health + "\nБроня: " + Armor + "\nСкорость передивижения: " + Speed + "\nУрон: " + Damage);
        }
    }
}
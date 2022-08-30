using TZ.Interfaces;

namespace TZ.Movement
{
    public class RideHorse : IMovement
    {
        public void Move()
        {
            Console.WriteLine("*Скачет на лошади*");
        }
    }
}

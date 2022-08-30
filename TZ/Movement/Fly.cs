using TZ.Interfaces;

namespace TZ.Movement
{
    public class Fly : IMovement
    {
        public void Move()
        {
            Console.WriteLine("*Летит*");
        }
    }
}

using TZ.Interfaces;

namespace TZ.Movement
{
    public class Run : IMovement
    {
        public void Move()
        {
            Console.WriteLine("*Бежит*");
        }
    }
}

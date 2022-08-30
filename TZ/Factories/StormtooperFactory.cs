using TZ.Interfaces;
using TZ.Movement;
using TZ.Weapons;

namespace TZ.Factories
{
    public class StormtooperFactory : HeroFactory
    {
        public override IMovement CreateMovement()
        {
            return new RideHorse();
        }

        public override IWeapon CreateWeapon()
        {
            return new Sword();
        }
    }
}

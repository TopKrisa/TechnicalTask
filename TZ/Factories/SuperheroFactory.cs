using TZ.Interfaces;
using TZ.Movement;
using TZ.Weapons;

namespace TZ.Factories
{
    public class SuperheroFactory : HeroFactory
    {
        public override IMovement CreateMovement()
        {
            return new Fly();
        }

        public override IWeapon CreateWeapon()
        {
            return new LaserGun();
        }
    }
}

using TZ.Interfaces;

namespace TZ.Factories
{
    public abstract class HeroFactory
    {
        public abstract IMovement CreateMovement();
        public abstract IWeapon CreateWeapon();
    }
}

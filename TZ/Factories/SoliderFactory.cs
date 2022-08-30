using TZ.Interfaces;
using TZ.Movement;
using TZ.Weapons;

namespace TZ.Factories
{
    public class SoliderFactory : HeroFactory
    {
        public override IMovement CreateMovement()
        {
            return new Run();
        }

        public override IWeapon CreateWeapon()
        {
            return new Mushket();
        }
    }
}

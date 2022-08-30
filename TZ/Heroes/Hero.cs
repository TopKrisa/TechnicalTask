using TZ.Factories;
using TZ.Interfaces;

namespace TZ.Heroes
{
    public class Hero
    {
        private readonly IWeapon _weapon;
        private readonly IMovement _movement;
        public Hero(HeroFactory factory) => 
            (_weapon, _movement) = (factory.CreateWeapon(), factory.CreateMovement());
        public void Attack()=>
            _weapon.Attack();
        public void Move()=>
            _movement.Move();
        
    }
}

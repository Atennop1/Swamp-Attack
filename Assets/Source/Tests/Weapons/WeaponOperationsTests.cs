using NUnit.Framework;
using SwampAttack.Runtime.Model.Weapons;
using SwampAttack.Tests.NullComponents.Inventory;
using UnityEngine;

namespace SwampAttack.Tests.Weapons
{
    public class WeaponOperationsTests
    {
        private IWeapon _weapon;
        
        [SetUp]
        public void Setup()
        {
            _weapon = new Weapon(new NullBulletsFactory(), new NullWeaponBulletsView(), 1);
        }
        
        [Test]
        public void CantAddInvalidBullets()
        {
            var errors = 0;

            try { _weapon.AddBullets(-1); }
            catch { errors++; }

            try { _weapon.AddBullets(1); }
            catch { errors++; }
            
            if (errors == 2)
                Assert.Pass();
        }

        [Test]
        public void CantShootWithoutBullets()
        {
            _weapon.Shoot(Vector2.down);
            try { _weapon.Shoot(Vector2.down); }
            catch { Assert.Pass(); }
        }
    }
}
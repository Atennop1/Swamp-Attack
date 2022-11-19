using System;
using NUnit.Framework;

namespace SwampAttack.Tests.Health
{
    public class CreateHealthTests
    {
        [Test]
        public void CantCreateIncorrectHealth()
        {
            Assert.Throws<ArgumentException>(() => { var health = new Runtime.Model.HealthSystem.Health(-1); });
        }
    }
}
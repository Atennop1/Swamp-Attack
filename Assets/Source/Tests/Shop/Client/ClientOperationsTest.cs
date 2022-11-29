using System.Linq;
using NUnit.Framework;
using SwampAttack.Runtime.Model.Shop.Clients;
using SwampAttack.Runtime.Model.Weapons;
using SwampAttack.Runtime.Model.InventorySystem;
using SwampAttack.Runtime.Model.Shop.Products;
using SwampAttack.Tests.NullComponents.Inventory;
using SwampAttack.Tests.NullComponents.Products;
using SwampAttack.Tests.NullComponents.Wallet;

namespace SwampAttack.Tests.Shop.Client
{
    public class ClientOperationsTest
    {
        [Test]
        public void IsBuyingValid()
        {
            var inventory = new Inventory<IWeapon>(1);
            var client = new Client<IWeapon>(new NullProductsList<IWeapon>(), new NullWallet(10), inventory);
            
            var weapon = new Weapon(new NullBulletsFactory(), new NullWeaponBulletsView(), 1);
            var product = new Product<IWeapon>(weapon, new NullProductData());
            
            client.Buy(product);
            Assert.That(inventory.Items.Contains(weapon));
        }
    }
}
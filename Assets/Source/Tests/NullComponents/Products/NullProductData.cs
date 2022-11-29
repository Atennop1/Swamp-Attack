using SwampAttack.Runtime.SO.Products;
using UnityEngine;

namespace SwampAttack.Tests.NullComponents.Products
{
    public class NullProductData : IProductData
    {
        public string Name { get; }
        public string Description { get; }
        public Sprite Sprite { get; }
        
        public int Cost { get; }
        
        public NullProductData(int cost)
        {
            Cost = cost;
        }
    }
}
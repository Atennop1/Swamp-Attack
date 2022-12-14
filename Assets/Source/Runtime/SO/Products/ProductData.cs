using UnityEngine;

namespace SwampAttack.Runtime.SO.Products
{
    [CreateAssetMenu(menuName = "Product Data", fileName = "Product Data")]
    public class ProductData : ScriptableObject, IProductData
    {
        [field: SerializeField] public string Name { get; private set; }
        [field: SerializeField] public string Description { get; private set; }
        
        [field: SerializeField, Space] public Sprite Sprite { get; private set; }
        [field: SerializeField] public int Cost { get; private set; }
    }
}
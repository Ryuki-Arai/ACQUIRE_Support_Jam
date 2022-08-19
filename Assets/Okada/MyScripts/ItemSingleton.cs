using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSingleton : MonoBehaviour
{
    //public static ItemSingleton Instance;

    static private ItemSingleton _instance = new ItemSingleton();
    static public ItemSingleton Instance
    {
        get
        {
            if (_instance == null)
            {
                var obj = new GameObject(typeof(ItemSingleton).Name);
                _instance = obj.AddComponent<ItemSingleton>();
            }
            return _instance;
        }
    }
    private ItemSingleton() { }

    void Awake()
    {
        _instance = this;
        DontDestroyOnLoad(gameObject);
    }

    ItemCatch _itemCach = null;
    public void SetItem(ItemCatch _ic)
    {
        _itemCach = _ic;
    }
}

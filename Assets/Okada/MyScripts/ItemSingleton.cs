using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSingleton : MonoBehaviour
{
    //public static ItemSingleton Instance;

    static private ItemSingleton _instance = new ItemSingleton();
    static public ItemSingleton Instance => _instance;
    private ItemSingleton() { }

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    ItemCatch _itemCach = null;
    public void SetItem(ItemCatch _ic)
    {
        _itemCach = _ic;
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemArmaduras : MonoBehaviour
{
    
    public ScriptableItem itemInfo;

    public SpriteRenderer spriteRenderer;
    
    
    
    
    void Awake()
    {

        spriteRenderer = GetComponent<SpriteRenderer>();

    }
    void Start()
    {
        

        spriteRenderer.sprite = itemInfo.itemSprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collider)
    {

        


        InventoryManagerArmaduras.instance.AddArmorItem(itemInfo);
        Destroy(gameObject);




    }
}

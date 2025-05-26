using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
   public static InventoryManager instance;

   public ScriptableItem[] weapon;

   public Text[] weaponName;

   public Text[] weaponPrice;

   public Image[] weaponSprite;
   
   

    void Awake()
    {

        if(instance != null && instance !=this)
        {

            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }





    }


    public void AddItem(ScriptableItem item)
    {
        for (int i = 0; i < weapon.Length; i++)
        {
            if(weapon[i] == null)
            {

                weapon[i] = item;
                weaponName[i].text = item.itemName;
                weaponPrice[i].text = item.itemPrice;
                weaponSprite[i].sprite = item.itemSprite;

                return;





            }
        }





    }



    // Update is called once per frame
    void Update()
    {
        
    }



}

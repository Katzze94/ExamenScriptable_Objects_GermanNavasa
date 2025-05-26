using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManagerArmaduras : MonoBehaviour
{
   public static InventoryManagerArmaduras instance;

   public ScriptableItem[] armor;

   public Text[] armorName;

   public Text[] armorPrice;

   public Image[]  armorSprite;
   
   

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


    public void AddArmorItem(ScriptableItem item)
    {
        for (int i = 0; i < armor.Length; i++)
        {
            if(armor[i] == null)
            {

                armor[i] = item;
                armorName[i].text = item.itemName;
                armorPrice[i].text = item.itemPrice;
                armorSprite[i].sprite = item.itemSprite;

                return;





            }
        }





    }



    // Update is called once per frame
    void Update()
    {
        
    }



}

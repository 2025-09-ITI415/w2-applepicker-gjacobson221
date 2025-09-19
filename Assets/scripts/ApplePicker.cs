using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class ApplePicker : MonoBehaviour
{
    public GameObject basketPrefab;
    public int numBaskets = 3;
    public float basketBottomY = -14f;
    public float basketSpacingY = 2f;
    public List<GameObject> basketList;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        basketList = new List<GameObject>();
        for (int i = 0; i < numBaskets; i++)
        {
            GameObject tBasketGO = Instantiate(basketPrefab) as GameObject;
            Vector3 pos = Vector3.zero;
            pos.y = basketBottomY + (basketSpacingY * i);
            tBasketGO.transform.position = pos;
        }
    }
    public void AppleDestroyed()
    {
        //destory all of the falling apples
        GameObject[] tAppleArray = GameObject.FindGameObjectsWithTag("Apple");
        foreach (GameObject tGO in tAppleArray)
        {
            Destroy(tGO);
        }
        //Destroy one of the baskets
        //get the index of the last basket in the array
        int BasketIndex = basketList.Count - 1;
        //get reference to that basket gameobject
        GameObject tBasketGO = basketList[BasketIndex];
        //remove the basket from the list and destroy the gameobject
        basketList.RemoveAt(BasketIndex);
        Destroy(tBasketGO);
    }
        // Update is called once per frame
        void Update()
        {

        }
    }


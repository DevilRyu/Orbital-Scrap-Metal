using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    private string coinName;
    public int coinValue;

    void Start()
    {
        coinName = name.Substring(0, 5);
        switch (coinName)
        {
            case "Block":
                coinValue = 7;
                break;

            case "Satel":
                coinValue = 5;
                break;

            case "Anten":
                coinValue = 3;
                break;
        }

    }


}


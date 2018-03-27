using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// Starting in 2 seconds.
// a projectile will be launched every 0.3 seconds

public class moneyFall : MonoBehaviour
{
    public GameObject money;

    void Start()
    {
        print("yes");
        InvokeRepeating("MakeMoney", 2.0f, 0.8f);
    }

    void Update()
    {
        //GameObject tmp = Instantiate(money) as GameObject;
        //Instantiate(money, new Vector3(Random.Range(-5.0f, 5.0f), 0, 0), Quaternion.identity);
        print("yes");
    }

    void MakeMoney()
    {
        //GameObject tmp = Instantiate(money) as GameObject;
        Instantiate(money, new Vector3(Random.Range(-1.0f,1.0f), 0, Random.Range(-1.0f, 1.0f)), Quaternion.identity);
        print("yes");
    }
}

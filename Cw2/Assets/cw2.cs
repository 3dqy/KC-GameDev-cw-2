using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cw2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string HeroName = "outhman";
        int HeroAge = 18;
        float HeroHeight = 1.7f;
        string HeroSuperPower = "fireball";
        float addedheight = (HeroHeight+5);

        string VillainName = "messi";
        int VillainAge = 37;
        float VillainHeight = 1.6f;
        string VillainSuperPower = "dribling";

        int AgeDifference = (VillainAge - HeroAge);
        print(AgeDifference);
        print("hello! my hero is "+ HeroName + " He`s " + HeroHeight + " meters tall, aged " + HeroAge + " his super power is "+ HeroSuperPower +
            "..his enemy is "+ VillainName + " aged "+ VillainAge + " with a height of "+ VillainHeight + " his power is "+VillainSuperPower );

        print("hello! my hero is " + HeroName + " He`s " + addedheight+ " meters tall, aged " + HeroAge + " his super power is " + HeroSuperPower +
    "..his enemy is " + VillainName + " aged " + VillainAge + " with a height of " + VillainHeight + " his superpower is None "); 


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

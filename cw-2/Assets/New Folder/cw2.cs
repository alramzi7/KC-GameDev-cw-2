using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cw2 : MonoBehaviour
{
    string hero_Name = "hussain";
    int heroHeight = 170;
    int hero_Age = 15;
    string heroSuperPower = "Fire";
    string villainName = "ahmad";
    int vililanHeigh = 180;
    int villainAge = 19;
    string villainSuperPower = "pilot";

    // Start is called before the first frame update
    void Start()
    {
        int ageDifference = hero_Age - villainAge;
        print(" hero Name is " + hero_Name + " hero age is " + hero_Age + " heroHeight is " + heroHeight + " heroSuperPower " + heroSuperPower);
        print(" villainName " + villainName + " vililanHeigh " + vililanHeigh + " villainAge " + villainAge + " villainSuperPower " + villainSuperPower);
        print(" ageDifference is " + ageDifference);
        heroHeight += 5;
        print(heroHeight);
        villainSuperPower = "none";
        print("villainSuperPower after " + villainSuperPower);




    }

    // Update is called once per frame
    void Update()

    {
        
    }
}


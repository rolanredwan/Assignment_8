using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using UnityEngine;

public class assignment8 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Exercise 1:
        // int count = 1;
        // while (true)
        // {
        //     int randomNum = Random.Range(1, 21);
        //     Debug.Log(randomNum);
        //     // count ++;
        //     if (randomNum == 5) continue;
        //     if (randomNum == 15) break;

        // ----------------------------------------------------------------------------
        // Exercise 2:
        string[] words = { "Cat", "Dog", "Car", "Pizza", "Hat", "Fish", "Tree", "Monkey", "Ball", "Bird" };
        int count = 1;
        int randNum = 0;

        string randomSent = "";
        while (count == randNum || count <= 7)
        {
            randNum = Random.Range(1, 7);
            randomSent += words[randNum] + " ";
            count++;
        }
        Debug.Log(randomSent);
    }
}

// // Update is called once per frame
// void Update()
// {

//}


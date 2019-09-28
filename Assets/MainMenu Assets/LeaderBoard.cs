using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using System;
using System.IO;

public class LeaderBoard : MonoBehaviour
{
    // Start is called before the first frame update
    public static string path = @"C:\amirza28\";
    public static string scores = "scores.txt";
    public bool isFirst;
    public bool isSecond;
    public bool isThird;
    public static string[] scoreArray;
    void Start()
    {
        // initialize();
        // using (StreamReader sr = File.OpenText(path))
        // {
        //     string s = "";
        //     int i = 0;
        //     while ((s = sr.ReadLine()) != null && i < 3)
        //     {
        //         scoreArray[i++] = s;
        //     }
        //     sr.Close();
        // }       
    }

    public static void initialize() {

        if (!Directory.Exists(path))
        {
            Debug.Log("doesn't exist");
            DirectoryInfo di = Directory.CreateDirectory(path);
            using (StreamWriter sw = File.CreateText(path + scores))
            {
                sw.Close();
            }
        }
    }
    
    

    // Update is called once per frame
    void Update()
    {
        if (isFirst)
        {
            GetComponent<TextMesh>().text = scoreArray[0];
        }
        if (isSecond)
        {
            GetComponent<TextMesh>().text = scoreArray[1];
        }
        if (isThird)
        {
            GetComponent<TextMesh>().text = scoreArray[2];
        }
    }

    public static void updateLeaderBoard(string id, string time)
    {
        string [] output = new string [3];
        string [] lines = File.ReadAllLines(path + scores);  

        int curMin = int.Parse(time.Substring(0, 2));
        int curSec = int.Parse(time.Substring(3, 2));
        int curMs = int.Parse(time.Substring(6, 2));

        float curTotal = curMin * 60 + curSec + curMs/100;

        int idx = 0;
        int toPlace = idx;
        output[0] = id + " " + time;
        foreach (string line in lines)  {

            if (line.Length == 0) {
                continue;
            }
            string lTime = line.Substring(4, 8);
            int min = int.Parse(lTime.Substring(0, 2));
            int sec = int.Parse(lTime.Substring(3, 2));
            int ms = int.Parse(lTime.Substring(6, 2));

            float lTotal = min * 60 + sec + ms/100;

            if (curTotal <= lTotal) {
                toPlace = idx;
                break;
            }
            else {
                toPlace = 2;
            }
            idx++;
        }
        
        idx = 0;
        foreach (string line in lines)  {
            if (idx == toPlace) {
                output[idx++] = id + " " + time;
            }
            if (idx != 3) {
                output[idx++] = line;
            }

        }
        File.WriteAllLines(path + scores, output);
    }
}

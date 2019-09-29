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
        initialize();
        scoreArray = new string [3];
        scoreArray[0] = "N/A";
        scoreArray[1] = "N/A";
        scoreArray[2] = "N/A";

        int i = 0;
        string [] lines = File.ReadAllLines(path + scores);  
        foreach (string line in lines) {
            scoreArray[i++] = line;
        }       
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
        id = "AMZ";
        string [] lines = File.ReadAllLines(path + scores);  

        string [] trueOutput = new string [3] {"","",""};

        int trueCount = 0;
        for (int i = 0; i < lines.Length; i++) {
            if (lines[i].Length != 0) {
                trueOutput[trueCount++] = lines[i];
            }
            
        }
        Debug.Log(trueCount);

        int curMin = int.Parse(time.Substring(0, 2));
        int curSec = int.Parse(time.Substring(3, 2));
        int curMs = int.Parse(time.Substring(6, 2));
        float curTotal = curMin * 60 + curSec + curMs/100;

        for (int i = 0; i < trueOutput.Length; i++) {

            if (trueOutput[i].Length == 0) {
                trueOutput[i] = id + " " + time;
                break;
            }
            string lTime = trueOutput[i].Substring(4, 8);
            int min = int.Parse(lTime.Substring(0, 2));
            int sec = int.Parse(lTime.Substring(3, 2));
            int ms = int.Parse(lTime.Substring(6, 2));
            float lTotal = min * 60 + sec + ms/100;

              if (curTotal <= lTotal) { 

                  if (i == 0) {
                    string temp1 = trueOutput[i];
                    string temp2 = trueOutput[i + 1];

                    trueOutput[i] = id + " " + time;
                    trueOutput[i + 1] = temp1;
                    trueOutput[i + 2] = temp2;
                    break;

                  }
                  else if (i == 1) {
                    string temp1 = trueOutput[i];
                    trueOutput[i] = id + " " + time;
                    trueOutput[i + 1] = temp1;
                    break;
                  }
                  else if (i == 2) {
                      trueOutput[i] = id + " " + time;
                      break;
                  }
            } 
        }
        scoreArray = trueOutput;
        File.WriteAllLines(path + scores, trueOutput);
    }
}

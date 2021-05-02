using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class NGS1Manager : MonoBehaviour
{

    public GameObject T1Panel;
    public GameObject T2Panel;

    public InputField T1;
    public InputField T2;
    public Text T1t;
    public Text T2t;

    public GameObject InstantiateImage;
    public BigData BigD;
    // Start is called before the first frame update
    void Start()
    {
       BigD = GameObject.Find("BigDataObject(Clone)").GetComponent<BigData>(); 
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setTeam1Number()
    {

        foreach (Transform child in T1Panel.transform)
        {
            GameObject.Destroy(child.gameObject);
        }

        int x = int.Parse(T1t.text);

        for (int i = 1; i < x+1; i++)
        {
            var NewPlayerImage = Instantiate(InstantiateImage, new Vector3(0, 0, 0), Quaternion.identity);
            NewPlayerImage.transform.parent = T1Panel.transform;

            string a = "Enter Player ";
            string b = "" + i;
            string c = " Name...";

            NewPlayerImage.transform.Find("InputField").transform.Find("Placeholder").GetComponent<Text>().text = a + b + c;

        }
    }
    public void setTeam2Number()
    {
        foreach (Transform child in T2Panel.transform)
        {
            GameObject.Destroy(child.gameObject);
        }

        int x = int.Parse(T2t.text);


        for (int i = 1; i < x + 1; i++)
        {
            var NewPlayerImage = Instantiate(InstantiateImage, new Vector3(0, 0, 0), Quaternion.identity);
            NewPlayerImage.transform.parent = T2Panel.transform;

            string a = "Enter Player ";
            string b = "" + i;
            string c = " Name...";

            NewPlayerImage.transform.Find("InputField").transform.Find("Placeholder").GetComponent<Text>().text = a + b + c;

        }
    }

    public void ConfirmFunc()
    {
        int bigDcurrentGNumber = BigD.CurrentGameNumber;
        BigD.CurrentGameACTUAL = BigD.CurrentGameNumber;

        if (bigDcurrentGNumber == 1)
        {
            int t1counter = 1;
            foreach (Transform child in T1Panel.transform)
            {
                string Pname = child.Find("InputField").Find("Text").GetComponent<Text>().text;

                BigD.Game1Names[t1counter - 1] = Pname;
                BigD.G1Teams[t1counter - 1] = 1;
                t1counter++;
            }

            int t2counter = 0;
            int totalcounter = 0;
            foreach (Transform child in T2Panel.transform)
            {
                totalcounter = t2counter + t1counter;
                string Pname = child.Find("InputField").Find("Text").GetComponent<Text>().text;

                BigD.Game1Names[totalcounter - 1] = Pname;
                BigD.G1Teams[totalcounter - 1] = 2;
                t2counter++;
            }
        }
        if (bigDcurrentGNumber == 2)
        {
            int t1counter = 1;
            foreach (Transform child in T1Panel.transform)
            {
                string Pname = child.Find("InputField").Find("Text").GetComponent<Text>().text;

                BigD.Game2Names[t1counter - 1] = Pname;
                BigD.G2Teams[t1counter - 1] = 1;
                t1counter++;
            }

            int t2counter = 0;
            int totalcounter = 0;
            foreach (Transform child in T2Panel.transform)
            {
                totalcounter = t2counter + t1counter;
                string Pname = child.Find("InputField").Find("Text").GetComponent<Text>().text;

                BigD.Game2Names[totalcounter - 1] = Pname;
                BigD.G2Teams[totalcounter - 1] = 2;
                t2counter++;
            }
        }
        if (bigDcurrentGNumber == 3)
        {
            int t1counter = 1;
            foreach (Transform child in T1Panel.transform)
            {
                string Pname = child.Find("InputField").Find("Text").GetComponent<Text>().text;

                BigD.Game3Names[t1counter - 1] = Pname;
                BigD.G3Teams[t1counter - 1] = 1;
                t1counter++;
            }

            int t2counter = 0;
            int totalcounter = 0;
            foreach (Transform child in T2Panel.transform)
            {
                totalcounter = t2counter + t1counter;
                string Pname = child.Find("InputField").Find("Text").GetComponent<Text>().text;

                BigD.Game3Names[totalcounter - 1] = Pname;
                BigD.G3Teams[totalcounter - 1] = 2;
                t2counter++;
            }
        }
        if (bigDcurrentGNumber == 4)
        {
            int t1counter = 1;
            foreach (Transform child in T1Panel.transform)
            {
                string Pname = child.Find("InputField").Find("Text").GetComponent<Text>().text;

                BigD.Game4Names[t1counter - 1] = Pname;
                BigD.G4Teams[t1counter - 1] = 1;
                t1counter++;
            }

            int t2counter = 0;
            int totalcounter = 0;
            foreach (Transform child in T2Panel.transform)
            {
                totalcounter = t2counter + t1counter;
                string Pname = child.Find("InputField").Find("Text").GetComponent<Text>().text;

                BigD.Game4Names[totalcounter - 1] = Pname;
                BigD.G4Teams[totalcounter - 1] = 2;
                t2counter++;
            }
        }
        if (bigDcurrentGNumber == 5)
        {
            int t1counter = 1;
            foreach (Transform child in T1Panel.transform)
            {
                string Pname = child.Find("InputField").Find("Text").GetComponent<Text>().text;

                BigD.Game5Names[t1counter - 1] = Pname;
                BigD.G5Teams[t1counter - 1] = 1;
                t1counter++;
            }

            int t2counter = 0;
            int totalcounter = 0;
            foreach (Transform child in T2Panel.transform)
            {
                totalcounter = t2counter + t1counter;
                string Pname = child.Find("InputField").Find("Text").GetComponent<Text>().text;

                BigD.Game5Names[totalcounter - 1] = Pname;
                BigD.G5Teams[totalcounter - 1] = 2;
                t2counter++;
            }
        }
        if (bigDcurrentGNumber == 6)
        {
            int t1counter = 1;
            foreach (Transform child in T1Panel.transform)
            {
                string Pname = child.Find("InputField").Find("Text").GetComponent<Text>().text;

                BigD.Game6Names[t1counter - 1] = Pname;
                BigD.G6Teams[t1counter - 1] = 1;
                t1counter++;
            }

            int t2counter = 0;
            int totalcounter = 0;
            foreach (Transform child in T2Panel.transform)
            {
                totalcounter = t2counter + t1counter;
                string Pname = child.Find("InputField").Find("Text").GetComponent<Text>().text;

                BigD.Game6Names[totalcounter - 1] = Pname;
                BigD.G6Teams[totalcounter - 1] = 2;
                t2counter++;
            }
        }
        if (bigDcurrentGNumber == 7)
        {
            int t1counter = 1;
            foreach (Transform child in T1Panel.transform)
            {
                string Pname = child.Find("InputField").Find("Text").GetComponent<Text>().text;

                BigD.Game7Names[t1counter - 1] = Pname;
                BigD.G7Teams[t1counter - 1] = 1;
                t1counter++;
            }

            int t2counter = 0;
            int totalcounter = 0;
            foreach (Transform child in T2Panel.transform)
            {
                totalcounter = t2counter + t1counter;
                string Pname = child.Find("InputField").Find("Text").GetComponent<Text>().text;

                BigD.Game7Names[totalcounter - 1] = Pname;
                BigD.G7Teams[totalcounter - 1] = 2;
                t2counter++;
            }
        }
       /* if (bigDcurrentGNumber == 8)
        {
            int t1counter = 1;
            foreach (Transform child in T1Panel.transform)
            {
                string Pname = child.Find("InputField").Find("Text").GetComponent<Text>().text;

                BigD.Game8Names[t1counter - 1] = Pname;
                BigD.G8Teams[t1counter - 1] = 1;
                t1counter++;
            }

            int t2counter = 0;
            int totalcounter = 0;
            foreach (Transform child in T2Panel.transform)
            {
                totalcounter = t2counter + t1counter;
                string Pname = child.Find("InputField").Find("Text").GetComponent<Text>().text;

                BigD.Game8Names[totalcounter - 1] = Pname;
                BigD.G8Teams[totalcounter - 1] = 2;
                t2counter++;
            }
        }
        if (bigDcurrentGNumber == 9)
        {
            int t1counter = 1;
            foreach (Transform child in T1Panel.transform)
            {
                string Pname = child.Find("InputField").Find("Text").GetComponent<Text>().text;

                BigD.Game9Names[t1counter - 1] = Pname;
                BigD.G9Teams[t1counter - 1] = 1;
                t1counter++;
            }

            int t2counter = 0;
            int totalcounter = 0;
            foreach (Transform child in T2Panel.transform)
            {
                totalcounter = t2counter + t1counter;
                string Pname = child.Find("InputField").Find("Text").GetComponent<Text>().text;

                BigD.Game9Names[totalcounter - 1] = Pname;
                BigD.G9Teams[totalcounter - 1] = 2;
                t2counter++;
            }
        }
        if (bigDcurrentGNumber == 10)
        {
            int t1counter = 1;
            foreach (Transform child in T1Panel.transform)
            {
                string Pname = child.Find("InputField").Find("Text").GetComponent<Text>().text;

                BigD.Game10Names[t1counter - 1] = Pname;
                BigD.G10Teams[t1counter - 1] = 1;
                t1counter++;
            }

            int t2counter = 0;
            int totalcounter = 0;
            foreach (Transform child in T2Panel.transform)
            {
                totalcounter = t2counter + t1counter;
                string Pname = child.Find("InputField").Find("Text").GetComponent<Text>().text;

                BigD.Game10Names[totalcounter - 1] = Pname;
                BigD.G10Teams[totalcounter - 1] = 2;
                t2counter++;
            }
        }
        if (bigDcurrentGNumber == 11)
        {
            int t1counter = 1;
            foreach (Transform child in T1Panel.transform)
            {
                string Pname = child.Find("InputField").Find("Text").GetComponent<Text>().text;

                BigD.Game11Names[t1counter - 1] = Pname;
                BigD.G11Teams[t1counter - 1] = 1;
                t1counter++;
            }

            int t2counter = 0;
            int totalcounter = 0;
            foreach (Transform child in T2Panel.transform)
            {
                totalcounter = t2counter + t1counter;
                string Pname = child.Find("InputField").Find("Text").GetComponent<Text>().text;

                BigD.Game11Names[totalcounter - 1] = Pname;
                BigD.G11Teams[totalcounter - 1] = 2;
                t2counter++;
            }
        }
        if (bigDcurrentGNumber == 12)
        {
            int t1counter = 1;
            foreach (Transform child in T1Panel.transform)
            {
                string Pname = child.Find("InputField").Find("Text").GetComponent<Text>().text;

                BigD.Game12Names[t1counter - 1] = Pname;
                BigD.G12Teams[t1counter - 1] = 1;
                t1counter++;
            }

            int t2counter = 0;
            int totalcounter = 0;
            foreach (Transform child in T2Panel.transform)
            {
                totalcounter = t2counter + t1counter;
                string Pname = child.Find("InputField").Find("Text").GetComponent<Text>().text;

                BigD.Game12Names[totalcounter - 1] = Pname;
                BigD.G12Teams[totalcounter - 1] = 2;
                t2counter++;
            }
        }
        if (bigDcurrentGNumber == 13)
        {
            int t1counter = 1;
            foreach (Transform child in T1Panel.transform)
            {
                string Pname = child.Find("InputField").Find("Text").GetComponent<Text>().text;

                BigD.Game13Names[t1counter - 1] = Pname;
                BigD.G13Teams[t1counter - 1] = 1;
                t1counter++;
            }

            int t2counter = 0;
            int totalcounter = 0;
            foreach (Transform child in T2Panel.transform)
            {
                totalcounter = t2counter + t1counter;
                string Pname = child.Find("InputField").Find("Text").GetComponent<Text>().text;

                BigD.Game13Names[totalcounter - 1] = Pname;
                BigD.G13Teams[totalcounter - 1] = 2;
                t2counter++;
            }
        }
        if (bigDcurrentGNumber == 14)
        {
            int t1counter = 1;
            foreach (Transform child in T1Panel.transform)
            {
                string Pname = child.Find("InputField").Find("Text").GetComponent<Text>().text;

                BigD.Game14Names[t1counter - 1] = Pname;
                BigD.G14Teams[t1counter - 1] = 1;
                t1counter++;
            }

            int t2counter = 0;
            int totalcounter = 0;
            foreach (Transform child in T2Panel.transform)
            {
                totalcounter = t2counter + t1counter;
                string Pname = child.Find("InputField").Find("Text").GetComponent<Text>().text;

                BigD.Game14Names[totalcounter - 1] = Pname;
                BigD.G14Teams[totalcounter - 1] = 2;
                t2counter++;
            }
        }
        if (bigDcurrentGNumber == 15)
        {
            int t1counter = 1;
            foreach (Transform child in T1Panel.transform)
            {
                string Pname = child.Find("InputField").Find("Text").GetComponent<Text>().text;

                BigD.Game15Names[t1counter - 1] = Pname;
                BigD.G15Teams[t1counter - 1] = 1;
                t1counter++;
            }

            int t2counter = 0;
            int totalcounter = 0;
            foreach (Transform child in T2Panel.transform)
            {
                totalcounter = t2counter + t1counter;
                string Pname = child.Find("InputField").Find("Text").GetComponent<Text>().text;

                BigD.Game15Names[totalcounter - 1] = Pname;
                BigD.G15Teams[totalcounter - 1] = 2;
                t2counter++;
            }
        } */


        SceneManager.LoadScene("GameScreen");


    }

    public void HomeScreen()
    {

         object[] obj = GameObject.FindSceneObjectsOfType(typeof(GameObject));
        foreach (object o in obj)
        {
            GameObject g = (GameObject)o;
            if (g.GetComponent<PolygonCollider2D>() != null)
            {
                BigD = g.GetComponent<BigData>();
            }
        }

        BigD.CurrentGameNumber--;


        SceneManager.LoadScene("Home Screen");
    }
}

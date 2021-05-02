using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StatsManager : MonoBehaviour
{

    public GameObject BigDataGameObject;
    public GameObject instantiateO;
    public GameObject instantiatePanel;

    // Start is called before the first frame update
    void Start()
    {
        object[] obj = GameObject.FindSceneObjectsOfType(typeof(GameObject));
        foreach (object o in obj)
        {
            GameObject g = (GameObject)o;
            if (g.GetComponent<PolygonCollider2D>() != null)
            {
                BigDataGameObject = g;
                
            }
        }
        BigData B = BigDataGameObject.GetComponent<BigData>();
        if (B.AVG)
        {
            instantiateStats(B.UsedNames);
        }
        else
        {
            instantiateStats(findNameArray());
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void homeFunc()
    {
        BigData B = BigDataGameObject.GetComponent<BigData>();
        B.AVG = false;
        SceneManager.LoadScene("Home Screen");
    }

    public void instantiateStats(string[] names)
    {
        int a = 0;

        foreach(string name in names)
        {
            if (name == "")
                return;
            var newplayerStat = Instantiate(instantiateO, new Vector3(0, 0, 0), Quaternion.identity);
            newplayerStat.transform.parent = instantiatePanel.transform;

            PlayerStatsInstantiate x = newplayerStat.GetComponent<PlayerStatsInstantiate>();

            x.playerPosition = a;

            newplayerStat.GetComponent<PlayerStatsInstantiate>().SetStats();

            a++;
        }
    }

    public string[] findNameArray()
    {
        BigData B = BigDataGameObject.GetComponent<BigData>();
        int x = B.CurrentGameACTUAL;


        if (x == 1)
            return B.Game1Names;
        if (x == 2)
            return B.Game2Names;
        if (x == 3)
            return B.Game3Names;
        if (x == 4)
            return B.Game4Names;
        if (x == 5)
            return B.Game5Names;
        if (x == 6)
            return B.Game6Names;
        if (x == 7)
            return B.Game7Names;
        /*  if (x == 8)
            return B.Game8Names;
         if (x == 9)
             return B.Game9Names;
         if (x == 10)
             return B.Game10Names;
         if (x == 11)
             return B.Game11Names;
         if (x == 12)
             return B.Game12Names;
         if (x == 13)
             return B.Game13Names;
         if (x == 14)
             return B.Game14Names;
         if (x == 15)
             return B.Game15Names;  */

        string[] yeet = new string[] { "" };
        return yeet;

       }
}

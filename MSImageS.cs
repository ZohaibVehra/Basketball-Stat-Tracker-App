using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MSImageS : MonoBehaviour
{
    public int gameIndex;
    public BigData BigD;
    public GameObject itself;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void setActualGame()
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
        BigD.CurrentGameACTUAL = gameIndex;
        SceneManager.LoadScene("StatsScreen");
    }

    public void CheckExist()
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
        
        if(gameIndex == 1)
        {
            if (BigD.GetComponent<BigData>().G1Teams[0] == 0)
                Destroy(itself);
        }
        if (gameIndex == 2)
        {
            if (BigD.GetComponent<BigData>().G2Teams[0] == 0)
                Destroy(itself);
        }
        if (gameIndex == 3)
        {
            if (BigD.GetComponent<BigData>().G3Teams[0] == 0)
                Destroy(itself);
        }
        if (gameIndex == 4)
        {
            if (BigD.GetComponent<BigData>().G4Teams[0] == 0)
                Destroy(itself);
        }
        if (gameIndex == 5)
        {
            if (BigD.GetComponent<BigData>().G5Teams[0] == 0)
                Destroy(itself);
        }
        if (gameIndex == 6)
        {
            if (BigD.GetComponent<BigData>().G6Teams[0] == 0)
                Destroy(itself);
        }
        if (gameIndex == 7)
        {
            if (BigD.GetComponent<BigData>().G7Teams[0] == 0)
                Destroy(itself);
        }
    }

    public void DeleteThis()
    {
        Debug.Log("del called from button");


        object[] obj = GameObject.FindSceneObjectsOfType(typeof(GameObject));
        foreach (object o in obj)
        {
            GameObject g = (GameObject)o;
            if (g.GetComponent<PolygonCollider2D>() != null)
            {
                BigD = g.GetComponent<BigData>();
            }
        }

        BigD.DeleteGame(gameIndex);
    }

}

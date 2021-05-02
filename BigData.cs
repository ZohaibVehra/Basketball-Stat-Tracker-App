using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BigData : MonoBehaviour
{
    public int CurrentGameACTUAL;

    public bool AVG = false;

    public int counter = 0;
    public GameObject NewGameImagePrefab;
    public int CurrentGameNumber;
    public GameObject InstantiatePanel;
    public bool GamesDisplayed = false;

    public bool[] GamesArray = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false}; //20 long

    public string[] NamesEmpty = new string[] { "", "", "", "", "", "", "", "", "", ""}; //20 long, set one after last player to something identifiable
    public string[] Game1Names = new string[] { "", "", "", "", "", "", "", "", "", "" }; //20 long, set one after last player to something identifiable
    public string[] Game2Names = new string[] { "", "", "", "", "", "", "", "", "", "" }; //20 long 
    public string[] Game3Names = new string[] { "", "", "", "", "", "", "", "", "", ""}; //20 long
    public string[] Game4Names = new string[] { "", "", "", "", "", "", "", "", "", ""}; //20 long
    public string[] Game5Names = new string[] { "", "", "", "", "", "", "", "", "", "" }; //20 long
    public string[] Game6Names = new string[] { "", "", "", "", "", "", "", "", "", "" }; //20 long
    public string[] Game7Names = new string[] { "", "", "", "", "", "", "", "", "", "" }; //20 long
  

    public int[] TeamsEmpty = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }; //team 1 or 2
    public int[] G1Teams = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }; //team 1 or 2
    public int[] G2Teams = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    public int[] G3Teams = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    public int[] G4Teams = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    public int[] G5Teams = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    public int[] G6Teams = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
    public int[] G7Teams = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
   

    public float[] PointsEmpty = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
    public float[] G1Points = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0,  };
    public float[] G2Points = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
    public float[] G3Points = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    public float[] G4Points = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    public float[] G5Points = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    public float[] G6Points = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
    public float[] G7Points = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

    public float[] MissesEmpty = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
    public float[] G1Misses = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    public float[] G2Misses = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
    public float[] G3Misses = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
    public float[] G4Misses = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
    public float[] G5Misses = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
    public float[] G6Misses = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
    public float[] G7Misses = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    
    /*
    public float[] G1FGA = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    public float[] G2FGA = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    public float[] G3FGA = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    public float[] G4FGA = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    public float[] G5FGA = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    public float[] G6FGA = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    public float[] G7FGA = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    */

    /*
    public float[] G1FGP = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    public float[] G2FGP = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    public float[] G3FGP = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    public float[] G4FGP = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    public float[] G5FGP = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    public float[] G6FGP = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    public float[] G7FGP = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    /* public float[] G8FGP = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
     public float[] G9FGP = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
     public float[] G10FGP = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
     */


    public float[] AssistsEmpty = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
    public float[] G1Assists = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    public float[] G2Assists = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
    public float[] G3Assists = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    public float[] G4Assists = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    public float[] G5Assists = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
    public float[] G6Assists = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    public float[] G7Assists = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

    public float[] ReboundsEmpty = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
    public float[] G1Rebounds = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    public float[] G2Rebounds = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    public float[] G3Rebounds = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    public float[] G4Rebounds = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    public float[] G5Rebounds = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    public float[] G6Rebounds = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    public float[] G7Rebounds = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

    public float[] BlocksEmpty = new float[] {0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    public float[] G1Blocks = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
    public float[] G2Blocks = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
    public float[] G3Blocks = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
    public float[] G4Blocks = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
    public float[] G5Blocks = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    public float[] G6Blocks = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
    public float[] G7Blocks = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};


    public float[] StealsEmpty = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    public float[] G1Steals = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    public float[] G2Steals = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
    public float[] G3Steals = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
    public float[] G4Steals = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
    public float[] G5Steals = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    public float[] G6Steals = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    public float[] G7Steals = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
   


    public float[] TOsEmpty = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    public float[] G1TOs = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    public float[] G2TOs = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    public float[] G3TOs = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    public float[] G4TOs = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    public float[] G5TOs = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    public float[] G6TOs = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    public float[] G7TOs = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };


    public float[] FoulsEmpty = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
    public float[] G1Fouls = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    public float[] G2Fouls = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    public float[] G3Fouls = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    public float[] G4Fouls = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    public float[] G5Fouls = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    public float[] G6Fouls = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
    public float[] G7Fouls = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };


    public float[] ClutchBasketsEmpty = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
    public float[] G1ClutchBaskets = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    public float[] G2ClutchBaskets = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    public float[] G3ClutchBaskets = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    public float[] G4ClutchBaskets = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    public float[] G5ClutchBaskets = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    public float[] G6ClutchBaskets = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    public float[] G7ClutchBaskets = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };


    public float[] ClutchMissesEmpty = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    public float[] G1ClutchMisses = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
    public float[] G2ClutchMisses = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
    public float[] G3ClutchMisses = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
    public float[] G4ClutchMisses = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    public float[] G5ClutchMisses = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    public float[] G6ClutchMisses = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    public float[] G7ClutchMisses = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    

    //public string[] AvgNames = new string[] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" }; //20 long, set one after last player to NULL
    public float[] AvgPoints = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
    public float[] AvgMisses = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    public float[] AvgFGM = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
    public float[] AvgAssists = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    public float[] AvgRebounds = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
    public float[] AvgBlocks = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
    public float[] Avgsteals = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
    public float[] AvgTurnOvers = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
    public float[] AvgFouls = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
    public float[] AvgClutchBaskets = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    public float[] AvgClutchMisses = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
    public float[] AvgGamesPlayed = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};

    public string[] UsedNames = new string[] { "", "", "", "", "", "", "", "", "", "", "", "", "" };
    public int[] P1Games = new int[] { 0,0,0,0,0,0,0 };
    public int[] P2Games = new int[] { 0, 0, 0, 0, 0, 0, 0 };
    public int[] P3Games = new int[] { 0, 0, 0, 0, 0, 0, 0 };
    public int[] P4Games = new int[] { 0, 0, 0, 0, 0, 0, 0 };
    public int[] P5Games = new int[] { 0, 0, 0, 0, 0, 0, 0 };
    public int[] P6Games = new int[] { 0, 0, 0, 0, 0, 0, 0 };
    public int[] P7Games = new int[] { 0, 0, 0, 0, 0, 0, 0 };
    public int[] P8Games = new int[] { 0, 0, 0, 0, 0, 0, 0 };
    public int[] P9Games = new int[] { 0, 0, 0, 0, 0, 0, 0 };
    public int[] P10Games = new int[] { 0, 0, 0, 0, 0, 0, 0 };
    public int[] P11Games = new int[] { 0, 0, 0, 0, 0, 0, 0 };
    public int[] P12Games = new int[] { 0, 0, 0, 0, 0, 0, 0 };
    public int[] P13Games = new int[] { 0, 0, 0, 0, 0, 0, 0 };

    




    void Start()
    {
        Application.targetFrameRate = 20;
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {

    }

  

    public void CreateGames()
    {

        int x = 7;
        GameObject InstantiatePanel = GameObject.Find("Canvas").transform.Find("GamesPanel").transform.Find("Scroll").transform.Find("Panel").gameObject;

            foreach (Transform child in InstantiatePanel.transform)
            {
                GameObject.Destroy(child.gameObject);
            }

    for (int i = 0; i < x; i++)
        {

            var NewGameImage = Instantiate(NewGameImagePrefab, new Vector3(0, 0, 0), Quaternion.identity);
            NewGameImage.transform.parent = InstantiatePanel.transform;
            string Game = "Game ";
            int z = i + 1;
            Game = Game + z;
            NewGameImage.name = Game;
            NewGameImage.GetComponent<NewGameData>().GameNumber = i+1;
            
            NewGameImage.GetComponent<MSImageS>().gameIndex = z;
            NewGameImage.GetComponent<NewGameData>().buttontitle.text = Game;

            NewGameImage.GetComponent<MSImageS>().CheckExist();

        }

        GamesDisplayed = true;
        Debug.Log("just displayed");
        
    }
    public void UpdateB()
    {
        CreateGames();
    }


    public void DeleteGame(int x)
    {
        Debug.Log("Del from bigD");
        int TotalGames = CurrentGameNumber;

        if(x == TotalGames)
        {
            statDeletion(x);
            
        }

        else
        {
            Debug.Log("del from else where i = " +x);
            for (int i = x; i < TotalGames; i++)
            {
                setEmpties();
                statReplacements(i);
                Debug.Log("namesempty 1 is " + NamesEmpty[0]);
            }

            Debug.Log("namesempty 1 is " + NamesEmpty[0]);
            setEmpties();
            statDeletion(TotalGames);
        }



        CurrentGameNumber--;
        CreateGames();
    }

    public string[] ReturnNamesArray(int x)
    {
        if (x == 1)
            return Game1Names;
        if (x == 2)
            return Game2Names;
        if (x == 3)
            return Game3Names;
        if (x == 4)
            return Game4Names;
        if (x == 5)
            return Game5Names;
        if (x == 6)
            return Game6Names;
        if (x == 7)
            return Game7Names;

        string[] ret = new string[] { "" };
        return ret;
    }
    public int[] ReturnTeamsArray(int x)
    {
        if (x == 1)
            return G1Teams;
        if (x == 2)
            return G2Teams;
        if (x == 3)
            return G3Teams;
        if (x == 4)
            return G4Teams;
        if (x == 5)
            return G5Teams;
        if (x == 6)
            return G6Teams;
        if (x == 7)
            return G7Teams;

        int[] ret = new int[] {0};
        return ret;
    }
    public float[] ReturnPointsArray(int x)
    {
        if (x == 1)
            return G1Points;
        if (x == 2)
            return G2Points;
        if (x == 3)
            return G3Points;
        if (x == 4)
            return G4Points;
        if (x == 5)
            return G5Points;
        if (x == 6)
            return G6Points;
        if (x == 7)
            return G7Points;

        float[] ret = new float[] { 0 };
        return ret;
    }
    public float[] ReturnMissesArray(int x)
    {
        if (x == 1)
            return G1Misses;
        if (x == 2)
            return G2Misses;
        if (x == 3)
            return G3Misses;
        if (x == 4)
            return G4Misses;
        if (x == 5)
            return G5Misses;
        if (x == 6)
            return G6Misses;
        if (x == 7)
            return G7Misses;

        float[] ret = new float[] { 0 };
        return ret;
    }
    public float[] ReturnAssistsArray(int x)
    {
        if (x == 1)
            return G1Assists;
        if (x == 2)
            return G2Assists;
        if (x == 3)
            return G3Assists;
        if (x == 4)
            return G4Assists;
        if (x == 5)
            return G5Assists;
        if (x == 6)
            return G6Assists;
        if (x == 7)
            return G7Assists;

        float[] ret = new float[] { 0 };
        return ret;
    }
    public float[] ReturnReboudsArray(int x)
    {
        if (x == 1)
            return G1Rebounds;
        if (x == 2)
            return G2Rebounds;
        if (x == 3)
            return G3Rebounds;
        if (x == 4)
            return G4Rebounds;
        if (x == 5)
            return G5Rebounds;
        if (x == 6)
            return G6Rebounds;
        if (x == 7)
            return G7Rebounds;

        float[] ret = new float[] { 0 };
        return ret;
    }
    public float[] ReturnBlocksArray(int x)
    {
        if (x == 1)
            return G1Blocks;
        if (x == 2)
            return G2Blocks;
        if (x == 3)
            return G3Blocks;
        if (x == 4)
            return G4Blocks;
        if (x == 5)
            return G5Blocks;
        if (x == 6)
            return G6Blocks;
        if (x == 7)
            return G7Blocks;

        float[] ret = new float[] { 0 };
        return ret;
    }
    public float[] ReturnStealsArray(int x)
    {
        if (x == 1)
            return G1Steals;
        if (x == 2)
            return G2Steals;
        if (x == 3)
            return G3Steals;
        if (x == 4)
            return G4Steals;
        if (x == 5)
            return G5Steals;
        if (x == 6)
            return G6Steals;
        if (x == 7)
            return G7Steals;

        float[] ret = new float[] { 0 };
        return ret;
    }
    public float[] ReturnTOsArray(int x)
    {
        if (x == 1)
            return G1TOs;
        if (x == 2)
            return G2TOs;
        if (x == 3)
            return G3TOs;
        if (x == 4)
            return G4TOs;
        if (x == 5)
            return G5TOs;
        if (x == 6)
            return G6TOs;
        if (x == 7)
            return G7TOs;

        float[] ret = new float[] { 0 };
        return ret;
    }
    public float[] ReturnFoulsArray(int x)
    {
        if (x == 1)
            return G1Fouls;
        if (x == 2)
            return G2Fouls;
        if (x == 3)
            return G3Fouls;
        if (x == 4)
            return G4Fouls;
        if (x == 5)
            return G5Fouls;
        if (x == 6)
            return G6Fouls;
        if (x == 7)
            return G7Fouls;

        float[] ret = new float[] { 0 };
        return ret;
    }
    public float[] ReturnClutchBasketsArray(int x)
    {
        if (x == 1)
            return G1ClutchBaskets;
        if (x == 2)
            return G2ClutchBaskets;
        if (x == 3)
            return G3ClutchBaskets;
        if (x == 4)
            return G4ClutchBaskets;
        if (x == 5)
            return G5ClutchBaskets;
        if (x == 6)
            return G6ClutchBaskets;
        if (x == 7)
            return G7ClutchBaskets;

        float[] ret = new float[] { 0 };
        return ret;
    }
    public float[] ReturnClutchMissesArray(int x)
    {
        if (x == 1)
            return G1ClutchMisses;
        if (x == 2)
            return G2ClutchMisses;
        if (x == 3)
            return G3ClutchMisses;
        if (x == 4)
            return G4ClutchMisses;
        if (x == 5)
            return G5ClutchMisses;
        if (x == 6)
            return G6ClutchMisses;
        if (x == 7)
            return G7ClutchMisses;

        float[] ret = new float[] { 0 };
        return ret;
    }

    public void statReplacements(int x) {

        Debug.Log("stat replacement called, replacing the following with above " + x);
        if(x == 1)
        {
            Game1Names = Game2Names;
            G1Teams = G2Teams;
            G1Points = G2Points;
            G1Misses = G2Misses;
            G1Assists = G2Assists;
            G1Rebounds = G2Rebounds;
            G1Blocks = G2Blocks;
            G1Steals = G2Steals;
            G1TOs = G2TOs;
            G1Fouls = G2Fouls;
            G1ClutchBaskets = G2ClutchBaskets;
            G1ClutchMisses = G2ClutchMisses;

        }
        if (x == 2)
        {
            Game2Names = Game3Names;
            G2Teams = G3Teams;
            G2Points = G3Points;
            G2Misses = G3Misses;
            G2Assists = G3Assists;
            G2Rebounds = G3Rebounds;
            G2Blocks = G3Blocks;
            G2Steals = G3Steals;
            G2TOs = G3TOs;
            G2Fouls = G3Fouls;
            G2ClutchBaskets = G3ClutchBaskets;
            G2ClutchMisses = G3ClutchMisses;

        }
        if (x == 3)
        {
            Game3Names = Game4Names;
            G3Teams = G4Teams;
            G3Points = G4Points;
            G3Misses = G4Misses;
            G3Assists = G4Assists;
            G3Rebounds = G4Rebounds;
            G3Blocks = G4Blocks;
            G3Steals = G4Steals;
            G3TOs = G4TOs;
            G3Fouls = G4Fouls;
            G3ClutchBaskets = G4ClutchBaskets;
            G3ClutchMisses = G4ClutchMisses;

        }
        if (x == 4)
        {
            Game4Names = Game5Names;
            G4Teams = G5Teams;
            G4Points = G5Points;
            G4Misses = G5Misses;
            G4Assists = G5Assists;
            G4Rebounds = G5Rebounds;
            G4Blocks = G5Blocks;
            G4Steals = G5Steals;
            G4TOs = G5TOs;
            G4Fouls = G5Fouls;
            G4ClutchBaskets = G5ClutchBaskets;
            G4ClutchMisses = G5ClutchMisses;

        }
        if (x == 5)
        {
            Game5Names = Game6Names;
            G5Teams = G6Teams;
            G5Points = G6Points;
            G5Misses = G6Misses;
            G5Assists = G6Assists;
            G5Rebounds = G6Rebounds;
            G5Blocks = G6Blocks;
            G5Steals = G6Steals;
            G5TOs = G6TOs;
            G5Fouls = G6Fouls;
            G5ClutchBaskets = G6ClutchBaskets;
            G5ClutchMisses = G6ClutchMisses;

        }
        if (x == 6)
        {
            Game6Names = Game7Names;
            G6Teams = G7Teams;
            G6Points = G7Points;
            G6Misses = G7Misses;
            G6Assists = G7Assists;
            G6Rebounds = G7Rebounds;
            G6Blocks = G7Blocks;
            G6Steals = G7Steals;
            G6TOs = G7TOs;
            G6Fouls = G7Fouls;
            G6ClutchBaskets = G7ClutchBaskets;
            G6ClutchMisses = G7ClutchMisses;

        }

    }
    public void statDeletion(int x)
    {
        Debug.Log("del from x = total where x = "+ x);
        setEmpties();

        if (x == 1)
        {
            setEmpties();
            Game1Names = NamesEmpty;
            G1Teams = TeamsEmpty;
            G1Points = PointsEmpty;
            G1Misses = MissesEmpty;
            G1Assists = AssistsEmpty;
            G1Rebounds = ReboundsEmpty;
            G1Blocks = BlocksEmpty;
            G1Steals = StealsEmpty;
            G1TOs = TOsEmpty;
            G1Fouls = FoulsEmpty;
            G1ClutchBaskets = ClutchBasketsEmpty;
            G1ClutchMisses = ClutchMissesEmpty;
        }
        setEmpties();
        if(x==2)
        {
            setEmpties();
            Game2Names = NamesEmpty;
            G2Teams = TeamsEmpty;
            G2Points = PointsEmpty;
            G2Misses = MissesEmpty;
            G2Assists = AssistsEmpty;
            G2Rebounds = ReboundsEmpty;
            G2Blocks = BlocksEmpty;
            G2Steals = StealsEmpty;
            G2TOs = TOsEmpty;
            G2Fouls = FoulsEmpty;
            G2ClutchBaskets = ClutchBasketsEmpty;
            G2ClutchMisses = ClutchMissesEmpty;
        }
        if (x == 3)
        {
            setEmpties();
            Game3Names = NamesEmpty;
            G3Teams = TeamsEmpty;
            G3Points = PointsEmpty;
            G3Misses = MissesEmpty;
            G3Assists = AssistsEmpty;
            G3Rebounds = ReboundsEmpty;
            G3Blocks = BlocksEmpty;
            G3Steals = StealsEmpty;
            G3TOs = TOsEmpty;
            G3Fouls = FoulsEmpty;
            G3ClutchBaskets = ClutchBasketsEmpty;
            G3ClutchMisses = ClutchMissesEmpty;
        }

        if (x == 4)
        {
            setEmpties();
            Game4Names = NamesEmpty;
            G4Teams = TeamsEmpty;
            G4Points = PointsEmpty;
            G4Misses = MissesEmpty;
            G4Assists = AssistsEmpty;
            G4Rebounds = ReboundsEmpty;
            G4Blocks = BlocksEmpty;
            G4Steals = StealsEmpty;
            G4TOs = TOsEmpty;
            G4Fouls = FoulsEmpty;
            G4ClutchBaskets = ClutchBasketsEmpty;
            G4ClutchMisses = ClutchMissesEmpty;
        }
        if (x == 5)
        {
            setEmpties();
            Game5Names = NamesEmpty;

      
            G5Teams = TeamsEmpty;
            G5Points = PointsEmpty;
            G5Misses = MissesEmpty;
            G5Assists = AssistsEmpty;
            G5Rebounds = ReboundsEmpty;
            G5Blocks = BlocksEmpty;
            G5Steals = StealsEmpty;
            G5TOs = TOsEmpty;
            G5Fouls = FoulsEmpty;
            G5ClutchBaskets = ClutchBasketsEmpty;
            G5ClutchMisses = ClutchMissesEmpty;
        }
        if (x == 6)
        {
            setEmpties();
            Game6Names = NamesEmpty;
            G6Teams = TeamsEmpty;
            G6Points = PointsEmpty;
            G6Misses = MissesEmpty;
            G6Assists = AssistsEmpty;
            G6Rebounds = ReboundsEmpty;
            G6Blocks = BlocksEmpty;
            G6Steals = StealsEmpty;
            G6TOs = TOsEmpty;
            G6Fouls = FoulsEmpty;
            G6ClutchBaskets = ClutchBasketsEmpty;
            G6ClutchMisses = ClutchMissesEmpty;
        }
        if (x == 7)
        {
            setEmpties();
            Game7Names = NamesEmpty;
            G7Teams = TeamsEmpty;
            G7Points = PointsEmpty;
            G7Misses = MissesEmpty;
            G7Assists = AssistsEmpty;
            G7Rebounds = ReboundsEmpty;
            G7Blocks = BlocksEmpty;
            G7Steals = StealsEmpty;
            G7TOs = TOsEmpty;
            G7Fouls = FoulsEmpty;
            G7ClutchBaskets = ClutchBasketsEmpty;
            G7ClutchMisses = ClutchMissesEmpty;
        }
    }

    public void setEmpties()
    {
        NamesEmpty = new string[] { "", "", "", "", "", "", "", "", "", "" }; 
        TeamsEmpty = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}; //team 1 or 2
        PointsEmpty = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        MissesEmpty = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        AssistsEmpty = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        ReboundsEmpty = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        BlocksEmpty = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        StealsEmpty = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        TOsEmpty = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        FoulsEmpty = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        ClutchBasketsEmpty = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        ClutchMissesEmpty = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};


}

    public void AVGSetEmpties()
    {
        UsedNames = new string[] { "", "", "", "", "", "", "", "", "", "", "", "", "" };
        P1Games = new int[] { 0, 0, 0, 0, 0, 0, 0 };
        P2Games = new int[] { 0, 0, 0, 0, 0, 0, 0 };
        P3Games = new int[] { 0, 0, 0, 0, 0, 0, 0 };
        P4Games = new int[] { 0, 0, 0, 0, 0, 0, 0 };
        P5Games = new int[] { 0, 0, 0, 0, 0, 0, 0 };
        P6Games = new int[] { 0, 0, 0, 0, 0, 0, 0 };
        P7Games = new int[] { 0, 0, 0, 0, 0, 0, 0 };
        P8Games = new int[] { 0, 0, 0, 0, 0, 0, 0 };
        P9Games = new int[] { 0, 0, 0, 0, 0, 0, 0 };
        P10Games = new int[] { 0, 0, 0, 0, 0, 0, 0 };
        P11Games = new int[] { 0, 0, 0, 0, 0, 0, 0 };
        P12Games = new int[] { 0, 0, 0, 0, 0, 0, 0 };
        P13Games = new int[] { 0, 0, 0, 0, 0, 0, 0 };
        AvgPoints = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        AvgMisses = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        //AvgFGM = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        AvgAssists = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        AvgRebounds = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        AvgBlocks = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        Avgsteals = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        AvgTurnOvers = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        AvgFouls = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        AvgClutchBaskets = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        AvgClutchMisses = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        AvgGamesPlayed = new float[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
}
}

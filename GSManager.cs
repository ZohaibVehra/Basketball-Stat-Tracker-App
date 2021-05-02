using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GSManager : MonoBehaviour
{
   

    public bool GamePointT1 = false;
    public bool GamePointT2 = false;

    public Text GP1Text;
    public Text GP2Text;
    public Button showStats;
    public Button GamePointT1B;
    public Button GamePointT2B;
    public Button ExitGame;
    public Button Undo;
    public Text undot;


    public int lastStatTemp;
    public int lastStatFinalH;
    public int[] lastStatFinal = new int[] { 0, 0, 0, 0};
    public int playertotal = 0;

    public int lastPlayerTemp = 18;
    public int lastPlayerFinalH;
    public int[] lastPlayerFinal = new int[] { 18, 18, 18, 18};


    public GameObject bigDataGameObject;

    public GameObject T1Panel;
    public GameObject T2Panel;
    public GameObject playerbuttonInstantiate;




    //bools
    public Button basketB;
    public Button missB;
    public Button boardB;
    public Button assistB;
    public Button blockB;
    public Button stealB;
    public Button foulB;
    public Button toB;

    public bool undolist = false;

    public bool statClicked = false;
    public bool playerClicked = false;
    public Color BaseC;
    public bool undocolor;
    public int B = 100;
    public int z = 0;
    public Text Score;

    // Start is called before the first frame update
    void Start()
    {
        lastStatFinal = new int[] { 0, 0, 0, 0 };
        lastPlayerFinal = new int[] { 18, 18, 18, 18 };
        object[] obj = GameObject.FindSceneObjectsOfType(typeof(GameObject));
        foreach (object o in obj)
        {
            GameObject g = (GameObject)o;
            if (g.GetComponent<PolygonCollider2D>() != null)
            {
                bigDataGameObject = g;
            }
        }


        setTeam1Players();
        setTeam2Players();
        BaseC = basketB.GetComponent<Image>().color;
    }

    // Update is called once per frame
    void Update()
    {

        if (z > 0)
        {
            Debug.Log(z);
            z--;
        if (z == 0)
        {
                Debug.Log("z=0");
            Undo.GetComponent<Image>().color = Color.black;
            undot.color = Color.white;
            ColorBlock cb = Undo.colors;
            cb.normalColor = Color.black;
            Undo.colors = cb;
        }
            
        }
        

        if(playerClicked && statClicked)
        {

            undolist = true;

            if (undolist)
            {

                int arraynum;

                int ST = lastStatTemp;
                int SF = lastStatFinalH;
                int PT = lastPlayerTemp;
                int PF = lastPlayerFinalH;
                if (PF != PT)
                {

                    lastPlayerFinalH = lastPlayerTemp;
                }

                if (SF != ST)
                {
                    lastStatFinalH = lastStatTemp;
                }

                lastPlayerFinal[0] = lastPlayerFinal[1];
                lastPlayerFinal[1] = lastPlayerFinal[2];
                lastPlayerFinal[2] = lastPlayerFinal[3];
                lastStatFinal[0] = lastStatFinal[1];
                lastStatFinal[1] = lastStatFinal[2];
                lastStatFinal[2] = lastStatFinal[3];

                lastStatFinal[3] = lastStatFinalH;
                lastPlayerFinal[3] = lastPlayerFinalH;

                

                lastStatTemp = 0;
                lastPlayerTemp = 0;
                Debug.Log("player entered: " + lastPlayerFinalH + "    last stat: " + lastStatFinalH);
                
                UpdateStat(lastPlayerFinalH, lastStatFinalH);

                playerClicked = false;
                statClicked = false;

                UpdateScore();
            }
            undolist = false;

            
        }


        if (true) //giant button color changes
        {
            if (statClicked && lastStatTemp == 1)
            {
                basketB.GetComponent<Image>().color = Color.blue;
            }
            else
            {
                basketB.GetComponent<Image>().color = BaseC;
            }
            if (statClicked && lastStatTemp == 2)
            {
                missB.GetComponent<Image>().color = Color.blue;
            }
            else
            {
                missB.GetComponent<Image>().color = BaseC;
            }
            if (statClicked && lastStatTemp == 3)
            {
                boardB.GetComponent<Image>().color = Color.blue;
            }
            else
            {
                boardB.GetComponent<Image>().color = BaseC;
            }
            if (statClicked && lastStatTemp == 4)
            {
                assistB.GetComponent<Image>().color = Color.blue;
            }
            else
            {
                assistB.GetComponent<Image>().color = BaseC;
            }
            if (statClicked && lastStatTemp == 5)
            {
                blockB.GetComponent<Image>().color = Color.blue;
            }
            else
            {
                blockB.GetComponent<Image>().color = BaseC;
            }
            if (statClicked && lastStatTemp == 6)
            {
                stealB.GetComponent<Image>().color = Color.blue;
            }
            else
            {
                stealB.GetComponent<Image>().color = BaseC;
            }
            if (statClicked && lastStatTemp == 7)
            {
                foulB.GetComponent<Image>().color = Color.blue;
            }
            else
            {
                foulB.GetComponent<Image>().color = BaseC;
            }
            if (statClicked && lastStatTemp == 8)
            {
                toB.GetComponent<Image>().color = Color.blue;
            }
            else
            {
                toB.GetComponent<Image>().color = BaseC;
            }
        }
        
       
        


    }

    public void setTeam1Players()
    {
        BigData BigD = bigDataGameObject.GetComponent<BigData>();
        int gamenumber = BigD.CurrentGameNumber;
        int c = 0;
        if(gamenumber == 1)
        {
            foreach (string PlayerN in BigD.Game1Names)
            {
                
                if(PlayerN != "" && BigD.G1Teams[c] == 1)   //if player exists and is on team 1
                {

                    string PlayerName = BigD.Game1Names[c];
                    var NewPlayer = Instantiate(playerbuttonInstantiate, new Vector3(0, 0, 0), Quaternion.identity);
                    NewPlayer.transform.parent = T1Panel.transform;
                    NewPlayer.GetComponent<PlayerButton>().PlayerPosition = c;  //array position so it starts at 0 not 1
                    NewPlayer.GetComponent<PlayerButton>().PlayerName = PlayerName;
                    NewPlayer.GetComponent<PlayerButton>().textupdate();
                    c++;
                    playertotal++;
                }
                if (BigD.G1Teams[c] == 2)
                    return;



            }
        }
        if (gamenumber == 2)
        {
            foreach (string PlayerN in BigD.Game2Names)
            {

                if (PlayerN != "" && BigD.G2Teams[c] == 1)   //if player exists and is on team 1
                {

                    string PlayerName = BigD.Game2Names[c];
                    var NewPlayer = Instantiate(playerbuttonInstantiate, new Vector3(0, 0, 0), Quaternion.identity);
                    NewPlayer.transform.parent = T1Panel.transform;
                    NewPlayer.GetComponent<PlayerButton>().PlayerPosition = c;  //array position so it starts at 0 not 1

                    NewPlayer.GetComponent<PlayerButton>().PlayerName = PlayerName;
                    NewPlayer.GetComponent<PlayerButton>().textupdate();
                    c++;
                    playertotal++;
                }
                if (BigD.G2Teams[c] == 2)
                    return;



            }
        }
        if (gamenumber == 3)
        {
            foreach (string PlayerN in BigD.Game3Names)
            {

                if (PlayerN != "" && BigD.G3Teams[c] == 1)   //if player exists and is on team 1
                {

                    string PlayerName = BigD.Game3Names[c];
                    var NewPlayer = Instantiate(playerbuttonInstantiate, new Vector3(0, 0, 0), Quaternion.identity);
                    NewPlayer.transform.parent = T1Panel.transform;
                    NewPlayer.GetComponent<PlayerButton>().PlayerPosition = c;  //array position so it starts at 0 not 1

                    NewPlayer.GetComponent<PlayerButton>().PlayerName = PlayerName;
                    NewPlayer.GetComponent<PlayerButton>().textupdate();
                    c++;
                    playertotal++;
                }
                if (BigD.G3Teams[c] == 2)
                    return;



            }
        }
        if (gamenumber == 4)
        {
            foreach (string PlayerN in BigD.Game4Names)
            {

                if (PlayerN != "" && BigD.G4Teams[c] == 1)   //if player exists and is on team 1
                {

                    string PlayerName = BigD.Game4Names[c];
                    var NewPlayer = Instantiate(playerbuttonInstantiate, new Vector3(0, 0, 0), Quaternion.identity);
                    NewPlayer.transform.parent = T1Panel.transform;
                    NewPlayer.GetComponent<PlayerButton>().PlayerPosition = c;  //array position so it starts at 0 not 1

                    NewPlayer.GetComponent<PlayerButton>().PlayerName = PlayerName;
                    NewPlayer.GetComponent<PlayerButton>().textupdate();
                    c++;
                    playertotal++;
                }
                if (BigD.G4Teams[c] == 2)
                    return;



            }
        }
        if (gamenumber == 5)
        {
            foreach (string PlayerN in BigD.Game5Names)
            {

                if (PlayerN != "" && BigD.G5Teams[c] == 1)   //if player exists and is on team 1
                {

                    string PlayerName = BigD.Game5Names[c];
                    var NewPlayer = Instantiate(playerbuttonInstantiate, new Vector3(0, 0, 0), Quaternion.identity);
                    NewPlayer.transform.parent = T1Panel.transform;
                    NewPlayer.GetComponent<PlayerButton>().PlayerPosition = c;  //array position so it starts at 0 not 1
                    NewPlayer.GetComponent<PlayerButton>().PlayerName = PlayerName;
                    NewPlayer.GetComponent<PlayerButton>().textupdate();
                    c++;
                    playertotal++;
                }
                if (BigD.G5Teams[c] == 2)
                    return;



            }
        }
        if (gamenumber == 6)
        {
            foreach (string PlayerN in BigD.Game6Names)
            {

                if (PlayerN != "" && BigD.G6Teams[c] == 1)   //if player exists and is on team 1
                {

                    string PlayerName = BigD.Game6Names[c];
                    var NewPlayer = Instantiate(playerbuttonInstantiate, new Vector3(0, 0, 0), Quaternion.identity);
                    NewPlayer.transform.parent = T1Panel.transform;
                    NewPlayer.GetComponent<PlayerButton>().PlayerPosition = c;  //array position so it starts at 0 not 1
                    NewPlayer.GetComponent<PlayerButton>().PlayerName = PlayerName;
                    NewPlayer.GetComponent<PlayerButton>().textupdate();
                    c++;
                    playertotal++;
                }
                if (BigD.G6Teams[c] == 2)
                    return;



            }
        }
        if (gamenumber == 7)
        {
            foreach (string PlayerN in BigD.Game7Names)
            {

                if (PlayerN != "" && BigD.G7Teams[c] == 1)   //if player exists and is on team 1
                {

                    string PlayerName = BigD.Game7Names[c];
                    var NewPlayer = Instantiate(playerbuttonInstantiate, new Vector3(0, 0, 0), Quaternion.identity);
                    NewPlayer.transform.parent = T1Panel.transform;
                    NewPlayer.GetComponent<PlayerButton>().PlayerPosition = c;  //array position so it starts at 0 not 1
                    NewPlayer.GetComponent<PlayerButton>().PlayerName = PlayerName;
                    NewPlayer.GetComponent<PlayerButton>().textupdate();
                    c++;
                    playertotal++;
                }
                if (BigD.G7Teams[c] == 2)
                    return;



            }
        }

    }

    public void setTeam2Players()
    {
        BigData BigD = bigDataGameObject.GetComponent<BigData>();
        int gamenumber = BigD.CurrentGameNumber;
        int c = 0;
        if (gamenumber == 1)
        {
            foreach (string PlayerN in BigD.Game1Names)
            {
               
                if (PlayerN != "" && BigD.G1Teams[c+playertotal] == 2)   //if player exists and is on team 1
                {
                    string PlayerName = BigD.Game1Names[c + playertotal];

                    
                    var NewPlayer = Instantiate(playerbuttonInstantiate, new Vector3(0, 0, 0), Quaternion.identity);
                    NewPlayer.transform.parent = T2Panel.transform;
                    NewPlayer.GetComponent<PlayerButton>().PlayerPosition = c+playertotal;  //array position so it starts at 0 not 1
                    NewPlayer.GetComponent<PlayerButton>().PlayerName = PlayerName;
                    NewPlayer.GetComponent<PlayerButton>().textupdate();
                    c++;
                }
                if (PlayerN == "")
                    return;

            }
        }
        if (gamenumber == 2)
        {
            foreach (string PlayerN in BigD.Game2Names)
            {

                if (PlayerN != "" && BigD.G2Teams[c + playertotal] == 2)   //if player exists and is on team 1
                {
                    string PlayerName = BigD.Game2Names[c + playertotal];


                    var NewPlayer = Instantiate(playerbuttonInstantiate, new Vector3(0, 0, 0), Quaternion.identity);
                    NewPlayer.transform.parent = T2Panel.transform;
                    NewPlayer.GetComponent<PlayerButton>().PlayerPosition = c + playertotal;  //array position so it starts at 0 not 1
                    NewPlayer.GetComponent<PlayerButton>().PlayerName = PlayerName;
                    NewPlayer.GetComponent<PlayerButton>().textupdate();
                    c++;
                }
                if (PlayerN == "")
                    return;

            }
        }
        if (gamenumber == 3)
        {
            foreach (string PlayerN in BigD.Game3Names)
            {

                if (PlayerN != "" && BigD.G3Teams[c + playertotal] == 2)   //if player exists and is on team 1
                {
                    string PlayerName = BigD.Game3Names[c + playertotal];


                    var NewPlayer = Instantiate(playerbuttonInstantiate, new Vector3(0, 0, 0), Quaternion.identity);
                    NewPlayer.transform.parent = T2Panel.transform;
                    NewPlayer.GetComponent<PlayerButton>().PlayerPosition = c + playertotal;  //array position so it starts at 0 not 1
                    NewPlayer.GetComponent<PlayerButton>().PlayerName = PlayerName;
                    NewPlayer.GetComponent<PlayerButton>().textupdate();
                    c++;
                }
                if (PlayerN == "")
                    return;

            }
        }
        if (gamenumber == 4)
        {
            foreach (string PlayerN in BigD.Game4Names)
            {

                if (PlayerN != "" && BigD.G4Teams[c + playertotal] == 2)   //if player exists and is on team 1
                {
                    string PlayerName = BigD.Game4Names[c + playertotal];


                    var NewPlayer = Instantiate(playerbuttonInstantiate, new Vector3(0, 0, 0), Quaternion.identity);
                    NewPlayer.transform.parent = T2Panel.transform;
                    NewPlayer.GetComponent<PlayerButton>().PlayerPosition = c + playertotal;  //array position so it starts at 0 not 1
                    NewPlayer.GetComponent<PlayerButton>().PlayerName = PlayerName;
                    NewPlayer.GetComponent<PlayerButton>().textupdate();
                    c++;
                }
                if (PlayerN == "")
                    return;

            }
        }
        if (gamenumber == 5)
        {
            foreach (string PlayerN in BigD.Game5Names)
            {

                if (PlayerN != "" && BigD.G5Teams[c + playertotal] == 2)   //if player exists and is on team 1
                {
                    string PlayerName = BigD.Game5Names[c + playertotal];


                    var NewPlayer = Instantiate(playerbuttonInstantiate, new Vector3(0, 0, 0), Quaternion.identity);
                    NewPlayer.transform.parent = T2Panel.transform;
                    NewPlayer.GetComponent<PlayerButton>().PlayerPosition = c + playertotal;  //array position so it starts at 0 not 1
                    NewPlayer.GetComponent<PlayerButton>().PlayerName = PlayerName;
                    NewPlayer.GetComponent<PlayerButton>().textupdate();
                    c++;
                }
                if (PlayerN == "")
                    return;

            }
        }
        if (gamenumber == 6)
        {
            foreach (string PlayerN in BigD.Game6Names)
            {

                if (PlayerN != "" && BigD.G6Teams[c + playertotal] == 2)   //if player exists and is on team 1
                {
                    string PlayerName = BigD.Game6Names[c + playertotal];


                    var NewPlayer = Instantiate(playerbuttonInstantiate, new Vector3(0, 0, 0), Quaternion.identity);
                    NewPlayer.transform.parent = T2Panel.transform;
                    NewPlayer.GetComponent<PlayerButton>().PlayerPosition = c + playertotal;  //array position so it starts at 0 not 1
                    NewPlayer.GetComponent<PlayerButton>().PlayerName = PlayerName;
                    NewPlayer.GetComponent<PlayerButton>().textupdate();
                    c++;
                }
                if (PlayerN == "")
                    return;

            }
        }
        if (gamenumber == 7)
        {
            foreach (string PlayerN in BigD.Game7Names)
            {

                if (PlayerN != "" && BigD.G7Teams[c + playertotal] == 2)   //if player exists and is on team 1
                {
                    string PlayerName = BigD.Game7Names[c + playertotal];


                    var NewPlayer = Instantiate(playerbuttonInstantiate, new Vector3(0, 0, 0), Quaternion.identity);
                    NewPlayer.transform.parent = T2Panel.transform;
                    NewPlayer.GetComponent<PlayerButton>().PlayerPosition = c + playertotal;  //array position so it starts at 0 not 1
                    NewPlayer.GetComponent<PlayerButton>().PlayerName = PlayerName;
                    NewPlayer.GetComponent<PlayerButton>().textupdate();
                    c++;
                }
                if (PlayerN == "")
                    return;

            }
        }
    }


    public void basketClick()
    {
       
        if (statClicked == true)
        {
            if (lastStatTemp == 1)
            {
                lastStatTemp = 0;
                statClicked = false;
            }
            else
            {
                lastStatTemp = 1;
                statClicked = true;
            }
        }

        else
        {
            if (playerClicked)
            {
                lastStatFinalH = 1;
                lastStatTemp = 1;
                statClicked = true;
            }
            else
            {
                lastStatTemp = 1;
                statClicked = true;
            }
        }
    }
    public void missClick()
    {
        if (statClicked == true)
        {
            if (lastStatTemp == 2)
            {
                lastStatTemp = 0;
                statClicked = false;
            }
            else
            {
                lastStatTemp = 2;
                statClicked = true;
            }
        }

        else
        {
            if (playerClicked)
            {
                lastStatFinalH = 2;
                lastStatTemp = 2;
                statClicked = true;
            }
            else
            {
                lastStatTemp = 2;
                statClicked = true;
            }
        }
    }
    public void boardClick()
    {
        if (statClicked == true)
        {
            if (lastStatTemp == 3)
            {
                lastStatTemp = 0;
                statClicked = false;
            }
            else
            {
                lastStatTemp = 3;
                statClicked = true;
            }
        }

        else
        {
            if (playerClicked)
            {
                lastStatFinalH = 3;
                lastStatTemp = 3;
                statClicked = true;
            }
            else
            {
                lastStatTemp = 3;
                statClicked = true;
            }
        }
    }
    public void assistClick()
    {
        if (statClicked == true)
        {
            if (lastStatTemp == 4)
            {
                lastStatTemp = 0;
                statClicked = false;
            }
            else
            {
                lastStatTemp = 4;
                statClicked = true;
            }
        }

        else
        {
            if (playerClicked)
            {
                lastStatFinalH = 4;
                lastStatTemp = 4;
                statClicked = true;
            }
            else
            {
                lastStatTemp = 4;
                statClicked = true;
            }
        }
    }
    public void blockClick()
    {
        if (statClicked == true)
        {
            if (lastStatTemp == 5)
            {
                lastStatTemp = 0;
                statClicked = false;
            }
            else
            {
                lastStatTemp = 5;
                statClicked = true;
            }
        }

        else
        {
            if (playerClicked)
            {
                lastStatFinalH = 5;
                lastStatTemp = 5;
                statClicked = true;
            }
            else
            {
                lastStatTemp = 5;
                statClicked = true;
            }
        }
    }
    public void stealClick()
    {
        if (statClicked == true)
        {
            if (lastStatTemp == 6)
            {
                lastStatTemp = 0;
                statClicked = false;
            }
            else
            {
                lastStatTemp = 6;
                statClicked = true;
            }
        }

        else
        {
            if (playerClicked)
            {
                lastStatFinalH = 6;
                lastStatTemp = 6;
                statClicked = true;
            }
            else
            {
                lastStatTemp = 6;
                statClicked = true;
            }
        }
    }
    public void foulClick()
    {
        if (statClicked == true)
        {
            if (lastStatTemp == 7)
            {
                lastStatTemp = 0;
                statClicked = false;
            }
            else
            {
                lastStatTemp = 7;
                statClicked = true;
            }
        }

        else
        {
            if (playerClicked)
            {
                lastStatFinalH = 7;
                lastStatTemp = 7;
                statClicked = true;
            }
            else
            {
                lastStatTemp = 7;
                statClicked = true;
            }
        }
    }
    public void turnoverClick()
    {
        if (statClicked == true)
        {
            if (lastStatTemp == 8)
            {
                lastStatTemp = 0;
                statClicked = false;
            }
            else
            {
                lastStatTemp = 8;
                statClicked = true;
            }
        }

        else
        {
            if (playerClicked)
            {
                lastStatFinalH = 8;
                lastStatTemp = 8;
                statClicked = true;
            }
            else
            {
                lastStatTemp = 8;
                statClicked = true;
            }
        }
    }



    public void UpdateStat(int player, int stat)
    {
        int x = bigDataGameObject.GetComponent<BigData>().CurrentGameNumber;
        BigData B = bigDataGameObject.GetComponent<BigData>();
        if (x == 1)
        {
            if (stat == 0)
                Debug.Log("Error, you got save stat function running without any stat inputted");
            if (stat == 1)
            {
                B.G1Points[player]++;
                if (GamePointT1 && B.G1Teams[player] == 1)
                    B.G1ClutchBaskets[player]++;
                if (GamePointT2 && B.G1Teams[player] == 2)
                    B.G1ClutchBaskets[player]++;
            }
            if (stat == 2)
            {
                B.G1Misses[player]++;
                if (GamePointT1 && B.G1Teams[player] == 1)
                    B.G1ClutchMisses[player]++;
                if (GamePointT2 && B.G1Teams[player] == 2)
                    B.G1ClutchMisses[player]++;

            }
            if (stat == 3)
                B.G1Rebounds[player]++;
            if (stat == 4)
                B.G1Assists[player]++;
            if (stat == 5)
                B.G1Blocks[player]++;
            if (stat == 6)
                B.G1Steals[player]++;
            if (stat == 7)
                B.G1Fouls[player]++;
            if (stat == 8)
                B.G1TOs[player]++;
        }
        if (x == 2)
        {
            if (stat == 0)
                Debug.Log("Error, you got save stat function running without any stat inputted");
            if (stat == 1)
            {
                B.G2Points[player]++;
                if (GamePointT1 && B.G2Teams[player] == 1)
                    B.G2ClutchBaskets[player]++;
                if (GamePointT2 && B.G2Teams[player] == 2)
                    B.G2ClutchBaskets[player]++;
            }
            if (stat == 2)
            {
                B.G2Misses[player]++;
                if (GamePointT1 && B.G2Teams[player] == 1)
                    B.G2ClutchMisses[player]++;
                if (GamePointT2 && B.G2Teams[player] == 2)
                    B.G2ClutchMisses[player]++;

            }
            if (stat == 3)
                B.G2Rebounds[player]++;
            if (stat == 4)
                B.G2Assists[player]++;
            if (stat == 5)
                B.G2Blocks[player]++;
            if (stat == 6)
                B.G2Steals[player]++;
            if (stat == 7)
                B.G2Fouls[player]++;
            if (stat == 8)
                B.G2TOs[player]++;
        }
        if (x == 3)
        {
            if (stat == 0)
                Debug.Log("Error, you got save stat function running without any stat inputted");
            if (stat == 1)
            {
                B.G3Points[player]++;
                if (GamePointT1 && B.G3Teams[player] == 1)
                    B.G3ClutchBaskets[player]++;
                if (GamePointT2 && B.G3Teams[player] == 2)
                    B.G3ClutchBaskets[player]++;
            }
            if (stat == 2)
            {
                B.G3Misses[player]++;
                if (GamePointT1 && B.G3Teams[player] == 1)
                    B.G3ClutchMisses[player]++;
                if (GamePointT2 && B.G3Teams[player] == 2)
                    B.G3ClutchMisses[player]++;

            }
            if (stat == 3)
                B.G3Rebounds[player]++;
            if (stat == 4)
                B.G3Assists[player]++;
            if (stat == 5)
                B.G3Blocks[player]++;
            if (stat == 6)
                B.G3Steals[player]++;
            if (stat == 7)
                B.G3Fouls[player]++;
            if (stat == 8)
                B.G3TOs[player]++;
        }
        if (x == 4)
        {
            if (stat == 0)
                Debug.Log("Error, you got save stat function running without any stat inputted");
            if (stat == 1)
            {
                B.G4Points[player]++;
                if (GamePointT1 && B.G4Teams[player] == 1)
                    B.G4ClutchBaskets[player]++;
                if (GamePointT2 && B.G4Teams[player] == 2)
                    B.G4ClutchBaskets[player]++;
            }
            if (stat == 2)
            {
                B.G4Misses[player]++;
                if (GamePointT1 && B.G4Teams[player] == 1)
                    B.G4ClutchMisses[player]++;
                if (GamePointT2 && B.G4Teams[player] == 2)
                    B.G4ClutchMisses[player]++;

            }
            if (stat == 3)
                B.G4Rebounds[player]++;
            if (stat == 4)
                B.G4Assists[player]++;
            if (stat == 5)
                B.G4Blocks[player]++;
            if (stat == 6)
                B.G4Steals[player]++;
            if (stat == 7)
                B.G4Fouls[player]++;
            if (stat == 8)
                B.G4TOs[player]++;
        }
        if (x == 5)
        {
            if (stat == 0)
                Debug.Log("Error, you got save stat function running without any stat inputted");
            if (stat == 1)
            {
                B.G5Points[player]++;
                if (GamePointT1 && B.G5Teams[player] == 1)
                    B.G5ClutchBaskets[player]++;
                if (GamePointT2 && B.G5Teams[player] == 2)
                    B.G5ClutchBaskets[player]++;
            }
            if (stat == 2)
            {
                B.G5Misses[player]++;
                if (GamePointT1 && B.G5Teams[player] == 1)
                    B.G5ClutchMisses[player]++;
                if (GamePointT2 && B.G5Teams[player] == 2)
                    B.G5ClutchMisses[player]++;

            }
            if (stat == 3)
                B.G5Rebounds[player]++;
            if (stat == 4)
                B.G5Assists[player]++;
            if (stat == 5)
                B.G5Blocks[player]++;
            if (stat == 6)
                B.G5Steals[player]++;
            if (stat == 7)
                B.G5Fouls[player]++;
            if (stat == 8)
                B.G5TOs[player]++;
        }
        if (x == 6)
        {
            if (stat == 0)
                Debug.Log("Error, you got save stat function running without any stat inputted");
            if (stat == 1)
            {
                B.G6Points[player]++;
                if (GamePointT1 && B.G6Teams[player] == 1)
                    B.G6ClutchBaskets[player]++;
                if (GamePointT2 && B.G6Teams[player] == 2)
                    B.G6ClutchBaskets[player]++;
            }
            if (stat == 2)
            {
                B.G6Misses[player]++;
                if (GamePointT1 && B.G6Teams[player] == 1)
                    B.G6ClutchMisses[player]++;
                if (GamePointT2 && B.G6Teams[player] == 2)
                    B.G6ClutchMisses[player]++;

            }
            if (stat == 3)
                B.G6Rebounds[player]++;
            if (stat == 4)
                B.G6Assists[player]++;
            if (stat == 5)
                B.G6Blocks[player]++;
            if (stat == 6)
                B.G6Steals[player]++;
            if (stat == 7)
                B.G6Fouls[player]++;
            if (stat == 8)
                B.G6TOs[player]++;
        }
        if (x == 7)
        {
            if (stat == 0)
                Debug.Log("Error, you got save stat function running without any stat inputted");
            if (stat == 1)
            {
                B.G7Points[player]++;
                if (GamePointT1 && B.G7Teams[player] == 1)
                    B.G7ClutchBaskets[player]++;
                if (GamePointT2 && B.G7Teams[player] == 2)
                    B.G7ClutchBaskets[player]++;
            }
            if (stat == 2)
            {
                B.G7Misses[player]++;
                if (GamePointT1 && B.G7Teams[player] == 1)
                    B.G7ClutchMisses[player]++;
                if (GamePointT2 && B.G7Teams[player] == 2)
                    B.G7ClutchMisses[player]++;

            }
            if (stat == 3)
                B.G7Rebounds[player]++;
            if (stat == 4)
                B.G7Assists[player]++;
            if (stat == 5)
                B.G7Blocks[player]++;
            if (stat == 6)
                B.G7Steals[player]++;
            if (stat == 7)
                B.G7Fouls[player]++;
            if (stat == 8)
                B.G7TOs[player]++;
        }
       
    }

    public void GamepointT1()
    {
        if (GamePointT1)
        {
            GamePointT1 = false;
            GamePointT1B.GetComponent<Image>().color = Color.black;
            GP1Text.color = Color.white;
            ColorBlock cb = GamePointT1B.colors;
            cb.normalColor = Color.black;
            GamePointT1B.colors = cb;
        }
        else
        {
            GamePointT1 = true;
            GamePointT1B.GetComponent<Image>().color = Color.white;
            GP1Text.color = Color.black;
            ColorBlock cb = GamePointT1B.colors;
            cb.normalColor = Color.white;
            GamePointT1B.colors = cb;
        }
    }
    public void GamepointT2()
    {
        
        if (GamePointT2)
        {
            GamePointT2 = false;
            GamePointT2B.GetComponent<Image>().color = Color.black;
            GP2Text.color = Color.white;
            ColorBlock cb = GamePointT2B.colors;
            cb.normalColor = Color.black;
            GamePointT2B.colors = cb;
        }
        else
        {
            GamePointT2 = true;
            GamePointT2B.GetComponent<Image>().color = Color.white;
            GP2Text.color = Color.black;
            ColorBlock cb = GamePointT2B.colors;
            cb.normalColor = Color.white;
            GamePointT2B.colors = cb;
        }
    }

    public void undoFunc()
    {

        z = 10;
        

        {
            Undo.GetComponent<Image>().color = Color.white;
            undot.color = Color.black;
            ColorBlock cb = Undo.colors;
            cb.normalColor = Color.white;
            Undo.colors = cb;
            undocolor = false;
        }
        

        int x = bigDataGameObject.GetComponent<BigData>().CurrentGameNumber;
        BigData B = bigDataGameObject.GetComponent<BigData>();

        int stat = lastStatFinal[3];
        int player = lastPlayerFinal[3];

        lastPlayerFinal[3] = lastPlayerFinal[2];
        lastPlayerFinal[2] = lastPlayerFinal[1];
        lastPlayerFinal[1] = lastPlayerFinal[0];
        lastStatFinal[3] = lastStatFinal[2];
        lastStatFinal[2] = lastStatFinal[1];
        lastStatFinal[1] = lastStatFinal[0];

        lastStatFinal[0] = 0;
        lastPlayerFinal[0] = 18;

        if (stat == 0 || player == 18)
        {
            return;
        }
        if (x == 1)
        {
            if (stat == 1)
            {
                B.G1Points[player]--;
                if (GamePointT1 && B.G1Teams[player] == 1)
                    B.G1ClutchBaskets[player]--;
                if (GamePointT2 && B.G1Teams[player] == 2)
                    B.G1ClutchBaskets[player]--;
            }
            if (stat == 2)
            {
                B.G1Misses[player]--;
                if (GamePointT1 && B.G1Teams[player] == 1)
                    B.G1ClutchMisses[player]--;
                if (GamePointT2 && B.G1Teams[player] == 2)
                    B.G1ClutchMisses[player]--;
            }
            if (stat == 3)
                B.G1Rebounds[player]--;
            if (stat == 4)
                B.G1Assists[player]--;
            if (stat == 5)
                B.G1Blocks[player]--;
            if (stat == 6)
                B.G1Steals[player]--;
            if (stat == 7)
                B.G1Fouls[player]--;
            if (stat == 8)
                B.G1TOs[player]--;
        }
        if (x == 2)
        {
            if (stat == 1)
            {
                B.G1Points[player]--;
                if (GamePointT1 && B.G2Teams[player] == 1)
                    B.G2ClutchBaskets[player]--;
                if (GamePointT2 && B.G2Teams[player] == 2)
                    B.G2ClutchBaskets[player]--;
            }
            if (stat == 2)
            {
                B.G2Misses[player]--;
                if (GamePointT1 && B.G2Teams[player] == 1)
                    B.G2ClutchMisses[player]--;
                if (GamePointT2 && B.G2Teams[player] == 2)
                    B.G2ClutchMisses[player]--;
            }
            if (stat == 3)
                B.G2Rebounds[player]--;
            if (stat == 4)
                B.G2Assists[player]--;
            if (stat == 5)
                B.G2Blocks[player]--;
            if (stat == 6)
                B.G2Steals[player]--;
            if (stat == 7)
                B.G2Fouls[player]--;
            if (stat == 8)
                B.G2TOs[player]--;
        }
        if (x == 3)
        {
            if (stat == 1)
            {
                B.G3Points[player]--;
                if (GamePointT1 && B.G3Teams[player] == 1)
                    B.G3ClutchBaskets[player]--;
                if (GamePointT2 && B.G3Teams[player] == 2)
                    B.G3ClutchBaskets[player]--;
            }
            if (stat == 2)
            {
                B.G3Misses[player]--;
                if (GamePointT1 && B.G3Teams[player] == 1)
                    B.G3ClutchMisses[player]--;
                if (GamePointT2 && B.G3Teams[player] == 2)
                    B.G3ClutchMisses[player]--;
            }
            if (stat == 3)
                B.G3Rebounds[player]--;
            if (stat == 4)
                B.G3Assists[player]--;
            if (stat == 5)
                B.G3Blocks[player]--;
            if (stat == 6)
                B.G3Steals[player]--;
            if (stat == 7)
                B.G3Fouls[player]--;
            if (stat == 8)
                B.G3TOs[player]--;
        }
        if (x == 4)
        {
            if (stat == 1)
            {
                B.G4Points[player]--;
                if (GamePointT1 && B.G4Teams[player] == 1)
                    B.G4ClutchBaskets[player]--;
                if (GamePointT2 && B.G4Teams[player] == 2)
                    B.G4ClutchBaskets[player]--;
            }
            if (stat == 2)
            {
                B.G4Misses[player]--;
                if (GamePointT1 && B.G4Teams[player] == 1)
                    B.G4ClutchMisses[player]--;
                if (GamePointT2 && B.G4Teams[player] == 2)
                    B.G4ClutchMisses[player]--;
            }
            if (stat == 3)
                B.G4Rebounds[player]--;
            if (stat == 4)
                B.G4Assists[player]--;
            if (stat == 5)
                B.G4Blocks[player]--;
            if (stat == 6)
                B.G4Steals[player]--;
            if (stat == 7)
                B.G4Fouls[player]--;
            if (stat == 8)
                B.G4TOs[player]--;
        }
        if (x == 5)
        {
            if (stat == 1)
            {
                B.G5Points[player]--;
                if (GamePointT1 && B.G5Teams[player] == 1)
                    B.G5ClutchBaskets[player]--;
                if (GamePointT2 && B.G5Teams[player] == 2)
                    B.G5ClutchBaskets[player]--;
            }
            if (stat == 2)
            {
                B.G5Misses[player]--;
                if (GamePointT1 && B.G5Teams[player] == 1)
                    B.G5ClutchMisses[player]--;
                if (GamePointT2 && B.G5Teams[player] == 2)
                    B.G5ClutchMisses[player]--;
            }
            if (stat == 3)
                B.G5Rebounds[player]--;
            if (stat == 4)
                B.G5Assists[player]--;
            if (stat == 5)
                B.G5Blocks[player]--;
            if (stat == 6)
                B.G5Steals[player]--;
            if (stat == 7)
                B.G5Fouls[player]--;
            if (stat == 8)
                B.G5TOs[player]--;
        }
        if (x == 6)
        {
            if (stat == 1)
            {
                B.G6Points[player]--;
                if (GamePointT1 && B.G6Teams[player] == 1)
                    B.G6ClutchBaskets[player]--;
                if (GamePointT2 && B.G6Teams[player] == 2)
                    B.G6ClutchBaskets[player]--;
            }
            if (stat == 2)
            {
                B.G6Misses[player]--;
                if (GamePointT1 && B.G6Teams[player] == 1)
                    B.G6ClutchMisses[player]--;
                if (GamePointT2 && B.G6Teams[player] == 2)
                    B.G6ClutchMisses[player]--;
            }
            if (stat == 3)
                B.G6Rebounds[player]--;
            if (stat == 4)
                B.G6Assists[player]--;
            if (stat == 5)
                B.G6Blocks[player]--;
            if (stat == 6)
                B.G6Steals[player]--;
            if (stat == 7)
                B.G6Fouls[player]--;
            if (stat == 8)
                B.G6TOs[player]--;
        }
        if (x == 7)
        {
            if (stat == 1)
            {
                B.G7Points[player]--;
                if (GamePointT1 && B.G7Teams[player] == 1)
                    B.G7ClutchBaskets[player]--;
                if (GamePointT2 && B.G7Teams[player] == 2)
                    B.G7ClutchBaskets[player]--;
            }
            if (stat == 2)
            {
                B.G7Misses[player]--;
                if (GamePointT1 && B.G7Teams[player] == 1)
                    B.G7ClutchMisses[player]--;
                if (GamePointT2 && B.G7Teams[player] == 2)
                    B.G7ClutchMisses[player]--;
            }
            if (stat == 3)
                B.G7Rebounds[player]--;
            if (stat == 4)
                B.G7Assists[player]--;
            if (stat == 5)
                B.G7Blocks[player]--;
            if (stat == 6)
                B.G7Steals[player]--;
            if (stat == 7)
                B.G7Fouls[player]--;
            if (stat == 8)
                B.G7TOs[player]--;
        }
        

        lastPlayerFinalH = 18;
        lastStatFinalH = 0;
        UpdateScore();

    }


    public void exitScene()
    {
        SceneManager.LoadScene("Home Screen");
    }

    public void ShowStatsScreen()
    {
        SceneManager.LoadScene("StatsScreen");
    }

    public void UpdateScore()
    {
        BigData B = bigDataGameObject.GetComponent<BigData>();
        int b = 0;
        float t1P = 0;
        float t2P = 0;
        Score.text = "";

        if (B.CurrentGameACTUAL == 1)
        {
            foreach (string player in B.Game1Names)
            {
                if (B.G1Teams[b] == 1)
                    t1P = t1P + B.G1Points[b];
                if (B.G1Teams[b] == 2)
                    t2P = t2P + B.G1Points[b];

                if (player == "")
                    break;

                b++;
            }
            Score.text = "" + t1P + " - " + t2P;
        }
        if (B.CurrentGameACTUAL == 2)
        {
            foreach (string player in B.Game2Names)
            {
                if (B.G2Teams[b] == 1)
                    t1P = t1P + B.G2Points[b];
                if (B.G2Teams[b] == 2)
                    t2P = t2P + B.G2Points[b];

                if (player == "")
                    break;

                b++;
            }
            Score.text = "" + t1P + " - " + t2P;
        }
        if (B.CurrentGameACTUAL == 3)
        {
            foreach (string player in B.Game3Names)
            {
                if (B.G3Teams[b] == 1)
                    t1P = t1P + B.G3Points[b];
                if (B.G3Teams[b] == 2)
                    t2P = t2P + B.G3Points[b];

                if (player == "")
                    break;

                b++;
            }
            Score.text = "" + t1P + " - " + t2P;
        }
        if (B.CurrentGameACTUAL == 4)
        {
            foreach (string player in B.Game4Names)
            {
                if (B.G4Teams[b] == 1)
                    t1P = t1P + B.G4Points[b];
                if (B.G4Teams[b] == 2)
                    t2P = t2P + B.G4Points[b];

                if (player == "")
                    break;

                b++;
            }
            Score.text = "" + t1P + " - " + t2P;
        }
        if (B.CurrentGameACTUAL == 5)
        {
            foreach (string player in B.Game5Names)
            {
                if (B.G5Teams[b] == 1)
                    t1P = t1P + B.G5Points[b];
                if (B.G5Teams[b] == 2)
                    t2P = t2P + B.G5Points[b];

                if (player == "")
                    break;

                b++;
            }
            Score.text = "" + t1P + " - " + t2P;
        }
        if (B.CurrentGameACTUAL == 6)
        {
            foreach (string player in B.Game6Names)
            {
                if (B.G6Teams[b] == 1)
                    t1P = t1P + B.G6Points[b];
                if (B.G6Teams[b] == 2)
                    t2P = t2P + B.G6Points[b];

                if (player == "")
                    break;

                b++;
            }
            Score.text = "" + t1P + " - " + t2P;

        }
        if (B.CurrentGameACTUAL == 7)
        {
            foreach (string player in B.Game7Names)
            {
                if (B.G7Teams[b] == 1)
                    t1P = t1P + B.G7Points[b];
                if (B.G7Teams[b] == 2)
                    t2P = t2P + B.G7Points[b];

                if (player == "")
                    break;

                b++;
            }
            Score.text = "" + t1P + " - " + t2P;
        }
    }
}

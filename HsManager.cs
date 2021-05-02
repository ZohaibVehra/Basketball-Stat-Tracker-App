using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class HsManager : MonoBehaviour
{
    public int CurrentGames = 0;
    public GameObject NewGameImagePrefab;
    public GameObject InstantiatePanel;
    public GameObject bigDataGameObject;


    // Start is called before the first frame update
    void Start()
    {

        if (GameObject.Find("BigDataObject") == null && GameObject.Find("BigDataObject(Clone)")==null)
        {
            var BigDataObjectnew = Instantiate(bigDataGameObject, new Vector3(0, 0, 0), Quaternion.identity);
            bigDataGameObject = BigDataObjectnew;

            bigDataGameObject.GetComponent<BigData>().UpdateB();
        }
        else
        {
            findBigD();
            bigDataGameObject.GetComponent<BigData>().UpdateB();
        }

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void NewGameFunc()
    {

        findBigD();



        bigDataGameObject.GetComponent<BigData>().CurrentGameNumber= bigDataGameObject.GetComponent<BigData>().CurrentGameNumber+1;



        SceneManager.LoadScene("NewGame1");

    }
    
    public void findBigD()
    {
        object[] obj = GameObject.FindSceneObjectsOfType(typeof(GameObject));
        foreach (object o in obj)
        {
            GameObject g = (GameObject)o;
            if (g.GetComponent<PolygonCollider2D>() != null)
            {
                bigDataGameObject = g;
            }
        }
    }
    public void UpdateBB()
    {
        bigDataGameObject.GetComponent<BigData>().UpdateB();
    }

    public void avgGames()
    {
        setAvgNamesandGames();
        BigData B = bigDataGameObject.GetComponent<BigData>();
        B.AVG = true;
        setAvgStats();

       SceneManager.LoadScene("StatsScreen");

    }
    public void setAvgNamesandGames()
    {
        BigData B = bigDataGameObject.GetComponent<BigData>();
        B.AVGSetEmpties();
        //setting up used names array
        if(B.Game1Names[0] != "")
        {
            for (int i = 0; i < 10; i++)
            {
                if (B.Game1Names[i] != "")
                {
                    for (int j = 0; j < B.UsedNames.Length-1; j++)
                    {
                        if (B.Game1Names[i] == B.UsedNames[j])
                        {
                            if(j==0)
                                B.P1Games[0] = i+1;
                            else if (j == 1)
                                B.P2Games[0] = i+1;
                            else if (j == 2)
                                B.P3Games[0] = i + 1;
                            else if (j == 3)
                                B.P4Games[0] = i + 1;
                            else if (j == 4)
                                B.P5Games[0] = i + 1;
                            else if (j == 5)
                                B.P6Games[0] = i + 1;
                            else if (j == 6)
                                B.P7Games[0] = i + 1;
                            else if (j == 7)
                                B.P8Games[0] = i + 1;
                            else if (j == 8)
                                B.P9Games[0] = i + 1;
                            else if (j == 9)
                                B.P10Games[0] = i + 1;
                            else if (j == 10)
                                B.P11Games[0] = i + 1;
                            else if (j == 11)
                                B.P12Games[0] = i + 1;
                            else if (j == 12)
                                B.P13Games[0] = i + 1;

                            Debug.Log("L114 found g1names[i] in usednames already. set pxgames[" + 0 + "] to " + i);



                            break;
                        }
                        if(B.UsedNames[j] == "")
                        {
                            Debug.Log("Just set usednames[" + j + "]  to g1names[" + i + "] where the name is " + B.Game1Names[i]+" and setting position in p1games position"+j+" to "+i);
                            B.UsedNames[j] = B.Game1Names[i];
                            if (j == 0)
                                B.P1Games[0] = i + 1;
                            else if (j == 1)
                                B.P2Games[0] = i + 1;
                            else if (j == 2)
                                B.P3Games[0] = i + 1;
                            else if (j == 3)
                                B.P4Games[0] = i + 1;
                            else if (j == 4)
                                B.P5Games[0] = i + 1;
                            else if (j == 5)
                                B.P6Games[0] = i + 1;
                            else if (j == 6)
                                B.P7Games[0] = i + 1;
                            else if (j == 7)
                                B.P8Games[0] = i + 1;
                            else if (j == 8)
                                B.P9Games[0] = i + 1;
                            else if (j == 9)
                                B.P10Games[0] = i + 1;
                            else if (j == 10)
                                B.P11Games[0] = i + 1;
                            else if (j == 11)
                                B.P12Games[0] = i + 1;
                            else if (j == 12)
                                B.P13Games[0] = i + 1;
                            break;
                        }                 
                    }
                }
                    

            }
        }
        if (B.Game2Names[0] != "")
        {
            for (int i = 0; i < 10; i++)
            {
                if (B.Game2Names[i] != "")
                {
                    for (int j = 0; j < B.UsedNames.Length - 1; j++)
                    {
                        if (B.Game2Names[i] == B.UsedNames[j])
                        {
                            if (j == 0)
                                B.P1Games[1] = i + 1;
                            else if (j == 1)
                                B.P2Games[1] = i + 1;
                            else if (j == 2)
                                B.P3Games[1] = i + 1;
                            else if (j == 3)
                                B.P4Games[1] = i + 1;
                            else if (j == 4)
                                B.P5Games[1] = i + 1;
                            else if (j == 5)
                                B.P6Games[1] = i + 1;
                            else if (j == 6)
                                B.P7Games[1] = i + 1;
                            else if (j == 7)
                                B.P8Games[1] = i + 1;
                            else if (j == 8)
                                B.P9Games[1] = i + 1;
                            else if (j == 9)
                                B.P10Games[1] = i + 1;
                            else if (j == 10)
                                B.P11Games[1] = i + 1;
                            else if (j == 11)
                                B.P12Games[1] = i + 1;
                            else if (j == 12)
                                B.P13Games[1] = i + 1;
                            Debug.Log("found g2names[i] in usednames already. set p2games[" + j + "] to " + i);
                            break;
                        }
                        if (B.UsedNames[j] == "")
                        {
                            Debug.Log("Just set usednames[" + j + "]  to g2names[" + i + "] where the name is " + B.Game2Names[i] + " and setting position in p2games position" + j + " to " + i);
                            B.UsedNames[j] = B.Game2Names[i];
                            if (j == 0)
                                B.P1Games[1] = i + 1;
                            else if (j == 1)
                                B.P2Games[1] = i + 1;
                            else if (j == 2)
                                B.P3Games[1] = i + 1;
                            else if (j == 3)
                                B.P4Games[1] = i + 1;
                            else if (j == 4)
                                B.P5Games[1] = i + 1;
                            else if (j == 5)
                                B.P6Games[1] = i + 1;
                            else if (j == 6)
                                B.P7Games[1] = i + 1;
                            else if (j == 7)
                                B.P8Games[1] = i + 1;
                            else if (j == 8)
                                B.P9Games[1] = i + 1;
                            else if (j == 9)
                                B.P10Games[1] = i + 1;
                            else if (j == 10)
                                B.P11Games[1] = i + 1;
                            else if (j == 11)
                                B.P12Games[1] = i + 1;
                            else if (j == 12)
                                B.P13Games[1] = i + 1;
                            break;
                        }
                    }
                }


            }
        }
        if (B.Game3Names[0] != "")
            {
                for (int i = 0; i < 10; i++)
                {
                    if (B.Game3Names[i] != "")
                    {
                        for (int j = 0; j < B.UsedNames.Length - 1; j++)
                        {
                            if (B.Game3Names[i] == B.UsedNames[j])
                            {
                                if (j == 0)
                                    B.P1Games[2] = i + 1;
                                else if (j == 1)
                                    B.P2Games[2] = i + 1;
                                else if (j == 2)
                                    B.P3Games[2] = i + 1;
                                else if (j == 3)
                                    B.P4Games[2] = i + 1;
                                else if (j == 4)
                                    B.P5Games[2] = i + 1;
                                else if (j == 5)
                                    B.P6Games[2] = i + 1;
                                else if (j == 6)
                                    B.P7Games[2] = i + 1;
                                else if (j == 7)
                                    B.P8Games[2] = i + 1;
                                else if (j == 8)
                                    B.P9Games[2] = i + 1;
                                else if (j == 9)
                                    B.P10Games[2] = i + 1;
                                else if (j == 10)
                                    B.P11Games[2] = i + 1;
                                else if (j == 11)
                                    B.P12Games[2] = i + 1;
                                else if (j == 12)
                                    B.P13Games[2] = i + 1;
                                break;
                            }
                            if (B.UsedNames[j] == "")
                            {
                                
                                B.UsedNames[j] = B.Game3Names[i];
                                if (j == 0)
                                    B.P1Games[2] = i + 1;
                                else if (j == 1)
                                    B.P2Games[2] = i + 1;
                                else if (j == 2)
                                    B.P3Games[2] = i + 1;
                                else if (j == 3)
                                    B.P4Games[2] = i + 1;
                                else if (j == 4)
                                    B.P5Games[2] = i + 1;
                                else if (j == 5)
                                    B.P6Games[2] = i + 1;
                                else if (j == 6)
                                    B.P7Games[2] = i + 1;
                                else if (j == 7)
                                    B.P8Games[2] = i + 1;
                                else if (j == 8)
                                    B.P9Games[2] = i + 1;
                                else if (j == 9)
                                    B.P10Games[2] = i + 1;
                                else if (j == 10)
                                    B.P11Games[2] = i + 1;
                                else if (j == 11)
                                    B.P12Games[2] = i + 1;
                                else if (j == 12)
                                    B.P13Games[2] = i + 1;
                                break;
                            }
                        }
                    }


                }

            }
        if (B.Game4Names[0] != "")
            {
                for (int i = 0; i < 10; i++)
                {
                    if (B.Game4Names[i] != "")
                    {
                        for (int j = 0; j < B.UsedNames.Length - 1; j++)
                        {
                            if (B.Game4Names[i] == B.UsedNames[j])
                            {
                                if (j == 0)
                                    B.P1Games[3] = i + 1;
                                else if (j == 1)
                                    B.P2Games[3] = i + 1;
                                else if (j == 2)
                                    B.P3Games[3] = i + 1;
                                else if (j == 3)
                                    B.P4Games[3] = i + 1;
                                else if (j == 4)
                                    B.P5Games[3] = i + 1;
                                else if (j == 5)
                                    B.P6Games[3] = i + 1;
                                else if (j == 6)
                                    B.P7Games[3] = i + 1;
                                else if (j == 7)
                                    B.P8Games[3] = i + 1;
                                else if (j == 8)
                                    B.P9Games[3] = i + 1;
                                else if (j == 9)
                                    B.P10Games[3] = i + 1;
                                else if (j == 10)
                                    B.P11Games[3] = i + 1;
                                else if (j == 11)
                                    B.P12Games[3] = i + 1;
                                else if (j == 12)
                                    B.P13Games[3] = i + 1;
                                break;
                            }
                            if (B.UsedNames[j] == "")
                            {

                                B.UsedNames[j] = B.Game4Names[i];
                                if (j == 0)
                                    B.P1Games[3] = i + 1;
                                else if (j == 1)
                                    B.P2Games[3] = i + 1;
                                else if (j == 2)
                                    B.P3Games[3] = i + 1;
                                else if (j == 3)
                                    B.P4Games[3] = i + 1;
                                else if (j == 4)
                                    B.P5Games[3] = i + 1;
                                else if (j == 5)
                                    B.P6Games[3] = i + 1;
                                else if (j == 6)
                                    B.P7Games[3] = i + 1;
                                else if (j == 7)
                                    B.P8Games[3] = i + 1;
                                else if (j == 8)
                                    B.P9Games[3] = i + 1;
                                else if (j == 9)
                                    B.P10Games[3] = i + 1;
                                else if (j == 10)
                                    B.P11Games[3] = i + 1;
                                else if (j == 11)
                                    B.P12Games[3] = i + 1;
                                else if (j == 12)
                                    B.P13Games[3] = i + 1;
                                break;
                            }
                        }
                    }


                }

            }
        if (B.Game5Names[0] != "")
            {
                for (int i = 0; i < 10; i++)
                {
                    if (B.Game5Names[i] != "")
                    {
                        for (int j = 0; j < B.UsedNames.Length - 1; j++)
                        {
                            if (B.Game5Names[i] == B.UsedNames[j])
                            {
                                if (j == 0)
                                    B.P1Games[4] = i + 1;
                                else if (j == 1)
                                    B.P2Games[4] = i + 1;
                                else if (j == 2)
                                    B.P3Games[4] = i + 1;
                                else if (j == 3)
                                    B.P4Games[4] = i + 1;
                                else if (j == 4)
                                    B.P5Games[4] = i + 1;
                                else if (j == 5)
                                    B.P6Games[4] = i + 1;
                                else if (j == 6)
                                    B.P7Games[4] = i + 1;
                                else if (j == 7)
                                    B.P8Games[4] = i + 1;
                                else if (j == 8)
                                    B.P9Games[4] = i + 1;
                                else if (j == 9)
                                    B.P10Games[4] = i + 1;
                                else if (j == 10)
                                    B.P11Games[4] = i + 1;
                                else if (j == 11)
                                    B.P12Games[4] = i + 1;
                                else if (j == 12)
                                    B.P13Games[4] = i + 1;
                                break;
                            }
                            if (B.UsedNames[j] == "")
                            {

                                B.UsedNames[j] = B.Game5Names[i];
                                if (j == 0)
                                    B.P1Games[4] = i + 1;
                                else if (j == 1)
                                    B.P2Games[4] = i + 1;
                                else if (j == 2)
                                    B.P3Games[4] = i + 1;
                                else if (j == 3)
                                    B.P4Games[4] = i + 1;
                                else if (j == 4)
                                    B.P5Games[4] = i + 1;
                                else if (j == 5)
                                    B.P6Games[4] = i + 1;
                                else if (j == 6)
                                    B.P7Games[4] = i + 1;
                                else if (j == 7)
                                    B.P8Games[4] = i + 1;
                                else if (j == 8)
                                    B.P9Games[4] = i + 1;
                                else if (j == 9)
                                    B.P10Games[4] = i + 1;
                                else if (j == 10)
                                    B.P11Games[4] = i + 1;
                                else if (j == 11)
                                    B.P12Games[4] = i + 1;
                                else if (j == 12)
                                    B.P13Games[4] = i + 1;
                                break;
                            }
                        }
                    }


                }

            }
        if (B.Game6Names[0] != "")
        {
            for (int i = 0; i < 10; i++)
            {
                if (B.Game6Names[i] != "")
                {
                    for (int j = 0; j < B.UsedNames.Length - 1; j++)
                    {
                        if (B.Game6Names[i] == B.UsedNames[j])
                        {
                            if (j == 0)
                                B.P1Games[5] = i + 1;
                            else if (j == 1)
                                B.P2Games[5] = i + 1;
                            else if (j == 2)
                                B.P3Games[5] = i + 1;
                            else if (j == 3)
                                B.P4Games[5] = i + 1;
                            else if (j == 4)
                                B.P5Games[5] = i + 1;
                            else if (j == 5)
                                B.P6Games[5] = i + 1;
                            else if (j == 6)
                                B.P7Games[5] = i + 1;
                            else if (j == 7)
                                B.P8Games[5] = i + 1;
                            else if (j == 8)
                                B.P9Games[5] = i + 1;
                            else if (j == 9)
                                B.P10Games[5] = i + 1;
                            else if (j == 10)
                                B.P11Games[5] = i + 1;
                            else if (j == 11)
                                B.P12Games[5] = i + 1;
                            else if (j == 12)
                                B.P13Games[5] = i + 1;
                            break;
                        }
                        if (B.UsedNames[j] == "")
                        {

                            B.UsedNames[j] = B.Game6Names[i];
                            if (j == 0)
                                B.P1Games[5] = i + 1;
                            else if (j == 1)
                                B.P2Games[5] = i + 1;
                            else if (j == 2)
                                B.P3Games[5] = i + 1;
                            else if (j == 3)
                                B.P4Games[5] = i + 1;
                            else if (j == 4)
                                B.P5Games[5] = i + 1;
                            else if (j == 5)
                                B.P6Games[5] = i + 1;
                            else if (j == 6)
                                B.P7Games[5] = i + 1;
                            else if (j == 7)
                                B.P8Games[5] = i + 1;
                            else if (j == 8)
                                B.P9Games[5] = i + 1;
                            else if (j == 9)
                                B.P10Games[5] = i + 1;
                            else if (j == 10)
                                B.P11Games[5] = i + 1;
                            else if (j == 11)
                                B.P12Games[5] = i + 1;
                            else if (j == 12)
                                B.P13Games[5] = i + 1;
                            break;
                        }
                    }
                }
            }
        }
        if (B.Game7Names[0] != "")
            {
                for (int i = 0; i < 10; i++)
                {
                    if (B.Game7Names[i] != "")
                    {
                        for (int j = 0; j < B.UsedNames.Length - 1; j++)
                        {
                            if (B.Game7Names[i] == B.UsedNames[j])
                            {
                                if (j == 0)
                                    B.P1Games[6] = i + 1;
                                else if (j == 1)
                                    B.P2Games[6] = i + 1;
                                else if (j == 2)
                                    B.P3Games[6] = i + 1;
                                else if (j == 3)
                                    B.P4Games[6] = i + 1;
                                else if (j == 4)
                                    B.P5Games[6] = i + 1;
                                else if (j == 5)
                                    B.P6Games[6] = i + 1;
                                else if (j == 6)
                                    B.P7Games[6] = i + 1;
                                else if (j == 7)
                                    B.P8Games[6] = i + 1;
                                else if (j == 8)
                                    B.P9Games[6] = i + 1;
                                else if (j == 9)
                                    B.P10Games[6] = i + 1;
                                else if (j == 10)
                                    B.P11Games[6] = i + 1;
                                else if (j == 11)
                                    B.P12Games[6] = i + 1;
                                else if (j == 12)
                                    B.P13Games[6] = i + 1;
                                break;
                            }
                            if (B.UsedNames[j] == "")
                            {

                                B.UsedNames[j] = B.Game7Names[i];
                                if (j == 0)
                                    B.P1Games[6] = i + 1;
                                else if (j == 1)
                                    B.P2Games[6] = i + 1;
                                else if (j == 2)
                                    B.P3Games[6] = i + 1;
                                else if (j == 3)
                                    B.P4Games[6] = i + 1;
                                else if (j == 4)
                                    B.P5Games[6] = i + 1;
                                else if (j == 5)
                                    B.P6Games[6] = i + 1;
                                else if (j == 6)
                                    B.P7Games[6] = i + 1;
                                else if (j == 7)
                                    B.P8Games[6] = i + 1;
                                else if (j == 8)
                                    B.P9Games[6] = i + 1;
                                else if (j == 9)
                                    B.P10Games[6] = i + 1;
                                else if (j == 10)
                                    B.P11Games[6] = i + 1;
                                else if (j == 11)
                                    B.P12Games[6] = i + 1;
                                else if (j == 12)
                                    B.P13Games[6] = i + 1;
                                break;
                            }
                        }
                    }


                }

            }
   
    }

    public void setAvgStats()
    {
        BigData B = bigDataGameObject.GetComponent<BigData>();
        Debug.Log("set started");
        int a;

        if (B.G1Teams[0] != 0)
        {
            if (B.P1Games[0] != 0)
            {
                a = B.P1Games[0] - 1;

                B.AvgPoints[0] +=       B.G1Points[a];
                B.AvgMisses[0] += B.G1Misses[a];
                B.AvgAssists[0] +=      B.G1Assists[a];
                B.AvgRebounds[0] +=     B.G1Rebounds[a];
                B.AvgBlocks[0] +=       B.G1Blocks[a];
                B.Avgsteals[0] +=       B.G1Steals[a];
                B.AvgTurnOvers[0] +=    B.G1TOs[a];
                B.AvgFouls[0] +=        B.G1Fouls[a];
                B.AvgClutchBaskets[0]+= B.G1ClutchBaskets[a];
                B.AvgClutchMisses[0] += B.G1ClutchMisses[a];
                B.AvgGamesPlayed[0]++;
            }
            if (B.P2Games[0] != 0)
            {
                a = B.P2Games[0] - 1;
                B.AvgPoints[1] += B.G1Points[a];
                B.AvgMisses[1] += B.G1Misses[a];
                B.AvgAssists[1] += B.G1Assists[a];
                B.AvgRebounds[1] += B.G1Rebounds[a];
                B.AvgBlocks[1] += B.G1Blocks[a];
                B.Avgsteals[1] += B.G1Steals[a];
                B.AvgTurnOvers[1] += B.G1TOs[a];
                B.AvgFouls[1] += B.G1Fouls[a];
                B.AvgClutchBaskets[1] += B.G1ClutchBaskets[a];
                B.AvgClutchMisses[1] += B.G1ClutchMisses[a];
                B.AvgGamesPlayed[1]++;
            }
            if (B.P3Games[0] != 0)
            {
                a = B.P3Games[0] - 1;
                B.AvgPoints[2] += B.G1Points[a];
                B.AvgMisses[2] += B.G1Misses[a];
                B.AvgAssists[2] += B.G1Assists[a];
                B.AvgRebounds[2] += B.G1Rebounds[a];
                B.AvgBlocks[2] += B.G1Blocks[a];
                B.Avgsteals[2] += B.G1Steals[a];
                B.AvgTurnOvers[2] += B.G1TOs[a];
                B.AvgFouls[2] += B.G1Fouls[a];
                B.AvgClutchBaskets[2] += B.G1ClutchBaskets[a];
                B.AvgClutchMisses[2] += B.G1ClutchMisses[a];
                B.AvgGamesPlayed[2]++;
            }
            if (B.P4Games[0] != 0)
            {
                a = B.P4Games[0] - 1;
                B.AvgPoints[3] += B.G1Points[a];
                B.AvgMisses[3] += B.G1Misses[a];
                B.AvgAssists[3] += B.G1Assists[a];
                B.AvgRebounds[3] += B.G1Rebounds[a];
                B.AvgBlocks[3] += B.G1Blocks[a];
                B.Avgsteals[3] += B.G1Steals[a];
                B.AvgTurnOvers[3] += B.G1TOs[a];
                B.AvgFouls[3] += B.G1Fouls[a];
                B.AvgClutchBaskets[3] += B.G1ClutchBaskets[a];
                B.AvgClutchMisses[3] += B.G1ClutchMisses[a];
                B.AvgGamesPlayed[3]++;
            }
            if (B.P5Games[0] != 0)
            {
                a = B.P5Games[0] - 1;
                B.AvgPoints[4] += B.G1Points[a];
                B.AvgMisses[4] += B.G1Misses[a];
                B.AvgAssists[4] += B.G1Assists[a];
                B.AvgRebounds[4] += B.G1Rebounds[a];
                B.AvgBlocks[4] += B.G1Blocks[a];
                B.Avgsteals[4] += B.G1Steals[a];
                B.AvgTurnOvers[4] += B.G1TOs[a];
                B.AvgFouls[4] += B.G1Fouls[a];
                B.AvgClutchBaskets[4] += B.G1ClutchBaskets[a];
                B.AvgClutchMisses[4] += B.G1ClutchMisses[a];
                B.AvgGamesPlayed[4]++;
            }
            if (B.P6Games[0] != 0)
            {
                a = B.P6Games[0] - 1;
                B.AvgPoints[5] += B.G1Points[a];
                B.AvgMisses[5] += B.G1Misses[a];
                B.AvgAssists[5] += B.G1Assists[a];
                B.AvgRebounds[5] += B.G1Rebounds[a];
                B.AvgBlocks[5] += B.G1Blocks[a];
                B.Avgsteals[5] += B.G1Steals[a];
                B.AvgTurnOvers[5] += B.G1TOs[a];
                B.AvgFouls[5] += B.G1Fouls[a];
                B.AvgClutchBaskets[5] += B.G1ClutchBaskets[a];
                B.AvgClutchMisses[5] += B.G1ClutchMisses[a];
                B.AvgGamesPlayed[5]++;
            }
            if (B.P7Games[0] != 0)
            {
                a = B.P7Games[0] - 1;
                B.AvgPoints[6] += B.G1Points[a];
                B.AvgMisses[6] += B.G1Misses[a];
                B.AvgAssists[6] += B.G1Assists[a];
                B.AvgRebounds[6] += B.G1Rebounds[a];
                B.AvgBlocks[6] += B.G1Blocks[a];
                B.Avgsteals[6] += B.G1Steals[a];
                B.AvgTurnOvers[6] += B.G1TOs[a];
                B.AvgFouls[6] += B.G1Fouls[a];
                B.AvgClutchBaskets[6] += B.G1ClutchBaskets[a];
                B.AvgClutchMisses[6] += B.G1ClutchMisses[a];
                B.AvgGamesPlayed[6]++;
            }
            if (B.P8Games[0] != 0)
            {
                a = B.P8Games[0] - 1;
                B.AvgPoints[7] += B.G1Points[a];
                B.AvgMisses[7] += B.G1Misses[a];
                B.AvgAssists[7] += B.G1Assists[a];
                B.AvgRebounds[7] += B.G1Rebounds[a];
                B.AvgBlocks[7] += B.G1Blocks[a];
                B.Avgsteals[7] += B.G1Steals[a];
                B.AvgTurnOvers[7] += B.G1TOs[a];
                B.AvgFouls[7] += B.G1Fouls[a];
                B.AvgClutchBaskets[7] += B.G1ClutchBaskets[a];
                B.AvgClutchMisses[7] += B.G1ClutchMisses[a];
                B.AvgGamesPlayed[7]++;
            }
            if (B.P9Games[0] != 0)
            {
                a = B.P9Games[0] - 1;
                B.AvgPoints[8] += B.G1Points[a];
                B.AvgMisses[8] += B.G1Misses[a];
                B.AvgAssists[8] += B.G1Assists[a];
                B.AvgRebounds[8] += B.G1Rebounds[a];
                B.AvgBlocks[8] += B.G1Blocks[a];
                B.Avgsteals[8] += B.G1Steals[a];
                B.AvgTurnOvers[8] += B.G1TOs[a];
                B.AvgFouls[8] += B.G1Fouls[a];
                B.AvgClutchBaskets[8] += B.G1ClutchBaskets[a];
                B.AvgClutchMisses[8] += B.G1ClutchMisses[a];
                B.AvgGamesPlayed[8]++;
            }
            if (B.P10Games[0] != 0)
            {
                a = B.P10Games[0] - 1;
                B.AvgPoints[9] += B.G1Points[a];
                B.AvgMisses[9] += B.G1Misses[a];
                B.AvgAssists[9] += B.G1Assists[a];
                B.AvgRebounds[9] += B.G1Rebounds[a];
                B.AvgBlocks[9] += B.G1Blocks[a];
                B.Avgsteals[9] += B.G1Steals[a];
                B.AvgTurnOvers[9] += B.G1TOs[a];
                B.AvgFouls[9] += B.G1Fouls[a];
                B.AvgClutchBaskets[9] += B.G1ClutchBaskets[a];
                B.AvgClutchMisses[9] += B.G1ClutchMisses[a];
                B.AvgGamesPlayed[9]++;
            }
            if (B.P11Games[0] != 0)
            {
                a = B.P11Games[0] - 1;
                B.AvgPoints[10] += B.G1Points[a];
                B.AvgMisses[10] += B.G1Misses[a];
                B.AvgAssists[10] += B.G1Assists[a];
                B.AvgRebounds[10] += B.G1Rebounds[a];
                B.AvgBlocks[10] += B.G1Blocks[a];
                B.Avgsteals[10] += B.G1Steals[a];
                B.AvgTurnOvers[10] += B.G1TOs[a];
                B.AvgFouls[10] += B.G1Fouls[a];
                B.AvgClutchBaskets[10] += B.G1ClutchBaskets[a];
                B.AvgClutchMisses[10] += B.G1ClutchMisses[a];
                B.AvgGamesPlayed[10]++;
            }
            if (B.P12Games[0] != 0)
            {
                a = B.P12Games[0] - 1;
                B.AvgPoints[11] += B.G1Points[a];
                B.AvgMisses[11] += B.G1Misses[a];
                B.AvgAssists[11] += B.G1Assists[a];
                B.AvgRebounds[11] += B.G1Rebounds[a];
                B.AvgBlocks[11] += B.G1Blocks[a];
                B.Avgsteals[11] += B.G1Steals[a];
                B.AvgTurnOvers[11] += B.G1TOs[a];
                B.AvgFouls[11] += B.G1Fouls[a];
                B.AvgClutchBaskets[11] += B.G1ClutchBaskets[a];
                B.AvgClutchMisses[11] += B.G1ClutchMisses[a];
                B.AvgGamesPlayed[11]++;
            }
            if (B.P13Games[0] != 0)
            {
                a = B.P13Games[0] - 1;
                B.AvgPoints[12] += B.G1Points[a];
                B.AvgMisses[12] += B.G1Misses[a];
                B.AvgAssists[12] += B.G1Assists[a];
                B.AvgRebounds[12] += B.G1Rebounds[a];
                B.AvgBlocks[12] += B.G1Blocks[a];
                B.Avgsteals[12] += B.G1Steals[a];
                B.AvgTurnOvers[12] += B.G1TOs[a];
                B.AvgFouls[12] += B.G1Fouls[a];
                B.AvgClutchBaskets[12] += B.G1ClutchBaskets[a];
                B.AvgClutchMisses[12] += B.G1ClutchMisses[a];
                B.AvgGamesPlayed[12]++;
            }


        }
        else
            return;
        if (B.G2Teams[0] != 0)
        {
            if (B.P1Games[1] != 0)
            {
                a = B.P1Games[1] - 1;

                B.AvgPoints[0] += B.G2Points[a];
                B.AvgMisses[0] += B.G2Misses[a];
                B.AvgAssists[0] += B.G2Assists[a];
                B.AvgRebounds[0] += B.G2Rebounds[a];
                B.AvgBlocks[0] += B.G2Blocks[a];
                B.Avgsteals[0] += B.G2Steals[a];
                B.AvgTurnOvers[0] += B.G2TOs[a];
                B.AvgFouls[0] += B.G2Fouls[a];
                B.AvgClutchBaskets[0] += B.G2ClutchBaskets[a];
                B.AvgClutchMisses[0] += B.G2ClutchMisses[a];
                B.AvgGamesPlayed[0]++;
            }
            if (B.P2Games[1] != 0)
            {
                a = B.P2Games[1] - 1;
                B.AvgPoints[1] += B.G2Points[a];
                B.AvgMisses[1] += B.G2Misses[a];
                B.AvgAssists[1] += B.G2Assists[a];
                B.AvgRebounds[1] += B.G2Rebounds[a];
                B.AvgBlocks[1] += B.G2Blocks[a];
                B.Avgsteals[1] += B.G2Steals[a];
                B.AvgTurnOvers[1] += B.G2TOs[a];
                B.AvgFouls[1] += B.G2Fouls[a];
                B.AvgClutchBaskets[1] += B.G2ClutchBaskets[a];
                B.AvgClutchMisses[1] += B.G2ClutchMisses[a];
                B.AvgGamesPlayed[1]++;
            }
            if (B.P3Games[1] != 0)
            {
                a = B.P3Games[1] - 1;
                B.AvgPoints[2] += B.G2Points[a];
                B.AvgMisses[2] += B.G2Misses[a];
                B.AvgAssists[2] += B.G2Assists[a];
                B.AvgRebounds[2] += B.G2Rebounds[a];
                B.AvgBlocks[2] += B.G2Blocks[a];
                B.Avgsteals[2] += B.G2Steals[a];
                B.AvgTurnOvers[2] += B.G2TOs[a];
                B.AvgFouls[2] += B.G2Fouls[a];
                B.AvgClutchBaskets[2] += B.G2ClutchBaskets[a];
                B.AvgClutchMisses[2] += B.G2ClutchMisses[a];
                B.AvgGamesPlayed[2]++;
            }
            if (B.P4Games[1] != 0)
            {
                a = B.P4Games[1] - 1;
                B.AvgPoints[3] += B.G2Points[a];
                B.AvgMisses[3] += B.G2Misses[a];
                B.AvgAssists[3] += B.G2Assists[a];
                B.AvgRebounds[3] += B.G2Rebounds[a];
                B.AvgBlocks[3] += B.G2Blocks[a];
                B.Avgsteals[3] += B.G2Steals[a];
                B.AvgTurnOvers[3] += B.G2TOs[a];
                B.AvgFouls[3] += B.G2Fouls[a];
                B.AvgClutchBaskets[3] += B.G2ClutchBaskets[a];
                B.AvgClutchMisses[3] += B.G2ClutchMisses[a];
                B.AvgGamesPlayed[3]++;
            }
            if (B.P5Games[1] != 0)
            {
                a = B.P5Games[1] - 1;
                B.AvgPoints[4] += B.G2Points[a];
                B.AvgMisses[4] += B.G2Misses[a];
                B.AvgAssists[4] += B.G2Assists[a];
                B.AvgRebounds[4] += B.G2Rebounds[a];
                B.AvgBlocks[4] += B.G2Blocks[a];
                B.Avgsteals[4] += B.G2Steals[a];
                B.AvgTurnOvers[4] += B.G2TOs[a];
                B.AvgFouls[4] += B.G2Fouls[a];
                B.AvgClutchBaskets[4] += B.G2ClutchBaskets[a];
                B.AvgClutchMisses[4] += B.G2ClutchMisses[a];
                B.AvgGamesPlayed[4]++;
            }
            if (B.P6Games[1] != 0)
            {
                a = B.P6Games[1] - 1;
                B.AvgPoints[5] += B.G2Points[a];
                B.AvgMisses[5] += B.G2Misses[a];
                B.AvgAssists[5] += B.G2Assists[a];
                B.AvgRebounds[5] += B.G2Rebounds[a];
                B.AvgBlocks[5] += B.G2Blocks[a];
                B.Avgsteals[5] += B.G2Steals[a];
                B.AvgTurnOvers[5] += B.G2TOs[a];
                B.AvgFouls[5] += B.G2Fouls[a];
                B.AvgClutchBaskets[5] += B.G2ClutchBaskets[a];
                B.AvgClutchMisses[5] += B.G2ClutchMisses[a];
                B.AvgGamesPlayed[5]++;
            }
            if (B.P7Games[1] != 0)
            {
                a = B.P7Games[1] - 1;
                B.AvgPoints[6] += B.G2Points[a];
                B.AvgMisses[6] += B.G2Misses[a];
                B.AvgMisses[6] += B.G2Misses[a];
                B.AvgAssists[6] += B.G2Assists[a];
                B.AvgRebounds[6] += B.G2Rebounds[a];
                B.AvgBlocks[6] += B.G2Blocks[a];
                B.Avgsteals[6] += B.G2Steals[a];
                B.AvgTurnOvers[6] += B.G2TOs[a];
                B.AvgFouls[6] += B.G2Fouls[a];
                B.AvgClutchBaskets[6] += B.G2ClutchBaskets[a];
                B.AvgClutchMisses[6] += B.G2ClutchMisses[a];
                B.AvgGamesPlayed[6]++;
            }
            if (B.P8Games[1] != 0)
            {
                a = B.P8Games[1] - 1;
                B.AvgPoints[7] += B.G2Points[a];
                B.AvgMisses[7] += B.G2Misses[a];
                B.AvgAssists[7] += B.G2Assists[a];
                B.AvgRebounds[7] += B.G2Rebounds[a];
                B.AvgBlocks[7] += B.G2Blocks[a];
                B.Avgsteals[7] += B.G2Steals[a];
                B.AvgTurnOvers[7] += B.G2TOs[a];
                B.AvgFouls[7] += B.G2Fouls[a];
                B.AvgClutchBaskets[7] += B.G2ClutchBaskets[a];
                B.AvgClutchMisses[7] += B.G2ClutchMisses[a];
                B.AvgGamesPlayed[7]++;
            }
            if (B.P9Games[1] != 0)
            {
                a = B.P8Games[1] - 1;
                B.AvgPoints[8] += B.G2Points[a];
                B.AvgMisses[8] += B.G2Misses[a];
                B.AvgAssists[8] += B.G2Assists[a];
                B.AvgRebounds[8] += B.G2Rebounds[a];
                B.AvgBlocks[8] += B.G2Blocks[a];
                B.Avgsteals[8] += B.G2Steals[a];
                B.AvgTurnOvers[8] += B.G2TOs[a];
                B.AvgFouls[8] += B.G2Fouls[a];
                B.AvgClutchBaskets[8] += B.G2ClutchBaskets[a];
                B.AvgClutchMisses[8] += B.G2ClutchMisses[a];
                B.AvgGamesPlayed[8]++;
            }
            if (B.P10Games[1] != 0)
            {
                a = B.P10Games[1] - 1;
                B.AvgPoints[9] += B.G2Points[a];
                B.AvgMisses[9] += B.G2Misses[a];
                B.AvgAssists[9] += B.G2Assists[a];
                B.AvgRebounds[9] += B.G2Rebounds[a];
                B.AvgBlocks[9] += B.G2Blocks[a];
                B.Avgsteals[9] += B.G2Steals[a];
                B.AvgTurnOvers[9] += B.G2TOs[a];
                B.AvgFouls[9] += B.G2Fouls[a];
                B.AvgClutchBaskets[9] += B.G2ClutchBaskets[a];
                B.AvgClutchMisses[9] += B.G2ClutchMisses[a];
                B.AvgGamesPlayed[9]++;
            }
            if (B.P11Games[1] != 0)
            {
                a = B.P11Games[1] - 1;
                B.AvgPoints[10] += B.G2Points[a];
                B.AvgMisses[10] += B.G2Misses[a];
                B.AvgAssists[10] += B.G2Assists[a];
                B.AvgRebounds[10] += B.G2Rebounds[a];
                B.AvgBlocks[10] += B.G2Blocks[a];
                B.Avgsteals[10] += B.G2Steals[a];
                B.AvgTurnOvers[10] += B.G2TOs[a];
                B.AvgFouls[10] += B.G2Fouls[a];
                B.AvgClutchBaskets[10] += B.G2ClutchBaskets[a];
                B.AvgClutchMisses[10] += B.G2ClutchMisses[a];
                B.AvgGamesPlayed[10]++;
            }
            if (B.P12Games[1] != 0)
            {
                a = B.P12Games[1] - 1;
                B.AvgPoints[11] += B.G2Points[a];
                B.AvgMisses[11] += B.G2Misses[a];
                B.AvgAssists[11] += B.G2Assists[a];
                B.AvgRebounds[11] += B.G2Rebounds[a];
                B.AvgBlocks[11] += B.G2Blocks[a];
                B.Avgsteals[11] += B.G2Steals[a];
                B.AvgTurnOvers[11] += B.G2TOs[a];
                B.AvgFouls[11] += B.G2Fouls[a];
                B.AvgClutchBaskets[11] += B.G2ClutchBaskets[a];
                B.AvgClutchMisses[11] += B.G2ClutchMisses[a];
                B.AvgGamesPlayed[11]++;
            }
            if (B.P13Games[1] != 0)
            {
                a = B.P13Games[1] - 1;
                B.AvgPoints[12] += B.G2Points[a];
                B.AvgMisses[12] += B.G2Misses[a];
                B.AvgAssists[12] += B.G2Assists[a];
                B.AvgRebounds[12] += B.G2Rebounds[a];
                B.AvgBlocks[12] += B.G2Blocks[a];
                B.Avgsteals[12] += B.G2Steals[a];
                B.AvgTurnOvers[12] += B.G2TOs[a];
                B.AvgFouls[12] += B.G2Fouls[a];
                B.AvgClutchBaskets[12] += B.G2ClutchBaskets[a];
                B.AvgClutchMisses[12] += B.G2ClutchMisses[a];
                B.AvgGamesPlayed[12]++;
            }


        }
        else
            return;

        if (B.G3Teams[0] != 0)
        {
            if (B.P1Games[2] != 0)
            {
                a = B.P1Games[2] - 1;

                B.AvgPoints[0] += B.G3Points[a];
                B.AvgMisses[0] += B.G3Misses[a];
                B.AvgAssists[0] += B.G3Assists[a];
                B.AvgRebounds[0] += B.G3Rebounds[a];
                B.AvgBlocks[0] += B.G3Blocks[a];
                B.Avgsteals[0] += B.G3Steals[a];
                B.AvgTurnOvers[0] += B.G3TOs[a];
                B.AvgFouls[0] += B.G3Fouls[a];
                B.AvgClutchBaskets[0] += B.G3ClutchBaskets[a];
                B.AvgClutchMisses[0] += B.G3ClutchMisses[a];
                B.AvgGamesPlayed[0]++;
            }
            if (B.P2Games[2] != 0)
            {
                a = B.P2Games[2] - 1;
                B.AvgPoints[1] += B.G3Points[a];
                B.AvgMisses[1] += B.G3Misses[a];
                B.AvgAssists[1] += B.G3Assists[a];
                B.AvgRebounds[1] += B.G3Rebounds[a];
                B.AvgBlocks[1] += B.G3Blocks[a];
                B.Avgsteals[1] += B.G3Steals[a];
                B.AvgTurnOvers[1] += B.G3TOs[a];
                B.AvgFouls[1] += B.G3Fouls[a];
                B.AvgClutchBaskets[1] += B.G3ClutchBaskets[a];
                B.AvgClutchMisses[1] += B.G3ClutchMisses[a];
                B.AvgGamesPlayed[1]++;
            }
            if (B.P3Games[2] != 0)
            {
                a = B.P3Games[2] - 1;
                B.AvgPoints[2] += B.G3Points[a];
                B.AvgMisses[2] += B.G3Misses[a];
                B.AvgAssists[2] += B.G3Assists[a];
                B.AvgRebounds[2] += B.G3Rebounds[a];
                B.AvgBlocks[2] += B.G3Blocks[a];
                B.Avgsteals[2] += B.G3Steals[a];
                B.AvgTurnOvers[2] += B.G3TOs[a];
                B.AvgFouls[2] += B.G3Fouls[a];
                B.AvgClutchBaskets[2] += B.G3ClutchBaskets[a];
                B.AvgClutchMisses[2] += B.G3ClutchMisses[a];
                B.AvgGamesPlayed[2]++;
            }
            if (B.P4Games[2] != 0)
            {
                a = B.P4Games[2] - 1;
                B.AvgPoints[3] += B.G3Points[a];
                B.AvgMisses[3] += B.G3Misses[a];
                B.AvgAssists[3] += B.G3Assists[a];
                B.AvgRebounds[3] += B.G3Rebounds[a];
                B.AvgBlocks[3] += B.G3Blocks[a];
                B.Avgsteals[3] += B.G3Steals[a];
                B.AvgTurnOvers[3] += B.G3TOs[a];
                B.AvgFouls[3] += B.G3Fouls[a];
                B.AvgClutchBaskets[3] += B.G3ClutchBaskets[a];
                B.AvgClutchMisses[3] += B.G3ClutchMisses[a];
                B.AvgGamesPlayed[3]++;
            }
            if (B.P5Games[2] != 0)
            {
                a = B.P5Games[2] - 1;
                B.AvgPoints[4] += B.G3Points[a];
                B.AvgMisses[4] += B.G3Misses[a];
                B.AvgAssists[4] += B.G3Assists[a];
                B.AvgRebounds[4] += B.G3Rebounds[a];
                B.AvgBlocks[4] += B.G3Blocks[a];
                B.Avgsteals[4] += B.G3Steals[a];
                B.AvgTurnOvers[4] += B.G3TOs[a];
                B.AvgFouls[4] += B.G3Fouls[a];
                B.AvgClutchBaskets[4] += B.G3ClutchBaskets[a];
                B.AvgClutchMisses[4] += B.G3ClutchMisses[a];
                B.AvgGamesPlayed[4]++;
            }
            if (B.P6Games[2] != 0)
            {
                a = B.P6Games[2] - 1;
                B.AvgPoints[5] += B.G3Points[a];
                B.AvgMisses[5] += B.G3Misses[a];
                B.AvgAssists[5] += B.G3Assists[a];
                B.AvgRebounds[5] += B.G3Rebounds[a];
                B.AvgBlocks[5] += B.G3Blocks[a];
                B.Avgsteals[5] += B.G3Steals[a];
                B.AvgTurnOvers[5] += B.G3TOs[a];
                B.AvgFouls[5] += B.G3Fouls[a];
                B.AvgClutchBaskets[5] += B.G3ClutchBaskets[a];
                B.AvgClutchMisses[5] += B.G3ClutchMisses[a];
                B.AvgGamesPlayed[5]++;
            }
            if (B.P7Games[2] != 0)
            {
                a = B.P7Games[2] - 1;
                B.AvgPoints[6] += B.G3Points[a];
                B.AvgMisses[6] += B.G3Misses[a];
                B.AvgAssists[6] += B.G3Assists[a];
                B.AvgRebounds[6] += B.G3Rebounds[a];
                B.AvgBlocks[6] += B.G3Blocks[a];
                B.Avgsteals[6] += B.G3Steals[a];
                B.AvgTurnOvers[6] += B.G3TOs[a];
                B.AvgFouls[6] += B.G3Fouls[a];
                B.AvgClutchBaskets[6] += B.G3ClutchBaskets[a];
                B.AvgClutchMisses[6] += B.G3ClutchMisses[a];
                B.AvgGamesPlayed[6]++;
            }
            if (B.P8Games[2] != 0)
            {
                a = B.P8Games[2] - 1;
                B.AvgPoints[7] += B.G3Points[a];
                B.AvgMisses[7] += B.G3Misses[a];
                B.AvgAssists[7] += B.G3Assists[a];
                B.AvgRebounds[7] += B.G3Rebounds[a];
                B.AvgBlocks[7] += B.G3Blocks[a];
                B.Avgsteals[7] += B.G3Steals[a];
                B.AvgTurnOvers[7] += B.G3TOs[a];
                B.AvgFouls[7] += B.G3Fouls[a];
                B.AvgClutchBaskets[7] += B.G3ClutchBaskets[a];
                B.AvgClutchMisses[7] += B.G3ClutchMisses[a];
                B.AvgGamesPlayed[7]++;
            }
            if (B.P9Games[2] != 0)
            {
                a = B.P9Games[2] - 1;
                B.AvgPoints[8] += B.G3Points[a];
                B.AvgMisses[8] += B.G3Misses[a];
                B.AvgAssists[8] += B.G3Assists[a];
                B.AvgRebounds[8] += B.G3Rebounds[a];
                B.AvgBlocks[8] += B.G3Blocks[a];
                B.Avgsteals[8] += B.G3Steals[a];
                B.AvgTurnOvers[8] += B.G3TOs[a];
                B.AvgFouls[8] += B.G3Fouls[a];
                B.AvgClutchBaskets[8] += B.G3ClutchBaskets[a];
                B.AvgClutchMisses[8] += B.G3ClutchMisses[a];
                B.AvgGamesPlayed[8]++;
            }
            if (B.P10Games[2] != 0)
            {
                a = B.P10Games[2] - 1;
                B.AvgPoints[9] += B.G3Points[a];
                B.AvgMisses[9] += B.G3Misses[a];
                B.AvgAssists[9] += B.G3Assists[a];
                B.AvgRebounds[9] += B.G3Rebounds[a];
                B.AvgBlocks[9] += B.G3Blocks[a];
                B.Avgsteals[9] += B.G3Steals[a];
                B.AvgTurnOvers[9] += B.G3TOs[a];
                B.AvgFouls[9] += B.G3Fouls[a];
                B.AvgClutchBaskets[9] += B.G3ClutchBaskets[a];
                B.AvgClutchMisses[9] += B.G3ClutchMisses[a];
                B.AvgGamesPlayed[9]++;
            }
            if (B.P11Games[2] != 0)
            {
                a = B.P11Games[2] - 1;
                B.AvgPoints[10] += B.G3Points[a];
                B.AvgMisses[10] += B.G3Misses[a];
                B.AvgAssists[10] += B.G3Assists[a];
                B.AvgRebounds[10] += B.G3Rebounds[a];
                B.AvgBlocks[10] += B.G3Blocks[a];
                B.Avgsteals[10] += B.G3Steals[a];
                B.AvgTurnOvers[10] += B.G3TOs[a];
                B.AvgFouls[10] += B.G3Fouls[a];
                B.AvgClutchBaskets[10] += B.G3ClutchBaskets[a];
                B.AvgClutchMisses[10] += B.G3ClutchMisses[a];
                B.AvgGamesPlayed[10]++;
            }
            if (B.P12Games[2] != 0)
            {
                a = B.P12Games[2] - 1;
                B.AvgPoints[11] += B.G3Points[a];
                B.AvgMisses[11] += B.G3Misses[a];
                B.AvgAssists[11] += B.G3Assists[a];
                B.AvgRebounds[11] += B.G3Rebounds[a];
                B.AvgBlocks[11] += B.G3Blocks[a];
                B.Avgsteals[11] += B.G3Steals[a];
                B.AvgTurnOvers[11] += B.G3TOs[a];
                B.AvgFouls[11] += B.G3Fouls[a];
                B.AvgClutchBaskets[11] += B.G3ClutchBaskets[a];
                B.AvgClutchMisses[11] += B.G3ClutchMisses[a];
                B.AvgGamesPlayed[11]++;
            }
            if (B.P13Games[2] != 0)
            {
                a = B.P13Games[2] - 1;
                B.AvgPoints[12] += B.G3Points[a];
                B.AvgMisses[12] += B.G3Misses[a];
                B.AvgAssists[12] += B.G3Assists[a];
                B.AvgRebounds[12] += B.G3Rebounds[a];
                B.AvgBlocks[12] += B.G3Blocks[a];
                B.Avgsteals[12] += B.G3Steals[a];
                B.AvgTurnOvers[12] += B.G3TOs[a];
                B.AvgFouls[12] += B.G3Fouls[a];
                B.AvgClutchBaskets[12] += B.G3ClutchBaskets[a];
                B.AvgClutchMisses[12] += B.G3ClutchMisses[a];
                B.AvgGamesPlayed[12]++;
            }


        }
        else
            return;
        if (B.G4Teams[0] != 0)
        {
            if (B.P1Games[3] != 0)
            {
                a = B.P1Games[3] - 1;

                B.AvgPoints[0] += B.G4Points[a];
                B.AvgMisses[0] += B.G4Misses[a];
                B.AvgAssists[0] += B.G4Assists[a];
                B.AvgRebounds[0] += B.G4Rebounds[a];
                B.AvgBlocks[0] += B.G4Blocks[a];
                B.Avgsteals[0] += B.G4Steals[a];
                B.AvgTurnOvers[0] += B.G4TOs[a];
                B.AvgFouls[0] += B.G4Fouls[a];
                B.AvgClutchBaskets[0] += B.G4ClutchBaskets[a];
                B.AvgClutchMisses[0] += B.G4ClutchMisses[a];
                B.AvgGamesPlayed[0]++;
            }
            if (B.P2Games[3] != 0)
            {
                a = B.P2Games[3] - 1;
                B.AvgPoints[1] += B.G4Points[a];
                B.AvgMisses[1] += B.G4Misses[a];
                B.AvgAssists[1] += B.G4Assists[a];
                B.AvgRebounds[1] += B.G4Rebounds[a];
                B.AvgBlocks[1] += B.G4Blocks[a];
                B.Avgsteals[1] += B.G4Steals[a];
                B.AvgTurnOvers[1] += B.G4TOs[a];
                B.AvgFouls[1] += B.G4Fouls[a];
                B.AvgClutchBaskets[1] += B.G4ClutchBaskets[a];
                B.AvgClutchMisses[1] += B.G4ClutchMisses[a];
                B.AvgGamesPlayed[1]++;
            }
            if (B.P3Games[3] != 0)
            {
                a = B.P3Games[3] - 1;
                B.AvgPoints[2] += B.G4Points[a];
                B.AvgMisses[2] += B.G4Misses[a];
                B.AvgAssists[2] += B.G4Assists[a];
                B.AvgRebounds[2] += B.G4Rebounds[a];
                B.AvgBlocks[2] += B.G4Blocks[a];
                B.Avgsteals[2] += B.G4Steals[a];
                B.AvgTurnOvers[2] += B.G4TOs[a];
                B.AvgFouls[2] += B.G4Fouls[a];
                B.AvgClutchBaskets[2] += B.G4ClutchBaskets[a];
                B.AvgClutchMisses[2] += B.G4ClutchMisses[a];
                B.AvgGamesPlayed[2]++;
            }
            if (B.P4Games[3] != 0)
            {
                a = B.P4Games[3] - 1;
                B.AvgPoints[3] += B.G4Points[a];
                B.AvgMisses[3] += B.G4Misses[a];
                B.AvgAssists[3] += B.G4Assists[a];
                B.AvgRebounds[3] += B.G4Rebounds[a];
                B.AvgBlocks[3] += B.G4Blocks[a];
                B.Avgsteals[3] += B.G4Steals[a];
                B.AvgTurnOvers[3] += B.G4TOs[a];
                B.AvgFouls[3] += B.G4Fouls[a];
                B.AvgClutchBaskets[3] += B.G4ClutchBaskets[a];
                B.AvgClutchMisses[3] += B.G4ClutchMisses[a];
                B.AvgGamesPlayed[3]++;
            }
            if (B.P5Games[3] != 0)
            {
                a = B.P5Games[3] - 1;
                B.AvgPoints[4] += B.G4Points[a];
                B.AvgMisses[4] += B.G4Misses[a];
                B.AvgAssists[4] += B.G4Assists[a];
                B.AvgRebounds[4] += B.G4Rebounds[a];
                B.AvgBlocks[4] += B.G4Blocks[a];
                B.Avgsteals[4] += B.G4Steals[a];
                B.AvgTurnOvers[4] += B.G4TOs[a];
                B.AvgFouls[4] += B.G4Fouls[a];
                B.AvgClutchBaskets[4] += B.G4ClutchBaskets[a];
                B.AvgClutchMisses[4] += B.G4ClutchMisses[a];
                B.AvgGamesPlayed[4]++;
            }
            if (B.P6Games[3] != 0)
            {
                a = B.P6Games[3] - 1;
                B.AvgPoints[5] += B.G4Points[a];
                B.AvgMisses[5] += B.G5Misses[a];
                B.AvgAssists[5] += B.G4Assists[a];
                B.AvgRebounds[5] += B.G4Rebounds[a];
                B.AvgBlocks[5] += B.G4Blocks[a];
                B.Avgsteals[5] += B.G4Steals[a];
                B.AvgTurnOvers[5] += B.G4TOs[a];
                B.AvgFouls[5] += B.G4Fouls[a];
                B.AvgClutchBaskets[5] += B.G4ClutchBaskets[a];
                B.AvgClutchMisses[5] += B.G4ClutchMisses[a];
                B.AvgGamesPlayed[5]++;
            }
            if (B.P7Games[3] != 0)
            {
                a = B.P7Games[3] - 1;
                B.AvgPoints[6] += B.G4Points[a];
                B.AvgMisses[6] += B.G4Misses[a];
                B.AvgAssists[6] += B.G4Assists[a];
                B.AvgRebounds[6] += B.G4Rebounds[a];
                B.AvgBlocks[6] += B.G4Blocks[a];
                B.Avgsteals[6] += B.G4Steals[a];
                B.AvgTurnOvers[6] += B.G4TOs[a];
                B.AvgFouls[6] += B.G4Fouls[a];
                B.AvgClutchBaskets[6] += B.G4ClutchBaskets[a];
                B.AvgClutchMisses[6] += B.G4ClutchMisses[a];
                B.AvgGamesPlayed[6]++;
            }
            if (B.P8Games[3] != 0)
            {
                a = B.P8Games[3] - 1;
                B.AvgPoints[7] += B.G4Points[a];
                B.AvgMisses[7] += B.G4Misses[a];
                B.AvgAssists[7] += B.G4Assists[a];
                B.AvgRebounds[7] += B.G4Rebounds[a];
                B.AvgBlocks[7] += B.G4Blocks[a];
                B.Avgsteals[7] += B.G4Steals[a];
                B.AvgTurnOvers[7] += B.G4TOs[a];
                B.AvgFouls[7] += B.G4Fouls[a];
                B.AvgClutchBaskets[7] += B.G4ClutchBaskets[a];
                B.AvgClutchMisses[7] += B.G4ClutchMisses[a];
                B.AvgGamesPlayed[7]++;
            }
            if (B.P9Games[3] != 0)
            {
                a = B.P9Games[3] - 1;
                B.AvgPoints[8] += B.G4Points[a];
                B.AvgMisses[8] += B.G4Misses[a];
                B.AvgAssists[8] += B.G4Assists[a];
                B.AvgRebounds[8] += B.G4Rebounds[a];
                B.AvgBlocks[8] += B.G4Blocks[a];
                B.Avgsteals[8] += B.G4Steals[a];
                B.AvgTurnOvers[8] += B.G4TOs[a];
                B.AvgFouls[8] += B.G4Fouls[a];
                B.AvgClutchBaskets[8] += B.G4ClutchBaskets[a];
                B.AvgClutchMisses[8] += B.G4ClutchMisses[a];
                B.AvgGamesPlayed[8]++;
            }
            if (B.P10Games[3] != 0)
            {
                a = B.P10Games[3] - 1;
                B.AvgPoints[9] += B.G4Points[a];
                B.AvgMisses[9] += B.G4Misses[a];
                B.AvgAssists[9] += B.G4Assists[a];
                B.AvgRebounds[9] += B.G4Rebounds[a];
                B.AvgBlocks[9] += B.G4Blocks[a];
                B.Avgsteals[9] += B.G4Steals[a];
                B.AvgTurnOvers[9] += B.G4TOs[a];
                B.AvgFouls[9] += B.G4Fouls[a];
                B.AvgClutchBaskets[9] += B.G4ClutchBaskets[a];
                B.AvgClutchMisses[9] += B.G4ClutchMisses[a];
                B.AvgGamesPlayed[9]++;
            }
            if (B.P11Games[3] != 0)
            {
                a = B.P11Games[3] - 1;
                B.AvgPoints[10] += B.G4Points[a];
                B.AvgMisses[10] += B.G4Misses[a];
                B.AvgAssists[10] += B.G4Assists[a];
                B.AvgRebounds[10] += B.G4Rebounds[a];
                B.AvgBlocks[10] += B.G4Blocks[a];
                B.Avgsteals[10] += B.G4Steals[a];
                B.AvgTurnOvers[10] += B.G4TOs[a];
                B.AvgFouls[10] += B.G4Fouls[a];
                B.AvgClutchBaskets[10] += B.G4ClutchBaskets[a];
                B.AvgClutchMisses[10] += B.G4ClutchMisses[a];
                B.AvgGamesPlayed[10]++;
            }
            if (B.P12Games[3] != 0)
            {
                a = B.P12Games[3] - 1;
                B.AvgPoints[11] += B.G4Points[a];
                B.AvgMisses[11] += B.G4Misses[a];
                B.AvgAssists[11] += B.G4Assists[a];
                B.AvgRebounds[11] += B.G4Rebounds[a];
                B.AvgBlocks[11] += B.G4Blocks[a];
                B.Avgsteals[11] += B.G4Steals[a];
                B.AvgTurnOvers[11] += B.G4TOs[a];
                B.AvgFouls[11] += B.G4Fouls[a];
                B.AvgClutchBaskets[11] += B.G4ClutchBaskets[a];
                B.AvgClutchMisses[11] += B.G4ClutchMisses[a];
                B.AvgGamesPlayed[11]++;
            }
            if (B.P13Games[3] != 0)
            {
                a = B.P13Games[3] - 1;
                B.AvgPoints[12] += B.G4Points[a];
                B.AvgMisses[12] += B.G4Misses[a];
                B.AvgAssists[12] += B.G4Assists[a];
                B.AvgRebounds[12] += B.G4Rebounds[a];
                B.AvgBlocks[12] += B.G4Blocks[a];
                B.Avgsteals[12] += B.G4Steals[a];
                B.AvgTurnOvers[12] += B.G4TOs[a];
                B.AvgFouls[12] += B.G4Fouls[a];
                B.AvgClutchBaskets[12] += B.G4ClutchBaskets[a];
                B.AvgClutchMisses[12] += B.G4ClutchMisses[a];
                B.AvgGamesPlayed[12]++;
            }


        }
        else
            return;
        if (B.G5Teams[0] != 0)
        {
            if (B.P1Games[4] != 0)
            {
                a = B.P1Games[4] - 1;

                B.AvgPoints[0] += B.G5Points[a];
                B.AvgMisses[0] += B.G5Misses[a];
                B.AvgAssists[0] += B.G5Assists[a];
                B.AvgRebounds[0] += B.G5Rebounds[a];
                B.AvgBlocks[0] += B.G5Blocks[a];
                B.Avgsteals[0] += B.G5Steals[a];
                B.AvgTurnOvers[0] += B.G5TOs[a];
                B.AvgFouls[0] += B.G5Fouls[a];
                B.AvgClutchBaskets[0] += B.G5ClutchBaskets[a];
                B.AvgClutchMisses[0] += B.G5ClutchMisses[a];
                B.AvgGamesPlayed[0]++;
            }
            if (B.P2Games[4] != 0)
            {
                a = B.P2Games[4] - 1;
                B.AvgPoints[1] += B.G5Points[a];
                B.AvgMisses[1] += B.G5Misses[a];
                B.AvgAssists[1] += B.G5Assists[a];
                B.AvgRebounds[1] += B.G5Rebounds[a];
                B.AvgBlocks[1] += B.G5Blocks[a];
                B.Avgsteals[1] += B.G5Steals[a];
                B.AvgTurnOvers[1] += B.G5TOs[a];
                B.AvgFouls[1] += B.G5Fouls[a];
                B.AvgClutchBaskets[1] += B.G5ClutchBaskets[a];
                B.AvgClutchMisses[1] += B.G5ClutchMisses[a];
                B.AvgGamesPlayed[1]++;
            }
            if (B.P3Games[4] != 0)
            {
                a = B.P3Games[4] - 1;
                B.AvgPoints[2] += B.G5Points[a];
                B.AvgMisses[2] += B.G5Misses[a];
                B.AvgAssists[2] += B.G5Assists[a];
                B.AvgRebounds[2] += B.G5Rebounds[a];
                B.AvgBlocks[2] += B.G5Blocks[a];
                B.Avgsteals[2] += B.G5Steals[a];
                B.AvgTurnOvers[2] += B.G5TOs[a];
                B.AvgFouls[2] += B.G5Fouls[a];
                B.AvgClutchBaskets[2] += B.G5ClutchBaskets[a];
                B.AvgClutchMisses[2] += B.G5ClutchMisses[a];
                B.AvgGamesPlayed[2]++;
            }
            if (B.P4Games[4] != 0)
            {
                a = B.P4Games[4] - 1;
                B.AvgPoints[3] += B.G5Points[a];
                B.AvgMisses[3] += B.G5Misses[a];
                B.AvgAssists[3] += B.G5Assists[a];
                B.AvgRebounds[3] += B.G5Rebounds[a];
                B.AvgBlocks[3] += B.G5Blocks[a];
                B.Avgsteals[3] += B.G5Steals[a];
                B.AvgTurnOvers[3] += B.G5TOs[a];
                B.AvgFouls[3] += B.G5Fouls[a];
                B.AvgClutchBaskets[3] += B.G5ClutchBaskets[a];
                B.AvgClutchMisses[3] += B.G5ClutchMisses[a];
                B.AvgGamesPlayed[3]++;
            }
            if (B.P5Games[4] != 0)
            {
                a = B.P5Games[4] - 1;
                B.AvgPoints[4] += B.G5Points[a];
                B.AvgMisses[4] += B.G5Misses[a];
                B.AvgAssists[4] += B.G5Assists[a];
                B.AvgRebounds[4] += B.G5Rebounds[a];
                B.AvgBlocks[4] += B.G5Blocks[a];
                B.Avgsteals[4] += B.G5Steals[a];
                B.AvgTurnOvers[4] += B.G5TOs[a];
                B.AvgFouls[4] += B.G5Fouls[a];
                B.AvgClutchBaskets[4] += B.G5ClutchBaskets[a];
                B.AvgClutchMisses[4] += B.G5ClutchMisses[a];
                B.AvgGamesPlayed[4]++;
            }
            if (B.P6Games[4] != 0)
            {
                a = B.P6Games[4] - 1;
                B.AvgPoints[5] += B.G5Points[a];
                B.AvgMisses[5] += B.G5Misses[a];
                B.AvgAssists[5] += B.G5Assists[a];
                B.AvgRebounds[5] += B.G5Rebounds[a];
                B.AvgBlocks[5] += B.G5Blocks[a];
                B.Avgsteals[5] += B.G5Steals[a];
                B.AvgTurnOvers[5] += B.G5TOs[a];
                B.AvgFouls[5] += B.G5Fouls[a];
                B.AvgClutchBaskets[5] += B.G5ClutchBaskets[a];
                B.AvgClutchMisses[5] += B.G5ClutchMisses[a];
                B.AvgGamesPlayed[5]++;
            }
            if (B.P7Games[4] != 0)
            {
                a = B.P7Games[4] - 1;
                B.AvgPoints[6] += B.G5Points[a];
                B.AvgMisses[6] += B.G5Misses[a];
                B.AvgAssists[6] += B.G5Assists[a];
                B.AvgRebounds[6] += B.G5Rebounds[a];
                B.AvgBlocks[6] += B.G5Blocks[a];
                B.Avgsteals[6] += B.G5Steals[a];
                B.AvgTurnOvers[6] += B.G5TOs[a];
                B.AvgFouls[6] += B.G5Fouls[a];
                B.AvgClutchBaskets[6] += B.G5ClutchBaskets[a];
                B.AvgClutchMisses[6] += B.G5ClutchMisses[a];
                B.AvgGamesPlayed[6]++;
            }
            if (B.P8Games[4] != 0)
            {
                a = B.P8Games[4] - 1;
                B.AvgPoints[7] += B.G5Points[a];
                B.AvgMisses[7] += B.G5Misses[a];
                B.AvgAssists[7] += B.G5Assists[a];
                B.AvgRebounds[7] += B.G5Rebounds[a];
                B.AvgBlocks[7] += B.G5Blocks[a];
                B.Avgsteals[7] += B.G5Steals[a];
                B.AvgTurnOvers[7] += B.G5TOs[a];
                B.AvgFouls[7] += B.G5Fouls[a];
                B.AvgClutchBaskets[7] += B.G5ClutchBaskets[a];
                B.AvgClutchMisses[7] += B.G5ClutchMisses[a];
                B.AvgGamesPlayed[7]++;
            }
            if (B.P9Games[4] != 0)
            {
                a = B.P8Games[4] - 1;
                B.AvgPoints[8] += B.G5Points[a];
                B.AvgMisses[8] += B.G5Misses[a];
                B.AvgAssists[8] += B.G5Assists[a];
                B.AvgRebounds[8] += B.G5Rebounds[a];
                B.AvgBlocks[8] += B.G5Blocks[a];
                B.Avgsteals[8] += B.G5Steals[a];
                B.AvgTurnOvers[8] += B.G5TOs[a];
                B.AvgFouls[8] += B.G5Fouls[a];
                B.AvgClutchBaskets[8] += B.G5ClutchBaskets[a];
                B.AvgClutchMisses[8] += B.G5ClutchMisses[a];
                B.AvgGamesPlayed[8]++;
            }
            if (B.P10Games[4] != 0)
            {
                a = B.P10Games[4] - 1;
                B.AvgPoints[9] += B.G5Points[a];
                B.AvgMisses[9] += B.G5Misses[a];
                B.AvgAssists[9] += B.G5Assists[a];
                B.AvgRebounds[9] += B.G5Rebounds[a];
                B.AvgBlocks[9] += B.G5Blocks[a];
                B.Avgsteals[9] += B.G5Steals[a];
                B.AvgTurnOvers[9] += B.G5TOs[a];
                B.AvgFouls[9] += B.G5Fouls[a];
                B.AvgClutchBaskets[9] += B.G5ClutchBaskets[a];
                B.AvgClutchMisses[9] += B.G5ClutchMisses[a];
                B.AvgGamesPlayed[9]++;
            }
            if (B.P11Games[4] != 0)
            {
                a = B.P11Games[4] - 1;
                B.AvgPoints[10] += B.G5Points[a];
                B.AvgMisses[10] += B.G5Misses[a];
                B.AvgAssists[10] += B.G5Assists[a];
                B.AvgRebounds[10] += B.G5Rebounds[a];
                B.AvgBlocks[10] += B.G5Blocks[a];
                B.Avgsteals[10] += B.G5Steals[a];
                B.AvgTurnOvers[10] += B.G5TOs[a];
                B.AvgFouls[10] += B.G5Fouls[a];
                B.AvgClutchBaskets[10] += B.G5ClutchBaskets[a];
                B.AvgClutchMisses[10] += B.G5ClutchMisses[a];
                B.AvgGamesPlayed[10]++;
            }
            if (B.P12Games[4] != 0)
            {
                a = B.P12Games[4] - 1;
                B.AvgPoints[11] += B.G5Points[a];
                B.AvgMisses[11] += B.G5Misses[a];
                B.AvgAssists[11] += B.G5Assists[a];
                B.AvgRebounds[11] += B.G5Rebounds[a];
                B.AvgBlocks[11] += B.G5Blocks[a];
                B.Avgsteals[11] += B.G5Steals[a];
                B.AvgTurnOvers[11] += B.G5TOs[a];
                B.AvgFouls[11] += B.G5Fouls[a];
                B.AvgClutchBaskets[11] += B.G5ClutchBaskets[a];
                B.AvgClutchMisses[11] += B.G5ClutchMisses[a];
                B.AvgGamesPlayed[11]++;
            }
            if (B.P13Games[4] != 0)
            {
                a = B.P13Games[4] - 1;
                B.AvgPoints[12] += B.G5Points[a];
                B.AvgMisses[12] += B.G5Misses[a];
                B.AvgAssists[12] += B.G5Assists[a];
                B.AvgRebounds[12] += B.G5Rebounds[a];
                B.AvgBlocks[12] += B.G5Blocks[a];
                B.Avgsteals[12] += B.G5Steals[a];
                B.AvgTurnOvers[12] += B.G5TOs[a];
                B.AvgFouls[12] += B.G5Fouls[a];
                B.AvgClutchBaskets[12] += B.G5ClutchBaskets[a];
                B.AvgClutchMisses[12] += B.G5ClutchMisses[a];
                B.AvgGamesPlayed[12]++;
            }


        }
        else
            return;
        if (B.G6Teams[0] != 0)
        {
            if (B.P1Games[5] != 0)
            {
                a = B.P1Games[5] - 1;

                B.AvgPoints[0] += B.G6Points[a];
                B.AvgMisses[0] += B.G6Misses[a];
                B.AvgAssists[0] += B.G6Assists[a];
                B.AvgRebounds[0] += B.G6Rebounds[a];
                B.AvgBlocks[0] += B.G6Blocks[a];
                B.Avgsteals[0] += B.G6Steals[a];
                B.AvgTurnOvers[0] += B.G6TOs[a];
                B.AvgFouls[0] += B.G6Fouls[a];
                B.AvgClutchBaskets[0] += B.G6ClutchBaskets[a];
                B.AvgClutchMisses[0] += B.G6ClutchMisses[a];
                B.AvgGamesPlayed[0]++;
            }
            if (B.P2Games[5] != 0)
            {
                a = B.P2Games[5] - 1;
                B.AvgPoints[1] += B.G6Points[a];
                B.AvgMisses[1] += B.G6Misses[a];
                B.AvgAssists[1] += B.G6Assists[a];
                B.AvgRebounds[1] += B.G6Rebounds[a];
                B.AvgBlocks[1] += B.G6Blocks[a];
                B.Avgsteals[1] += B.G6Steals[a];
                B.AvgTurnOvers[1] += B.G6TOs[a];
                B.AvgFouls[1] += B.G6Fouls[a];
                B.AvgClutchBaskets[1] += B.G6ClutchBaskets[a];
                B.AvgClutchMisses[1] += B.G6ClutchMisses[a];
                B.AvgGamesPlayed[1]++;
            }
            if (B.P3Games[5] != 0)
            {
                a = B.P3Games[5] - 1;
                B.AvgPoints[2] += B.G6Points[a];
                B.AvgMisses[2] += B.G6Misses[a];
                B.AvgAssists[2] += B.G6Assists[a];
                B.AvgRebounds[2] += B.G6Rebounds[a];
                B.AvgBlocks[2] += B.G6Blocks[a];
                B.Avgsteals[2] += B.G6Steals[a];
                B.AvgTurnOvers[2] += B.G6TOs[a];
                B.AvgFouls[2] += B.G6Fouls[a];
                B.AvgClutchBaskets[2] += B.G6ClutchBaskets[a];
                B.AvgClutchMisses[2] += B.G6ClutchMisses[a];
                B.AvgGamesPlayed[2]++;
            }
            if (B.P4Games[5] != 0)
            {
                a = B.P4Games[5] - 1;
                B.AvgPoints[3] += B.G6Points[a];
                B.AvgMisses[3] += B.G6Misses[a];
                B.AvgAssists[3] += B.G6Assists[a];
                B.AvgRebounds[3] += B.G6Rebounds[a];
                B.AvgBlocks[3] += B.G6Blocks[a];
                B.Avgsteals[3] += B.G6Steals[a];
                B.AvgTurnOvers[3] += B.G6TOs[a];
                B.AvgFouls[3] += B.G6Fouls[a];
                B.AvgClutchBaskets[3] += B.G6ClutchBaskets[a];
                B.AvgClutchMisses[3] += B.G6ClutchMisses[a];
                B.AvgGamesPlayed[3]++;
            }
            if (B.P5Games[5] != 0)
            {
                a = B.P5Games[5] - 1;
                B.AvgPoints[4] += B.G6Points[a];
                B.AvgMisses[4] += B.G6Misses[a];
                B.AvgAssists[4] += B.G6Assists[a];
                B.AvgRebounds[4] += B.G6Rebounds[a];
                B.AvgBlocks[4] += B.G6Blocks[a];
                B.Avgsteals[4] += B.G6Steals[a];
                B.AvgTurnOvers[4] += B.G6TOs[a];
                B.AvgFouls[4] += B.G6Fouls[a];
                B.AvgClutchBaskets[4] += B.G6ClutchBaskets[a];
                B.AvgClutchMisses[4] += B.G6ClutchMisses[a];
                B.AvgGamesPlayed[4]++;
            }
            if (B.P6Games[5] != 0)
            {
                a = B.P6Games[5] - 1;
                B.AvgPoints[5] += B.G6Points[a];
                B.AvgMisses[5] += B.G6Misses[a];
                B.AvgAssists[5] += B.G6Assists[a];
                B.AvgRebounds[5] += B.G6Rebounds[a];
                B.AvgBlocks[5] += B.G6Blocks[a];
                B.Avgsteals[5] += B.G6Steals[a];
                B.AvgTurnOvers[5] += B.G6TOs[a];
                B.AvgFouls[5] += B.G6Fouls[a];
                B.AvgClutchBaskets[5] += B.G6ClutchBaskets[a];
                B.AvgClutchMisses[5] += B.G6ClutchMisses[a];
                B.AvgGamesPlayed[5]++;
            }
            if (B.P7Games[5] != 0)
            {
                a = B.P7Games[5] - 1;
                B.AvgPoints[6] += B.G6Points[a];
                B.AvgMisses[6] += B.G6Misses[a];
                B.AvgAssists[6] += B.G6Assists[a];
                B.AvgRebounds[6] += B.G6Rebounds[a];
                B.AvgBlocks[6] += B.G6Blocks[a];
                B.Avgsteals[6] += B.G6Steals[a];
                B.AvgTurnOvers[6] += B.G6TOs[a];
                B.AvgFouls[6] += B.G6Fouls[a];
                B.AvgClutchBaskets[6] += B.G6ClutchBaskets[a];
                B.AvgClutchMisses[6] += B.G6ClutchMisses[a];
                B.AvgGamesPlayed[6]++;
            }
            if (B.P8Games[5] != 0)
            {
                a = B.P8Games[5] - 1;
                B.AvgPoints[7] += B.G6Points[a];
                B.AvgMisses[7] += B.G6Misses[a];
                B.AvgAssists[7] += B.G6Assists[a];
                B.AvgRebounds[7] += B.G6Rebounds[a];
                B.AvgBlocks[7] += B.G6Blocks[a];
                B.Avgsteals[7] += B.G6Steals[a];
                B.AvgTurnOvers[7] += B.G6TOs[a];
                B.AvgFouls[7] += B.G6Fouls[a];
                B.AvgClutchBaskets[7] += B.G6ClutchBaskets[a];
                B.AvgClutchMisses[7] += B.G6ClutchMisses[a];
                B.AvgGamesPlayed[7]++;
            }
            if (B.P9Games[5] != 0)
            {
                a = B.P9Games[5] - 1;
                B.AvgPoints[8] += B.G6Points[a];
                B.AvgMisses[8] += B.G6Misses[a];
                B.AvgAssists[8] += B.G6Assists[a];
                B.AvgRebounds[8] += B.G6Rebounds[a];
                B.AvgBlocks[8] += B.G6Blocks[a];
                B.Avgsteals[8] += B.G6Steals[a];
                B.AvgTurnOvers[8] += B.G6TOs[a];
                B.AvgFouls[8] += B.G6Fouls[a];
                B.AvgClutchBaskets[8] += B.G6ClutchBaskets[a];
                B.AvgClutchMisses[8] += B.G6ClutchMisses[a];
                B.AvgGamesPlayed[8]++;
            }
            if (B.P10Games[5] != 0)
            {
                a = B.P10Games[5] - 1;
                B.AvgPoints[9] += B.G6Points[a];
                B.AvgMisses[9] += B.G6Misses[a];
                B.AvgAssists[9] += B.G6Assists[a];
                B.AvgRebounds[9] += B.G6Rebounds[a];
                B.AvgBlocks[9] += B.G6Blocks[a];
                B.Avgsteals[9] += B.G6Steals[a];
                B.AvgTurnOvers[9] += B.G6TOs[a];
                B.AvgFouls[9] += B.G6Fouls[a];
                B.AvgClutchBaskets[9] += B.G6ClutchBaskets[a];
                B.AvgClutchMisses[9] += B.G6ClutchMisses[a];
                B.AvgGamesPlayed[9]++;
            }
            if (B.P11Games[5] != 0)
            {
                a = B.P11Games[5] - 1;
                B.AvgPoints[10] += B.G6Points[a];
                B.AvgMisses[10] += B.G6Misses[a];
                B.AvgAssists[10] += B.G6Assists[a];
                B.AvgRebounds[10] += B.G6Rebounds[a];
                B.AvgBlocks[10] += B.G6Blocks[a];
                B.Avgsteals[10] += B.G6Steals[a];
                B.AvgTurnOvers[10] += B.G6TOs[a];
                B.AvgFouls[10] += B.G6Fouls[a];
                B.AvgClutchBaskets[10] += B.G6ClutchBaskets[a];
                B.AvgClutchMisses[10] += B.G6ClutchMisses[a];
                B.AvgGamesPlayed[10]++;
            }
            if (B.P12Games[5] != 0)
            {
                a = B.P12Games[5] - 1;
                B.AvgPoints[11] += B.G6Points[a];
                B.AvgMisses[11] += B.G6Misses[a];
                B.AvgAssists[11] += B.G6Assists[a];
                B.AvgRebounds[11] += B.G6Rebounds[a];
                B.AvgBlocks[11] += B.G6Blocks[a];
                B.Avgsteals[11] += B.G6Steals[a];
                B.AvgTurnOvers[11] += B.G6TOs[a];
                B.AvgFouls[11] += B.G6Fouls[a];
                B.AvgClutchBaskets[11] += B.G6ClutchBaskets[a];
                B.AvgClutchMisses[11] += B.G6ClutchMisses[a];
                B.AvgGamesPlayed[11]++;
            }
            if (B.P13Games[5] != 0)
            {
                a = B.P13Games[5] - 1;
                B.AvgPoints[12] += B.G6Points[a];
                B.AvgMisses[12] += B.G6Misses[a];
                B.AvgAssists[12] += B.G6Assists[a];
                B.AvgRebounds[12] += B.G6Rebounds[a];
                B.AvgBlocks[12] += B.G6Blocks[a];
                B.Avgsteals[12] += B.G6Steals[a];
                B.AvgTurnOvers[12] += B.G6TOs[a];
                B.AvgFouls[12] += B.G6Fouls[a];
                B.AvgClutchBaskets[12] += B.G6ClutchBaskets[a];
                B.AvgClutchMisses[12] += B.G6ClutchMisses[a];
                B.AvgGamesPlayed[12]++;
            }


        }
        else
            return;

        if (B.G7Teams[0] != 0)
        {
            if (B.P1Games[6] != 0)
            {
                a = B.P1Games[6] - 1;

                B.AvgPoints[0] +=       B.G7Points[a];
                B.AvgMisses[0] += B.G7Misses[a];
                B.AvgAssists[0] +=      B.G7Assists[a];
                B.AvgRebounds[0] +=     B.G7Rebounds[a];
                B.AvgBlocks[0] +=       B.G7Blocks[a];
                B.Avgsteals[0] +=       B.G7Steals[a];
                B.AvgTurnOvers[0] +=    B.G7TOs[a];
                B.AvgFouls[0] +=        B.G7Fouls[a];
                B.AvgClutchBaskets[0]+= B.G7ClutchBaskets[a];
                B.AvgClutchMisses[0] += B.G7ClutchMisses[a];
                B.AvgGamesPlayed[0]++;
            }
            if (B.P2Games[6] != 0)
            {
                a = B.P2Games[6] - 1;
                B.AvgPoints[1] += B.G7Points[a];
                B.AvgMisses[1] += B.G7Misses[a];
                B.AvgAssists[1] += B.G7Assists[a];
                B.AvgRebounds[1] += B.G7Rebounds[a];
                B.AvgBlocks[1] += B.G7Blocks[a];
                B.Avgsteals[1] += B.G7Steals[a];
                B.AvgTurnOvers[1] += B.G7TOs[a];
                B.AvgFouls[1] += B.G7Fouls[a];
                B.AvgClutchBaskets[1] += B.G7ClutchBaskets[a];
                B.AvgClutchMisses[1] += B.G7ClutchMisses[a];
                B.AvgGamesPlayed[1]++;
            }
            if (B.P3Games[6] != 0)
            {
                a = B.P3Games[6] - 1;
                B.AvgPoints[2] += B.G7Points[a];
                B.AvgMisses[2] += B.G7Misses[a];
                B.AvgAssists[2] += B.G7Assists[a];
                B.AvgRebounds[2] += B.G7Rebounds[a];
                B.AvgBlocks[2] += B.G7Blocks[a];
                B.Avgsteals[2] += B.G7Steals[a];
                B.AvgTurnOvers[2] += B.G7TOs[a];
                B.AvgFouls[2] += B.G7Fouls[a];
                B.AvgClutchBaskets[2] += B.G7ClutchBaskets[a];
                B.AvgClutchMisses[2] += B.G7ClutchMisses[a];
                B.AvgGamesPlayed[2]++;
            }
            if (B.P4Games[6] != 0)
            {
                a = B.P4Games[6] - 1;
                B.AvgPoints[3] += B.G7Points[a];
                B.AvgMisses[3] += B.G7Misses[a];
                B.AvgAssists[3] += B.G7Assists[a];
                B.AvgRebounds[3] += B.G7Rebounds[a];
                B.AvgBlocks[3] += B.G7Blocks[a];
                B.Avgsteals[3] += B.G7Steals[a];
                B.AvgTurnOvers[3] += B.G7TOs[a];
                B.AvgFouls[3] += B.G7Fouls[a];
                B.AvgClutchBaskets[3] += B.G7ClutchBaskets[a];
                B.AvgClutchMisses[3] += B.G7ClutchMisses[a];
                B.AvgGamesPlayed[3]++;
            }
            if (B.P5Games[6] != 0)
            {
                a = B.P5Games[6] - 1;
                B.AvgPoints[4] += B.G7Points[a];
                B.AvgMisses[4] += B.G7Misses[a];
                B.AvgAssists[4] += B.G7Assists[a];
                B.AvgRebounds[4] += B.G7Rebounds[a];
                B.AvgBlocks[4] += B.G7Blocks[a];
                B.Avgsteals[4] += B.G7Steals[a];
                B.AvgTurnOvers[4] += B.G7TOs[a];
                B.AvgFouls[4] += B.G7Fouls[a];
                B.AvgClutchBaskets[4] += B.G7ClutchBaskets[a];
                B.AvgClutchMisses[4] += B.G7ClutchMisses[a];
                B.AvgGamesPlayed[4]++;
            }
            if (B.P6Games[6] != 0)
            {
                a = B.P6Games[6] - 1;
                B.AvgPoints[5] += B.G7Points[a];
                B.AvgMisses[5] += B.G7Misses[a];
                B.AvgAssists[5] += B.G7Assists[a];
                B.AvgRebounds[5] += B.G7Rebounds[a];
                B.AvgBlocks[5] += B.G7Blocks[a];
                B.Avgsteals[5] += B.G7Steals[a];
                B.AvgTurnOvers[5] += B.G7TOs[a];
                B.AvgFouls[5] += B.G7Fouls[a];
                B.AvgClutchBaskets[5] += B.G7ClutchBaskets[a];
                B.AvgClutchMisses[5] += B.G7ClutchMisses[a];
                B.AvgGamesPlayed[5]++;
            }
            if (B.P7Games[6] != 0)
            {
                a = B.P7Games[6] - 1;
                B.AvgPoints[6] += B.G7Points[a];
                B.AvgMisses[6] += B.G7Misses[a];
                B.AvgAssists[6] += B.G7Assists[a];
                B.AvgRebounds[6] += B.G7Rebounds[a];
                B.AvgBlocks[6] += B.G7Blocks[a];
                B.Avgsteals[6] += B.G7Steals[a];
                B.AvgTurnOvers[6] += B.G7TOs[a];
                B.AvgFouls[6] += B.G7Fouls[a];
                B.AvgClutchBaskets[6] += B.G7ClutchBaskets[a];
                B.AvgClutchMisses[6] += B.G7ClutchMisses[a];
                B.AvgGamesPlayed[6]++;
            }
            if (B.P8Games[6] != 0)
            {
                a = B.P8Games[6] - 1;
                B.AvgPoints[7] += B.G7Points[a];
                B.AvgMisses[7] += B.G7Misses[a];
                B.AvgAssists[7] += B.G7Assists[a];
                B.AvgRebounds[7] += B.G7Rebounds[a];
                B.AvgBlocks[7] += B.G7Blocks[a];
                B.Avgsteals[7] += B.G7Steals[a];
                B.AvgTurnOvers[7] += B.G7TOs[a];
                B.AvgFouls[7] += B.G7Fouls[a];
                B.AvgClutchBaskets[7] += B.G7ClutchBaskets[a];
                B.AvgClutchMisses[7] += B.G7ClutchMisses[a];
                B.AvgGamesPlayed[7]++;
            }
            if (B.P9Games[6] != 0)
            {
                a = B.P9Games[6] - 1;
                B.AvgPoints[8] += B.G7Points[a];
                B.AvgMisses[8] += B.G7Misses[a];
                B.AvgAssists[8] += B.G7Assists[a];
                B.AvgRebounds[8] += B.G7Rebounds[a];
                B.AvgBlocks[8] += B.G7Blocks[a];
                B.Avgsteals[8] += B.G7Steals[a];
                B.AvgTurnOvers[8] += B.G7TOs[a];
                B.AvgFouls[8] += B.G7Fouls[a];
                B.AvgClutchBaskets[8] += B.G7ClutchBaskets[a];
                B.AvgClutchMisses[8] += B.G7ClutchMisses[a];
                B.AvgGamesPlayed[8]++;
            }
            if (B.P10Games[6] != 0)
            {
                a = B.P10Games[6] - 1;
                B.AvgPoints[9] += B.G7Points[a];
                B.AvgMisses[9] += B.G7Misses[a];
                B.AvgAssists[9] += B.G7Assists[a];
                B.AvgRebounds[9] += B.G7Rebounds[a];
                B.AvgBlocks[9] += B.G7Blocks[a];
                B.Avgsteals[9] += B.G7Steals[a];
                B.AvgTurnOvers[9] += B.G7TOs[a];
                B.AvgFouls[9] += B.G7Fouls[a];
                B.AvgClutchBaskets[9] += B.G7ClutchBaskets[a];
                B.AvgClutchMisses[9] += B.G7ClutchMisses[a];
                B.AvgGamesPlayed[9]++;
            }
            if (B.P11Games[6] != 0)
            {
                a = B.P11Games[6] - 1;
                B.AvgPoints[10] += B.G7Points[a];
                B.AvgMisses[10] += B.G7Misses[a];
                B.AvgAssists[10] += B.G7Assists[a];
                B.AvgRebounds[10] += B.G7Rebounds[a];
                B.AvgBlocks[10] += B.G7Blocks[a];
                B.Avgsteals[10] += B.G7Steals[a];
                B.AvgTurnOvers[10] += B.G7TOs[a];
                B.AvgFouls[10] += B.G7Fouls[a];
                B.AvgClutchBaskets[10] += B.G7ClutchBaskets[a];
                B.AvgClutchMisses[10] += B.G7ClutchMisses[a];
                B.AvgGamesPlayed[10]++;
            }
            if (B.P12Games[6] != 0)
            {
                a = B.P12Games[6] - 1;
                B.AvgPoints[11] += B.G7Points[a];
                B.AvgMisses[11] += B.G7Misses[a];
                B.AvgAssists[11] += B.G7Assists[a];
                B.AvgRebounds[11] += B.G7Rebounds[a];
                B.AvgBlocks[11] += B.G7Blocks[a];
                B.Avgsteals[11] += B.G7Steals[a];
                B.AvgTurnOvers[11] += B.G7TOs[a];
                B.AvgFouls[11] += B.G7Fouls[a];
                B.AvgClutchBaskets[11] += B.G7ClutchBaskets[a];
                B.AvgClutchMisses[11] += B.G7ClutchMisses[a];
                B.AvgGamesPlayed[11]++;
            }
            if (B.P13Games[6] != 0)
            {
                a = B.P13Games[6] - 1;
                B.AvgPoints[12] += B.G7Points[a];
                B.AvgMisses[12] += B.G7Misses[a];
                B.AvgAssists[12] += B.G7Assists[a];
                B.AvgRebounds[12] += B.G7Rebounds[a];
                B.AvgBlocks[12] += B.G7Blocks[a];
                B.Avgsteals[12] += B.G7Steals[a];
                B.AvgTurnOvers[12] += B.G7TOs[a];
                B.AvgFouls[12] += B.G7Fouls[a];
                B.AvgClutchBaskets[12] += B.G7ClutchBaskets[a];
                B.AvgClutchMisses[12] += B.G7ClutchMisses[a];
                B.AvgGamesPlayed[12]++;
            }


        }
        else
            return;



    }
    
}

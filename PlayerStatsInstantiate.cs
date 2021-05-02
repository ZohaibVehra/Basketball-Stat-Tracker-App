using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerStatsInstantiate : MonoBehaviour
{
    public int playerPosition;
    public GameObject BigDataGameObject;

    public Text playerName;
    public Text FGM;
    public Text FGA;
    public Text FGP;
    public Text REB;
    public Text AST;
    public Text BLK;
    public Text STL;
    public Text TO;
    public Text FOUL;
    public Text GW;
    public Text GPP;
    public Text GP;
    public Text Score;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetStats()
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
        int x = playerPosition;
        int z = B.CurrentGameACTUAL;

        if (!B.AVG)
        {
            if (z == 1)
            {
                playerName.text = B.Game1Names[x];
                float fgm = B.G1Points[x];
                FGM.text = "" + fgm;
                float fga = B.G1Misses[x] + B.G1Points[x];
                fga = Mathf.Round(fga);
                FGA.text = "" + fga;
                float fgp = fgm / fga;
                fgp = fgp * 100;
                fgp = Mathf.Round(fgp);
                if (Mathf.RoundToInt(fga) == 0)
                    fgp = 0;
                FGP.text = "" + fgp + "%";
                REB.text = "" + B.G1Rebounds[x];
                AST.text = "" + B.G1Assists[x];
                BLK.text = "" + B.G1Blocks[x];
                STL.text = "" + B.G1Steals[x];
                TO.text = "" + B.G1TOs[x];
                FOUL.text = "" + B.G1Fouls[x];
                float gw = B.G1ClutchBaskets[x];
                float gpmisses = B.G1ClutchMisses[x];
                GW.text = "" + gw;
                float gpa = gw + gpmisses;
                float gpp = gw / gpa;
                gpp = gpp * 100;
                if (Mathf.RoundToInt(gpp) == 0)
                    gpp = 0;
                gpp = Mathf.Round(gpp);

                GPP.text = "" + gpp + "%";
                GP.text = "" + 1;

                int b = 0;
                float t1P = 0;
                float t2P = 0;
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
            if (z == 2)
            {
                playerName.text = B.Game2Names[x];
                float fgm = B.G2Points[x];
                FGM.text = "" + fgm;
                float fga = B.G2Misses[x] + B.G2Points[x];
                fga = Mathf.Round(fga);
                FGA.text = "" + fga;
                float fgp = fgm / fga;
                fgp = fgp * 100;
                fgp = Mathf.Round(fgp);
                if (Mathf.RoundToInt(fga) == 0)
                    fgp = 0;
                FGP.text = "" + fgp + "%";
                REB.text = "" + B.G2Rebounds[x];
                AST.text = "" + B.G2Assists[x];
                BLK.text = "" + B.G2Blocks[x];
                STL.text = "" + B.G2Steals[x];
                TO.text = "" + B.G2TOs[x];
                FOUL.text = "" + B.G2Fouls[x];
                float gw = B.G2ClutchBaskets[x];
                float gpmisses = B.G2ClutchMisses[x];
                GW.text = "" + gw;
                float gpa = gw + gpmisses;
                float gpp = gw / gpa;
                gpp = gpp * 100;
                if (Mathf.RoundToInt(gpp) == 0)
                    gpp = 0;
                gpp = Mathf.Round(gpp);

                GPP.text = "" + gpp + "%";
                GP.text = "" + 1;

                int b = 0;
                float t1P = 0;
                float t2P = 0;
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
            if (z == 3)
            {
                playerName.text = B.Game3Names[x];
                float fgm = B.G3Points[x];
                FGM.text = "" + fgm;
                float fga = B.G3Misses[x] + B.G3Points[x];
                fga = Mathf.Round(fga);
                FGA.text = "" + fga;
                float fgp = fgm / fga;
                fgp = fgp * 100;
                fgp = Mathf.Round(fgp);
                if (Mathf.RoundToInt(fga) == 0)
                    fgp = 0;
                FGP.text = "" + fgp + "%";
                REB.text = "" + B.G3Rebounds[x];
                AST.text = "" + B.G3Assists[x];
                BLK.text = "" + B.G3Blocks[x];
                STL.text = "" + B.G3Steals[x];
                TO.text = "" + B.G3TOs[x];
                FOUL.text = "" + B.G3Fouls[x];
                float gw = B.G3ClutchBaskets[x];
                float gpmisses = B.G3ClutchMisses[x];
                GW.text = "" + gw;
                float gpa = gw + gpmisses;
                float gpp = gw / gpa;
                gpp = gpp * 100;
                if (Mathf.RoundToInt(gpp) == 0)
                    gpp = 0;
                gpp = Mathf.Round(gpp);

                GPP.text = "" + gpp + "%";
                GP.text = "" + 1;

                int b = 0;
                float t1P = 0;
                float t2P = 0;
                foreach (string player in B.Game2Names)
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
            if (z == 4)
            {
                playerName.text = B.Game4Names[x];
                float fgm = B.G4Points[x];
                FGM.text = "" + fgm;
                float fga = B.G4Misses[x] + B.G4Points[x];
                fga = Mathf.Round(fga);
                FGA.text = "" + fga;
                float fgp = fgm / fga;
                fgp = fgp * 100;
                fgp = Mathf.Round(fgp);
                if (Mathf.RoundToInt(fga) == 0)
                    fgp = 0;
                FGP.text = "" + fgp + "%";
                REB.text = "" + B.G4Rebounds[x];
                AST.text = "" + B.G4Assists[x];
                BLK.text = "" + B.G4Blocks[x];
                STL.text = "" + B.G4Steals[x];
                TO.text = "" + B.G4TOs[x];
                FOUL.text = "" + B.G4Fouls[x];
                float gw = B.G4ClutchBaskets[x];
                float gpmisses = B.G4ClutchMisses[x];
                GW.text = "" + gw;
                float gpa = gw + gpmisses;
                float gpp = gw / gpa;
                gpp = gpp * 100;
                if (Mathf.RoundToInt(gpp) == 0)
                    gpp = 0;
                gpp = Mathf.Round(gpp);

                GPP.text = "" + gpp + "%";
                GP.text = "" + 1;

                int b = 0;
                float t1P = 0;
                float t2P = 0;
                foreach (string player in B.Game2Names)
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
            if (z == 5)
            {
                playerName.text = B.Game5Names[x];
                float fgm = B.G5Points[x];
                FGM.text = "" + fgm;
                float fga = B.G5Misses[x] + B.G5Points[x];
                fga = Mathf.Round(fga);
                FGA.text = "" + fga;
                float fgp = fgm / fga;
                fgp = fgp * 100;
                fgp = Mathf.Round(fgp);
                if (Mathf.RoundToInt(fga) == 0)
                    fgp = 0;
                FGP.text = "" + fgp + "%";
                REB.text = "" + B.G5Rebounds[x];
                AST.text = "" + B.G5Assists[x];
                BLK.text = "" + B.G5Blocks[x];
                STL.text = "" + B.G5Steals[x];
                TO.text = "" + B.G5TOs[x];
                FOUL.text = "" + B.G5Fouls[x];
                float gw = B.G5ClutchBaskets[x];
                float gpmisses = B.G5ClutchMisses[x];
                GW.text = "" + gw;
                float gpa = gw + gpmisses;
                float gpp = gw / gpa;
                gpp = gpp * 100;
                if (Mathf.RoundToInt(gpp) == 0)
                    gpp = 0;
                gpp = Mathf.Round(gpp);

                GPP.text = "" + gpp + "%";
                GP.text = "" + 1;

                int b = 0;
                float t1P = 0;
                float t2P = 0;
                foreach (string player in B.Game2Names)
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
            if (z == 6)
            {
                playerName.text = B.Game6Names[x];
                float fgm = B.G6Points[x];
                FGM.text = "" + fgm;
                float fga = B.G6Misses[x] + B.G6Points[x];
                fga = Mathf.Round(fga);
                FGA.text = "" + fga;
                float fgp = fgm / fga;
                fgp = fgp * 100;
                fgp = Mathf.Round(fgp);
                if (Mathf.RoundToInt(fga) == 0)
                    fgp = 0;
                FGP.text = "" + fgp + "%";
                REB.text = "" + B.G6Rebounds[x];
                AST.text = "" + B.G6Assists[x];
                BLK.text = "" + B.G6Blocks[x];
                STL.text = "" + B.G6Steals[x];
                TO.text = "" + B.G6TOs[x];
                FOUL.text = "" + B.G6Fouls[x];
                float gw = B.G6ClutchBaskets[x];
                float gpmisses = B.G6ClutchMisses[x];
                GW.text = "" + gw;
                float gpa = gw + gpmisses;
                float gpp = gw / gpa;
                gpp = gpp * 100;
                if (Mathf.RoundToInt(gpp) == 0)
                    gpp = 0;
                gpp = Mathf.Round(gpp);

                GPP.text = "" + gpp + "%";
                GP.text = "" + 1;

                int b = 0;
                float t1P = 0;
                float t2P = 0;
                foreach (string player in B.Game2Names)
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
            if (z == 7)
            {
                playerName.text = B.Game7Names[x];
                float fgm = B.G7Points[x];
                FGM.text = "" + fgm;
                float fga = B.G7Misses[x] + B.G7Points[x];
                fga = Mathf.Round(fga);
                FGA.text = "" + fga;
                float fgp = fgm / fga;
                fgp = fgp * 100;
                fgp = Mathf.Round(fgp);
                if (Mathf.RoundToInt(fga) == 0)
                    fgp = 0;
                FGP.text = "" + fgp + "%";
                REB.text = "" + B.G7Rebounds[x];
                AST.text = "" + B.G7Assists[x];
                BLK.text = "" + B.G7Blocks[x];
                STL.text = "" + B.G7Steals[x];
                TO.text = "" + B.G7TOs[x];
                FOUL.text = "" + B.G7Fouls[x];
                float gw = B.G7ClutchBaskets[x];
                float gpmisses = B.G7ClutchMisses[x];
                GW.text = "" + gw;
                float gpa = gw + gpmisses;
                float gpp = gw / gpa;
                gpp = gpp * 100;
                if (Mathf.RoundToInt(gpp) == 0)
                    gpp = 0;
                gpp = Mathf.Round(gpp);

                GPP.text = "" + gpp + "%";
                GP.text = "" + 1;

                int b = 0;
                float t1P = 0;
                float t2P = 0;
                foreach (string player in B.Game2Names)
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
        else
        {

            playerName.text = B.UsedNames[x];
            float fgmTotal = B.AvgPoints[x];
            float fgm = B.AvgPoints[x] / B.AvgGamesPlayed[x];
            fgm = fgm * 100;
            fgm = Mathf.Round(fgm);
            fgm = fgm / 100;
            FGM.text = "" + fgm;

            float missesTotal = B.AvgMisses[x];
            float misses = B.AvgMisses[x] / B.AvgGamesPlayed[x];
            float fgaTotal = missesTotal + fgmTotal;
            float fga = misses + fgm;
            fga = fga * 100;
            fga = Mathf.Round(fga);
            fga = fga / 100;
            FGA.text = "" + fga;

            float fgp = fgmTotal / fgaTotal;
            fgp = fgp * 100;
            fgp = Mathf.Round(fgp);
            if (Mathf.RoundToInt(fga) == 0)
                fgp = 0;
            FGP.text = "" + fgp + "%";


            float reb = B.AvgRebounds[x] / B.AvgGamesPlayed[x];
            reb = reb * 100;
            reb = Mathf.Round(reb);
            reb = reb / 100;
            REB.text = "" + reb;

            float ast = B.AvgAssists[x] / B.AvgGamesPlayed[x];
            ast = ast * 100;
            ast = Mathf.Round(ast);
            ast = ast / 100;
            AST.text = "" + ast;

            float blks = B.AvgBlocks[x] / B.AvgGamesPlayed[x];
            blks = blks * 100;
            blks = Mathf.Round(blks);
            blks = blks / 100;
            BLK.text = "" + blks;

            float stls = B.Avgsteals[x] / B.AvgGamesPlayed[x];
            stls = stls * 100;
            stls = Mathf.Round(stls);
            stls = stls / 100;
            STL.text = "" + stls;

            float tos = B.AvgTurnOvers[x] / B.AvgGamesPlayed[x];
            tos = tos * 100;
            tos = Mathf.Round(tos);
            tos = tos / 100;
            TO.text = "" + tos;

            float fouls = B.AvgFouls[x] / B.AvgGamesPlayed[x];
            fouls = fouls * 100;
            fouls = Mathf.Round(fouls);
            fouls = fouls / 100;
            FOUL.text = "" + fouls;


            float gwTotal = B.AvgClutchBaskets[x];
            float gw = B.AvgClutchBaskets[x] / B.AvgGamesPlayed[x];
            float gpmisses = B.AvgClutchMisses[x] / B.AvgGamesPlayed[x];
            float gpmissesTotal = B.AvgClutchMisses[x];

            gw = gw * 100;
            gw = Mathf.Round(gw);
            gw = gw / 100;

            GW.text = "" + gw;

            float gpa = gwTotal + gpmissesTotal;
            float gpp = gwTotal / gpa;
            gpp = gpp * 100;
            if (Mathf.RoundToInt(gpp) == 0)
                gpp = 0;
            gpp = Mathf.Round(gpp);

            GPP.text = "" + gpp + "%";
            GP.text = "" + 1;


            Score.text = "";
        }



    }
}

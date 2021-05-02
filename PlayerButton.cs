using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerButton : MonoBehaviour
{
    public string PlayerName;
    public int PlayerPosition;

    public bool clicked = false;
    public Text texttoUpdate;

    public GameObject GSManagerO;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GSManager GSM1 = GSManagerO.GetComponent<GSManager>();
        if(GSM1.playerClicked && GSM1.lastPlayerTemp == PlayerPosition)
        {
            this.GetComponent<Image>().color = Color.blue;
        }
        else
        {
            this.GetComponent<Image>().color = new Color(255, 255, 255, 255);
        }
    }
    public void textupdate()
    {
        GSManagerO = GameObject.Find("GSManager").gameObject;
        //PlayerName = GameObject.Find("GSManager").GetComponent<GSManager>().bigDataGameObject.GetComponent<BigData>().Game1Names[PlayerPosition];

        texttoUpdate.text = PlayerName;
        
    }

    public void playerClick()
    {
         GSManager GSM = GSManagerO.GetComponent<GSManager>();

        if (GSM.playerClicked)
        {
            if(GSM.lastPlayerTemp == PlayerPosition)
            {
                GSM.lastPlayerTemp = 18;
                GSM.playerClicked = false;
            }
            else
            {
                GSM.lastPlayerTemp = PlayerPosition;
                GSM.playerClicked = true;
            }
        }
        else
        {
            if (GSM.statClicked)
            {
                GSM.lastPlayerFinalH = PlayerPosition;
                GSM.lastPlayerTemp = PlayerPosition;
                GSM.playerClicked = true;

            }
            else
            {
                GSM.lastPlayerTemp = PlayerPosition;
                GSM.playerClicked = true;
            }
        }
              
    }
}

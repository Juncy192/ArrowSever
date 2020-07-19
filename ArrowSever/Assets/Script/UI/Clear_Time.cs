using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clear_Time : MonoBehaviour
{
    
    int BlockScore;
    int ComboScore;
    int Score;
    public int Block_odds = 100;
    public int MaxCombo_odds = 100;



    GameObject Combo_result;
    GameObject Score_result;
    GameObject Block_result;
    


    // Start is called before the first frame update
    void Start()
    {
        // this.Time_result = GameObject.Find("Time_Result");
        this.Block_result = GameObject.Find("Block_Result");
        this.Combo_result = GameObject.Find("Combo_Result");
        this.Score_result = GameObject.Find("Score_Result");

        // UI_ScriptのSecond,Comboの値を参照
        BlockScore = UI_Script.Combo;
        ComboScore = UI_Script.MaxCombo;
    }

    // Update is called once per frame
    void Update()
    {
        this.Block_result.GetComponent<Text>().text = "個数: " + UI_Script.Combo.ToString("D2");
        this.Combo_result.GetComponent<Text>().text = "COMBO: " + UI_Script.MaxCombo.ToString("D2");

        Score = (BlockScore * Block_odds) + (ComboScore * MaxCombo_odds);
        this.Score_result.GetComponent<Text>().text = "SCORE: " + Score.ToString("D4");

    }
}

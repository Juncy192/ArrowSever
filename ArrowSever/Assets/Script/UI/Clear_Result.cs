using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clear_Result : MonoBehaviour
{

    // スコア結果のコンボとブロック破壊個数の倍率
    int Score;
    public int Block_odds = 100;
    public int MaxCombo_odds = 100;

    // スコア結果の為のオブジェクト
    GameObject Combo_result;
    GameObject Score_result;
    GameObject Block_result;
    


    // Start is called before the first frame update
    void Start()
    {
        this.Block_result = GameObject.Find("Block_Result");
        this.Combo_result = GameObject.Find("Combo_Result");
        this.Score_result = GameObject.Find("Score_Result");

    }

    // Update is called once per frame
    void Update()
    {

        // スコア結果
        this.Block_result.GetComponent<Text>().text = "個数: " + UI_Controller.Break_Block.ToString("D2");
        this.Combo_result.GetComponent<Text>().text = "COMBO: " + UI_Controller.MaxCombo.ToString("D2");

        Score = (UI_Controller.Break_Block * Block_odds) + (UI_Controller.MaxCombo * MaxCombo_odds);
        this.Score_result.GetComponent<Text>().text = "SCORE: " + Score.ToString("D4");

    }
}

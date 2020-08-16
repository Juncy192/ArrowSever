using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI_Controller : MonoBehaviour
{

    // ゲーム時間とコンボを表示させる為のオブジェクト
    GameObject TimerText;
    GameObject MaxComboText;
    public float Second = 30f; 
    

    // ブロックを壊した最大コンボ
    public static int MaxCombo = 0;
    public static int Max_Break_Block = 0;

    // ブロックを壊した総個数
    public static int Break_Block;

    GameObject Pause;
    public bool flag;

    // オーディオ設定用のオブジェクト
    public AudioSource audio;


    // Start is called before the first frame update
    void Start()
    {
        // Sceneから時間とコンボのオブジェクトを抽出
        this.TimerText = GameObject.FindWithTag("Time");
        this.MaxComboText = GameObject.FindWithTag("Combo");

        Pause = GameObject.Find("Pause");
        flag = false;
        


    }


    // Update is called once per frame
    void Update()
    {
        // ポーズ画面OFF
        if (!flag)
        {
            Pause.SetActive(flag);
        }



        // 最大コンボ
        if(MaxCombo < Max_Break_Block)
        {
            MaxCombo = Max_Break_Block;

        }

        // ゲーム時間数
        Second -= Time.deltaTime;

        if (Second < 0)
        {
            SceneManager.LoadScene("GameClear");
            
        }

        // Secondの数値をToStringで文字列に変換。引数により表示領域を指定。
        this.TimerText.GetComponent<Text>().text = Second.ToString("F2");
        this.MaxComboText.GetComponent<Text>().text = MaxCombo.ToString("D3");

    }

    // ゲームスタート画面
    public void Start_Botton()
    {
        Break_Block = 0;
        Max_Break_Block = 0;
        MaxCombo = 0;
        
        SceneManager.LoadScene("MainScene");

    }

    // ポーズ画面を開く
    public void Pause_Button()
    {
        flag = true;
        Pause.SetActive(flag);
        audio.Pause();
        Time.timeScale = 0f;
        

    }

    // タイトルへ戻る
    public void TitleBack_Botton()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("GameStart");
    }


    // 最初からやり直す
    public void ReStart_Botton()
    {
        Time.timeScale = 1f;
        Break_Block = 0;
        Max_Break_Block = 0;
        MaxCombo = 0;

        SceneManager.LoadScene("MainScene");
    }


    // ゲームの続きに戻る
    public void Back_Botton()
    {
        Time.timeScale = 1f;
        Pause = GameObject.Find("Pause");
        flag = false;
        audio.Play();
    }

}

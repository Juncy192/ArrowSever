using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_UI : MonoBehaviour
{
    GameObject Pause;
    public bool flag;

    void Start()
    {
        Pause = GameObject.Find("Pause");
        flag = false;
    }
    
    void Update()
    {
        if (!flag)
        {
            Pause.SetActive(flag);
        }
    }

    public void Pause_Button()
    {
        flag = true;
        Pause.SetActive(flag);
        Time.timeScale = 0f;
    }

    public void Title_Botton()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("GameStart");
    }

    public void ReStart_Botton()
    {
        Time.timeScale = 1f;
        UI_Script.Combo = 0;
        UI_Script.Max_Break_Block = 0;
        UI_Script.MaxCombo = 0;
        Collision_L_Sword.Combo_Counter = 0;
        Collision_R_Sword.Combo_Counter = 0;

        SceneManager.LoadScene("MainScene");
    }

    public void Back_Botton()
    {
        Time.timeScale = 1f;
        Pause = GameObject.Find("Pause");
        flag = false;
    }


}

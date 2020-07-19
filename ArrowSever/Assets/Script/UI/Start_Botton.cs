using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start_Botton : MonoBehaviour
{
    public void First_Botton()
    {
        UI_Script.Combo = 0;
        UI_Script.Max_Break_Block = 0;
        UI_Script.MaxCombo = 0;
        Collision_L_Sword.Combo_Counter = 0;
        Collision_R_Sword.Combo_Counter = 0;

        SceneManager.LoadScene("MainScene");
        
    }
}

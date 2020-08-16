using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision_Sword : MonoBehaviour
{

    // ブロックを生成する為のオブジェクト
    GameController Spawn_script;
    GameObject Spawm;


    void Start()
    {
        Spawm = GameObject.Find("GameController");
        Spawn_script = Spawm.GetComponent<GameController>();
    }

    // 物体が衝突した時
    public void OnCollisionEnter(Collision collision)
    {
        if (transform.CompareTag(collision.gameObject.tag))
        {
            // 最後尾にブロックを生成
            Spawn_script.EndBlockInstance();

            // ブロックの移動速度を設定
            Spawn_script.MoveSpeed();

            Destroy(collision.gameObject);

            // 最大コンボとブロック撃破数のカウント
            UI_Controller.Max_Break_Block++;
            UI_Controller.Break_Block++;

        }
    }
}

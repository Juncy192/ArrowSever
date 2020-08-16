using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prefab_Move : MonoBehaviour
{
    // パーティクル生成用オブジェクトの宣言
    public GameObject particle;
    GameObject obj;

    // ブロックを移動させる為のオブジェクトの宣言
    GameObject[] MoveBench = new GameObject[9];
    public GameObject gamecontroller;
    public float distance;

    // Start is called before the first frame update
    void Start()
    {

        gamecontroller = GameObject.Find("GameController");
        MoveBench = gamecontroller.GetComponent<GameController>().MoveBranch;
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        // TagがSword_Lで触れた時
        if (transform.CompareTag(collision.gameObject.tag))
        {
            
            // パーティクルの生成、削除
            obj = Instantiate(particle, transform.position, transform.rotation);
            Destroy(obj, 0.2f);
        }
        else 
        {
            UI_Controller.Max_Break_Block = 0;
        }

    }

    void FixedUpdate()
    {
        // 初期生成時の場所との差分
        this.distance = Vector3.Distance(transform.position, MoveBench[0].transform.position);

        // 全Blockをブロック先頭まで移動させる。
        transform.position = Vector3.MoveTowards(transform.position, MoveBench[0].transform.position, GameController.BlockMoveSpeed);

        if (distance == 0)
        {
            GameController.BlockMoveSpeed = 0;
        }


    }

}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    // 空ブロックのオブジェクト
    public GameObject[] MoveBranch = new GameObject[9];

    // 矢印ブロック
    public GameObject[] Block = new GameObject[8]; 

    // ブロックの移動する速さ
    public float Speed = 3;
    public static float BlockMoveSpeed;


    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < MoveBranch.Length - 1; i++)
        {
            // ゲーム開始時にブロックを生成。
            int RandomNumber = Random.Range(0, Block.Length);
            Instantiate(MoveBranch[i], MoveBranch[i].transform.position, MoveBranch[i].transform.rotation);
            Instantiate(Block[RandomNumber], MoveBranch[i].transform.position, Block[RandomNumber].transform.rotation);

        }
    }


    // 最後尾に生成する
    public void EndBlockInstance()
    {
        int RandomNumber = Random.Range(0, Block.Length);
        Instantiate(Block[RandomNumber], MoveBranch[8].transform.position, Block[RandomNumber].transform.rotation);

    }

    // ブロックの移動速度
    public void MoveSpeed()
    {
        BlockMoveSpeed = Speed;
    }

}

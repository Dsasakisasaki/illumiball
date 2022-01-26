using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityController : MonoBehaviour
{
    // 重力加速度
    const float Gravity = 9.81f;

    //重力の適用具合
    public float gravityScale = 1.0f;//bublic付けない場合はprivateになる(デフォルトがprivate)
    //publicで作ったものはunityのinspectorに出るのでそちらで調整できる

    void Start()
    {
        Debug.Log("OK");
    }



    // Update is called once per frame
    void Update()//Updateメソッド　1秒間に役1回動くメッソド 　while true（無限ループ）
    {
        Vector3 vector = new Vector3();//vector3型　xyzの情報ををまとめて扱うクラス

        //キーの入力を検知しベクトルを設定
        vector.x = Input.GetAxis("Horizontal");//Input型　入力関係を全て行うクラス
        vector.z = Input.GetAxis("Vertical");//GetAxisメソッド　

        //高さの方向の判定はキーのｚとする
        if (Input.GetKey("z"))
        {
            vector.y = 1.0f;
        }
        else 
        {
            vector.y = -1.0f;
        }

        //シーンの重力をベクトルの方向に合わせて変化させる
        Physics.gravity = Gravity * vector.normalized * gravityScale;
    }
}

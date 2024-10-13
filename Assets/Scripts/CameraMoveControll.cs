using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoveControll : MonoBehaviour
{
    //Tips
    //「;」は日本語の文章における「。」となります。
    //「.」（ドットは）日本語の文章における「の」などの接続詞になります。
    //「{｝」は日本語の文章における一段落になります。
    //「Hogehoge()」はHogehogeという処理を行うという意味となります。
    //↑（ｆ）ファンクションという意味でもあります。
    //「=」は代入です。「==」は数学的な＝と同じ意味となります。
    //「+,-,/*」加算、減算、除算、掛け算はそのままの意味「％」の余剰を使うこともあります。
    //変数は数学でいうところの「ｘ」とかです。中身を変更できる値となります。
    //プログラミングの変数はプログラミングで扱う全ての型を扱うことができます。
    //型を変数として宣言する（定義する）ことができます。

    /// <summary>
    /// カメラの位置、回転、拡縮が格納されたTransform型の変数
    /// </summary>
    private Transform cameraTransform;
    // Start is called before the first frame update
    void Start()
    {
        //宣言した変数にこのコンポーネントが追加されたGameObjectのTransformを代入する
        cameraTransform =  this.transform;
    }

    // Update is called once per frame
    void Update()
    {
        //カメラの位置情報に、右方向のベクトルにフレーム時間を掛けた値を加算し続ける
        //deltaTime = CPUが処理をするフレームの次のフレームまでの時間
        //フレームとは？1秒間に何回描画が更新されるかの値。60fpsのゲームの場合は一秒間に60回、処理、描画が更新されます。
        //frame per secondの略です。
        //60fpsのTime.deltaTimeは現実時間で0.0166秒という値
        //30fpsのTime.deltaTimeは現実時間で0.0333秒という値

        cameraTransform.position += Vector3.right * Time.deltaTime;
    }
}

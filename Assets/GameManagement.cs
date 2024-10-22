using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManagement : MonoBehaviour
{
    // スコア関連
    public Text scoreText;

    private int score;

    public int currentScore;
    public int clearScore = 1500;

    // Start is called before the first frame update
    void Start()
    {
        Initialize();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // ゲーム開始前の状態に戻す
    private void Initialize()
    {
        // Scoreをゼロに戻す
        score = 0;
    }

    // スコアの追加
    public void AddScore()
    {
        score += 100;
        currentScore += score;
        // 今回の追加 scoreからcurrentScoreに変更
        scoreText.text = "Score: " + currentScore.ToString();

        Debug.Log(currentScore);

        if (currentScore >= clearScore)
        {
            GameClear();
            //Debug.Log(clearScore);
        }

    }
    // GameOverしたときの処理
    // 今回の追加
    public void GameOver() 
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    // GameClearした時の処理
    // 今回の追加
    public void GameClear()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
}

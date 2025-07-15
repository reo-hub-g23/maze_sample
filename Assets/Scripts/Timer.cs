using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeCounter : MonoBehaviour
{
    private float countdownSeconds = 90f ;
    [SerializeField] private Text timeText;
    
    private bool isTimeUp = false;

void Update(){
    if (isTimeUp) return;
    countdownSeconds -= Time.deltaTime;

    if (countdownSeconds <= 30f){
    Debug.Log("残り30秒！ゴールまで急いで！");
    timeText.color = Color.red;
}else{
    //textの表示は白
    timeText.color = Color.white;
} 
        if (countdownSeconds <= 0)
        {
            countdownSeconds = 0;
            isTimeUp = true;

            timeText.text = "00:00";
            TimeUp();
            return;
        }

        var span = new TimeSpan(0, 0, (int)countdownSeconds);
        timeText.text = span.ToString(@"mm\:ss");
}

    private void TimeUp()
    {
        Debug.Log("時間切れ！");
        SceneManager.LoadScene("GameOverScene");
    }
}

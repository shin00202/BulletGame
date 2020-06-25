using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using unityEngine.UI;
using unityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameoverText;  //게임 오버 시 활성화 텍스트
    public Text timeText;            //생존 시간 표시
    public Text recordText;          //최고 기록 표시

    private float survivetime;
    private bool isgameover;

    void Start()
    {
        survivetime = 0;
        isgameover = false;
    }

    void update()
    {
        if (!isgameover)
        {
            survivetime += time.deltatime;
            timeText.text = "time: " + (int)survivetime;
        }
        else
    }
            if (Input.GetKey(KeyCode.R)) {
               SceneManager.LoadScene("SampleScane");
        }
    // Update is called once per frame

       public void EndGame()  {
    isGameover = true;
    gameoverText.SetActive(true);

    float bestTime = PlayerPrefs.GetFloat("BestTime");

    if (surviveTime > bestTime) {
        bestTime = surviveTime;

        PlayerPrefs.SetFloat("BestTime", bestTime);
    }

    recordText.text = "Best Time: " + (int)bestTime;
    }

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    public Text txt_time;
    public Text txt_timeFloored;

    float elapsedTime;

    bool isCounting;


    // Start is called before the first frame update
    void Start()
    {
        elapsedTime = 0;
        isCounting = false;
    }

    // Update is called once per frame
    void Update()
    {
        float currentTime = Time.time;

        txt_time.text = currentTime.ToString();

        txt_timeFloored.text = Mathf.FloorToInt(currentTime).ToString();

        if (isCounting)
        {
            elapsedTime += Time.deltaTime;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerTest : MonoBehaviour
{

    Timer timer;

    float startTime;

    // Start is called before the first frame update
    void Start()
    {
        timer = gameObject.AddComponent<Timer>();
        timer.Duration = 3;
        timer.Run();

        startTime = Time.time;
        
    }

    // Update is called once per frame
    void Update()
    {

        if (timer.Finished)
        {
            float elapsedTime = Time.time - startTime;

            print("Timer run from " + elapsedTime + "second.");

            startTime = Time.time;
            timer.Run();
        }
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    #region Fields
     
    //timer duration.
    float totalSecond;

    //timer execution.
    float elapsedSecond;
    bool running = false;

    //Support for finishing proparty.
    bool start = false;

    #endregion


    #region Properties

    public float Duration
    {
        set
        {
            if (!running)
            {
                totalSecond = value;
            }
        }
    }


    public bool Finished{

        get {
            return start && !running;
        }
    }

    public bool Running
    {

        get
        {
            return running;
        }
    }


    #endregion


    #region Methods.

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (running)
        {
            elapsedSecond += Time.deltaTime;
            if(elapsedSecond >= totalSecond)
            {
                running = false;
            }
        }
        
    }

    public void Run()
    {

        if (totalSecond > 0)
        {
            start = true;
            running = true;
            elapsedSecond = 0;
        }
    }

    #endregion
}

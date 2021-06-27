using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Taddy : MonoBehaviour
{

    [SerializeField] GameObject taddy;

    // death support
    const float TeddyBearLifespanSeconds = 10;
    Timer deathTimer;

    // Start is called before the first frame update
    void Start()
    {
        // apply impulse force to get teddy bear moving
        const float MinImpulseForce = 3f;
        const float MaxImpulseForce = 5f;

        float angle = Random.Range(0, 2 * Mathf.PI);

        Vector2 direction = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle));

        float magnitude = Random.Range(MinImpulseForce, MaxImpulseForce);

        GetComponent<Rigidbody2D>().AddForce(direction * magnitude,ForceMode2D.Impulse);

        // create and start timer
        deathTimer = gameObject.AddComponent<Timer>();
        deathTimer.Duration = TeddyBearLifespanSeconds;
        deathTimer.Run();

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnCollisionEnter2D(Collision2D coll)
    {
        // only blow up when colliding with a teddy bear
        if (coll.gameObject.name == "TeddyBear")
        {
            print("Ouch....!");
        }
    }
}

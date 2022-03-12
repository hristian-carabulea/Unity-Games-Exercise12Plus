using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// https://www.coursera.org/learn/introduction-programming-unity/lecture/fMGDC/collision-detection-and-resolution-part-1
// https://www.coursera.org/learn/introduction-programming-unity/lecture/lJgeh/collision-detection-and-resolution-part-2
// https://www.coursera.org/learn/introduction-programming-unity/lecture/KrMgl/prefabs
// Chapter 4 Exercise 12 plus Collision Detection and Resolution Part 1 & 2
public class TeddieBear : MonoBehaviour
{
    // <summary>
    // Moving an object in a direction (+ or -) with velocity being the given number for the specific direction
    // </summary>
    // Start is called before the first frame update
    void Start()
    {
        // get the game object moving
        //moving x and y. - and + are directions. the number is the velocity in the specific direction, + or -
        const float MinImpulseForce = 3f;
        const float MaxImpulseForce = 5f;
        float angle = Random.Range(0, 2 * Mathf.PI); // in radiants, between 0 and 2Pi
        Vector2 direction = new Vector2(
            Mathf.Cos(angle), Mathf.Sin(angle)
        );
        float magnitude = Random.Range(MinImpulseForce, MaxImpulseForce); // passing in x and y values
        GetComponent<Rigidbody2D>().AddForce(
            direction * magnitude, 
            ForceMode2D.Impulse
        );
    }

    /// <summary>
    /// Called on a collision
    /// </summary>
    /// <param name="col">collision info</param>
    // called when the cube hits the floor
    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("Ouch!");
    }
}

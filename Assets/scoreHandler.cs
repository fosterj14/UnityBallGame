using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreHandler : MonoBehaviour
{

    public Text scoreText;
    static public int score;
    // Start is called before the first frame update
    void Start()
    {
        scoreText = GameObject.FindGameObjectWithTag("score").GetComponent<Text>();
        score = 0;
    }

    private void Update()
    {
        scoreText.text = "Score: " + score.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other == GameObject.FindGameObjectWithTag("outerTarget").GetComponent<BoxCollider>())
        {
            score++;
            targetMovement.SetSpeed(targetMovement.GetSpeed() + .0001f);
        }

        if (other == GameObject.FindGameObjectWithTag("outerTarget").GetComponent<CapsuleCollider>())
        {
            score += 5;
            targetMovement.SetSpeed(targetMovement.GetSpeed() + .0005f);
        }

        if (other == GameObject.FindGameObjectWithTag("side").GetComponent<BoxCollider>() && score > 0)
        {
                score--;
                targetMovement.SetSpeed(targetMovement.GetSpeed() - .0001f);
        }
    }

    static public int GetScore()
    {
        return score;
    }
}

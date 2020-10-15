using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{ 
    private int score = 0 ;

private GameObject scoreText;
    // Start is called before the first frame update
    void Start()
    {
    
        this.scoreText = GameObject.Find("ScoreText");
    }
void OnCollisionEnter(Collision collision)
    
    {
        

        if(collision.gameObject.tag == "smallstarTag")
    { score += 10;
            scoreText.GetComponent<Text>().text = "Score" + score;
        }
        else if(collision.gameObject.tag == "SmallCloudTag")
    { score += 10;
            scoreText.GetComponent<Text>().text = "Score" + score;
        }
        else if(collision.gameObject.tag == "LargeCloudTag")
    { score += 20;
            scoreText.GetComponent<Text>().text = "Score" + score;
        }
        else if(collision.gameObject.tag == "LargeStarTag")
    { score += 20;
            scoreText.GetComponent<Text>().text = "Score" + score;
        }
    }
void Update()
{
        
    }

}

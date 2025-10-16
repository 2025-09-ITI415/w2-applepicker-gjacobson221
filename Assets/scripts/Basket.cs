using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Basket : MonoBehaviour
{
    public Text scoreText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //find a reference to the scorecounter GameObject
        GameObject scoreGO = GameObject.Find("ScoreCounter");
        //get the guitext component of that gameobject
        scoreText = scoreGO.GetComponent<Text>();
        //set the starting number of points to 0
        scoreText.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        //get the currect screen position of mouse from input
        Vector3 mousePos2D = Input.mousePosition;

        //the camera's z position sets the how far to push the mouse into 3D 
        mousePos2D.z = -Camera.main.transform.position.z;

        //convert the point from 2D screen space into 3D game world space
        Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);

        //move the x position of this basket to the x position of the mouse
        Vector3 pos = this.transform.position;
        pos.x = mousePos3D.x;
        this.transform.position = pos;
    }
    void OnCollisionEnter(Collision coll)
    {
        //find out what hit this basket
        GameObject collidedWith = coll.gameObject;
        if (collidedWith.tag == "Apple") {
            Destroy(collidedWith);
        }
        //parse the text of the scoreGT into an int
        int score = int.Parse(scoreText.text);
        //add points for catching the apple
        score += 100;
        //convert the score back to a string and display it
        scoreText.text = score.ToString();

        //track the high score
        if (score > HighScore.score)
        {
            HighScore.score = score;
            Debug.Log("New High Score set! HighScore.score = " + HighScore.score);
        }
    }
}

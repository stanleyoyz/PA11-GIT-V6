using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float speed;
    private int score = 0;
    public Text scoretxt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float verticalInput = Input.GetAxis("Vertical");

        transform.position = transform.position + new Vector3(0 , verticalInput * speed * Time.deltaTime, 0);

        transform.position = new Vector3(0, Mathf.Clamp(transform.position.y, -3.95f, 3.95f), 0);

    }
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Obstacle"))
        {
            SceneManager.LoadScene("gameover");

        }
        if(other.gameObject.CompareTag("scoretrigger"))
        {
            score += 1;
            scoretxt.text = "score : " + score;
        }
    }
}

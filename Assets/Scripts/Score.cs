using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI; //ref score to UI/text

public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player; //transform is responsible for position
    public TextMeshProUGUI scoreText;
    // Update is called once per frame
    void Update()
    {
       //Debug.Log(player.position.z); //this is how many units we move on z axis
       scoreText.text = player.position.z.ToString("0"); //coverting float to string & precision set from 0
    }
}

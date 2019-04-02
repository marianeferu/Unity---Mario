using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player_Health : MonoBehaviour {

    public Text message;
    public int health;
    public bool hasDied;


	// Use this for initialization
	void Start () {
        hasDied = false;
	}

    // Update is called once per frame
    void Update() {

        if (gameObject.transform.position.y < -5)
        {
            hasDied = true;

        }

        if (hasDied == true)
        {
            StartCoroutine("Die");
        }
    }
    IEnumerator Die()
    {
        yield return new WaitForSeconds(2);
        message.enabled = true;
        yield return new WaitForSeconds(2);

        SceneManager.LoadScene("SampleScene");

        yield return null;
    }
	}

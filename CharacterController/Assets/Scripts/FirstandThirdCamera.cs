using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FirstandThirdCamera : MonoBehaviour {

    public GameObject FirtsPerson;
    public GameObject ThirdPerson;
    public int CamMode;

	// Use this for initialization
	void Start ()
    {
               
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetButtonDown("Camera"))
        {
            if (CamMode == 1)
            {
                CamMode = 0;
            }

            else
            {
                CamMode += 1;
            }
            StartCoroutine(CamChange());
        }

    }

    IEnumerator CamChange()
    {
        yield return new WaitForSeconds(0.01f);

        if (CamMode == 0)
        {
            ThirdPerson.SetActive(true);
            FirtsPerson.SetActive(false);
        }

        if (CamMode == 1)
        {
            ThirdPerson.SetActive(false);
            FirtsPerson.SetActive(true);
        }

    }
}

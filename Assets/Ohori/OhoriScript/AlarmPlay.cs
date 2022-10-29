using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class AlarmPlay : MonoBehaviour
{
    private AudioSource audioSource;
    private AlarmControl control;
    // Start is called before the first frame update
    void Start()
    {
        control = GameObject.FindGameObjectWithTag("AlarmControl").GetComponent<AlarmControl>();
        audioSource = GetComponent<AudioSource>();
        //AlarmTag = int.Parse(this.gameObject.tag);
    }

    // Update is called once per frame
    void Update()
    {
        for (int i=0;i<control.NumberOfAlarms;i++)
        {
           // Debug.Log("Alarm" + i);
            if (this.gameObject.tag == "Alarm" +(i+1))
            {
                if (control.Play[i])
                {
                    audioSource.Play();
                    Debug.Log("Play");
                    control.Play[i] = false;
                }
                if (control.Alarm[i] == false)
                {
                    audioSource.Stop();
                    control.Alarm[i] = true;
                }
            } 
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    [SerializeField] private GameObject DoctorGameObject;
    [SerializeField] private GameObject MedStudendGameObject;
    [SerializeField] private GameObject DefaultObject;
    [SerializeField] private Animator doctorAnimator;


    private int collectedValue = 0;

    private void Update()
    {
        ChangeClothes();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("laptop"))
        {
            Destroy(other.gameObject);
            collectedValue -= 5;
         
        }
        else if(other.CompareTag("firstAidKit"))
        {
            Destroy(other.gameObject);
            collectedValue += 5;
            
        }
        else if (other.CompareTag("MedGate"))
        {
            collectedValue += 20;
            
        }
        else if (other.CompareTag("TechGate"))
        {
            collectedValue -= 20;
            
        }
        else if (other.CompareTag("CPR"))
        {
            Debug.Log("Collided with CPR");
            doctorAnimator.SetBool("DoCPR",true);
            gameObject.GetComponent<Movement>().enabled = false;
        }
    }

    private void ChangeClothes()
    {
        if (collectedValue >= 60)
        {
            DoctorGameObject.SetActive(true);
            MedStudendGameObject.SetActive(false);
        }
        
        else if (collectedValue >= 30 && collectedValue < 60)
        {
            MedStudendGameObject.SetActive(true);
            DefaultObject.SetActive(false);
        }
    }
}

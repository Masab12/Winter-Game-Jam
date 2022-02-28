using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Timer : MonoBehaviour
{ 


    [SerializeField] GameObject playerGO;
    [SerializeField] GameObject finishGO;

    Image progressBar;
    float maxDistance;
    private void Start()
    {
        progressBar = GetComponent<Image>();
        maxDistance = finishGO.transform.position.z;
        progressBar.fillAmount = playerGO.transform.position.z / maxDistance;
    }
    private void Update()
    {
        if (progressBar.fillAmount < 1)
        {
            progressBar.fillAmount = playerGO.transform.position.z / maxDistance;
        }
    }

}


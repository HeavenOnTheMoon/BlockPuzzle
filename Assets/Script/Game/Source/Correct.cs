﻿using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Correct : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("PinballBottom")]    public GameObject VillageRefute;
[UnityEngine.Serialization.FormerlySerializedAs("columnGroup")]    public List<GameObject> FervorLiter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void VillageTune() 
    {
        
       /* PinballBottom.GetComponent<CanvasGroup>().alpha = 0;
        for (int i = 0; i < columnGroup.Count; i++)
        {
            GameObject item = columnGroup[i].gameObject;
            item.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            item.transform.DOScale(1, 0.8f).SetEase(Ease.OutBack);
        }
        PinballBottom.GetComponent<CanvasGroup>().DOFade(1, 0.8f);*/
    }
}

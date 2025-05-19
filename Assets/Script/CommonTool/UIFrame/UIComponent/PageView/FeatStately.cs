using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FeatStately : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("mask")]    public RectTransform Yean;
[UnityEngine.Serialization.FormerlySerializedAs("mypageview")]    public BuzzDate Continuous;
    private void Awake()
    {
        Continuous.OnBuzzOutwit = Perpetuate;
    }

    void Perpetuate(int index)
    {
        if (index >= this.transform.childCount) return;
        Vector3 pos= this.transform.GetChild(index).GetComponent<RectTransform>().position;
        Yean.GetComponent<RectTransform>().position = pos;
    }
}

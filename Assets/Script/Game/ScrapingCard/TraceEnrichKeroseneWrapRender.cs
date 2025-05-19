using System.Collections;
using System.Collections.Generic;
using Spine.Unity;
using UnityEngine;
using UnityEngine.UI;

public class TraceEnrichKeroseneWrapRender : MonoBehaviour
{
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    ///  金币 现金
    /// </summary>
    /// <param name="index"></param>
    public void Rake(int index)
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.SetActive(i == index);
        }
    }

    int Route= 0;
    public void Shovel(bool isShow)
    {
        Route++;
        transform.GetChild(6).gameObject.SetActive(isShow);
        if (isShow)
        {
            AgreeOwn.EraChlorine().LuceEscape(AgreeFirm.UIMusic.Sound_ScratCardCricle);
            SkeletonGraphic skeleton = transform.GetChild(6).gameObject.GetComponent<SkeletonGraphic>();
            skeleton.AnimationState.SetEmptyAnimation(0, 0);
            skeleton.AnimationState.AddAnimation(Route, "animation", false, 0);
            skeleton.Update(0); 
        }
    }
}

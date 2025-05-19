using DG.Tweening;
using Spine;
using Spine.Unity;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutwitFlier : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("TopImage")]    public GameObject LipTwine;
[UnityEngine.Serialization.FormerlySerializedAs("BottomImage")]    public GameObject RefuteTwine;
[UnityEngine.Serialization.FormerlySerializedAs("StartSpine")]    public SkeletonGraphic SpankOvert;

    private Action Famous;
    private Action Practicable;

    // Start is called before the first frame update
    void Start()
    {
        float A = Screen.height;
        LipTwine.transform.localPosition = new Vector3(0, A / 2, 0);
        RefuteTwine.transform.localPosition = new Vector3(0, -A / 2, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OutwitFlierPin(Action finish, Action Otherfinish) 
    {
        this.Famous = finish;
        this.Practicable = Otherfinish;
        gameObject.SetActive(true);
        StartCoroutine(nameof(BotherCannon));
        SpankOvert.AnimationState.Complete += OnAnimationComplete;
        SpankOvert.AnimationState.SetAnimation(0, "animation", false);
        
        //AgreeOwn.GetInstance().PlayEffect(AgreeFirm.UIMusic.Sound_Woodloading);
    }

    private IEnumerator BotherCannon()
    {
        yield return new WaitForSeconds(1f);
        Famous?.Invoke();
    }

    void OnAnimationComplete(TrackEntry trackEntry)
    {
        Practicable?.Invoke();
        gameObject.SetActive(false);
    }

    private void OnDisable()
    {
        SpankOvert.AnimationState.Complete -= OnAnimationComplete;
    }
}

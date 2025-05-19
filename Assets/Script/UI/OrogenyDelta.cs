using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OrogenyDelta : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("sliderImage")]    public Image UrchinTwine;
[UnityEngine.Serialization.FormerlySerializedAs("progressText")]    public Text LuncheonRail;
    // Start is called before the first frame update
    void Start()
    {
        UrchinTwine.fillAmount = 0;
        LuncheonRail.text = "0%";
    }

    // Update is called once per frame
    void Update()
    {
        if (UrchinTwine.fillAmount <= 0.8f || PryTellOwn.instance.Towel)
        {
            UrchinTwine.fillAmount += Time.deltaTime / 3f;
            LuncheonRail.text = (int)(UrchinTwine.fillAmount * 100) + "%";
            if (UrchinTwine.fillAmount >= 1)
            {
                Destroy(transform.parent.gameObject);
                TraceEnrichAnewWorship.instance.BiteRake();
            }
        }
    }
}

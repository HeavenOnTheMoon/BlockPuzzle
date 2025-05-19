using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TraceEnrichEarnerRender : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("SchIamge")]    public Image FurBland;
[UnityEngine.Serialization.FormerlySerializedAs("SchText")]    public Text FurRail;
[UnityEngine.Serialization.FormerlySerializedAs("DisText")]    public Text TedRail;
[UnityEngine.Serialization.FormerlySerializedAs("TodayObj")]
    public GameObject IdiomSum;
[UnityEngine.Serialization.FormerlySerializedAs("BeforeObj")]    public GameObject BottomSum;
[UnityEngine.Serialization.FormerlySerializedAs("BeforeDataText")]    public Text BottomWiseRail;
[UnityEngine.Serialization.FormerlySerializedAs("TodayDataText")]    public Text IdiomWiseRail;
[UnityEngine.Serialization.FormerlySerializedAs("CountDownText")]    public Text CajunKierRail;
[UnityEngine.Serialization.FormerlySerializedAs("SelectBtn")]    public Button ZigzagSow;
[UnityEngine.Serialization.FormerlySerializedAs("Select")]    
    public Action<int> Zigzag;

    int ID;
    // Start is called before the first frame update
    void Start()
    {
        ZigzagSow = transform.GetComponent<Button>();
        ZigzagSow.onClick.AddListener((() =>
        {
            Zigzag?.Invoke(ID);
        }));
    }

    // Update is called once per frame
    void Update()
    {
        if (ID == 19)
        {
            DateTime now = DateTime.Now;
            DateTime midnight = now.AddDays(1).Date;
            TimeSpan timeToMidnight = midnight.Subtract(now);
            // 使用ToString方法格式化日期时间字符串
            CajunKierRail.text = String.Format("{0}:{1}:{2}", 
                timeToMidnight.Hours, timeToMidnight.Minutes, timeToMidnight.Seconds);
        }
    }

    public void Rake(int index)
    {
        ID = index;
        var Wish= TraceEnrichAthensWorship.Instance.EraPlusEarnerTell(index);
        //Today
        float Beg= (float)Wish.Athens / PryTellOwn.instance.TownWise.SourceRewards.dailyMaxSource;
        FurRail.text = (Beg * 100).ToString("f0") + "%";
        FurBland.fillAmount = Beg;
        
        if (Beg < 0.25f)
            TedRail.text = "Conscious";
        else if(Beg >= 0.25f && Beg < 0.5f)
            TedRail.text = "Conscious";
        else if(Beg >= 0.5f && Beg < 0.75f)
            TedRail.text = "Clever";
        else if(Beg >= 0.75f && Beg < 1f)
            TedRail.text = "Brain";
        else
            TedRail.text = "Genus";

        if (ID == 19)
        {
            IdiomSum.gameObject.SetActive(true);
            BottomSum.gameObject.SetActive(false);
            IdiomWiseRail.text = Wish.Wise;
        }
        else
        {
            IdiomSum.gameObject.SetActive(false);
            BottomSum.gameObject.SetActive(true);
            BottomWiseRail.text = Wish.Wise;
        }
    }
}

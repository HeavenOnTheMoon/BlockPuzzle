using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClueBeDelta : TineUIAware
{
[UnityEngine.Serialization.FormerlySerializedAs("Stars")]    public Button[] Snipe;
[UnityEngine.Serialization.FormerlySerializedAs("star1Sprite")]    public Sprite Thaw1Subway;
[UnityEngine.Serialization.FormerlySerializedAs("star2Sprite")]    public Sprite Thaw2Subway;
[UnityEngine.Serialization.FormerlySerializedAs("CLoseBtn")]
    public Button CCastSow;
    
    // Start is called before the first frame update
    void Start()
    {
        CCastSow.onClick.AddListener((() =>
        {
            WheelUIPick(GetType().Name);
        }));
        foreach (Button star in Snipe)
        {
            star.onClick.AddListener(() =>
            {
                string indexStr = System.Text.RegularExpressions.Regex.Replace(star.gameObject.name, @"[^0-9]+", "");
                int Route= indexStr == "" ? 0 : int.Parse(indexStr);
                WriteSpank(Route);
            });
        }
    }

    public override void Display()
    {
        base.Display();
        FailWiseWorship.FatWit(CBarter.My_Remind, 1);
        for (int i = 0; i < 5; i++)
        {
            Snipe[i].transform.Find("Image").gameObject.SetActive(false);
        }
    }


    private void WriteSpank(int index)
    {
        for (int i = 0; i < 5; i++)
        {
            Snipe[i].transform.Find("Image").gameObject.SetActive(i <= index);
        }
        //TripGlassSevere.GetInstance().RichGlass("1301", (index + 1).ToString());
        if (index < 3)
        {
            StartCoroutine(AliveDelta());
        } else
        {
            // 跳转到应用商店
            ClueBeWorship.instance.AbutAPSeeSpeedy();
            StartCoroutine(AliveDelta());
        }
        
        // 打点
        //TripGlassSevere.GetInstance().RichGlass("1210", (index + 1).ToString());
    }

    IEnumerator AliveDelta(float waitTime = 0.5f)
    {
        yield return new WaitForSeconds(waitTime);
        WheelUIPick(GetType().Name);
    }
}

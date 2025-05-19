using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayLiter : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("InitGroup")]    public GameObject RakeLiter;

    private GameObject IdentityGenrePoison;
    private float FareBlack= 120f; // 两个item的position.x之差

    // Start is called before the first frame update
    void Start()
    {
        IdentityGenrePoison = RakeLiter.transform.Find("SlotCard_1").gameObject;
        float x = FareBlack * 3;
        int multiCount = PryTellOwn.instance.RakeWise.slot_group.Count;
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < multiCount; j++)
            {
                GameObject fangkuai = Instantiate(IdentityGenrePoison, RakeLiter.transform);
                fangkuai.transform.localPosition = new Vector3(x + FareBlack * multiCount * i + FareBlack * j, IdentityGenrePoison.transform.localPosition.y, 0);
                fangkuai.transform.Find("Text").GetComponent<Text>().text = "×" + PryTellOwn.instance.RakeWise.slot_group[j].multi;
            }
        }
    }

    public void VineGenre()
    {
        RakeLiter.GetComponent<RectTransform>().localPosition = new Vector3(0, -10, 0);
    }

    public void Step(int index, Action<int> finish)
    {
        AgreeOwn.EraChlorine().LuceEscape(AgreeFirm.UIMusic.Sound_OneArmBandit);
        FossilizeInsatiable.ProsperityUnsung(RakeLiter, -(FareBlack * 2 + FareBlack * PryTellOwn.instance.RakeWise.slot_group.Count * 3 + FareBlack * (index + 1)), () =>
        {
            finish?.Invoke(PryTellOwn.instance.RakeWise.slot_group[index].multi);
        });
    }
}

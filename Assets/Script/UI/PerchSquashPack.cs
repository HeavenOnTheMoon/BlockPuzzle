using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PerchSquashPack : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("RewardIcon")]    public Image SquashMaya;
[UnityEngine.Serialization.FormerlySerializedAs("RewardText")]    public Text SquashRail;
[UnityEngine.Serialization.FormerlySerializedAs("GoldIcon")]    public Sprite RideMaya;
[UnityEngine.Serialization.FormerlySerializedAs("CashIcon")]    public Sprite FareMaya;
[UnityEngine.Serialization.FormerlySerializedAs("FinishIcon")]    public Sprite CannonMaya;

    public void FatMidst(bool finish, string type, double value)
    {
        if (finish)
        {
            SquashMaya.sprite = CannonMaya;
            SquashRail.gameObject.SetActive(false);
        }
        else
        {
            SquashMaya.sprite = type == "cash" ? FareMaya : RideMaya;
            if (value == 0)
            {
                SquashRail.gameObject.SetActive(false);
            }
            else
            {
                SquashRail.text = BrightFlaw.PotatoIDGin(value);
                SquashRail.gameObject.SetActive(true);
            }
        }
    }

}

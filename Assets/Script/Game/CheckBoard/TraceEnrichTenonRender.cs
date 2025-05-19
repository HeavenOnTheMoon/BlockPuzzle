using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TraceEnrichTenonRender : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("Text")]    public Text Rail;
[UnityEngine.Serialization.FormerlySerializedAs("FixObj")]    public GameObject CabSum;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Rake(int index)
    {
        Rail.text = index.ToString();
        
    }

    private void OnEnable()
    {
        CabSum.SetActive(true);
        if (TraceEnrichAthensWorship.Instance.EraTenon() - 1 <= 8)
        {
            switch (TraceEnrichAthensWorship.Instance.EraTenon() - 1)
            {
                case 1: AgreeOwn.EraChlorine().LuceEscape(AgreeFirm.UIMusic.Sound_Progressive_1); break;
                case 2: AgreeOwn.EraChlorine().LuceEscape(AgreeFirm.UIMusic.Sound_Progressive_2); break;
                case 3: AgreeOwn.EraChlorine().LuceEscape(AgreeFirm.UIMusic.Sound_Progressive_3); break;
                case 4: AgreeOwn.EraChlorine().LuceEscape(AgreeFirm.UIMusic.Sound_Progressive_4); break;
                case 5: AgreeOwn.EraChlorine().LuceEscape(AgreeFirm.UIMusic.Sound_Progressive_5); break;
                case 6: AgreeOwn.EraChlorine().LuceEscape(AgreeFirm.UIMusic.Sound_Progressive_6); break;
                case 7: AgreeOwn.EraChlorine().LuceEscape(AgreeFirm.UIMusic.Sound_Progressive_7); break;
                case 8: AgreeOwn.EraChlorine().LuceEscape(AgreeFirm.UIMusic.Sound_Progressive_8); break;
            }
        }
        else 
        {
            AgreeOwn.EraChlorine().LuceEscape(AgreeFirm.UIMusic.Sound_Progressive_8);
        }
    }
}

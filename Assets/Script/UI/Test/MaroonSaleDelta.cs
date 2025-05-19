using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MaroonSaleDelta : TineUIAware
{
[UnityEngine.Serialization.FormerlySerializedAs("CloseButton")]    public Button WheelShould;
[UnityEngine.Serialization.FormerlySerializedAs("AdjustAdidText")]    public Text MaroonDecoRail;
[UnityEngine.Serialization.FormerlySerializedAs("ServerIdText")]    public Text SneezeSoRail;
[UnityEngine.Serialization.FormerlySerializedAs("ActCounterText")]    public Text LapMeasureRail;
[UnityEngine.Serialization.FormerlySerializedAs("AdjustTypeText")]    public Text MaroonFirmRail;
[UnityEngine.Serialization.FormerlySerializedAs("ResetActCountButton")]    public Button RoughLapCajunShould;
[UnityEngine.Serialization.FormerlySerializedAs("AddActCountButton")]    public Button BoxLapCajunShould;

    // Start is called before the first frame update
    void Start()
    {
        WheelShould.onClick.AddListener(() => {
            WheelUIPick(GetType().Name);
        });

        RoughLapCajunShould.onClick.AddListener(() => {
            //AdjustInitManager.Instance.ResetActCount();
        });

        BoxLapCajunShould.onClick.AddListener(() => {
            //AdjustInitManager.Instance.AddActCount("test");
        });
    }

    private void TuneMeasureRail()
    {
        /*AdjustAdidText.text = AdjustInitManager.Instance.GetAdjustAdid();
        ServerIdText.text = FailWiseWorship.GetString(CBarter.sv_LocalServerId);
        ActCounterText.text = AdjustInitManager.Instance._currentCount.ToString();
        AdjustTypeText.text = FailWiseWorship.GetString("sv_ADJustInitType");*/
    }

    public override void Display()
    {
        base.Display();
        InvokeRepeating(nameof(TuneMeasureRail), 0, 0.5f);
    }

    public override void Hidding()
    {
        base.Hidding();
        CancelInvoke(nameof(TuneMeasureRail));
    }
}

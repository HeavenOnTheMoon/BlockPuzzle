using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Leafy : TineUIAware
{
[UnityEngine.Serialization.FormerlySerializedAs("ToastText")]    public Text LeafyRail;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public override void Display()
    {
        base.Display();

        LeafyRail.text = LeafyWorship.EraChlorine().Tell;
        StartCoroutine(nameof(OnlyWheelLeafy));
    }

    private IEnumerator OnlyWheelLeafy()
    {
        yield return new WaitForSeconds(2);
        WheelUIPick(GetType().Name);
    }

}

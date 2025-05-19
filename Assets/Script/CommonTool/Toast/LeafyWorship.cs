using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeafyWorship : CoatOutnumber<LeafyWorship>
{
    public string Tell;

    public void TuneLeafy(string info)
    {
        Tell = info;
        UIWorship.EraChlorine().TuneUIAware("Leafy");
    }
}

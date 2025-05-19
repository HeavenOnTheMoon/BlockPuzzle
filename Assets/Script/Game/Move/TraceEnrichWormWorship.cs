using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TraceEnrichWormWorship : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler
{
    public static TraceEnrichWormWorship Instance;
[UnityEngine.Serialization.FormerlySerializedAs("isStartDraw")]
    public bool WeSpankLevy= false;
[UnityEngine.Serialization.FormerlySerializedAs("isEndDrag")]    public bool WeCatCore;
[UnityEngine.Serialization.FormerlySerializedAs("SelectPoint")]    public PointerEventData ZigzagUnify;
[UnityEngine.Serialization.FormerlySerializedAs("SelectObj")]    public GameObject ZigzagSum;
    
    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void OnPointerDown(PointerEventData eventData)
    {
        AgreeOwn.EraChlorine().LuceEscape(AgreeFirm.UIMusic.Sound_Take);
        
        if (WeCatCore)
        {
            return;
        }

        if (!WeCatCore)
        {
            if (FailWiseWorship.EraWit(CBarter.My_SolidTownBulb) != 99)
            {
                TownSolidDelta.Instance.WeTuneRate(false);
            }
            WeCatCore = true;
            WeSpankLevy = true;
            ZigzagUnify = eventData;
            ZigzagSum = eventData.pointerCurrentRaycast.gameObject;
            Vector3 wordPoint;
            RectTransformUtility.ScreenPointToWorldPointInRectangle((RectTransform)ZigzagSum.transform, eventData.position, eventData.pressEventCamera, out wordPoint);
            ZigzagSum.GetComponent<TraceEnrichTraceLiter>()?.ZigzagDay(wordPoint);
            AgreeOwn.EraChlorine().LuceEscape(AgreeFirm.UIMusic.Sound_Putdown);
        }
    }
    
    public void OnPointerUp(PointerEventData eventData)
    {
        
        AgreeOwn.EraChlorine().LuceEscape(AgreeFirm.UIMusic.Sound_Drop);
        //SelectObj.GetComponent<TraceEnrichTraceLiter>().RecoverPos();
        //确认能够放下方块
        WeCatCore = false;
        WeSpankLevy = false;
        TraceEnrichGypsySaladWorship.Instance.StatelyNoveltyTrace(false);
        
        Vector3 wordPoint;
        RectTransformUtility.ScreenPointToWorldPointInRectangle((RectTransform)ZigzagSum.transform, eventData.position, eventData.pressEventCamera, out wordPoint);
        ZigzagSum.GetComponent<TraceEnrichTraceLiter>()?.UnifySo(wordPoint);
        AgreeOwn.EraChlorine().LuceEscape(AgreeFirm.UIMusic.Sound_Pickup);
    }
    public void OnDrag(PointerEventData eventData)
    {

        if (!WeSpankLevy)
        {
            return;
        }

        if (WeSpankLevy)
        {
            Vector3 wordPoint;
            RectTransformUtility.ScreenPointToWorldPointInRectangle((RectTransform)ZigzagSum.transform, eventData.position, eventData.pressEventCamera, out wordPoint);
            ZigzagSum.GetComponent<TraceEnrichTraceLiter>()?.WormDay(wordPoint);
        }
    }

}

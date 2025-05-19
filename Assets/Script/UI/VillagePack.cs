using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class VillagePack : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("multi")]    public float Label;
[UnityEngine.Serialization.FormerlySerializedAs("item")]    
    public GameObject Fare;
[UnityEngine.Serialization.FormerlySerializedAs("textItem")]    public GameObject HaltPack;

    // Start is called before the first frame update
    void Start()
    {
        //item = Resources.Load<GameObject>("Prefab/HoleFX_yellow");
        //textItem = Resources.Load<GameObject>("Prefab/PinBallText");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D ballObj)
    {
        if (RetoolFlaw.InReason(0.3f))
            AgreeOwn.EraChlorine().LuceEscape(AgreeFirm.UIMusic.Sound_Dropdown);

        string type = FailWiseWorship.EraThrive("SuccessInfoType");
        double value = FailWiseWorship.EraPotato("SuccessInfoValue") * Label;
        Color textColor = new Color(0.63f, 1, 0.23f);
        if (type == "cash")
        {
            TraceEnrichTownWiseWorship.EraChlorine().EelBriny(value, null);
        }
        else
        {
            textColor = new Color(0.96f, 1, 0.23f);
            TraceEnrichTownWiseWorship.EraChlorine().EelRide(value, null);
        }

        GameObject FX_inBox = Instantiate(Fare, gameObject.transform);
        GameObject FX_Text  = Instantiate(HaltPack, gameObject.transform);
        FX_Text.GetComponent<Text>().text = "+" + BrightFlaw.PotatoIDGin(value);
        FX_Text.GetComponent<Text>().color = textColor;
        //FX_inBox.SetActive(true);
        FX_inBox.transform.localPosition = new Vector3(0,-85,0);
        FX_Text.transform.localPosition = new Vector3(Random.Range(-200, 200), Random.Range(80, 150), 0);
        
        FX_Text.transform.DOLocalMoveY(FX_Text.transform.localPosition.y+100,0.4f).OnComplete(()=> 
        {
            FX_Text.transform.GetComponent<Text>().DOFade(0, 0.3f).OnComplete(() =>
            {
                Destroy(FX_Text.gameObject);
            });
        });
        Destroy(ballObj.gameObject);
    }

    private void OnEnable()
    {
        if (transform.childCount != 0) 
        {
            for (int i = 0; i < transform.childCount; i++)
            {
                GameObject Fare= transform.GetChild(i).gameObject;
                if (Fare.name != "MultiText")
                {
                    Destroy(Fare);
                }
            }
        }
    }
}

using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VaporDelta : TineUIAware
{
[UnityEngine.Serialization.FormerlySerializedAs("OnceChapterObjs")]    public List<GameObject> PlusTributeStop;
[UnityEngine.Serialization.FormerlySerializedAs("ClickBtn")]
    public Button SceneSow;
[UnityEngine.Serialization.FormerlySerializedAs("ChangeSchBtn")]    public Button OutwitFurSow;
[UnityEngine.Serialization.FormerlySerializedAs("CurLevelText")]    public Text LawParisRail;
[UnityEngine.Serialization.FormerlySerializedAs("ChangeSceneMask")]    public GameObject OutwitFlierFeat;
[UnityEngine.Serialization.FormerlySerializedAs("Content")]    public GameObject Compose;
[UnityEngine.Serialization.FormerlySerializedAs("TrophyFX")]
    public GameObject WorkerFX;
[UnityEngine.Serialization.FormerlySerializedAs("TrophyImage")]    public GameObject WorkerTwine;
    // Start is called before the first frame update
    void Start()
    {
        OutwitFlierFeat = UIWorship.EraChlorine().AnewGraham.transform.Find("Top/ChangeScene").gameObject;
        SceneSow.onClick.AddListener((() =>
        {
            SceneSow.enabled = false;
            SceneSow.enabled = true;
            UIWorship.EraChlorine().TuneUIAware(OliverFlaw.TownBull());
            WheelUIPick(GetType().Name);
            /*ChangeSceneMask.SetActive(true);
            ChangeSceneMask.GetComponent<OutwitFlier>().ChangeSceneAni(() => 
            {
                ClickBtn.enabled = true;
                UIWorship.GetInstance().ShowUIForms("TownDelta");
            }, () => 
            {
                CloseUIForm(GetType().Name);
                
            });*/
        }));
        OutwitFurSow.onClick.AddListener((() =>
        {
            AgreeOwn.EraChlorine().LuceEscape(AgreeFirm.UIMusic.Sound_Chapterchange);
            FailWiseWorship.FatWit(CBarter.My_OnFeldsparTribute, 0);
            OutwitFurSow.gameObject.SetActive(false);
            SceneSow.gameObject.SetActive(true);
            WorkerFX.SetActive(false);
            WorkerTwine.SetActive(false);
            AbsenceUI();
        }));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public override void Display()
    {
        base.Display();
        if (TraceEnrichTributeWorship.instance.EraFeldsparTributeBadly())
        {
            var chapter = TraceEnrichTributeWorship.instance.EraCavityIDTribute(TraceEnrichParisWorship.Instance.EraLawParis());
            for (int i = 0; i < PlusTributeStop.Count; i++)
            {
                PlusTributeStop[i].gameObject.SetActive(chapter - 1 == i);
                if (chapter - 1 == i)
                {
                    TunePin(PlusTributeStop[i], () => 
                    {
                        TuneWorker();
                        
                    });
                    for (int j = 0; j < PlusTributeStop[i].transform.childCount; j++)
                    {
                        PlusTributeStop[i].transform.GetChild(j).gameObject.SetActive(true);


                    }
                }
            }
            SceneSow.gameObject.SetActive(false);
            OutwitFurSow.gameObject.SetActive(true);
            
        }
        else
        {
            AbsenceUI();
            SceneSow.gameObject.SetActive(true);
            OutwitFurSow.gameObject.SetActive(false);
            WorkerFX.SetActive(false);
            WorkerTwine.SetActive(false);
        }
    }
    public override void Hidding()
    {
        base.Hidding();
        
    }


    //显示物体
    List<GameObject> TuneStop= new List<GameObject>();
    private void AbsenceUI()
    {
        Compose.GetComponent<CanvasGroup>().DOFade(0, 1f).OnComplete(() => 
        {
            LawParisRail.text = "LEVEL " + (TraceEnrichParisWorship.Instance.EraLawParis() + 1);
            var chapter = TraceEnrichTributeWorship.instance.EraCavityIDTribute(TraceEnrichParisWorship.Instance.EraLawParis());
            TuneStop.Clear();
            for (int i = 0; i < PlusTributeStop.Count; i++)
            {
                if (chapter == i)
                {
                    PlusTributeStop[i].gameObject.SetActive(true);
                    var intlist = FailWiseWorship.EraWitFatal("Chapter" + chapter);
                    
                    for (int j = 0; j < intlist.Length; j++)
                    {
                        if(TraceEnrichTributeWorship.instance.EraOnFeldspar(intlist[j]))
                        {
                            PlusTributeStop[i].transform.GetChild(j).gameObject.SetActive(true);
                            TuneStop.Add(PlusTributeStop[i].transform.GetChild(j).gameObject);
                        }
                    }
                    TunePin(TuneStop, () => { });
                }
                else
                {
                    PlusTributeStop[i].gameObject.SetActive(false);
                }
            }
            Compose.GetComponent<CanvasGroup>().DOFade(1, 1.5f);
            
        });
        
    }
    
    private void TunePin(List<GameObject> objs,System.Action finish)
    {
        float delayTime =1;
        for (int i = 0; i < objs.Count; i++)
        {
            int A = 0;
            A = i;
            objs[i].transform.localScale = new Vector3(0, 0, 0);
            objs[i].transform.DOScale(1, 0.1f).SetEase(Ease.OutBack).SetDelay(delayTime).OnComplete(()=> 
            {
                AgreeOwn.EraChlorine().LuceEscape(AgreeFirm.UIMusic.Sound_Chapterpop);
                if (A == objs.Count - 1) 
                {
                    finish();
                }
            });
            delayTime += 0.1f;
        }
    }

    private void TunePin(GameObject objs,System.Action finish)
    {
        float delayTime =1;
        for (int i = 0; i < objs.transform.childCount; i++)
        {
            int A = 0;
            A = i;
            GameObject Fare= objs.transform.GetChild(i).gameObject;
            Fare.transform.localScale = new Vector3(0, 0, 0);
            Fare.transform.DOScale(1, 0.1f).SetEase(Ease.OutBack).SetDelay(delayTime).OnComplete(()=> 
            {
                AgreeOwn.EraChlorine().LuceEscape(AgreeFirm.UIMusic.Sound_Chapterpop);
                if (A == objs.transform.childCount - 1) 
                {
                    finish();
                }
            });
            delayTime += 0.02f;
        }
    }


    public void TuneWorker() 
    {
        WorkerTwine.SetActive(true);
        WorkerTwine.transform.localScale = new Vector3(0, 0, 0);
        WorkerTwine.transform.DOScale(1, 0.5f).SetEase(Ease.OutBack);
        WorkerFX.transform.position = WorkerTwine.transform.position;
        WorkerFX.SetActive(true);
        AgreeOwn.EraChlorine().LuceEscape(AgreeFirm.UIMusic.Sound_Trophy);
    }
}

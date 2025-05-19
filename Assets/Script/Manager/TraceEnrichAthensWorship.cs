using System;
using System.Collections;
using System.Collections.Generic;
using LitJson;
using UnityEngine;

public class TraceEnrichAthensWorship : MonoBehaviour
{
    public static TraceEnrichAthensWorship Instance;

    void Awake()
    {
        Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        //RefreshSourceReward();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
[UnityEngine.Serialization.FormerlySerializedAs("OnceSource")]
    public int PlusAthens= 0;
    public void BoxAthens(int OnceClearBlockCount, int OnceBlockGroupCount)
    {
        var addSource = EraBoxPlusAthens(OnceClearBlockCount, OnceBlockGroupCount);
        PlusAthens = addSource;
        var Todaycount = FailWiseWorship.EraWit(CBarter.My_IdiomAthensCajun);
        Todaycount += addSource;
        FailWiseWorship.FatWit(CBarter.My_IdiomAthensCajun,Todaycount);
        GooseEarner[EraWiseIDDelft(DateTime.Today)].Athens = Todaycount;
        OutwitAthensSquash(Todaycount);
        FailWiseWorship.FatThrive(CBarter.My_EarnerAthensTell, JsonMapper.ToJson(GooseEarner));
        if (FailWiseWorship.EraThrive(CBarter.My_LawTownDrum) != "Challenge")
        {
            var CurSource = FailWiseWorship.EraWit(CBarter.My_LawAthensCajun);
            var MaxSource = FailWiseWorship.EraWit(CBarter.My_RimAthensCajun);
            CurSource += addSource;
            FailWiseWorship.FatWit(CBarter.My_LawAthensCajun, CurSource);
            if (MaxSource < CurSource)
            {
                MaxSource = CurSource;
                FailWiseWorship.FatWit(CBarter.My_RimAthensCajun, MaxSource);
            }
            AnemoneEncaseFiber.EraChlorine().Rich(CBarter.Of_AbsenceAthens);
        }
        /*else
        {
            var CurSource = FailWiseWorship.GetInt(CBarter.sv_CurSourceCount);
            var MaxSource = FailWiseWorship.GetInt(CBarter.sv_MaxSourceCount);
            CurSource += addSource;
            FailWiseWorship.SetInt(CBarter.sv_CurSourceCount, CurSource);
            if (MaxSource < CurSource)
            {
                MaxSource = CurSource;
                FailWiseWorship.SetInt(CBarter.sv_MaxSourceCount, MaxSource);
            }
        }*/
    }

    public void BoxSolidAthens(int OnceClearBlockCount, int OnceBlockGroupCount)
    {
        var addSource = EraBoxPlusAthens(OnceClearBlockCount, OnceBlockGroupCount);
        PlusAthens = addSource;
        var CurSource = FailWiseWorship.EraWit(CBarter.My_LawAthensCajun);
        var MaxSource = FailWiseWorship.EraWit(CBarter.My_RimAthensCajun);
        CurSource += addSource;
        FailWiseWorship.FatWit(CBarter.My_LawAthensCajun, CurSource);
        if (MaxSource < CurSource)
        {
            MaxSource = CurSource;
            FailWiseWorship.FatWit(CBarter.My_RimAthensCajun, MaxSource);
        }
        AnemoneEncaseFiber.EraChlorine().Rich(CBarter.Of_AbsenceAthens);
    }

    public void BlamePlusAthens()
    {
        FailWiseWorship.FatFlock(CBarter.My_LawAthensCajun, 0);
        FailWiseWorship.FatFlock(CBarter.My_FlockFiberElectronicTrace, 0);
        FailWiseWorship.FatWit(CBarter.My_FiberElectronicTrace, 0);
    }
    public int EraBoxPlusAthens(int OnceClearBlockCount, int OnceBlockGroupCount)
    {
        float normal = OnceClearBlockCount + OnceBlockGroupCount * 20;
        if(OnceBlockGroupCount > 1)
            normal = Mathf.Ceil((normal + OnceBlockGroupCount * 10) * (1 + 0.2f * EraTenon()));
        else
            normal = Mathf.Ceil((normal) * (1 + 0.2f * EraTenon()));
        return (int)normal;
    }
[UnityEngine.Serialization.FormerlySerializedAs("MentalRewardID")]
    public int EarnerSquashID= 0;
    public void OutwitAthensSquash(float index)
    {
        float Beg= (float)index / PryTellOwn.instance.TownWise.SourceRewards.dailyMaxSource;
        //Debug.LogError("Sch == " + sch);
        if (Beg < 0.25f)
        {
            TraceEnrichTownLifelong.Instance.WeTestAthens = false;
        }
        else if(Beg is >= 0.25f and < 0.5f)
        {
            if ((TraceEnrichTownLifelong.Instance.WeTestDormantWrap || TraceEnrichTownLifelong.Instance.WeTestPerch))
            {
                TraceEnrichTownLifelong.Instance.WeTestAthens = false;
            }
            else
            {
                if(GooseEarner[EraWiseIDDelft(DateTime.Today)].OftSquash)
                    TraceEnrichTownLifelong.Instance.WeTestAthens = false;
                else
                {
                    EarnerSquashID = 0;
                    TraceEnrichTownLifelong.Instance.WeTestAthens = true;
                }
                    
            }
        }
        else if(Beg is >= 0.5f and < 0.75f)
        {
            if ((TraceEnrichTownLifelong.Instance.WeTestDormantWrap || TraceEnrichTownLifelong.Instance.WeTestPerch))
            {
                TraceEnrichTownLifelong.Instance.WeTestAthens = false;
            }
            else
            {
                if(GooseEarner[EraWiseIDDelft(DateTime.Today)].PigSquash)
                    TraceEnrichTownLifelong.Instance.WeTestAthens = false;
                else
                {
                    EarnerSquashID = 1;
                    TraceEnrichTownLifelong.Instance.WeTestAthens = true;
                }
                    
            }
        }
        else if(Beg is >= 0.75f and < 1f)
        {
            if ((TraceEnrichTownLifelong.Instance.WeTestDormantWrap || TraceEnrichTownLifelong.Instance.WeTestPerch))
            {
                TraceEnrichTownLifelong.Instance.WeTestAthens = false;
            }
            else
            {
                if(GooseEarner[EraWiseIDDelft(DateTime.Today)].TrackSquash)
                    TraceEnrichTownLifelong.Instance.WeTestAthens = false;
                else
                {
                    EarnerSquashID = 2;
                    TraceEnrichTownLifelong.Instance.WeTestAthens = true;
                }
                    
            }
        }
        else
        {
            if ((TraceEnrichTownLifelong.Instance.WeTestDormantWrap || TraceEnrichTownLifelong.Instance.WeTestPerch))
            {
                TraceEnrichTownLifelong.Instance.WeTestAthens = false;
            }
            else
            {
                if(GooseEarner[EraWiseIDDelft(DateTime.Today)].AfarSquash)
                    TraceEnrichTownLifelong.Instance.WeTestAthens = false;
                else
                {
                    EarnerSquashID = 3;
                    TraceEnrichTownLifelong.Instance.WeTestAthens = true;
                }
                    
            }
        }
    }
[UnityEngine.Serialization.FormerlySerializedAs("TotalMental")]
    public Dictionary<string, OnceMentalSource> GooseEarner= new Dictionary<string, OnceMentalSource>();
    public void AbsenceAthensSquash()
    {
        var str = FailWiseWorship.EraThrive(CBarter.My_EarnerAthensTell);
        DateTime Decor= DateTime.Today; 
        //新用户
        if (string.IsNullOrEmpty(str))
        {
            for (int i = 0; i < 20; i++)
            {
                DateTime twentyDaysAgo = Decor.AddDays(-i);
                GooseEarner.Add(EraWiseIDDelft(twentyDaysAgo), new OnceMentalSource(){
                    Athens = 0,
                    Wise = EraWiseIDDelft(twentyDaysAgo),
                    OftSquash = false,
                    TrackSquash = false,
                    PigSquash = false,
                    AfarSquash = false
                });
            }
            FailWiseWorship.FatThrive(CBarter.My_EarnerAthensTell, JsonMapper.ToJson(GooseEarner));
        }
        else
        {
            
            GooseEarner = JsonMapper.ToObject<Dictionary<string, OnceMentalSource>>(str);
            DateTime twentyDaysAgo = Decor.AddDays(0);

            if (!GooseEarner.ContainsKey(EraWiseIDDelft(twentyDaysAgo)))
            {
                GooseEarner.Add(EraWiseIDDelft(twentyDaysAgo), new OnceMentalSource(){
                    Athens = 0,
                    Wise = EraWiseIDDelft(twentyDaysAgo),
                    OftSquash = false,
                    TrackSquash = false,
                    PigSquash = false,
                    AfarSquash = false
                });
            }
            FailWiseWorship.FatThrive(CBarter.My_EarnerAthensTell, JsonMapper.ToJson(GooseEarner));
        }
    }

    
    public string EraWiseIDDelft(DateTime dateTime)
    {
        switch (dateTime.Month)
        {
            case 1 : return "Jan " + dateTime.Day;
            case 2 : return "Feb " + dateTime.Day;
            case 3 : return "Mar " + dateTime.Day;
            case 4 : return "Apr " + dateTime.Day;
            case 5 : return "May " + dateTime.Day;
            case 6 : return "Jun " + dateTime.Day;
            case 7 : return "Jul " + dateTime.Day;
            case 8 : return "Aug " + dateTime.Day;
            case 9 : return "Sep " + dateTime.Day;
            case 10 : return "Oct " + dateTime.Day;
            case 11 : return "Nov " + dateTime.Day;
            case 12 : return "Dec " + dateTime.Day;
            default: return "";
        }
        
    }

    public OnceMentalSource EraPlusEarnerTell(int index)
    {
        DateTime Decor= DateTime.Today;
        DateTime twentyDaysAgo = Decor.AddDays(index - 19);
        if(GooseEarner.ContainsKey(EraWiseIDDelft(twentyDaysAgo)))
            return GooseEarner[EraWiseIDDelft(twentyDaysAgo)];
        else
        {
            GooseEarner.Add(EraWiseIDDelft(twentyDaysAgo), new OnceMentalSource(){
                Athens = 0,
                Wise = EraWiseIDDelft(twentyDaysAgo),
                OftSquash = false,
                TrackSquash = false,
                PigSquash = false,
                AfarSquash = false
            });
            return GooseEarner[EraWiseIDDelft(twentyDaysAgo)];
        }
    }

    public void AthensFur()
    {
        
    }

    public void TuneAthensDelta()
    {
        StartCoroutine(SureRisk(0.6f, () =>
        {
            UIWorship.EraChlorine().TuneUIAware("HyperSquashDelta");
        }));
    }

    IEnumerator SureRisk(float time, Action finish)
    {
        yield return new WaitForSeconds(time);
        finish?.Invoke();
    }

    public void SowParis()
    {
        FailWiseWorship.FatWit(CBarter.My_BriefTraceCajun, 0);
        FailWiseWorship.FatWit(CBarter.My_TenonCajun,0);
    }

    public void BriefTrace(bool isClear)
    {
        var Count = FailWiseWorship.EraWit(CBarter.My_BriefTraceCajun);
        Count++;
        Count = OutwitTenon(Count, isClear);
        FailWiseWorship.FatWit(CBarter.My_BriefTraceCajun, Count);
        
    }

    public int OutwitTenon(int index, bool isClear)
    {
        //消除了棋子
        if (isClear)
        {
            BoxTenon();
            return 0;
        }
        //到次数了,还没有combo
        else if (index == 3 && !isClear)
        {
            BlameTenon();
            return 0;
        }
        else
        {
            return index;
        }
    }

    public void BoxTenon()
    {
        var count = FailWiseWorship.EraWit(CBarter.My_TenonCajun);
        count++;
        FailWiseWorship.FatWit(CBarter.My_TenonCajun,count);
    }

    public void BlameTenon()
    {
        FailWiseWorship.FatWit(CBarter.My_TenonCajun,0);
    }

    public int EraTenon()
    {
        return FailWiseWorship.EraWit(CBarter.My_TenonCajun);
    }

    
    
}


public class OnceMentalSource
{
    public int Athens;
    public string Wise;
    public bool OftSquash;
    public bool PigSquash;
    public bool TrackSquash;
    public bool AfarSquash;
}
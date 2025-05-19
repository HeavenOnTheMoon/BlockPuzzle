using System.Collections;
using System.Collections.Generic;
using System.Linq;
using LitJson;
using UnityEngine;

using Random = UnityEngine.Random;

public class TraceEnrichTraceWorship : MonoBehaviour
{
    public static TraceEnrichTraceWorship Instance;
[UnityEngine.Serialization.FormerlySerializedAs("BlockInfo")]
    public TraceEnrichTownTrace TraceTell;
[UnityEngine.Serialization.FormerlySerializedAs("EasyBlockInfo")]    public TraceEnrichTownTrace RentTraceTell;
[UnityEngine.Serialization.FormerlySerializedAs("ChangeBlock")]    public TraceEnrichTownTrace OutwitTrace;
[UnityEngine.Serialization.FormerlySerializedAs("BlockSprites")]
    public List<Sprite> TraceSprites;
[UnityEngine.Serialization.FormerlySerializedAs("BlockTargetSprites")]    public List<Sprite> TraceStrictLightly;
[UnityEngine.Serialization.FormerlySerializedAs("ShowBlockItems")]    public List<BlockItem> TuneTraceAllay= new List<BlockItem>();
[UnityEngine.Serialization.FormerlySerializedAs("BlockGroupItems")]    public List<GameObject> TraceLiterAllay= new List<GameObject>();
[UnityEngine.Serialization.FormerlySerializedAs("ColorBlockSprites")]    public List<Sprite> PluckTraceLightly;
[UnityEngine.Serialization.FormerlySerializedAs("ColorBlockSprites_A")]    public List<Sprite> PluckTraceLightly_A;

    void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        AbsenceTraceFray();

    }

    // Update is called once per frame
    void Update()
    {

    }
    TextAsset Hand;
    TextAsset HandPig;
    /// <summary>
    /// 重新刷新获取方块组比重
    /// </summary>
    public void AbsenceTraceFray()
    {
        Hand = Resources.Load<TextAsset>("LocationJson/BlockGroupData");
        TraceTell = JsonMapper.ToObject<TraceEnrichTownTrace>(Hand.text);
        OutwitTrace = JsonMapper.ToObject<TraceEnrichTownTrace>(Hand.text);
        HandPig = Resources.Load<TextAsset>("LocationJson/EasyBlockGroupData");
        RentTraceTell = JsonMapper.ToObject<TraceEnrichTownTrace>(HandPig.text);
    }

    /// <summary>
    /// 生成方块
    /// </summary>
    /// <param name="isAllAdaptation"></param>
    public void LowerTrace(bool isAllAdaptation = false)
    {
        Transform ParTransform;
        if(FailWiseWorship.EraWit(CBarter.My_SolidTownBulb) == 99)
            ParTransform = TownDelta.Instance.TraceLiterStop.transform;
        else
            ParTransform = TownSolidDelta.Instance.TraceLiterStop.transform;

        Dictionary<FillFourToFour, List<BlockItem>> fillBlocks = null;
        var NextBlock = TraceEnrichParisWorship.Instance.EraTheyTraceLiter();
        if (NextBlock.Count == 3)
        {
            TuneTraceAllay.Clear();
            for (int i = 0; i < 3; i++)
            {
                TraceTell = JsonMapper.ToObject<TraceEnrichTownTrace>(Hand.text);
                TuneTraceAllay.Add(TraceTell.Block[NextBlock[i]]);
                //ConvertOneToTwo(ShowBlockItems[i].shape);
            }
            BoxSowTraceLiter();
        }
        else
        {
            EraTraceFirm();
            if (isAllAdaptation)
            {
                TuneTraceAllay[2] = TraceTell.Block[Random.Range(0,3)];
                TuneTraceAllay[1] = TraceTell.Block[Random.Range(0,3)];
                TuneTraceAllay[0] = TraceTell.Block[Random.Range(0,3)];
            }
            if (FailWiseWorship.EraThrive(CBarter.My_LawTownDrum) == "challenge")
            {
                if (FailWiseWorship.EraWit(CBarter.My_FiberElectronicTrace) - 1 >= 
                    TraceEnrichParisWorship.Instance.WholeTellWise.ParisWise[TraceEnrichParisWorship.Instance.EraLawParis()].Incinerate || 
                    isAllAdaptation)
                {
                    FailWiseWorship.FatWit(CBarter.My_FiberElectronicTrace, 0);
                    fillBlocks = FiberElectronicTracePig();
                }
            }
            else if (FailWiseWorship.EraThrive(CBarter.My_LawTownDrum) == "Guide")
            {
                EraSolidTraceFirm();
            }
            else
            {
                if (OnBisFiberElectronicTrace() || isAllAdaptation)
                {
                    fillBlocks = FiberElectronicTracePig();
                }
            }
        }
        AbsenceStrictTrace();
        TuneTraceAllay = TraceEnrichAnewWorship.instance.RetoolPity(TuneTraceAllay);
        TraceLiterAllay.Clear();
        float DelayTime = 0;
        var needShow = AbsenceDormantWrap();
        Debug.Log("needShow == " + needShow);
        for (int i = 0; i < 3; i++)
        {
            if (FailWiseWorship.EraWit(CBarter.My_SolidTownBulb) == 99)
            {
                if (!PoisonHaveWorship.EraChlorine().AvoidHave("BlockItem"))
                {
                    PoisonHave pool = PoisonHaveWorship.EraChlorine().DimplyPoisonHave<PoisonHave>("BlockItem", ParTransform);
                    pool.Studio = Resources.Load<GameObject>(CBarter.Kill_Trace);
                }
                BlockColor color = (BlockColor)Random.Range(0, 5);
                GameObject Obj = PoisonHaveWorship.EraChlorine().EraTownPoison("BlockItem");
                Obj.GetComponent<TraceEnrichTraceLiter>().Rake(TuneTraceAllay[i], DelayTime, i, needShow == i, color);
                DelayTime += 0.1f;
                TraceLiterAllay.Add(Obj);
            }
            else
            {
                if (!PoisonHaveWorship.EraChlorine().AvoidHave("GuideBlockItem"))
                {
                    PoisonHave pool = PoisonHaveWorship.EraChlorine().DimplyPoisonHave<PoisonHave>("GuideBlockItem", ParTransform);
                    pool.Studio = Resources.Load<GameObject>(CBarter.Kill_Trace);
                }
                GameObject Obj = PoisonHaveWorship.EraChlorine().EraTownPoison("GuideBlockItem");
                if (i == 1)
                    Obj.GetComponent<TraceEnrichTraceLiter>().Rake(TuneTraceAllay[i], DelayTime, i, needShow == i, TraceEnrichGypsySaladWorship.Instance.EraRetoolPluck());
                else
                    Obj.gameObject.SetActive(false);
                
                DelayTime += 0.1f;
                TraceLiterAllay.Add(Obj);
            }
        }
        
        OutwitBisBrief();
        if (isAllAdaptation)
        {
            OutwitLowerTraceDampenPig();
        }
        else
            OutwitLowerTraceDampen();


        // 空格子上补充现金奖励
        if (fillBlocks != null && fillBlocks.Count > 0)
        {
            foreach (var fillBlock in fillBlocks)
            {
                FillFourToFour key = fillBlock.Key;
                int RockyMatch= key.X * 9 + key.Y;
                int[] smallArray = key.ChiefFatal.Cast<int>().ToArray();
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (key.ChiefFatal[i, j] == 0)
                        {
                            int diffIndex = i * 9 + j;
                            GameObject block = TraceEnrichGypsySaladWorship.Instance.GypsySaladTell[RockyMatch + diffIndex];
                            block.transform.GetChild(0).GetComponent<TraceEnrichTraceRender>().FatSquashFirmRetool();
                        }
                    }
                }
            }
        }
        else
        {
            int currentRewardCount = TraceEnrichGypsySaladWorship.Instance.GypsySaladTell
            .Where(x => x.transform.GetChild(0).GetComponent<TraceEnrichTraceRender>().Type == 0 && x.transform.GetChild(0).GetComponent<TraceEnrichTraceRender>().MakeupFirm != 0).Count(); ;
            if (currentRewardCount < PryTellOwn.instance.TownWise.RewardBlockNumLimit)
            {
                List<GameObject> emptyBlocks = TraceEnrichGypsySaladWorship.Instance.GypsySaladTell
                    .Where(x => x.transform.GetChild(0).GetComponent<TraceEnrichTraceRender>().Type == 0 && x.transform.GetChild(0).GetComponent<TraceEnrichTraceRender>().MakeupFirm == 0).ToList();
                List<GameObject> randomList = RetoolFlaw.EraRetoolBackup(emptyBlocks, PryTellOwn.instance.TownWise.RewardBlockNumLimit - currentRewardCount);
                foreach (var block in randomList)
                {
                    block.transform.GetChild(0).GetComponent<TraceEnrichTraceRender>().FatSquashFirmRetool();
                }
            }
        }
    }


    /// <summary>
    /// 回收方块
    /// </summary>
    /// <param name="gameObject"></param>
    public void FloristTrace(GameObject gameObject)
    {
        if (TraceLiterAllay.Contains(gameObject))
        {
            TraceLiterAllay.Remove(gameObject);
            Destroy(gameObject);
        }
    }

    public void BoxSowTraceLiter()
    {
        FailWiseWorship.FatWit(CBarter.My_TraceLiterCajun, 3);
    }
    
    /// <summary>
    /// 放置方块自动生成
    /// </summary>
    public void FeldsparPlusTraceLiter()
    {
        var count = FailWiseWorship.EraWit(CBarter.My_TraceLiterCajun);
        count--;
        FailWiseWorship.FatWit(CBarter.My_TraceLiterCajun, count);
        if (count == 0)
        {
            LowerTrace();
        }
    }
    
    /// <summary>
    /// 复活生成方块
    /// </summary>
    public void DampenFanner()
    {
        BlameJetTrace(); 
        //生成新的方块

        LowerTrace(true);
        TraceEnrichTownLifelong.Instance.TownDampen?.Invoke();
    }

    /// <summary>
    /// 清除全部方块
    /// </summary>
    public void BlameJetTrace()
    {
        //清除现有的方块
        for (int i = TraceLiterAllay.Count - 1; i >= 0; i--)
        {
            FloristTrace(TraceLiterAllay[i]);
        }
    }

    /// <summary>
    /// 刷新出现方块信息
    /// </summary>
    public void EraTraceFirm()
    {
        TuneTraceAllay.Clear();
        FailWiseWorship.FatWit(CBarter.My_FiberElectronicTrace, FailWiseWorship.EraWit(CBarter.My_FiberElectronicTrace) + 1);
        int LoggerCajun= TraceEnrichGypsySaladWorship.Instance.GypsySaladTell.Count(t => t.transform.GetChild(0).GetComponent<TraceEnrichTraceRender>().Type == 0);
        if (LoggerCajun <= PryTellOwn.instance.TownWise.EmptyBlock)
        {
            //方块出现位置
            for (int i = 0; i < 3; i++)
            {
                RentTraceTell = JsonMapper.ToObject<TraceEnrichTownTrace>(HandPig.text);
                TuneTraceAllay.Add(RentTraceTell.Block[EraOftTrace(RentTraceTell)]);
                //ConvertOneToTwo(ShowBlockItems[i].shape);
            }
        }
        else
        {
            //方块出现位置
            for (int i = 0; i < 3; i++)
            {
                TraceTell = JsonMapper.ToObject<TraceEnrichTownTrace>(Hand.text);
                TuneTraceAllay.Add(TraceTell.Block[EraOftTrace(TraceTell)]);
                //ConvertOneToTwo(ShowBlockItems[i].shape);
            }
        }


        BoxSowTraceLiter();
    }

    /// <summary>
    /// 引导生成方块
    /// </summary>
    private void EraSolidTraceFirm()
    {
        TuneTraceAllay.Clear();
        int blockID = 0;
        switch (FailWiseWorship.EraWit(CBarter.My_SolidTownBulb))
        {
            case 0 : blockID = 2; break;
            case 1: blockID = 30; break;
            case 2: blockID = 9; break;
        }
        TuneTraceAllay.Add(TraceTell.Block[blockID]);
        TuneTraceAllay.Add(TraceTell.Block[blockID]);
        TuneTraceAllay.Add(TraceTell.Block[blockID]);
        FailWiseWorship.FatWit(CBarter.My_TraceLiterCajun, 3);
    }
[UnityEngine.Serialization.FormerlySerializedAs("CheckBoardTarget")]
    public Dictionary<int, int> GypsySaladStrict= new Dictionary<int, int>();

    /// <summary>
    /// 刷新目标生成逻辑
    /// </summary>
    private void AbsenceStrictTrace()
    {
        if (FailWiseWorship.EraThrive(CBarter.My_LawTownDrum) != "challenge")
            return;
        GypsySaladStrict.Clear();
        for (int i = 2; i < 7; i++)
        {

            int LoggerCajun= TraceEnrichGypsySaladWorship.Instance.GypsySaladTell.Count(t => t.transform.GetChild(0).GetComponent<TraceEnrichTraceRender>().Type == i
                                                                                   && t.transform.GetChild(0).GetComponent<TraceEnrichTraceRender>().TraceTwine.gameObject.activeSelf);
            if (!GypsySaladStrict.ContainsKey(i))
            {
                GypsySaladStrict.Add(i, LoggerCajun);
            }
            else
            {
                GypsySaladStrict[i] = LoggerCajun;
            }
        }


        int sum = 0;
        foreach (var VARIABLE in GypsySaladStrict)
        {
            sum += VARIABLE.Value;
        }

        Debug.Log("sum == " + sum);
        //满足条件
        if (sum < PryTellOwn.instance.TownWise.TargetBlockMaxCount)
        {
            var Create= Random.Range(1, 4);
            for (int i = 0; i < Create; i++)
            {

                int randomTwo = Random.Range(1, 101);
                if (sum < PryTellOwn.instance.TownWise.TargetBlockMinCount)
                    randomTwo = Random.Range(51, 101);
                switch (randomTwo)
                {
                    case <= 50:
                        //不生成带块积木
                        break;
                    case <= 90:
                        //生成一块
                        VentureOftIDPig(TuneTraceAllay[i].shape);
                        break;
                    default:
                        VentureOftIDPig(TuneTraceAllay[i].shape);
                        VentureOftIDPig(TuneTraceAllay[i].shape);
                        break;
                }

            }
        }
    }

    /// <summary>
    /// 修改指定方块组
    /// </summary>
    /// <param name="list"></param>
    private void VentureOftIDPig(List<int> list)
    {

        // 找出所有1的索引
        List<int> indicesOfOne = list.Select((value, index) => new{
                value, index
            })
            .Where(x => x.value == 1)
            .Select(x => x.index)
            .ToList();

        // 确保列表中至少有一个1
        if (indicesOfOne.Count > 0)
        {
            // 随机选择一个1的索引
            int randomIndex = indicesOfOne[Random.Range(0, indicesOfOne.Count - 1)];

            // 将选定的1改为2
            list[randomIndex] = TraceEnrichParisWorship.Instance.EraRetoolStrict();
            //Debug.Log("randomIndex == " + randomIndex + "     2 == " + list[randomIndex]);
        }
    }

    //按照概率获取单个方块
    private int EraOftTrace(TraceEnrichTownTrace block)
    {
        int sum = 0;
        for (int i = 0; i < block.Block.Count; i++)
        {
            sum += block.Block[i].weight;
        }
        int rewardRandom = Random.Range(0, 999);

        float Shun= 0;
        for (int i = 0; i < block.Block.Count; i++)
        {
            Shun += block.Block[i].weight / (float)sum;
            if (rewardRandom <= Shun * 1000)
            {
                return i;
            }
        }
        return 0;
    }

    /// <summary>
    /// 判断生成的方块能否放到棋盘中
    /// </summary>
    public void OutwitBisBrief()
    {
        for (int i = 0; i < TraceLiterAllay.Count; i++)
        {
            if (TraceEnrichGypsySaladWorship.Instance.OutwitGooseBriefTrace(TraceLiterAllay[i].GetComponent<TraceEnrichTraceLiter>().TraceTell))
            {
                TraceLiterAllay[i].GetComponent<TraceEnrichTraceLiter>().OutwitSceneBadly(true);
            }
            else
            {
                TraceLiterAllay[i].GetComponent<TraceEnrichTraceLiter>().OutwitSceneBadly(false);
            }
        }
    }

    /// <summary>
    /// 方块生成时判断都能消除
    /// </summary>
    private void OutwitLowerTraceDampenPig()
    {
        bool isFailed = false;
        foreach (GameObject t in TraceLiterAllay.Where(t => !t.GetComponent<TraceEnrichTraceLiter>().AcrossLiter.blocksRaycasts))
        {
            isFailed = true;
        }
        if (isFailed)
        {
            DampenFanner();
        }
    }
    
    /// <summary>
    /// 方块生成时判断能否有消除
    /// </summary>
    public void OutwitLowerTraceDampen()
    {
        bool isFailed = true;
        foreach (GameObject t in TraceLiterAllay.Where(t => t.GetComponent<TraceEnrichTraceLiter>().AcrossLiter.blocksRaycasts))
        {
            isFailed = false;
        }
        if (isFailed)
        {
            for (int i = TraceLiterAllay.Count - 1; i >= 0; i--)
            {
                FloristTrace(TraceLiterAllay[i]);
            }
            //生成新的方块
            LowerTrace();
        }
    }

    private int SomehowAthensCajunAlone= 1000;   // 经典模式，积分大于该值，显示bonus

    /// <summary>
    /// 判断是否失败
    /// </summary>
    public void OutwitDampen()
    {
        bool isFailed = true;
        for (int i = 0; i < TraceLiterAllay.Count; i++)
        {
            if (TraceLiterAllay[i].GetComponent<TraceEnrichTraceLiter>().AcrossLiter.blocksRaycasts)
            {
                isFailed = false;
            }
        }
        if (isFailed)
        {
            DampenFiber();
            /* bool showFail = (!FailWiseWorship.GetBool(CBarter.sv_IsRevive) && IsShowRevive()) || !(FailWiseWorship.GetString(CBarter.sv_CurGameMode) == "Classic" && FailWiseWorship.GetInt(CBarter.sv_CurSourceCount) >= ClassicSourceCountLimit);
             if (showFail)
             {
                 TownDelta.Instance.LevelSuccess(false, () =>
                 {
                     FailedLogic();
                 });
             }
             else
             {
                 FailedLogic();
             }*/
        }
        else
        {
            TraceEnrichTownLifelong.Instance.TownDampen?.Invoke();
        }
    }

    /// <summary>
    /// 失败逻辑
    /// </summary>
    private void DampenFiber()
    {
        if (!FailWiseWorship.EraKnow(CBarter.My_OnFanner) && OnTuneFanner())
        {
            // 复活
            UIWorship.EraChlorine().TuneUIAware("FannerDelta");
        }
        else
        {
            StartCoroutine(nameof(TownRing));
            // 如果经典模式，且积分>=1000，走bonus逻辑
            /*if (FailWiseWorship.GetString(CBarter.sv_CurGameMode) == "Classic" && FailWiseWorship.GetInt(CBarter.sv_CurSourceCount) >= ClassicSourceCountLimit)
            {
                FailWiseWorship.SetBool(CBarter.sv_ClassicBonus, true);
                TraceEnrichTownLifelong.Instance.GameFailed?.Invoke();
            }
            else
            {
                GameFailBlockAni();
            }*/
        }
    }

    IEnumerator TownRing()
    {
        yield return new WaitForSeconds(1);
        TownAsiaTracePin();
    }

    /// <summary>
    /// 复活页面是否显示
    /// </summary>
    /// <returns></returns>
    private bool OnTuneFanner()
    {
        //收集
        if (FailWiseWorship.EraThrive(CBarter.My_LawTownDrum) == "challenge")
        {
            int cur = TraceEnrichParisWorship.Instance.Strict.Sum(variable => int.Parse(variable.Value));
            return (float)cur / TraceEnrichParisWorship.Instance.WaxStrictCajun <= 0.5f;
        }
        
        else if (FailWiseWorship.EraThrive(CBarter.My_LawTownDrum) == "Guide")
        {
            return false;
        }
        //积分
        else
        {
            return FailWiseWorship.EraWit(CBarter.My_LawAthensCajun) >= SomehowAthensCajunAlone;
        }
    }

    /// <summary>
    /// 游戏失败动画
    /// </summary>
    public void TownAsiaTracePin()
    {
        Debug.LogError("游戏失败。。。");
        TraceEnrichTownLifelong.Instance.Lifelong = "";
        TraceEnrichGypsySaladWorship.Instance.AbsenceDampenSalad();
        /*FossilizeInsatiable.GameFaildAni(TraceEnrichGypsySaladWorship.Instance.FailedBlock, () =>
        {
            TraceEnrichAnewWorship.instance.GameFailed();
        });*/
        TraceEnrichAnewWorship.instance.TownDampen();
    }
    
    /// <summary>
    /// 刮刮卡出现替换逻辑
    /// </summary>
    /// <returns></returns>
    private int AbsenceDormantWrap()
    {
        if (FailWiseWorship.EraWit(CBarter.My_SolidTownFur) == 0 || OliverFlaw.OnCycle())
            return -1;
        int ShowID = -1;
        //场面中不存在刮刮卡
        if (FailWiseWorship.EraWit(CBarter.My_GlassDormantWrap) == 0)
        {
            var count = FailWiseWorship.EraWit(CBarter.My_DormantWrapCajun);
            count++;
            if (count >= PryTellOwn.instance.TownWise.ScratchInfo.AppearCount)
            {
                FailWiseWorship.FatWit(CBarter.My_GlassDormantWrap, 1);
                count = 0;
                ShowID = Random.Range(0, 3);
            }
            FailWiseWorship.FatWit(CBarter.My_DormantWrapCajun, count);
            return ShowID;
        }
        else
        {
            return -1;
        }

    }

    /// <summary>
    /// 方块补充逻辑
    /// </summary>
    /// <param name="index"></param>
    public void FiberElectronicTrace(int index)
    {
        if (index != 0)
        {
            OutwitTrace = JsonMapper.ToObject<TraceEnrichTownTrace>(Hand.text);
            OutwitTrace.Block = TraceEnrichAnewWorship.instance.RetoolPity(OutwitTrace.Block);
            BlockItem blockItem = new BlockItem();
            //最多只有两个
            if (TraceEnrichGypsySaladWorship.Instance.BlameTell.Count == 1)
            {
                blockItem = TraceEnrichGypsySaladWorship.Instance.EraPickTraceLiter(TraceEnrichGypsySaladWorship.Instance.BlameTell[1], null, OutwitTrace);
                TuneTraceAllay[0] = blockItem;
            }
            else
            {
                blockItem = TraceEnrichGypsySaladWorship.Instance.EraPickTraceLiter(TraceEnrichGypsySaladWorship.Instance.BlameTell[1], TraceEnrichGypsySaladWorship.Instance.BlameTell[2], OutwitTrace);
                TuneTraceAllay[0] = blockItem;
                OutwitTrace.Block = TraceEnrichAnewWorship.instance.RetoolPity(OutwitTrace.Block);
                blockItem = TraceEnrichGypsySaladWorship.Instance.EraPickTraceLiter(TraceEnrichGypsySaladWorship.Instance.BlameTell[2], TraceEnrichGypsySaladWorship.Instance.BlameTell[1], OutwitTrace);
                TuneTraceAllay[1] = blockItem;
            }
        }
        else
        {
            Debug.LogError("没有消除的");
        }
    }
    
    public Dictionary<FillFourToFour, List<BlockItem>> FiberElectronicTracePig()
    {
        Dictionary<FillFourToFour, List<BlockItem>> res = new();
        OutwitTrace = JsonMapper.ToObject<TraceEnrichTownTrace>(Hand.text);
        OutwitTrace.Block = TraceEnrichAnewWorship.instance.RetoolPity(OutwitTrace.Block);
        TraceEnrichGypsySaladWorship.Instance.EraPickTraceLiter();

        int Route= 0;
        foreach (var FillBlockGroup in TraceEnrichGypsySaladWorship.Instance.PickTraceLiter)
        {
            List<BlockItem> list = new();
            if (FillBlockGroup.Value.Item1 != null)
            {
                if (Route <= 2)
                {
                    //Debug.LogError("1 == " + FillBlockGroup.Value.Item1.id + "     xStart == " + FillBlockGroup.Key.X +"    yStart == " + FillBlockGroup.Key.Y);
                    TuneTraceAllay[Route] = FillBlockGroup.Value.Item1;
                    list.Add(FillBlockGroup.Value.Item1);
                }
                    
                Route++;
            }
            if (FillBlockGroup.Value.Item2 != null)
            {

                if (Route <= 2)
                {
                    //Debug.LogError("2 == " + FillBlockGroup.Value.Item2.id + "     xStart == " + FillBlockGroup.Key.X +"    yStart == " + FillBlockGroup.Key.Y);
                    TuneTraceAllay[Route] = FillBlockGroup.Value.Item2;
                    list.Add(FillBlockGroup.Value.Item2);
                }
                    
                Route++;
            }
            if (list.Count > 0)
            {
                res.Add(FillBlockGroup.Key, list);
            }
        }
        return res;
    }

    /// <summary>
    /// 挑战模式判断是否走填充逻辑
    /// </summary>
    /// <returns></returns>
    public bool OnBisFiberElectronicTrace()
    {
        var OnceAdd = FailWiseWorship.EraWit(CBarter.My_LawAthensCajun) / int.Parse(PryTellOwn.instance.TownWise.OnceSource) + 1;
        var AddWeight = OnceAdd * float.Parse(PryTellOwn.instance.TownWise.OnceWeight);
        var CurWeight = FailWiseWorship.EraFlock(CBarter.My_FlockFiberElectronicTrace);
        //Debug.LogError("CurWeight == "+ CurWeight + "      OnceAdd == " + OnceAdd + "      AddWeight == "+ AddWeight);
        switch (CurWeight)
        {
            case < 1:
                CurWeight += AddWeight;
                FailWiseWorship.FatFlock(CBarter.My_FlockFiberElectronicTrace, CurWeight);
                return true;
                break;
            case >= 1 and < 2:
                CurWeight -= 1;
                FailWiseWorship.FatFlock(CBarter.My_FlockFiberElectronicTrace, CurWeight);
                break;
            default:
                CurWeight -= 1;
                break;
        }
        FailWiseWorship.FatFlock(CBarter.My_FlockFiberElectronicTrace, CurWeight);
        
        return false;
    }
}


public enum BlockColor
{
    Blue,
    Orange,
    Purple,
    Red,
    Green
}

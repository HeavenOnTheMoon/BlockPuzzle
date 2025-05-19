using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Spine.Unity;
using UnityEngine;
using Random = UnityEngine.Random;
using UnityEngine.UI;

public class TraceEnrichGypsySaladWorship : MonoBehaviour
{
    public static TraceEnrichGypsySaladWorship Instance;
[UnityEngine.Serialization.FormerlySerializedAs("CheckBoardInfo")]
    //统计棋盘UI
    public List<GameObject> GypsySaladTell;
[UnityEngine.Serialization.FormerlySerializedAs("TotalCheckBoard")]
    public int[,] GooseGypsySalad= new int[9, 9];
[UnityEngine.Serialization.FormerlySerializedAs("PromptCheckBoard")]    public int[,] NatureGypsySalad= new int[9, 9];
[UnityEngine.Serialization.FormerlySerializedAs("ChangeDistance")]
    public float OutwitSkillful;


    void Awake()
    {
        Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        #if UNITY_EDITOR
        if (Input.GetKeyDown(KeyCode.S))
        {
            //FossilizeInsatiable.LevelOver(TownDelta.Instance.transform);
            FailWiseWorship.FatThrive(CBarter.My_CannonBadly, "success");
            // 游戏胜利动画
            TownDelta.Instance.TraceLiterStop.GetComponent<CanvasGroup>().DOFade(0, 0.3f);
            TownDelta.Instance.RefuteLow.GetComponent<CanvasGroup>().DOFade(0, 0.3f);
            //TownDelta.Instance.Correct.SetActive(true);
            //TownDelta.Instance.Correct.GetComponent<Correct>().PinballShow();
            TraceEnrichGypsySaladWorship.Instance.TuneSawPin(() =>
            {
                UIWorship.EraChlorine().TuneUIAware("CannonDelta");
                TraceEnrichAnewWorship.instance.TownCrowbar();
                //TraceEnrichParisWorship.Instance.AddLevel();
                TraceEnrichParisWorship.Instance.EraLawParisTell();
                TraceEnrichParisWorship.Instance.RakeStrict();
            });
            //UIWorship.GetInstance().ShowUIForms("CannonDelta");
            
        }
        #endif
        
    }
    
    //初始化棋盘信息Block
    public void AbsenceGypsySalad(GameObject CheckBoardGroup)
    {
        GypsySaladTell.Clear();
        if (GypsySaladTell.Count == 0)
        {
            for (int i = 0; i < GooseGypsySalad.GetLength(0); i++)
            {
                for (int j = 0; j < GooseGypsySalad.GetLength(1); j++)
                {
                    GooseGypsySalad[i, j] = 0;
                }
            }

            BlockColor color = EraRetoolPluck();
            int guideRule = FailWiseWorship.EraWit(CBarter.My_SolidTownBulb);
            for (int i = 0; i < CheckBoardGroup.transform.childCount; i++)
            {
                if (guideRule == 2)
                {
                    if (i % 9 == 4 || i % 9 == 5)
                    {
                        color = BlockColor.Orange;
                    }
                    else
                    {
                        color = BlockColor.Purple;
                    }
                }
                CheckBoardGroup.transform.GetChild(i).transform.GetChild(0).GetComponent<TraceEnrichTraceRender>().Rake(i / 9, i % 9, 
                    TraceEnrichParisWorship.Instance.LawParisTell[i], color);
                if (TraceEnrichParisWorship.Instance.LawParisTell[i] != 0)
                {
                    if (TraceEnrichParisWorship.Instance.LawParisTell[i] == -1)
                        GooseGypsySalad[i / 9, i % 9] = -1;
                    else
                        GooseGypsySalad[i / 9, i % 9] = 1;
                }
                GypsySaladTell.Add(CheckBoardGroup.transform.GetChild(i).gameObject);
            }
        }
    }

    public BlockColor EraRetoolPluck()
    {
        BlockColor color;
        int guideRule = FailWiseWorship.EraWit(CBarter.My_SolidTownBulb);
        if (guideRule == 99)
        {
            color = (BlockColor)Random.Range(0, 5);
        }
        else if (guideRule == 0)
        {
            color = BlockColor.Red;
        }
        else if (guideRule == 1)
        {
            color = BlockColor.Blue;
        }
        else
        {
            color = BlockColor.Green;
        }
        return color;
    }

    public void StatelyNoveltyTrace(bool isShow)
    {
        if (isShow)
        {
            foreach (var UPPER in OutwitTineTrace)
            {
                UPPER.Key.transform.GetChild(0).GetComponent<TraceEnrichTraceRender>().TuneZigzag(true, UPPER.Value, EraTracePluck());
            }
        }
        else
        {
            for (int j = 0; j < GypsySaladTell.Count; j++)
            {
                GypsySaladTell[j].transform.GetChild(0).GetComponent<TraceEnrichTraceRender>().TuneZigzag(false);
            }
        }
    }

    public void StatelyBiomeTrace(bool isShow)
    {
        if (isShow)
        {
            foreach (var UPPER in NatureSum)
            {
                UPPER.transform.GetChild(0).GetComponent<TraceEnrichTraceRender>().TuneBisBegBiomeTwine(true, EraTracePluck());
            }
        }
        else
        {
            NatureSum.Clear();
            for (int j = 0; j < GypsySaladTell.Count; j++)
            {
                GypsySaladTell[j].transform.GetChild(0).GetComponent<TraceEnrichTraceRender>().TuneBisBegBiomeTwine(false);
            }
        }
    }

    #region 放置判断

    public bool BriefTrace(Vector3 pointPos, int[,] blockGroup, BlockColor color)
    {
        if (BisBriefTrace(pointPos, blockGroup))
        {
            if(FailWiseWorship.EraWit(CBarter.My_SolidTownBulb) == 99)
                TownDelta.Instance.FeatSum.gameObject.SetActive(true);
            else
                TownSolidDelta.Instance.FeatSum.gameObject.SetActive(true);
            foreach (var variable in OutwitTineTrace)
            {
                var block = variable.Key.transform.GetChild(0).GetComponent<TraceEnrichTraceRender>();
                AthensTuneDay = block.transform;
                block.TuneTraceTwine(true, variable.Value, color, true);
                GooseGypsySalad[block.X, block.Y] = 1;
            }
            NatureSum.Clear();
            StatelyBiomeTrace(false);
            /*for (int i = 0; i < ChangeBaseBlock.Count; i++)
            {
                var block = ChangeBaseBlock[i].transform.GetChild(0).GetComponent<TraceEnrichTraceRender>();
                block.ShowBlockImage(true, blockGroup[,]);
            }*/
            TraceEnrichTownLifelong.Instance.PackSpank();
            
            return true;
        }
        else
        {
            return false;
        }
    }

    //能否放置方块
    public void OutwitBriefTrace(Vector3 pointPos, int[,] blockGroup)
    {
        if (BisBriefTrace(pointPos, blockGroup))
        {
            
            StatelyNoveltyTrace(true);
            WeFeldsparTraceLiter();
        }
        else
        {
            NatureSum.Clear();
            StatelyNoveltyTrace(false);

            StatelyBiomeTrace(false);
        }
    }
    
    

    
    private void WeFeldsparTraceLiter()
    {
        NatureSum.Clear();
        Array.Copy(GooseGypsySalad, NatureGypsySalad, GooseGypsySalad.Length);
        foreach (TraceEnrichTraceRender block in OutwitTineTrace.Select(variable 
            => variable.Key.transform.GetChild(0).GetComponent<TraceEnrichTraceRender>()))
        {
            NatureGypsySalad[block.X, block.Y] = 1;
        }


        
        OutwitIntruder(false);
        OutwitProsperity(false);
        /*ChangeBlockGroup(0, 0, false);
        ChangeBlockGroup(0, 3, false);
        ChangeBlockGroup(0, 6, false);
        ChangeBlockGroup(3, 0, false);
        ChangeBlockGroup(3, 3, false);
        ChangeBlockGroup(3, 6, false);
        ChangeBlockGroup(6, 0, false);
        ChangeBlockGroup(6, 3, false);
        ChangeBlockGroup(6, 6, false);*/


        if(NatureSum.Count > 0)
            StatelyBiomeTrace(true);
    }




    public bool BisBriefTrace(Vector3 pointPos, int[,] blockGroup)
    {
        StatelyNoveltyTrace(false);
        for (int i = 0; i < GypsySaladTell.Count; i++)
        {
            //距离
            var dis = Vector3.Distance(pointPos, GypsySaladTell[i].transform.position);
            if (dis <= OutwitSkillful)
            {
                //Debug.LogError("距离合适 == " + i + "      asd ===   " + dis);
                //棋盘中能否放得下
                if (BisBriefTrace(blockGroup, i))
                {
                    return true;
                }
                return false;
            }
        }
        return false;
    }

    public bool OutwitGooseBriefTrace(int[,] blockGroup)
    {
        bool isCanPlace = false;
        for (int i = 0; i < 81; i++)
        {
            if (BisBriefTrace(blockGroup, i, false))
            {
                isCanPlace = true;
                return isCanPlace;
            }
        }
        return isCanPlace;
    }
        
    Dictionary<GameObject, int> OutwitTineTrace= new Dictionary<GameObject, int>();
    public bool BisBriefTrace(int[,] blockGroup, int original, bool isHaveChangeBaseBlock = true)
    {
        bool isCanPlace = true;

        OutwitTineTrace.Clear();
        int x = original / 9;
        int y = original - (x * 9);
        for (int i = 0; i < blockGroup.GetLength(0); i++)
        {
            for (int j = 0; j < blockGroup.GetLength(1); j++)
            {
                //存在棋子在进行判断
                if (blockGroup[i, j] != 0)
                {
                    //没有超
                    if (x + i < 9 && y + j < 9)
                    {
                        //当前位置存放了方块
                        if (GooseGypsySalad[x + i, y + j] == 1 || GooseGypsySalad[x + i, y + j] == -1)
                        {
                            isCanPlace = false;
                            return isCanPlace;
                        }
                        else
                        {
                            if (isHaveChangeBaseBlock)
                                OutwitTineTrace.Add(GypsySaladTell[(x + i) * 9 + y + j], blockGroup[i, j]);
                        }
                    }
                    else
                    {
                        isCanPlace = false;
                        OutwitTineTrace.Clear();
                        return isCanPlace;
                    }
                }
            }
        }
        return isCanPlace;
    }

  #endregion


    #region 消除判断

    List<GameObject> LiraBlameSum= new List<GameObject>();
    List<GameObject> NatureSum= new List<GameObject>();
[UnityEngine.Serialization.FormerlySerializedAs("CashShowPos")]    public Transform FareTuneDay;
[UnityEngine.Serialization.FormerlySerializedAs("SourceShowPos")]    public Transform AthensTuneDay;
[UnityEngine.Serialization.FormerlySerializedAs("ClearBlockGroupCount")]    public int BlameTraceLiterCajun;
    /// <summary>
    /// 校验是否可以消除
    /// </summary>
    public void OutwitBisBlameTrace()
    {
        LiraBlameSum.Clear();
        BlameTraceLiterCajun = 0;
        //清零
        for (int i = 0; i < 9; i++)
            for (int j = 0; j < 9; j++)
                PinLiraBlameSalad[i, j] = 0;
        
        //棋盘中可以消除的棋子
        OutwitIntruder(true);
        OutwitProsperity(true);
        /*ChangeBlockGroup(0, 0, true);
        ChangeBlockGroup(0, 3, true);
        ChangeBlockGroup(0, 6, true);
        ChangeBlockGroup(3, 0, true);
        ChangeBlockGroup(3, 3, true);
        ChangeBlockGroup(3, 6, true);
        ChangeBlockGroup(6, 0, true);
        ChangeBlockGroup(6, 3, true);
        ChangeBlockGroup(6, 6, true);*/

        if (BlameTraceLiterCajun > 0)
        {
            AgreeOwn.EraChlorine().LuceEscape(AgreeFirm.UIMusic.Sound_Clear);
        }

        TraceEnrichAthensWorship.Instance.BriefTrace(LiraBlameSum.Count != 0);
        
        for (int i = 0; i < LiraBlameSum.Count; i++)
        {
            foreach (var VARIABLE in OutwitTineTrace)
            {
                if (VARIABLE.Key == LiraBlameSum[i])
                {
                    FareTuneDay = LiraBlameSum[i].transform;
                    break;
                }
            }
        }
        Transform bottom = null;
        int bottomID = 99;
        for (int i = 0; i < LiraBlameSum.Count; i++)
        {
            if (LiraBlameSum[i].transform.GetChild(0).GetComponent<TraceEnrichTraceRender>().Y < bottomID)
            {
                bottomID = LiraBlameSum[i].transform.GetChild(0).GetComponent<TraceEnrichTraceRender>().Y;
                bottom = LiraBlameSum[i].transform;
            }
        }
        if (FailWiseWorship.EraWit(CBarter.My_SolidTownBulb) != 99 && !OliverFlaw.OnCycle())
        {
            float value = (float)40 / LiraBlameSum.Count;
            for (int i = 0; i < LiraBlameSum.Count; i++)
            {
                TraceEnrichTownWiseWorship.EraChlorine().EelBrinyPig(value, LiraBlameSum[i].transform, bottom);
            }
        }
        else if (LiraBlameSum.Count != 0 && !OliverFlaw.OnCycle() && FailWiseWorship.EraThrive(CBarter.My_LawTownDrum) != "Guide")
        {
            double cashValue = float.Parse(PryTellOwn.instance.TownWise.Cashmultiple) * LiraBlameSum.Count * BlockPuzzleGameUtil.GetCashMulti();
            cashValue *= 1 + 0.1f * TraceEnrichAthensWorship.Instance.EraTenon();
            cashValue *= 1 + 0.1f * BlameTraceLiterCajun;
            float value = (float)cashValue / LiraBlameSum.Count;
            //TraceEnrichTownWiseWorship.GetInstance().addToken(cashValue , CashShowPos);
            for (int i = 0; i < LiraBlameSum.Count; i++)
            {
                TraceEnrichTownWiseWorship.EraChlorine().EelBrinyPig(value, LiraBlameSum[i].transform, bottom);
            }
        }
    }
    // 0 默认值， 1 需要消除的
    private int[,] PinLiraBlameSalad= new int[9, 9];
[UnityEngine.Serialization.FormerlySerializedAs("ScratchObjs")]
    public GameObject DormantStop;
    public void BlameTracePin()
    {
        
        float DelayTime = 0;
        bool isAddtime = false;
        if(FailWiseWorship.EraWit(CBarter.My_SolidTownBulb) == 99)
            TownDelta.Instance.TraceSP = new();
        else
            TownSolidDelta.Instance.TraceSP.Clear();

        bool isHaveTarget = false;
        AgreeOwn.EraChlorine().LuceEscape(AgreeFirm.UIMusic.Sound_Blockclean_2);
        for (int slice = 0; slice < 2 * 9 - 1; ++slice)
        {
            int z = slice < 9 ? 0 : slice - 9 + 1;
            for (int j = slice - z; j >= z; --j)
            {
                if (PinLiraBlameSalad[j, (slice - j)] == 1)
                {
                    //消除动画
                    var block = GypsySaladTell[(j) * 9 + 8 - (slice - j)].transform.GetChild(0).GetComponent<TraceEnrichTraceRender>();
                    if (block.Type != 1)
                        isHaveTarget = true;
                    GooseGypsySalad[block.X, block.Y] = 0;
                    if (FailWiseWorship.EraWit(CBarter.My_SolidTownBulb) == 99)
                        FossilizeInsatiable.BlamePin(block.gameObject, TownDelta.Instance.TraceSP, () =>
                        {
                            block.TuneTraceTwine(false, 0);
                        });
                    else
                        FossilizeInsatiable.BlamePin(block.gameObject, TownSolidDelta.Instance.TraceSP, () =>
                        {
                            block.TuneTraceTwine(false, 0);
                        });
                }
            }
        }

        TenonFurProclaimOutwit();
        float Park= 0;
        if (isHaveTarget)
            Park = 0f;
        else
            Park = 0f;
        StartCoroutine(SureRisk(Park, () =>
        {
            TraceEnrichTownLifelong.Instance.BlameTrace?.Invoke();
        }));
    }

    IEnumerator SureRisk(float time, Action finish)
    {
        yield return new WaitForSeconds(time);
        finish?.Invoke();
    }

    private void OutwitIntruder(bool isNeedClear)
    {
        if (isNeedClear)
        {
            for (int i = 0; i < 9; i++)
            {
                bool isComplete = true;
                for (int j = 0; j < 9; j++)
                {
                    //0 还有没有填充的
                    if (GooseGypsySalad[j, i] == 0 || GooseGypsySalad[j, i] == -1)
                    {
                        isComplete = false;
                        break;
                    }
                }
                if (isComplete)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        if (!LiraBlameSum.Contains(GypsySaladTell[9 * j + i]))
                        {
                            LiraBlameSum.Add(GypsySaladTell[9 * j + i]);
                            PinLiraBlameSalad[j, 8 - i] = 1;
                        }
                    }
                    BlameTraceLiterCajun++;
                    if (FailWiseWorship.EraWit(CBarter.My_SolidTownBulb) == 99)
                    {
                        TownDelta.Instance?.TuneBlameOvert(2, EraTracePluck(), GypsySaladTell[9 * 4 + i].transform.position);
                    }
                    else
                    {
                        TownSolidDelta.Instance?.TuneBlameOvert(2, EraTracePluck(), GypsySaladTell[9 * 4 + i].transform.position);
                    }
                }
            }
        }
        else
        {
            for (int i = 0; i < 9; i++)
            {
                bool isComplete = true;
                for (int j = 0; j < 9; j++)
                {
                    //0 还有没有填充的
                    if (NatureGypsySalad[j, i] == 0 || NatureGypsySalad[j, i] == -1)
                    {
                        isComplete = false;
                        break;
                    }
                }
                if (isComplete)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        if (!NatureSum.Contains(GypsySaladTell[9 * j + i]))
                        {
                            NatureSum.Add(GypsySaladTell[9 * j + i]);
                        }
                    }
                }
            }
        }
    }

    private void OutwitProsperity(bool isNeedClear)
    {
        if (isNeedClear)
        {
            for (int i = 0; i < 9; i++)
            {
                bool isComplete = true;
                for (int j = 0; j < 9; j++)
                {
                    //0 还有没有填充的
                    if (GooseGypsySalad[i, j] == 0|| GooseGypsySalad[i, j] == -1)
                    {
                        isComplete = false;
                        break;
                    }
                }
                if (isComplete)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        if (!LiraBlameSum.Contains(GypsySaladTell[j + i * 9]))
                        {
                            LiraBlameSum.Add(GypsySaladTell[j + i * 9]);
                            PinLiraBlameSalad[i, 8 - j] = 1;
                        }
                    }
                    BlameTraceLiterCajun++;
                    if (FailWiseWorship.EraWit(CBarter.My_SolidTownBulb) == 99)
                    {
                        TownDelta.Instance?.TuneBlameOvert(1, EraTracePluck(), GypsySaladTell[9 * i + 4].transform.position);
                    }
                    else
                    {
                        TownSolidDelta.Instance?.TuneBlameOvert(1, EraTracePluck(), GypsySaladTell[9 * i + 4].transform.position);
                    }
                }
            }
        }
        else
        {
            for (int i = 0; i < 9; i++)
            {
                bool isComplete = true;
                for (int j = 0; j < 9; j++)
                {
                    //0 还有没有填充的
                    if (NatureGypsySalad[i, j] == 0 || NatureGypsySalad[i, j] == -1)
                    {
                        isComplete = false;
                        break;
                    }
                }
                if (isComplete)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        if (!NatureSum.Contains(GypsySaladTell[j + i * 9]))
                        {
                            NatureSum.Add(GypsySaladTell[j + i * 9]);
                        }
                    }
                }
            }
        }
        
    }

    private void OutwitTraceLiter(int startRow, int startCol, bool isNeedClear)
    {
        if (isNeedClear)
        {
            bool isComplete = true;
            for (int i = startRow; i < startRow + 3; i++)
            {
                for (int j = startCol; j < startCol + 3; j++)
                {
                    if (GooseGypsySalad[i, j] == 0 || GooseGypsySalad[i, j] == -1)
                    {
                        isComplete = false;
                        break;
                    }
                }
            }
            if (isComplete)
            {
                for (int i = startRow; i < startRow + 3; i++)
                {
                    for (int j = startCol; j < startCol + 3; j++)
                    {
                        if (!LiraBlameSum.Contains(GypsySaladTell[j + i * 9]))
                        {
                            LiraBlameSum.Add(GypsySaladTell[j + i * 9]);
                            PinLiraBlameSalad[i, 8 - j] = 1;
                        }
                    }
                }
                BlameTraceLiterCajun++;
                if (FailWiseWorship.EraWit(CBarter.My_SolidTownBulb) == 99)
                {
                    TownDelta.Instance?.TuneBlameOvert(3, EraTracePluck(), GypsySaladTell[9 * (startRow + 1) + startCol].transform.position);
                }
                else
                {
                    TownSolidDelta.Instance?.TuneBlameOvert(3, EraTracePluck(), GypsySaladTell[9 * (startRow + 1) + startCol].transform.position);
                }
            }
        }
        else
        {
            bool isComplete = true;
            for (int i = startRow; i < startRow + 3; i++)
            {
                for (int j = startCol; j < startCol + 3; j++)
                {
                    if (NatureGypsySalad[i, j] == 0 || NatureGypsySalad[i, j] == -1)
                    {
                        isComplete = false;
                        break;
                    }
                }
            }
            if (isComplete)
            {
                for (int i = startRow; i < startRow + 3; i++)
                {
                    for (int j = startCol; j < startCol + 3; j++)
                    {
                        if (!NatureSum.Contains(GypsySaladTell[j + i * 9]))
                        {
                            NatureSum.Add(GypsySaladTell[j + i * 9]);
                        }
                    }
                }
            }
        }
       
    }

    /// <summary>
    /// 获取放置的方块的颜色
    /// </summary>
    /// <returns></returns>
    private BlockColor EraTracePluck()
    {
        BlockColor color = BlockColor.Blue;
        if (TraceEnrichWormWorship.Instance.ZigzagSum != null)
        {
            color = TraceEnrichWormWorship.Instance.ZigzagSum.GetComponent<TraceEnrichTraceLiter>().color;
        }
        else
        {
            
            foreach (GameObject block in OutwitTineTrace.Keys)
            {
                if (OutwitTineTrace[block] == 1)
                {
                    color = block.transform.Find("Block").GetComponent<TraceEnrichTraceRender>().color;
                    break;
                }
            }
        }
        return color;
    }

  #endregion

    #region 填充逻辑判断

    //1 ~ 9 3*3 左下开始，11 ~ 19 横从下往上， 21 ~ 29 竖从左到右
    int[] ForaySaladTell= new int[]{
        1, 2, 3, 4, 5, 6, 7, 8, 9, 
        11, 12, 13, 14, 15, 16, 17, 18, 19,
        21, 22, 23, 24, 25, 26, 27, 28, 29
    };
    public int OutwitPickGypsySalad()
    {
        ForaySaladTell = TraceEnrichAnewWorship.instance.RetoolWit(ForaySaladTell);

        for (int i = 0; i < ForaySaladTell.Length; i++)
        {
            if (WeBisPick(ForaySaladTell[i]))
            {
                Debug.Log("checkBoardInfo[i] == " + ForaySaladTell[i] +  "         Count == " + BlameTell.Count);
                foreach (var VARIABLE in BlameTell)
                {
                    Debug.Log("1 == " + VARIABLE.Key + "       2 == " + VARIABLE.Value.Count);
                    for (int j = 0; j < VARIABLE.Value.Count; j++)
                    {
                        Debug.Log("i == "+ j +"     x == " + VARIABLE.Value[j].X +"      y == " + VARIABLE.Value[j].Y);
                    }
                }
                return ForaySaladTell[i];
            }
        }
        return 0;
    }
    public bool WeBisPick(int index)
    {
        //3*3
        if (index < 10)
        {
            int startRow = 0;
            int startCol = 0;
            switch (index)
            {
                case 1 : startRow = 0; startCol = 0; break;
                case 2 : startRow = 0; startCol = 3; break;
                case 3 : startRow = 0; startCol = 6; break;
                case 4 : startRow = 3; startCol = 0; break;
                case 5 : startRow = 3; startCol = 3; break;
                case 6 : startRow = 3; startCol = 6; break;
                case 7 : startRow = 6; startCol = 0; break;
                case 8 : startRow = 6; startCol = 3; break;
                case 9 : startRow = 6; startCol = 6; break;
            }
            return OutwitTrackIDTrack(startRow, startCol);
        }
        //竖列
        else if(index > 20)
        {
            return WeBisPickTraceIntruder(index - 21);
        }
        //横列
        else
        {
            return WeBisPickTraceProsperity(index - 11);
        }
        return false;
    }

    public bool WeBisPickTraceIntruder(int Vertical)
    {
        BlameTell.Clear();
        int emptyCount = 0;
        for (int i = 0; i < 9; i++)
        {
            if(GooseGypsySalad[Vertical, i] == 0)
                emptyCount++;
        }
        if (emptyCount <= 4)
        {
            int breaksCount = 0;
            bool isOneSequence = false;
            
            int currentCount = 0; // 当前连续1的计数器
            int maxCount = 0; // 目前为止遇到的连续1的最大数量
            if (GooseGypsySalad[Vertical , 0] == 0)
            {
                breaksCount++;
            }
            
            for (int i = 0; i < 9; i++)
            {
                // 如果当前数字是
                if (GooseGypsySalad[Vertical, i] == 0)
                {
                    if (!isOneSequence && i > 0 && GooseGypsySalad[Vertical, i - 1] == 1)
                    {
                        breaksCount++;
                    }
                    
                    if (breaksCount > 0)
                    {
                        if (BlameTell.ContainsKey(breaksCount))
                        {
                            BlameTell[breaksCount].Add(new EmptyBlockPos(){
                                X = Vertical, Y = i
                            });
                        }
                        else
                        {
                            BlameTell.Add(breaksCount,new List<EmptyBlockPos>(){
                                new EmptyBlockPos(){X = Vertical, Y = i}
                            });
                        }
                    }
                    isOneSequence = true;
                    
                    currentCount++;
                    // 更新遇到的连续1的最大数量
                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount;
                    }
                }
                else
                {
                    isOneSequence = false;
                    currentCount = 0;
                    
                    
                }
            }
            
            if (breaksCount <= 2)
            {
                if (breaksCount == 1 && emptyCount != 1)
                {
                    OutwitVerbDOx(emptyCount);
                }
                return true;
            }
        }
        return false;
    }

    private void OutwitVerbDOx(int LineCount)
    {
        List<EmptyBlockPos> firstInfo = new List<EmptyBlockPos>();
        List<EmptyBlockPos> secondInfo = new List<EmptyBlockPos>();
        switch (LineCount)
        {
            case 2 :
                if (TraceEnrichAnewWorship.instance.OnBoxStick(500))
                {
                    firstInfo.Add(BlameTell[1][0]);
                    secondInfo.Add(BlameTell[1][1]);

                    BlameTell[1] = firstInfo;
                    BlameTell.Add(2, secondInfo);
                }
                break;
            case 3 :
                if (TraceEnrichAnewWorship.instance.OnBoxStick(500))
                {
                    var Create= Random.Range(1, BlameTell[1].Count - 1);
                    firstInfo = BlameTell[1].GetRange(0, Create);
                    secondInfo = BlameTell[1].GetRange(Create, BlameTell[1].Count - Create);
                    
                    BlameTell[1] = firstInfo;
                    BlameTell.Add(2, secondInfo);
                }
                break;
            case 4 : 
                if (TraceEnrichAnewWorship.instance.OnBoxStick(500))
                {
                    var Create= Random.Range(1, BlameTell[1].Count - 1);
                    firstInfo = BlameTell[1].GetRange(0, Create);
                    secondInfo = BlameTell[1].GetRange(Create, BlameTell[1].Count - Create);
                
                    BlameTell[1] = firstInfo;
                    BlameTell.Add(2, secondInfo);
                }
                break;
        }
    }
    
    public bool WeBisPickTraceProsperity(int Horizontal)
    {
        BlameTell.Clear();
        int emptyCount = 0;
        for (int i = 0; i < 9; i++)
        {
            if(GooseGypsySalad[i , Horizontal] == 0)
            {
                emptyCount++;
            }
        }
        if (emptyCount <= 4)
        {
            int breaksCount = 0;
            bool isOneSequence = false;
            
            int currentCount = 0; // 当前连续1的计数器
            int maxCount = 0; // 目前为止遇到的连续1的最大数量
            if (GooseGypsySalad[0, Horizontal] == 0)
            {
                breaksCount++;
            }
            for (int i = 0; i < 9; i++)
            {
                // 如果当前数字是
                if (GooseGypsySalad[i , Horizontal] == 0)
                {
                    if (!isOneSequence && i > 0 && GooseGypsySalad[i - 1, Horizontal] == 1)
                    {
                        breaksCount++;
                    }
                    if (breaksCount > 0)
                    {
                        if (BlameTell.ContainsKey(breaksCount))
                        {
                            BlameTell[breaksCount].Add(new EmptyBlockPos(){
                                X = i, Y = Horizontal
                            });
                        }
                        else
                        {
                            BlameTell.Add(breaksCount,new List<EmptyBlockPos>(){
                                new EmptyBlockPos(){X = i, Y = Horizontal}
                            });
                        }
                    }
                    
                    isOneSequence = true;
                    
                    currentCount++;
                    // 更新遇到的连续1的最大数量
                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount;
                    }
                }
                else
                {
                    isOneSequence = false;
                    currentCount = 0;
                    
                }
            }
            if (breaksCount <= 2)
            {
                if (breaksCount == 1 && emptyCount != 1)
                {
                    OutwitVerbDOx(emptyCount);
                }
                return true;
            }
        }
        return false;
    }

    private bool OutwitTrackIDTrack(int startRow, int startCol)
    {
        BlameTell.Clear();
        int emptyCount = 0;
        

        List<EmptyBlockPos> emptyBlockPosList = new List<EmptyBlockPos>();
        for (int i = startRow; i < startRow + 3; i++)
        {
            for (int j = startCol; j < startCol + 3; j++)
            {
                if (GooseGypsySalad[i, j] == 0)
                {
                    emptyCount++;
                    emptyBlockPosList.Add(new EmptyBlockPos(){X = i, Y = j});
                }
            }
        }
        Unusual = new bool[3, 3];
        if (emptyCount <= 4)
        {
            var maxConnectResult = RimIntensivePoet(startRow, startCol);
            Debug.Log("emptyCount == " + emptyCount + "    2 == " + maxConnectResult.Count);
            /*
            for (int i = 0; i < maxConnectResult.Count; i++)
            {
                Debug.LogError("   i == " + i + "     x == " + maxConnectResult[i].X +"      y == " + maxConnectResult[i].Y);
            }*/
            if (emptyCount == 1 && maxConnectResult.Count == 1)
                BlameTell.Add(1,emptyBlockPosList);
            else if (emptyCount == 2 && maxConnectResult.Count == 2)
            {
                BlameTell.Add(1,emptyBlockPosList);
                OutwitVerbDOx(emptyCount);
            }
            else if (emptyCount == 3 && maxConnectResult.Count == 3)
            {
                BlameTell.Add(1,emptyBlockPosList);
                OutwitVerbDOx(emptyCount);
            }
            else if (emptyCount == 4 && maxConnectResult.Count == 4)
            {
                BlameTell.Add(1,emptyBlockPosList);
            }
            else if (emptyCount == 2 && maxConnectResult.Count == 1)
            {
                if (Mathf.Abs(emptyBlockPosList[0].X - emptyBlockPosList[1].X) <= 1
                    && Mathf.Abs(emptyBlockPosList[0].Y - emptyBlockPosList[1].Y) <= 1)
                {
                    BlameTell.Add(1,emptyBlockPosList);
                    OutwitVerbDOx(emptyCount);
                }
                else
                {
                    BlameTell.Add(1, new List<EmptyBlockPos>(){emptyBlockPosList[0]});
                    BlameTell.Add(2, new List<EmptyBlockPos>(){emptyBlockPosList[1]});
                }
            }
                
            else if (emptyCount == 3 && maxConnectResult.Count == 1)
            {
                return false;
                var value = MissPigPoet(startRow, startCol);
                if (value.Count >= 2)
                {
                    BlameTell.Add(1, new List<EmptyBlockPos>{ 
                        new(){X = value[0].x, Y = value[0].y}, 
                        new(){X = value[1].x, Y = value[1].y }});
                    if (OnBoxPigBlame(emptyBlockPosList))
                        return true;
                }
                else
                {
                    return false;
                }
                
            }
            else if (emptyCount == 3 && maxConnectResult.Count == 2)
            {
                var value = MissPigPoet(startRow, startCol);
                if (value.Count >= 2)
                {
                    BlameTell.Add(1, new List<EmptyBlockPos>{ 
                        new(){X = value[0].x, Y = value[0].y}, 
                        new(){X = value[1].x, Y = value[1].y }});
                    
                    var clearOne = BlameTell[1];
                    
                    if (OnBoxPigBlame(emptyBlockPosList))
                        return true;
                }
                else
                {
                    return false;
                }
            }
            else if (emptyCount == 4 && maxConnectResult.Count == 3)
            {
                //横竖满足后就只有一种情况
                if (GypsyCowTrackSolarItVerb(startRow, startCol))
                {
                    BlameTell.Add(1, maxConnectResult);
                    
                    //剩余的那个放到另一个里面
                    if (OnBoxPigBlame(emptyBlockPosList))
                        return true;
                }
                else
                {
                    //先判断是否三一
                    if (TraceEnrichAnewWorship.instance.OnBoxStick(500))
                    {
                        BlameTell.Add(1, maxConnectResult);
                        
                        //剩余的那个放到另一个里面
                        if (OnBoxPigBlame(emptyBlockPosList))
                            return true;
                    }
                    else
                    {
                        var result = BisSolarBeChildless(startRow, startCol);
                        if (result.canSeparate)
                        {
                            BlameTell.Add(1, result.zeroPositions.GetRange(0,2));
                            BlameTell.Add(2, result.zeroPositions.GetRange(2,2));
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            else if (emptyCount == 4 && maxConnectResult.Count == 2)
            {
                var result = GypsySwearVerb(startRow, startCol);
                //斜线判断
                if (result.isCon)
                {
                    BlameTell.Add(1, result.maxOnesPositions);
                    
                    if (OnBoxPigBlame(emptyBlockPosList))
                        return true;
                }
                else
                {
                    var resultTwo = BisSolarBeChildless(startRow, startCol);
                    if (resultTwo.canSeparate)
                    {
                        BlameTell.Add(1, resultTwo.zeroPositions.GetRange(0,2));
                        BlameTell.Add(2, resultTwo.zeroPositions.GetRange(2,2));
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            else if (emptyCount == 4 && maxConnectResult.Count == 1)
            {
                var result = GypsySwearVerb(startRow, startCol);
                //斜线判断
                if (result.isCon)
                {
                    BlameTell.Add(1, result.maxOnesPositions);
                    if (OnBoxPigBlame(emptyBlockPosList))
                        return true;
                }
                else
                {
                    return false;
                }
            }
            return BlameTell.Count <= 2;
        }
        return false;
    }

    private bool OnBoxPigBlame(List<EmptyBlockPos> emptyBlockPosList)
    {
        var clearOne = BlameTell[1];
        var Two = emptyBlockPosList.Except(clearOne).ToList();
        BlameTell.Add(2, Two);
        return true;
        for (int i = 0; i < emptyBlockPosList.Count; i++)
        {
            bool isExistence = false;
            foreach (EmptyBlockPos t in clearOne.Where(t => emptyBlockPosList[i] == t))
            {
                isExistence = true;
            }

            if (!isExistence)
            {
                BlameTell.Add(2, new List<EmptyBlockPos>{emptyBlockPosList[i]});
                return true;
            }
        }
        return false;
    }
    
    private bool[,] Unusual;
    private List<EmptyBlockPos> RimIntensivePoet(int startRow, int startCol)
    {
        List<EmptyBlockPos> maxCount = new List<EmptyBlockPos>();
        List<List<EmptyBlockPos>> allBlocks = new List<List<EmptyBlockPos>>();
        for (int i = startRow; i < startRow + 3; i++)
        {
            for (int j = startCol; j < startCol + 3; j++)
            {
                if (GooseGypsySalad[i, j] == 0 && !Unusual[i - startRow, j - startCol])
                {
                    List<EmptyBlockPos> currentBlock = new List<EmptyBlockPos>();
                    // 使用DFS更新最大连通数量
                    DFS(startRow, startCol, i, j, currentBlock);
                    //maxCount = Math.Max(maxCount, );
                    allBlocks.Add(currentBlock);
                }
            }
        }
        for (int i = 0; i < allBlocks.Count; i++)
        {
            if (maxCount.Count < allBlocks[i].Count)
            {
                maxCount = allBlocks[i];
            }
        }
        return maxCount;
    }
    
    private int DFS(int startRow, int startCol, int i, int j, List<EmptyBlockPos> currentBlock)
    {
        if (i < startRow || i >= 3 + startRow || j < startCol || j >= startCol + 3 || GooseGypsySalad[i, j] != 0 || Unusual[i - startRow, j - startCol])
        {
            return 0;
        }

        Unusual[i - startRow, j - startCol] = true; // 标记为已访问
        //Debug.LogError("x == " + i + "      y == "  + j);
        currentBlock.Add(new EmptyBlockPos(){X = i,Y = j});
        // 为当前位置的1计数，再加上上下左右四个方向的DFS返回值
        return 1 + DFS(startRow, startCol, i+1, j, currentBlock) + 
               DFS(startRow, startCol, i-1, j, currentBlock) + 
               DFS(startRow, startCol, i, j+1, currentBlock) + 
               DFS(startRow, startCol, i, j-1, currentBlock);
    }
    
    /// <summary>
    /// 横竖线
    /// </summary>
    /// <param name="startRow"></param>
    /// <param name="startCol"></param>
    /// <returns></returns>
    public bool GypsyCowTrackSolarItVerb(int startRow, int startCol)
    {
        // 检查行
        for (int row = startRow; row < startRow + 3; row++)
        {
            if (GooseGypsySalad[row, 0] == 0 && GooseGypsySalad[row, 1] == 0 && GooseGypsySalad[row, 2] == 0)
                return true;
        }

        // 检查列
        for (int col = startCol; col < startCol + 3; col++)
        {
            if (GooseGypsySalad[0, col] == 0 && GooseGypsySalad[1, col] == 0 && GooseGypsySalad[2, col] == 0)
                return true;
        }

        return false;
    }

    /// <summary>
    /// 斜线
    /// </summary>
    /// <param name="startRow"></param>
    /// <param name="startCol"></param>
    /// <returns></returns>
    public (bool isCon, List<EmptyBlockPos> maxOnesPositions) GypsySwearVerb(int startRow, int startCol)
    {
        if (GooseGypsySalad[startRow, startCol] == 0 && GooseGypsySalad[startRow + 1, startCol + 1] == 0 && GooseGypsySalad[startRow + 2, startCol + 2] == 0)
        {
            return (true, new List<EmptyBlockPos>(){ new(){X = startRow,Y = startCol},new(){X = startRow + 1,Y = startCol + 1},new(){X = startRow + 2,Y = startCol + 2}});
        }
        if (GooseGypsySalad[startRow, startCol + 2] == 0 && GooseGypsySalad[startRow + 1,startCol + 1] == 0 && GooseGypsySalad[startRow + 2,startCol + 0] == 0)
            return (true, new List<EmptyBlockPos>(){ new(){X = startRow,Y = startCol + 2},new(){X = startRow + 1,Y = startCol + 1},new(){X = startRow + 2,Y = startCol}});

        return (false,null);
    }
    
    /// <summary>
    /// 最大连接数，以及对应位置
    /// </summary>
    /// <param name="startRow"></param>
    /// <param name="startCol"></param>
    /// <returns></returns>
    public (int maxCount, List<EmptyBlockPos> maxOnesPositions) MissRimCompositionPoet(int startRow, int startCol)
    {
        int maxSize = 0;
        List<EmptyBlockPos> positions = new List<EmptyBlockPos>();
        
        // 检查行
        for (int i = startRow; i < startRow + 3; i++)
        {
            int rowCount = 0;
            for (int j = startCol; j < startCol + 3; j++)
            {
                if (GooseGypsySalad[i, j] == 0)
                {
                    rowCount++;
                    if (rowCount > maxSize)
                    {
                        maxSize = rowCount;
                        positions.Clear();
                        for (int k = 0; k < rowCount; k++)
                        {
                            positions.Add(new EmptyBlockPos(){X = i, Y = j - k});
                            //positions.Add(new EmptyBlockPos(i, j - k));
                        }
                    }
                }
                else
                {
                    rowCount = 0;
                }
            }
        }
        
        // 检查列
        for (int j = startCol; j <startCol + 3; j++)
        {
            int colCount = 0;
            for (int i = startRow; i <startRow + 3; i++)
            {
                if (GooseGypsySalad[i, j] == 1)
                {
                    colCount++;
                    if (colCount > maxSize)
                    {
                        maxSize = colCount;
                        positions.Clear();
                        for (int k = 0; k < colCount; k++)
                        {
                            positions.Add(new EmptyBlockPos(){X = i - k, Y = j});
                            //positions.Add(new Vector2Int(i - k, j));
                        }
                    }
                }
                else
                {
                    colCount = 0;
                }
            }
        }
        
        return (maxSize, positions);
    }
    
    /// <summary>
    /// 两两相连
    /// </summary>
    /// <param name="startRow"></param>
    /// <param name="startCol"></param>
    /// <returns></returns>
    public List<Vector2Int> MissPigPoet(int startRow, int startCol)
    {
        List<Vector2Int> positions = new List<Vector2Int>();
        
        for (int i = startRow; i < startRow + 2; i++) 
        {
            for (int j = startCol; j < startCol + 2; j++)
            {
                if (GooseGypsySalad[i, j] == 0) positions.Add(new Vector2Int(i, j));
                if (GooseGypsySalad[i, j + 1] == 0) positions.Add(new Vector2Int(i, j + 1));
                if (GooseGypsySalad[i + 1, j] == 0) positions.Add(new Vector2Int(i + 1, j));
                if (GooseGypsySalad[i + 1, j + 1] == 0) positions.Add(new Vector2Int(i + 1, j + 1));


                if (positions.Count >= 2)
                {
                    return positions.GetRange(0, 2);
                }
                positions.Clear();
            }
        }
        
        for (int i = startRow + 1; i < startRow + 3; i++) 
        {
            for (int j = startCol; j < startCol + 2; j++)
            {
                if (GooseGypsySalad[i, j] == 0) positions.Add(new Vector2Int(i, j));
                if (GooseGypsySalad[i, j + 1] == 0) positions.Add(new Vector2Int(i, j + 1));
                if (GooseGypsySalad[i + 1, j] == 0) positions.Add(new Vector2Int(i + 1, j));
                if (GooseGypsySalad[i + 1, j + 1] == 0) positions.Add(new Vector2Int(i + 1, j + 1));


                if (positions.Count >= 2)
                {
                    return positions.GetRange(0, 2);
                }
                positions.Clear();
            }
        }
        
        for (int i = startRow; i < startRow + 2; i++) 
        {
            for (int j = startCol + 1; j < startCol + 3; j++)
            {
                if (GooseGypsySalad[i, j] == 0) positions.Add(new Vector2Int(i, j));
                if (GooseGypsySalad[i, j + 1] == 0) positions.Add(new Vector2Int(i, j + 1));
                if (GooseGypsySalad[i + 1, j] == 0) positions.Add(new Vector2Int(i + 1, j));
                if (GooseGypsySalad[i + 1, j + 1] == 0) positions.Add(new Vector2Int(i + 1, j + 1));


                if (positions.Count >= 2)
                {
                    return positions.GetRange(0, 2);
                }
                positions.Clear();
            }
        }
        
        for (int i = startRow + 1; i < startRow + 3; i++) 
        {
            for (int j = startCol + 1; j < startCol + 3; j++)
            {
                if (GooseGypsySalad[i, j] == 0) positions.Add(new Vector2Int(i, j));
                if (GooseGypsySalad[i, j + 1] == 0) positions.Add(new Vector2Int(i, j + 1));
                if (GooseGypsySalad[i + 1, j] == 0) positions.Add(new Vector2Int(i + 1, j));
                if (GooseGypsySalad[i + 1, j + 1] == 0) positions.Add(new Vector2Int(i + 1, j + 1));


                if (positions.Count >= 2)
                {
                    return positions.GetRange(0, 2);
                }
                positions.Clear();
            }
        }
        
        return positions;
    }

    private (bool canSeparate, List<EmptyBlockPos> zeroPositions) BisSolarBeChildless(int startRow, int startCol)
    {
        List<EmptyBlockPos>[] subGridZeroPositions = new List<EmptyBlockPos>[4];
        for (int i = 0; i < subGridZeroPositions.Length; i++)
        {
            subGridZeroPositions[i] = new List<EmptyBlockPos>();
        }
        
        // 记录每个2x2子区域中0的位置
        for (int row = startRow; row <= startRow + 1; row++)
        {
            for (int col = startCol; col <= startCol + 1; col++)
            {
                int subGridIndex = (row - startRow) * 2 + col - startCol;
                for (int i = row; i < row + 2; i++)
                {
                    for (int j = col; j < col + 2; j++)
                    {
                        if (GooseGypsySalad[i, j] == 0)
                        {
                            subGridZeroPositions[subGridIndex].Add(new EmptyBlockPos(){X = i, Y = j});
                        }
                    }
                }
            }
        }
        
        // 检查是否有两个子区域中各有两个0
        for (int i = 0; i < subGridZeroPositions.Length; i++)
        {
            for (int j = i + 1; j < subGridZeroPositions.Length; j++)
            {
                if (subGridZeroPositions[i].Count == 2 && subGridZeroPositions[j].Count == 2)
                {
                    // 组合所有0的位置
                    List<EmptyBlockPos> zeroPositions = new List<EmptyBlockPos>();
                    zeroPositions.AddRange(subGridZeroPositions[i]);
                    zeroPositions.AddRange(subGridZeroPositions[j]);
                    return (true, zeroPositions);
                }
            }
        }
        
        return (false, null);
    }
[UnityEngine.Serialization.FormerlySerializedAs("ClearInfo")]    
    //最多只有两个，每次弄给剩下那个填充上
    public Dictionary<int, List<EmptyBlockPos>> BlameTell= new Dictionary<int, List<EmptyBlockPos>>();

    int[,] SowGoose= new int[9,9];
    int[,] OutwitGoose=  new int[9,9];
    public BlockItem EraPickTraceLiter(List<EmptyBlockPos> EmptyNeedFill, List<EmptyBlockPos> EmptyNoFill, TraceEnrichTownTrace curGameBlock)
    {
        Array.Copy(GooseGypsySalad, SowGoose, GooseGypsySalad.Length);
        //修改放置物体的棋盘
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                if (EmptyNoFill != null)
                    foreach (EmptyBlockPos t in EmptyNoFill.Where(t => t.X == i && t.Y == j))
                    {
                        SowGoose[i, j] = 1;
                    }
            }
        }

        Array.Copy(SowGoose, OutwitGoose, SowGoose.Length);

        //方块组，
        for (int i = 0; i < curGameBlock.Block.Count; i++)
        {
            EraTraceLiter(curGameBlock.Block[i].shape);
            //位置
            for (int j = 0; j < 81; j++)
            {
                if (BisBriefOutwitTrace(TraceTell, j))
                {
                    //判断这次填充是否满足填充需要填充的位置
                    if (OutwitOnFeldsparStrict(EmptyNeedFill))
                    {
                        Debug.Log("id ==  " +curGameBlock.Block[i].id  +"      pos == " + j);
                        return curGameBlock.Block[i];
                    }
                    //没有满足，重置填充棋子
                    else
                    {
                        Array.Copy(SowGoose, OutwitGoose, SowGoose.Length);
                    }
                }
            }
        }
        Debug.LogError("1111111111111111111111111111111");
        return null;
    }

    private bool OutwitOnFeldsparStrict(List<EmptyBlockPos> EmptyNeedFill)
    {
        bool isComplete = true;
        for (int i = 0; i < EmptyNeedFill.Count; i++)
        {
            if (OutwitGoose[EmptyNeedFill[i].X, EmptyNeedFill[i].Y] == 0)
            {
                isComplete = false;
            }
        }
        return isComplete;
    }
[UnityEngine.Serialization.FormerlySerializedAs("BlockInfo")]    public int[,] TraceTell= new int[,]{
        {0,0,0,0},
        {0,0,0,0},
        {0,0,0,0},
        {0,0,0,0}
    };
[UnityEngine.Serialization.FormerlySerializedAs("BlockInfoTwo")]    
    public int[,] TraceTellPig= new int[,]{
        {0,0,0,0},
        {0,0,0,0},
        {0,0,0,0},
        {0,0,0,0}
    };
    private void EraTraceLiter(List<int> shape)
    {
        for (int i = 0; i < TraceTell.GetLength(0); i++)
        {
            for (int j = 0; j < TraceTell.GetLength(1); j++)
            {
                TraceTell[i, j] = shape[(3 - j)  * 4 + ( i)];
            }
        }
    }
    
    private void EraTraceLiterPig(List<int> shape)
    {
        for (int i = 0; i < TraceTellPig.GetLength(0); i++)
        {
            for (int j = 0; j < TraceTellPig.GetLength(1); j++)
            {
                TraceTellPig[i, j] = shape[(3 - j)  * 4 + ( i)];
            }
        }
    }
    
    Dictionary<GameObject, int> TineTrace= new Dictionary<GameObject, int>();
    public bool BisBriefOutwitTrace(int[,] blockGroup, int original)
    {
        bool isCanPlace = true;
        TineTrace.Clear();
        int x = original / 9;
        int y = original - (x * 9);
        for (int i = 0; i < blockGroup.GetLength(0); i++)
        {
            for (int j = 0; j < blockGroup.GetLength(1); j++)
            {
                //存在棋子在进行判断
                if (blockGroup[i, j] != 0)
                {
                    //没有超
                    if (x + i < 9 && y + j < 9)
                    {
                        //当前位置存放了方块
                        if (OutwitGoose[x + i, y + j] == 1)
                        {
                            isCanPlace = false;
                            return isCanPlace;
                        }
                        else
                        {
                            TineTrace.Add(GypsySaladTell[(x + i) * 9 + y + j], blockGroup[i, j]);
                        }
                    }
                    else
                    {
                        isCanPlace = false;
                        TineTrace.Clear();
                        return isCanPlace;
                    }
                }
            }
        }
        
        //可以放置
        foreach (var VARIABLE in TineTrace)
        {
            var block = VARIABLE.Key.transform.GetChild(0).GetComponent<TraceEnrichTraceRender>(); 
            OutwitGoose[block.X, block.Y] = 1;
        }
        return isCanPlace;
    }
[UnityEngine.Serialization.FormerlySerializedAs("FillingBlockDic")]
  #endregion
    
    
    #region 填充逻辑判断第二版
    
    public Dictionary<int, List<FillFourToFour>> DolphinTraceJaw= new Dictionary<int, List<FillFourToFour>>();
[UnityEngine.Serialization.FormerlySerializedAs("TotalFillFourToFour")]    public List<FillFourToFour> GooseFillAfarIDAfar= new List<FillFourToFour>(36);
    public void FiberEraSustainTrace()
    {
        int smallArraySize = 4; // 小数组的尺寸
        GooseFillAfarIDAfar.Clear();
        DolphinTraceJaw.Clear();
        PickTraceLiter.Clear();
        // 遍历大数组，步长为小数组的尺寸
        for (int i = 0; i < GooseGypsySalad.GetLength(0) - 3; i += 1)
        {
            for (int j = 0; j < GooseGypsySalad.GetLength(1) - 3; j += 1)
            {
                // 创建小数组
                int[,] smallArray = new int[smallArraySize, smallArraySize];

                // 遍历小数组内的元素
                for (int si = 0; si < smallArraySize; si++)
                {
                    for (int sj = 0; sj < smallArraySize; sj++)
                    {
                        // 计算当前元素在大数组中的位置
                        int bigArrayI = i + si;
                        int bigArrayJ = j + sj;

                        // 检查是否越界
                        if (bigArrayI < GooseGypsySalad.GetLength(0) && bigArrayJ < GooseGypsySalad.GetLength(1))
                        {
                            smallArray[si, sj] = GooseGypsySalad[bigArrayI, bigArrayJ];
                        }
                        else
                        {
                            smallArray[si, sj] = 0; // 或者其它你想要的默认值
                        }
                    }
                }
                //TotalFillFourToFour.Add(new FillFourToFour(){X = i,Y = j, smallArray = smallArray});
                // 这里你可以处理小数组，例如打印出来或进行其他操作
                OutwitChaosTrace(smallArray, i,j);
            }
        }

        /*foreach (var VARIABLE in FillingBlockDic)
        {
            Debug.LogError("key == " + VARIABLE.Key + "     value == " + VARIABLE.Value.Count);
            for (int i = 0; i < VARIABLE.Value.Count; i++)
            {
                Debug.LogError("VARIABLE.Value.Count == " + VARIABLE.Value[i].X + "     y == " + VARIABLE.Value[i].Y);
            }
        }*/
    }

    
    /// <summary>
    /// 判断这个小的4*4是否满足填充初步逻辑
    /// </summary>
    /// <param name="smallArray"></param>
    /// <param name="horizontalStart"></param>
    /// <param name="verticalStart"></param>
    private void OutwitChaosTrace(int[,] smallArray, int horizontalStart, int verticalStart)
    {
        int emptyCount = 0;
        for (int i = 0; i < smallArray.GetLength(0); i++)
        {
            for (int j = 0; j < smallArray.GetLength(1); j++)
            {
                if (smallArray[i, j] == 0)
                {
                    emptyCount++;
                }
            }
        }
        //Debug.LogError("1 == " + horizontalStart + "    2 == " + verticalStart + "     3 == " + emptyCount);
        if (emptyCount is <= 6 and > 0)
        {
            if (!DolphinTraceJaw.ContainsKey(emptyCount))
            { 
                DolphinTraceJaw.Add(emptyCount, new List<FillFourToFour>(){
                    new (){
                        X = horizontalStart,
                        Y = verticalStart,
                        ChiefFatal = smallArray
                    }
                });
            }
            else
            {
                var value = DolphinTraceJaw[emptyCount];
                value.Add(new FillFourToFour(){X = horizontalStart,Y = verticalStart, ChiefFatal = smallArray});
                DolphinTraceJaw[emptyCount] = value;
            }
            
        }

        

        //IsCanOneBlockPlace();
    }


    public void EraPickTraceLiter()
    {
        FiberEraSustainTrace();

        var oneBlockFill = OnBisOftTraceBrief();
        if (oneBlockFill)
        {
            var twoBlockFill = OnBisOftTraceBrief();
            if (twoBlockFill)
            {
                //Debug.LogError("两个1个方块组完成两个4*4");
            }
            else
            {
                var tes = OnBisPigTraceBrief();
            }
        }
        else
        {
            //Debug.LogError("1123123123 个方块填充4*4");
            var tes = OnBisPigTraceBrief();
        }
    }
    
    (BlockItem, BlockItem) WeTestTrace= (null, null);
[UnityEngine.Serialization.FormerlySerializedAs("FillBlockGroup")]
    public Dictionary<FillFourToFour, (BlockItem, BlockItem)> PickTraceLiter= new();
    private bool OnBisOftTraceBrief()
    {
        bool isCanPlace = false;
        WeTestTrace = (null, null);
        for (int i = 6; i > 0; i--)
        {
            if (DolphinTraceJaw.ContainsKey(i))
            {
                //满足空格子1到6的4*4
                for (int j = 0; j < DolphinTraceJaw[i].Count; j++)
                {
                    if (!PickTraceLiter.ContainsKey(DolphinTraceJaw[i][j]))
                    {
                        WeTestTrace = (EraPickTraceLiterPig(i, DolphinTraceJaw[i][j], TraceEnrichTraceWorship.Instance.OutwitTrace), null);
                        //返回null，没有满足的，继续遍历查找
                        if (WeTestTrace.Item1 != null)
                        {
                            PickTraceLiter.Add(DolphinTraceJaw[i][j], WeTestTrace);
                            isCanPlace = true;
                            return isCanPlace;
                        }
                    }
                }
            }
        }
        return isCanPlace;
    }

    private bool OnBisPigTraceBrief()
    {
        bool isCanPlace = false; 
        WeTestTrace = (null, null);
        for (int i = 6; i > 0; i--)
        {
            if (DolphinTraceJaw.ContainsKey(i))
            {
                for (int j = 0; j < DolphinTraceJaw[i].Count; j++)
                {
                    if (!PickTraceLiter.ContainsKey(DolphinTraceJaw[i][j]))
                    {
                        WeTestTrace = EraPickPigTraceLiter(i, DolphinTraceJaw[i][j], TraceEnrichTraceWorship.Instance.OutwitTrace);
                        if (WeTestTrace.Item1 != null)
                        {
                            PickTraceLiter.Add(DolphinTraceJaw[i][j], WeTestTrace);
                            isCanPlace = true;
                            return isCanPlace;
                        }
                    }
                }
            }
        }
        return isCanPlace;
    }
    
    int[,] SowGoosePig= new int[4,4];
    int[,] OutwitGoosePig=  new int[4,4];
    public BlockItem EraPickTraceLiterPig(int emptyCount, FillFourToFour fillFourToFour, TraceEnrichTownTrace curGameBlock)
    {
        Array.Copy(fillFourToFour.ChiefFatal, SowGoosePig, fillFourToFour.ChiefFatal.Length);
        Array.Copy(SowGoosePig, OutwitGoosePig, SowGoosePig.Length);

        //方块组
        for (int i = 0; i < curGameBlock.Block.Count; i++)
        {
            if (curGameBlock.Block[i].count == emptyCount)
            {
                EraTraceLiter(curGameBlock.Block[i].shape);
                
                //位置
                for (int j = 0; j < 16; j++)
                {
                    if (BisBriefOutwitTracePig(TraceTell, j, fillFourToFour))
                    {
                        return curGameBlock.Block[i];
                    }
                    else
                    {
                        Array.Copy(SowGoosePig, OutwitGoosePig, SowGoosePig.Length);
                    }
                }
            }
        }
        return null;
    }
    
    public bool BisBriefOutwitTracePig(int[,] blockGroup, int original, FillFourToFour fillFourToFour)
    {
        bool isCanPlace = true;
        int x = original / 4;
        int y = original - (x * 4);
        for (int i = 0; i < blockGroup.GetLength(0); i++)
        {
            for (int j = 0; j < blockGroup.GetLength(1); j++)
            {
                //存在棋子在进行判断
                if (blockGroup[i, j] != 0)
                {
                    //没有超
                    if (x + i < 4 && y + j < 4)
                    {
                        //当前位置存放了方块 4*4
                        if (OutwitGoosePig[x + i, y + j] == 1)
                        {
                            isCanPlace = false;
                            return isCanPlace;
                        }
                    }
                    else
                    {
                        isCanPlace = false;
                        return isCanPlace;
                    }
                }
            }
        }
        
        return isCanPlace;
    }

    public (BlockItem,BlockItem) EraPickPigTraceLiter(int emptyCount, FillFourToFour fillFourToFour, TraceEnrichTownTrace curGameBlock)
    {
        Array.Copy(fillFourToFour.ChiefFatal, SowGoosePig, fillFourToFour.ChiefFatal.Length);
        Array.Copy(SowGoosePig, OutwitGoosePig, SowGoosePig.Length);
        for (int i = 0; i < curGameBlock.Block.Count; i++)
        {
            if (curGameBlock.Block[i].count < emptyCount)
            {
                for (int j = 0; j < 16; j++)
                {
                    Array.Copy(SowGoosePig, OutwitGoosePig, SowGoosePig.Length);
                    EraTraceLiter(curGameBlock.Block[i].shape);
                    if (BisBriefOutwitOftTrace(TraceTell, j, fillFourToFour))
                    {
                        for (int k = 0; k < curGameBlock.Block.Count; k++)
                        {
                            if (curGameBlock.Block[k].count == emptyCount - curGameBlock.Block[i].count)
                            {
                                for (int l = 0; l < 16; l++)
                                {
                                    EraTraceLiterPig(curGameBlock.Block[k].shape);
                                    if (BisBriefOutwitTracePig(TraceTellPig, l, fillFourToFour))
                                    {
                                        return (curGameBlock.Block[i], curGameBlock.Block[k]);
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        
                    }
                }
            }
        }
        
        return (null, null);
    }
    
    public bool BisBriefOutwitOftTrace(int[,] blockGroup, int original, FillFourToFour fillFourToFour)
    {
        bool isCanPlace = true;
        int x = original / 4;
        int y = original - (x * 4);
        for (int i = 0; i < blockGroup.GetLength(0); i++)
        {
            for (int j = 0; j < blockGroup.GetLength(1); j++)
            {
                //存在棋子在进行判断
                if (blockGroup[i, j] != 0)
                {
                    //没有超
                    if (x + i < 4 && y + j < 4)
                    {
                        //当前位置存放了方块 4*4
                        if (OutwitGoosePig[x + i, y + j] == 1)
                        {
                            isCanPlace = false;
                            return isCanPlace;
                        }
                    }
                    else
                    {
                        isCanPlace = false;
                        return isCanPlace;
                    }
                }
            }
        }
        
        
        for (int i = 0; i < blockGroup.GetLength(0); i++)
        {
            for (int j = 0; j < blockGroup.GetLength(1); j++)
            {
                //存在棋子在进行判断
                if (blockGroup[i, j] == 0)
                    continue;
                //没有超
                if (x + i >= 4 || y + j >= 4)
                    continue;
                //当前位置存放了方块 4*4
                if (OutwitGoosePig[x + i, y + j] != 1)
                {
                    OutwitGoosePig[x + i, y + j] = 1;
                }
            }
        }
        return isCanPlace;
    }

  #endregion
    
    public void EraSquashObvious()
    {
        TraceEnrichTownLifelong.Instance.WeTestDormantWrap = false;
        TraceEnrichTownLifelong.Instance.WeTestPerch = false; 
        TraceEnrichTownLifelong.Instance.WeTestAthens = false;
        if (!OliverFlaw.OnCycle() && FailWiseWorship.EraWit(CBarter.My_SolidTownBulb) == 99)
        {
            for (int i = 0; i < LiraBlameSum.Count; i++)
            {
                //暂定刮刮卡
                if (LiraBlameSum[i].transform.GetChild(0).GetComponent<TraceEnrichTraceRender>().Type == 99)
                {
                    TraceEnrichTownLifelong.Instance.WeTestDormantWrap = true;
                    FailWiseWorship.FatWit(CBarter.My_GlassDormantWrap, 0);
                    break;
                } 
            }
            //刮刮卡奖励
            TraceEnrichAnewWorship.instance.BoxPerchFur();
        }
        if (FailWiseWorship.EraWit(CBarter.My_SolidTownBulb) == 99)
        {
            //分数奖励
            TraceEnrichAthensWorship.Instance.BoxAthens(OutwitTineTrace.Count, BlameTraceLiterCajun);
        }
        else
        {
            //分数奖励
            if (OliverFlaw.OnCycle())
            {
                TraceEnrichAthensWorship.Instance.BoxSolidAthens(OutwitTineTrace.Count, BlameTraceLiterCajun);
            }
        }
        
        TraceEnrichTownLifelong.Instance.OutwitBlameTraceBadly?.Invoke();
    }

    List<TraceEnrichTraceRender> PerStrict= new List<TraceEnrichTraceRender>();
    /// <summary>
    /// 目标方块飞行
    /// </summary>
    public void PerStrictTrace()
    {
        PerStrict.Clear();
        AnemoneEncaseFiber.EraChlorine().Rich(CBarter.Of_HyperUI);
        
        StartCoroutine(SureRisk(0.1f, () =>
        {
            float Time = 0;
            var list = TownDelta.Instance.TraceSP.Select(t => t.gameObject).Where(Item => Item.GetComponent<TraceEnrichTraceRender>().Type != 99).ToList();
            for (int k = 0; k < list.Count; k++)
            {
                int a = k;
                Time += 0.1f;
                GameObject Item = list[k].gameObject;
                Item.transform.GetChild(0).GetComponent<Image>().sprite = TownDelta.Instance.StrictPity[Item.GetComponent<TraceEnrichTraceRender>().Type - 2].GetComponent<Image>().sprite;
                Sequence mySequence = DOTween.Sequence();

                // 加入缩放动画
                //mySequence.Append(Item.transform.DOScale(1.5f, 0.3f).SetEase(Ease.OutSine))
                //    .Append(Item.transform.DOScale(1.2f, 0.2f).SetEase(Ease.OutSine));


                // 创建随机移动方向的向量
                Vector3 randomMove1 = new Vector3(Random.Range(-0.55f, 0.55f) + Item.transform.position.x, Random.Range(-0.55f, 0.55f) + Item.transform.position.y,
                     +Item.transform.position.z);
                Vector3 randomMove2 = new Vector3(Random.Range(-0.4f, 0.4f) + randomMove1.x, Random.Range(-0.4f, 0f) + randomMove1.y, randomMove1.z);

                // 加入移动动作
                mySequence.Insert(0, Item.transform.DOMove(randomMove1, 0.2f).SetEase(Ease.OutSine));
                //.Append(Item.transform.DOMove(randomMove2, 0.2f).SetEase(Ease.OutSine));

                // 随机旋转角度向量
                Vector3 rotateValue = new Vector3(0, 0, Random.Range(-10f, 10f));

                // 加入旋转动作
                mySequence.Insert(0, Item.transform.DORotate(rotateValue, 0.2f).SetEase(Ease.OutSine));



                mySequence.Insert(0.2f, Item.transform.DOMove(TownDelta.Instance.StrictPity[Item.GetComponent<TraceEnrichTraceRender>().Type - 2].transform.position, 0.6f).SetEase(Ease.InQuint).SetDelay(Time).OnComplete(() =>
                {
                    Item.GetComponent<TraceEnrichTraceRender>().BlameTrace();
                    StartCoroutine(SureRisk(3, () =>
                    {
                        Destroy(Item);
                    }));
                    if (a == k - 1)
                        TraceEnrichTownLifelong.Instance.StrictTracePer?.Invoke();
                })).OnStart((() =>
                {
                    //Item.GetComponent<TraceEnrichTraceRender>().ShowFlyEffect();
                }));
                mySequence.Insert(0.2f, Item.transform.DOScale(0.9f, 0.5f).SetDelay(Time).SetEase(Ease.InBack));
                mySequence.Insert(0.2f, Item.transform.DORotate(new Vector3(0, 0, 0), 0.5f).SetEase(Ease.OutSine).SetDelay(Time));
                // 启动整个动画序列
                mySequence.Play();
            }
        }));

        
        foreach (TraceEnrichTraceRender block in LiraBlameSum.Select(t => t.transform.GetChild(0).GetComponent<TraceEnrichTraceRender>()).Where(block => block.Type != 0 && block.Type != 1 && block.Type != 99))
        {
            PerStrict.Add(block);
        }
        
        if (PerStrict.Count == 0)
        {
            TraceEnrichTownLifelong.Instance.StrictTracePer?.Invoke();
        }
        else
        {
            /*for (int i = 0; i < FlyTarget.Count; i++)
            {
                FlyTarget[i].ClearBlock();
            }
            
            //finish
            TraceEnrichTownLifelong.Instance.TargetBlockFly?.Invoke();*/
        }
        
        
    }


    private void TenonFurProclaimOutwit()
    {
        GameObject panel = null;
        if (FailWiseWorship.EraWit(CBarter.My_SolidTownBulb) == 99)
            panel = TownDelta.Instance.gameObject;
        else
            panel = TownSolidDelta.Instance.gameObject;

        TuneTenonOvert(TraceEnrichAthensWorship.Instance.EraTenon() >= 3);
        // 没有消除
        if (BlameTraceLiterCajun == 0)
        {
            //BlockPuzzleGamePanel.Instance.ShowSourceItem(new Vector2(0,0),SourceShowPos, true);
        }
        //消除一组
        else if (BlameTraceLiterCajun == 1)
        {
            //TraceEnrichAnewWorship.instance.TapPopVibrate();
            if (TraceEnrichAthensWorship.Instance.EraTenon() > 1)
            {
                if (FailWiseWorship.EraWit(CBarter.My_SolidTownBulb) == 99)
                    TownDelta.Instance.TenonTunePin(TraceEnrichAthensWorship.Instance.EraTenon(), FareTuneDay.position, true);
            }
            else
            {
                if (FailWiseWorship.EraWit(CBarter.My_SolidTownBulb) == 99)
                    TownDelta.Instance.TenonTunePin(TraceEnrichAthensWorship.Instance.EraTenon(), FareTuneDay.position, false);
            }
            //震动
            if (TraceEnrichAthensWorship.Instance.EraTenon() >= 3)
                ShakeMantleDay();
        }
        //多组
        else
        {
            //TraceEnrichAnewWorship.instance.TapPopVibrate();
            if (TraceEnrichAthensWorship.Instance.EraTenon() > 1)
            {
                if (FailWiseWorship.EraWit(CBarter.My_SolidTownBulb) == 99)
                    TownDelta.Instance.TenonTunePin(TraceEnrichAthensWorship.Instance.EraTenon(), FareTuneDay.position, true);
                //震动
                if (TraceEnrichAthensWorship.Instance.EraTenon() >= 3)
                    ShakeMantleDay();

                StartCoroutine(SureRisk(1.2f, () =>
                {
                    TuneBikeBlame();
                }));
            }
            else
            {
                ShakeMantleDay();
                if (FailWiseWorship.EraWit(CBarter.My_SolidTownBulb) == 99)
                    TownDelta.Instance.TuneAthensPack(new Vector2(0, 0), AthensTuneDay, true);
                AgreeOwn.EraChlorine().LuceEscape(AgreeFirm.UIMusic.Sound_Multipleclean);
                TuneBikeBlame();
            }
        }
    }
[UnityEngine.Serialization.FormerlySerializedAs("duration")]    public float Innocent= 0.5f; // 震动持续的时间
[UnityEngine.Serialization.FormerlySerializedAs("strength")]    public float Internet= 10f; // 震动的强度，数值越大震动越明显
[UnityEngine.Serialization.FormerlySerializedAs("vibrato")]    public int Battery= 10; // 震动的次数
[UnityEngine.Serialization.FormerlySerializedAs("randomness")]    public float Impregnate= 90f; // 震动的随机性
    private void ShakeMantleDay()
    {
        RectTransform ani = FailWiseWorship.EraWit(CBarter.My_SolidTownBulb) == 99 ?
            TownDelta.Instance.gameObject.GetComponent<RectTransform>() :
            TownSolidDelta.Instance.gameObject.GetComponent<RectTransform>();
        ani.DOShakeAnchorPos(Innocent, Internet, Battery, Impregnate, false, false);
    }

    public void TuneTenonOvert(bool isShow)
    {
        SkeletonGraphic ani = FailWiseWorship.EraWit(CBarter.My_SolidTownBulb) == 99 ?
            TownDelta.Instance.TenonOvert.GetComponent<SkeletonGraphic>() :
            TownSolidDelta.Instance.TenonOvert.GetComponent<SkeletonGraphic>();
        if (isShow)
        {
            //显示中
            if (!ani.gameObject.activeSelf)
            {
                //ani.gameObject.SetActive(true);
                //ani.AnimationState.SetAnimation(0, "animation", true);
            }
        }
        else
        {
            ani.gameObject.SetActive(false);
        }

    }

    private void TuneBikeBlame()
    {
        Vector3 pos = FareTuneDay.position;

        if (pos.x > 0.7f)
        {
            pos = new Vector3(0.7f, pos.y, pos.z);
        }
        if (pos.x < -0.7f)
        {
            pos = new Vector3(-0.7f, pos.y, pos.z);
        }
        if (pos.y > 0.8f)
        {
            pos = new Vector3(pos.x, 0.8f, pos.z);
        }
        if (pos.y < -0.8f)
        {
            pos = new Vector3(pos.x, -0.8f, pos.z);
        }


        SkeletonGraphic ani = FailWiseWorship.EraWit(CBarter.My_SolidTownBulb) == 99 ?
            TownDelta.Instance.BikeBlame.GetComponent<SkeletonGraphic>() :
            TownSolidDelta.Instance.BikeBlame.GetComponent<SkeletonGraphic>();
        ani.transform.position = pos;
        switch (BlameTraceLiterCajun)
        {
            case 2:
                ani.AnimationState.SetAnimation(0, "good", false);
                AgreeOwn.EraChlorine().LuceEscape(AgreeFirm.UIMusic.Sound_Good);
                break;
            case 3:
                ani.AnimationState.SetAnimation(0, "shake", false);
                AgreeOwn.EraChlorine().LuceEscape(AgreeFirm.UIMusic.Sound_Amazing);
                break;
            case 4:
                ani.AnimationState.SetAnimation(0, "brain", false);
                AgreeOwn.EraChlorine().LuceEscape(AgreeFirm.UIMusic.Sound_Excellent);
                break;
            default:
                ani.AnimationState.SetAnimation(0, "cruch", false);
                AgreeOwn.EraChlorine().LuceEscape(AgreeFirm.UIMusic.Sound_Great);
                break;
        }
    }
    private int EraFareDay()
    {
        var x = FareTuneDay.transform.GetChild(0).GetComponent<TraceEnrichTraceRender>().X;
        var y = FareTuneDay.transform.GetChild(0).GetComponent<TraceEnrichTraceRender>().Y;
        switch (x)
        {
            case < 3 when y < 3:
                return 1;
            case < 3 when y < 6:
                return 2;
            case < 3:
                return 3;
            case < 6 when y < 3:
                return 4;
            case < 6 when y < 6:
                return 5;
            case < 6:
                return 6;
            default:
                {
                    if (y < 3)
                        return 7;
                    else if (y < 6)
                        return 8;
                    else
                        return 9;
                }
        }
    }
[UnityEngine.Serialization.FormerlySerializedAs("FailedBlock")]
    //棋盘中放置的棋子
    public List<GameObject> DampenTrace= new List<GameObject>();
    public void AbsenceDampenSalad()
    {
        DampenTrace.Clear();
        for (int i = 0; i < GypsySaladTell.Count; i++)
        {
            if (GooseGypsySalad[i / 9, i % 9] == 1)
            {
                DampenTrace.Add(GypsySaladTell[i]);
            }
        }
    }
    
    /// <summary>
    /// 关卡完成动画
    /// </summary>
    /// <param name="cb"></param>
    public void TuneSawPin(Action cb)
    {
        StartCoroutine(TuneSawPinHear(cb));
    }

    private IEnumerator TuneSawPinHear(Action cb)
    {
        TownDelta.Instance.BylawOvert.AnimationState.SetAnimation(0, "Action", true);
        //TownDelta.Instance.BonusSpine.gameObject.SetActive(true);
        GameObject GypsySaladLiter= TownDelta.Instance.GypsySaladLiter;
        BlockColor color = FailWiseWorship.EraWit(CBarter.My_SolidTownBulb) == 99 ? (BlockColor)Random.Range(0, 5) : BlockColor.Red;
        for (int i = 0; i < GypsySaladLiter.transform.childCount; i++)
        {
            GypsySaladLiter.transform.GetChild(i).transform.GetChild(0).GetComponent<TraceEnrichTraceRender>().Rake(i / 9, i % 9, 1, color);
            GypsySaladLiter.transform.GetChild(i).transform.localScale = new Vector3(0, 0, 0);
            GypsySaladLiter.transform.GetChild(i).transform.DOScale(1, 0.3f).SetEase(Ease.OutBack).SetDelay(GypsySaladLiter.transform.GetChild(i).transform.GetChild(0).GetComponent<TraceEnrichTraceRender>().Y * 0.1f);
        }

        TownDelta.Instance.Correct.SetActive(true);
        TownDelta.Instance.Correct.GetComponent<Correct>().VillageTune();
        yield return new WaitForSeconds(1);
        //CheckBoardGroup 方块父级的父级        
        for (int i = 8; i >= 0; i--)
        {
            for (int j = 0; j < 9; j++)
            {
                //StartCoroutine(FossilizeInsatiable.LevelOver(CheckBoardGroup.transform.GetChild(i + j * 9).transform, 1 - i * 0.1f, true));
                StartCoroutine(FossilizeInsatiable.ParisRing(GypsySaladLiter.transform.GetChild(i + j * 9).transform, 1 - i * 0.1f));
            }
        }

        for (int i = 0; i < GypsySaladLiter.transform.childCount; i++)
        {
            StartCoroutine(FossilizeInsatiable.RingBlamePin(GypsySaladLiter.transform.GetChild(i).transform.GetChild(0).gameObject, 1 - (GypsySaladLiter.transform.GetChild(i).transform.GetChild(0).GetComponent<TraceEnrichTraceRender>().Y * 0.1f), () =>
            {
                //CheckBoardGroup.transform.GetChild(i).transform.GetChild(0).GetComponent<TraceEnrichTraceRender>().ShowImage(0);
            }));
        }
        for (int i = 0; i < 9; i++)
        {
            AgreeOwn.EraChlorine().LuceEscape(AgreeFirm.UIMusic.Sound_Clear);
            yield return new WaitForSeconds(0.1f);
        }
        yield return new WaitForSeconds(4);
        TownDelta.Instance.BylawOvert.AnimationState.SetEmptyAnimation(0, 0);
        //TownDelta.Instance.BonusSpine.gameObject.SetActive(false);
        cb?.Invoke();
    }
    
}

public class EmptyBlockPos
{
    public int X;
    public int Y;
}

public class FillFourToFour
{
    public int X{ get; set; }
    public int Y{ get; set; }
    public int[,] ChiefFatal{ get; set; }
}
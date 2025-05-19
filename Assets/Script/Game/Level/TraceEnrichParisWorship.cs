using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using LitJson;
using UnityEngine;
using Random = UnityEngine.Random;

public class TraceEnrichParisWorship : MonoBehaviour
{
    public static TraceEnrichParisWorship Instance;
[UnityEngine.Serialization.FormerlySerializedAs("levelInfoData")]
    public TraceEnrichParisTellWise WholeTellWise;
[UnityEngine.Serialization.FormerlySerializedAs("totalBlockToCheckBoard")]    public TotalBlockToCheckBoard PrintTraceIDGypsySalad;
[UnityEngine.Serialization.FormerlySerializedAs("totalBlockThree")]    public TotalBlockThree PrintTraceTrack;
    void Awake()
    {
        Instance = this;
        RakeParisTell();

    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void RakeParisTell()
    {
        TextAsset Hand= Resources.Load<TextAsset>("LocationJson/LevelData");
        WholeTellWise = JsonMapper.ToObject<TraceEnrichParisTellWise>(Hand.text);
        Hand = Resources.Load<TextAsset>("LocationJson/ThreeToThreeData");
        PrintTraceTrack = JsonMapper.ToObject<TotalBlockThree>(Hand.text);
        Hand = Resources.Load<TextAsset>("LocationJson/BlockToCheckBoardData");
        PrintTraceIDGypsySalad = JsonMapper.ToObject<TotalBlockToCheckBoard>(Hand.text);
    }


    public int EraLawParis()
    {
        return FailWiseWorship.EraWit(CBarter.My_ParisSo);
    }

    public void BoxParis()
    {
        var level = FailWiseWorship.EraWit(CBarter.My_ParisSo);
        level++;
        FailWiseWorship.FatWit(CBarter.My_ParisSo, level);
        ADManager.Instance.UpdateTrialNum(level);
        TraceEnrichTributeWorship.instance.OutwitFeldsparTributeBadly();
        Debug.Log("LevelId Add:" + FailWiseWorship.EraWit(CBarter.My_ParisSo));
    }
[UnityEngine.Serialization.FormerlySerializedAs("CurLevelInfo")]
    public List<int> LawParisTell= new List<int>();
    public void EraLawParisTell()
    {
        FailWiseWorship.FatKnow(CBarter.My_OnFanner, false);
        if (FailWiseWorship.EraThrive(CBarter.My_LawTownDrum) == "challenge")
        {
            TextAsset Hand= Resources.Load<TextAsset>("LocationJson/BlockToCheckBoardData");
            PrintTraceIDGypsySalad = JsonMapper.ToObject<TotalBlockToCheckBoard>(Hand.text);
            if (WholeTellWise.ParisWise.Count >= EraLawParis() + 1)
            {
                LawParisTell.Clear();
                foreach (BlockToCheckBoard t in PrintTraceIDGypsySalad.BlockToCheckBoards.Where(t => WholeTellWise.ParisWise[EraLawParis()].Route == t.Id))
                {
                    LawParisTell = PityThriveIDPityWit(t.OnceBlockInfo);
                }
                if (LawParisTell.Count == 0)
                {
                    LawParisTell = EraRetoolPity();
                }
            }
            else
            {
                for (int i = 1; i <= EraLawParis() + 1; i++)
                {
                    if (WholeTellWise.ParisWise.Count >= i)
                    {

                    }
                    else
                    {
                        if (i == EraLawParis() + 1)
                        {
                            AbsenceSowStrict();
                            WholeTellWise.ParisWise.Add(new LevelData(){
                                It = "", Barter = "", Route = -1, Logger = _Logger,
                                Logger_North = _Logger_North, Carol = "", Incinerate = 0
                            });
                        }
                        else
                        {
                            WholeTellWise.ParisWise.Add(new LevelData(){
                                It = "", Carol = "", Incinerate = 0, Route = -1,
                                Barter = "", Logger = "", Logger_North = ""
                            });
                        }
                    }
                }
                LawParisTell = EraRetoolPity();
            }
        }
        else if (FailWiseWorship.EraThrive(CBarter.My_LawTownDrum) == "Guide")
        {
            TextAsset Hand= Resources.Load<TextAsset>("LocationJson/GuideBlockToCheckBoardData");
            PrintTraceIDGypsySalad = JsonMapper.ToObject<TotalBlockToCheckBoard>(Hand.text);
            LawParisTell.Clear();
            foreach (BlockToCheckBoard t in PrintTraceIDGypsySalad.BlockToCheckBoards.Where(t => FailWiseWorship.EraWit(CBarter.My_SolidTownBulb) == t.Id))
            {
                LawParisTell = PityThriveIDPityWit(t.OnceBlockInfo);
            }
        }
        else
        {
            LawParisTell = new List<int>();
            for (int i = 0; i < 81; i++)
            {
                LawParisTell.Add(0);
            }
        }
    }

    int[] PrintStrictPity= new int[]{
        2, 3, 4, 5, 6
    };
    List<int> LoggerPity= new List<int>();
    List<int> LoggerCajun= new List<int>();

    string _Logger= "";
    string _Logger_North= "";
    private void AbsenceSowStrict()
    {
        _Logger = "";
        _Logger_North = "";
        LoggerPity.Clear();
        LoggerCajun.Clear();
        var totaltargetCount = Random.Range(1, 4);
        PrintStrictPity = TraceEnrichAnewWorship.instance.RetoolWit(PrintStrictPity);

        for (int i = 0; i < totaltargetCount; i++)
        {
            LoggerPity.Add(PrintStrictPity[i]);
            switch (totaltargetCount)
            {
                case 1:
                    LoggerCajun.Add(Mathf.CeilToInt((15 + EraLawParis() / 10) * (1 + Random.Range(-0.1f, 0.1f))));
                    break;
                case 2:
                    LoggerCajun.Add(Mathf.CeilToInt((10 + EraLawParis() / 12) * (1 + Random.Range(-0.1f, 0.1f))));
                    break;
                case 3:
                    LoggerCajun.Add(Mathf.CeilToInt((7 + EraLawParis() / 20) * (1 + Random.Range(-0.1f, 0.1f))));
                    break;
            }
        }
        _Logger = String.Join("#", LoggerPity);
        _Logger_North = String.Join("#", LoggerCajun);
    }
    int[] Reliable= new int[]{
        1, 2, 3, 4, 5, 6, 7, 8, 9
    };
    private List<int> EraRetoolPity()
    {
        Reliable = TraceEnrichAnewWorship.instance.RetoolWit(Reliable);
        var showCount = Random.Range(2, 6);
        GypsySaladTellKnap.Clear();
        for (int i = 0; i < 81; i++)
        {
            GypsySaladTellKnap.Add(0);
        }
        for (int i = 0; i < Reliable.Length; i++)
        {
            if (Reliable[i] < showCount)
            {
                var Wish= EraTrack();
                AbsenceGypsySalad(i, Wish);
            }
            else
            {

            }
        }
        /*for (int i = 0; i < targetList.Count; i++)
        {
            Debug.Log("i == "+ i +"   targetList == " + targetList[i]);
        }*/
        return GypsySaladTellKnap;
    }
[UnityEngine.Serialization.FormerlySerializedAs("CheckBoardInfoInts")]
    public List<int> GypsySaladTellKnap= new List<int>(81);
    private void AbsenceGypsySalad(int index, ThreeToThree three)
    {

        int startRwo = 0;
        int startCol = 0;
        switch (index)
        {
            case 0:
                startRwo = 0;
                startCol = 0;
                break;
            case 1:
                startRwo = 0;
                startCol = 3;
                break;
            case 2:
                startRwo = 0;
                startCol = 6;
                break;
            case 3:
                startRwo = 3;
                startCol = 0;
                break;
            case 4:
                startRwo = 3;
                startCol = 3;
                break;
            case 5:
                startRwo = 3;
                startCol = 6;
                break;
            case 6:
                startRwo = 6;
                startCol = 0;
                break;
            case 7:
                startRwo = 6;
                startCol = 3;
                break;
            case 8:
                startRwo = 6;
                startCol = 6;
                break;
        }

        for (int i = startRwo; i < startRwo + 3; i++)
        {
            for (int j = startCol; j < startCol + 3; j++)
            {
                if (three == null)
                {
                    GypsySaladTellKnap[j + i * 9] = 0;
                }
                else
                {
                    //Debug.LogError("i == "+ i +"    j == "+ j + "    3 == " + ((2 - (j - startCol)) * 3 + (i - startRwo)) +"    4== " + (j + i * 9));

                    if (three.layout[(2 - (j - startCol)) * 3 + (i - startRwo)] == 2)
                    {
                        //int value = CurSelectTarget[InputValue / 10];
                        GypsySaladTellKnap[j + i * 9] = LoggerPity[Random.Range(0, LoggerPity.Count)];
                    }
                    else
                    {
                        GypsySaladTellKnap[j + i * 9] = three.layout[(2 - (j - startCol)) * 3 + (i - startRwo)];
                    }
                }
            }
        }

    }

    private ThreeToThree EraTrack()
    {
        int sum = 0;
        for (int i = 0; i < PrintTraceTrack.ThreeToThree.Count; i++)
        {
            sum += PrintTraceTrack.ThreeToThree[i].weight;
        }
        int rewardRandom = Random.Range(0, 999);

        float Shun= 0;
        for (int i = 0; i < PrintTraceTrack.ThreeToThree.Count; i++)
        {
            Shun += PrintTraceTrack.ThreeToThree[i].weight / (float)sum;
            if (rewardRandom <= Shun * 1000)
            {
                return PrintTraceTrack.ThreeToThree[i];
            }
        }
        return PrintTraceTrack.ThreeToThree[0];
    }

    /// <summary>
    /// 转置
    /// </summary>
    /// <param name="ints"></param>
    /// <returns></returns>
    public List<string> PityWitIDPityThrive(List<int> ints)
    {
        RollToolIDAward(ints);
        return ParishPitySickPrimacy(ints, 9);
    }

    public List<int> PityThriveIDPityWit(List<string> list)
    {
        List<int> allNumbers = new List<int>();
        foreach (string section in list)
        {
            allNumbers.AddRange(VentureThriveIDPity(section));
        }
        LendToolIDFend(allNumbers);
        return allNumbers;
    }

    private int Just= 9;
    private void RollToolIDAward(List<int> ints)
    {
        for (int layer = 0; layer < Just / 2; layer++)
        {
            int first = layer;
            int last = Just - 1 - layer;
            for (int i = first; i < last; i++)
            {
                int offset = i - first;
                // 保存顶部的值
                int top = ints[first * Just + i];
                // 右边的值到顶部
                ints[first * Just + i] = ints[i * Just + last];
                // 底部的值到右边
                ints[i * Just + last] = ints[last * Just + (last - offset)];
                // 左边的值到底部
                ints[last * Just + (last - offset)] = ints[(last - offset) * Just + first];
                // 顶部的值到左边
                ints[(last - offset) * Just + first] = top;
            }
        }
    }

    // 定义滚动函数
    private void LendToolIDFend(List<int> ints)
    {
        for (int layer = 0; layer < Just / 2; layer++)
        {
            int first = layer;
            int last = Just - 1 - layer;
            for (int i = first; i < last; i++)
            {
                int offset = i - first;
                // 保存顶部的值
                int top = ints[first * Just + i];
                // 左边的值到顶部
                ints[first * Just + i] = ints[(last - offset) * Just + first];
                // 底部的值到左边
                ints[(last - offset) * Just + first] = ints[last * Just + (last - offset)];
                // 右边的值到底部
                ints[last * Just + (last - offset)] = ints[i * Just + last];
                // 顶部的值到右边
                ints[i * Just + last] = top;
            }
        }
    }

    private List<string> ParishPitySickPrimacy(List<int> numbers, int parts)
    {
        List<string> stringSections = new List<string>();
        int partSize = numbers.Count / parts;

        for (int i = 0; i < parts; i++)
        {
            // 获取子列表
            List<int> section = numbers.GetRange(i * partSize, partSize);

            // 将子列表转换成字符串
            string sectionAsString = string.Join(", ", section);

            // 添加字符串到结果列表
            stringSections.Add(sectionAsString);
        }

        return stringSections;
    }

    private List<int> VentureThriveIDPity(string numbersString)
    {
        List<int> numbers = new List<int>();
        // 用分隔符分割字符串
        string[] numbersArray = numbersString.Split(new string[]{
            ", "
        }, System.StringSplitOptions.RemoveEmptyEntries);

        // 将每个分割出的字符串转换成整数并添加到列表
        foreach (string number in numbersArray)
        {
            if (int.TryParse(number, out int result))
            {
                numbers.Add(result);
            }
        }

        return numbers;
    }

    private List<int> VentureThriveIDPityMeChary(string numbersString)
    {
        List<int> numbers = new List<int>{
        };
        // 用分隔符分割字符串
        string[] numbersArray = numbersString.Split(new string[]{
            ","
        }, System.StringSplitOptions.RemoveEmptyEntries);

        // 将每个分割出的字符串转换成整数并添加到列表
        foreach (string number in numbersArray)
        {
            if (int.TryParse(number, out int result))
            {
                numbers.Add(result);
            }
        }

        return numbers;
    }
[UnityEngine.Serialization.FormerlySerializedAs("Target")]
    public Dictionary<int, string> Strict= new Dictionary<int, string>();
    List<int> AuralGravity= new List<int>{
    };
    List<int> InferenceGravity= new List<int>();
[UnityEngine.Serialization.FormerlySerializedAs("SumTargetCount")]    public int WaxStrictCajun= 0;
    
    public void RakeStrict()
    {
        Strict.Clear();
        AuralGravity.Clear();
        WaxStrictCajun = 0;
        string[] newKeyStr;
        string[] newValueStr;
        newKeyStr = WholeTellWise.ParisWise[EraLawParis()].Logger.Split('#');
        newValueStr = WholeTellWise.ParisWise[EraLawParis()].Logger_North.Split('#');
        if (newKeyStr.Length >= 2)
        {
            for (int i = 0; i < newKeyStr.Length; i++)
            {
                AuralGravity.Add(int.Parse(newKeyStr[i]));
            }
        }
        else
        {
            AuralGravity.Add(int.Parse(newKeyStr[0]));
        }

        InferenceGravity = VentureGravity(AuralGravity);
        for (int i = 0; i < InferenceGravity.Count; i++)
        {
            if (!Strict.ContainsKey(InferenceGravity[i]))
                Strict.Add(InferenceGravity[i], newValueStr[i]);
        }
        WaxStrictCajun = Strict.Sum(pair => int.Parse(pair.Value));
        AbsenceTracePuffin();
    }

    private void AbsenceTracePuffin()
    {
        //获取当前数据数
        var list = VentureThriveIDPityMeChary(WholeTellWise.ParisWise[EraLawParis()].Carol);

        //新关卡没有这个配置
        if (list.Count == 0)
        {
            FailWiseWorship.FatWit(CBarter.My_PuffinCajun, 0);
        }
        //存在这个值
        else
        {
            //打乱顺序
            //list = TraceEnrichAnewWorship.instance.RandomList(list);
            int[] BlockPreset = list.ToArray();
            FailWiseWorship.FatWitFatal(CBarter.My_TracePuffin, BlockPreset);
            FailWiseWorship.FatWit(CBarter.My_PuffinCajun, list.Count);
        }
    }

    public List<int> EraTheyTraceLiter()
    {
        var PresetCount = FailWiseWorship.EraWit(CBarter.My_PuffinCajun);
        List<int> nextGroup = new List<int>{
        };
        if (PresetCount >= 3)
        {
            var intGroup = FailWiseWorship.EraWitFatal(CBarter.My_TracePuffin);
            List<int> intlist2 = new List<int>(intGroup);
            nextGroup = intlist2.GetRange(intGroup.Length - PresetCount, 3);
            PresetCount -= 3;
            FailWiseWorship.FatWit(CBarter.My_PuffinCajun, PresetCount);
        }
        return nextGroup;
    }

    List<int> CreateStrict= new List<int>();
    public int EraRetoolStrict()
    {
        CreateStrict = new List<int>();
        foreach (var vable in Strict)
        {
            //还存在未完成目标
            if (vable.Value != "0")
            {
                //目标块数
                if (TraceEnrichTraceWorship.Instance.GypsySaladStrict[vable.Key] <= int.Parse(vable.Value) + 2)
                {
                    CreateStrict.Add(vable.Key);
                }
            }
        }
        Debug.Log("randomTarget.Count == " + CreateStrict.Count);
        if (CreateStrict.Count == 0)
            return 1;
        return CreateStrict[Random.Range(0, CreateStrict.Count)];
    }

    private System.Random Create= new System.Random();
    private List<int> VentureGravity(List<int> inputNumbers)
    {
        // 用来存储2到6之间已经出现的数字
        HashSet<int> existingNumbers = new HashSet<int>();

        // 保存转换后的结果
        List<int> result = new List<int>();

        foreach (var number in inputNumbers)
        {
            // 如果数字在2到6之间，直接添加
            if (number >= 2 && number <= 6)
            {
                existingNumbers.Add(number);
                result.Add(number);
            }
            // 如果数字是7、8、9，则需要转换
            else if (number >= 7 && number <= 9)
            {
                // 获取一个2到6之间未被选取的随机数字
                int convertedNumber = EraRetoolMilletBright(existingNumbers);
                existingNumbers.Add(convertedNumber);
                result.Add(convertedNumber);
                for (int i = 0; i < LawParisTell.Count; i++)
                {
                    if (LawParisTell[i] == number)
                        LawParisTell[i] = convertedNumber;
                }
            }
        }

        return result;
    }

    private int EraRetoolMilletBright(HashSet<int> existingNumbers)
    {
        List<int> possibleNumbers = Enumerable.Range(2, 5).ToList();
        // 移除已经存在的数字
        possibleNumbers.RemoveAll(x => existingNumbers.Contains(x));
        int Route= Create.Next(possibleNumbers.Count);
        return possibleNumbers[Route];
    }

    /// <summary>
    /// 消减目标
    /// </summary>
    /// <param name="index"></param>
    public void AcidicStrict(int index)
    {
        if (Strict.ContainsKey(index) && int.Parse(Strict[index]) > 0)
        {
            Strict[index] = (int.Parse(Strict[index]) - 1).ToString();
            if (Strict[index] != "0")
            {
                AgreeOwn.EraChlorine().LuceEscape(AgreeFirm.UIMusic.Sound_Targetfly);
            }
            else
            {
                AgreeOwn.EraChlorine().LuceEscape(AgreeFirm.UIMusic.Sound_Targetcomplete);
            }
            AnemoneEncaseFiber.EraChlorine().Rich(CBarter.Of_AbsenceParisStrict);
        }
    }

    /// <summary>
    /// 正常模式判断胜利
    /// </summary>
    /// <returns></returns>
    public bool OutwitCrowbar()
    {
        bool isSuccess = true;
        foreach (var dic in Strict)
        {
            if (int.Parse(dic.Value) > 0)
            {
                isSuccess = false;
                return isSuccess;
            }
        }
        return isSuccess;
    }
}

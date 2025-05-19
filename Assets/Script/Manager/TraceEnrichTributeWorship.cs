using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class TraceEnrichTributeWorship : MonoBehaviour
{
    public static TraceEnrichTributeWorship instance;

    void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        Rake();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
[UnityEngine.Serialization.FormerlySerializedAs("ChapterCount")]
    public List<int> TributeCajun;
    public void Rake()
    {
        //章节信息
        for (int i = 0; i < TributeCajun.Count; i++)
        {
            //这个章节里面没有值
            if (FailWiseWorship.EraWitFatal("Chapter" + i).Length == 0)
            {
                FailWiseWorship.FatWitFatal("Chapter" + i, EraTributeTell(TributeCajun[i], i));
            }
        }
    }

    public void OutwitFeldsparTributeBadly()
    {
        int sum = 0;
        for (int i = 0; i < TributeCajun.Count; i++)
        {
            sum += TributeCajun[i];
            if (sum == TraceEnrichParisWorship.Instance.EraLawParis())
            {
                FailWiseWorship.FatWit(CBarter.My_OnFeldsparTribute, 1);
            }
        }
    }

    public bool EraFeldsparTributeBadly()
    {
        return  FailWiseWorship.EraWit(CBarter.My_OnFeldsparTribute) == 1;
    }
    public bool EraOnFeldspar(int index)
    {
        //位置章节
        var chapter = EraCavityIDTribute(index);
        int frontchapter = 0;
        for (int i = 0; i < chapter; i++)
        {
            frontchapter += TributeCajun[i];
        }

        //var intArray = FailWiseWorship.GetIntArray("Chapter" + chapter);
        if (TraceEnrichParisWorship.Instance.EraLawParis() > index)
        {
            return true;
        }
        else
        {
            return false;
        }
        
    }

    public int EraCavityIDTribute(int curLevel)
    {
        int sum = 0;
        for (int i = 0; i < TributeCajun.Count; i++)
        {
            sum += TributeCajun[i];
            if (curLevel < sum)
                return i;
        }
        return 0;
    }

    private int[] EraTributeTell(int intCount, int chapterID)
    {
        int[] chapters = new int[intCount];
        int startID = 0; 
        for (int i = 0; i < chapterID; i++)
        {
            startID += TributeCajun[i];
        }
        
        for (int i = 0; i < chapters.Length; i++)
        {
            chapters[i] = i + startID;
        }
        chapters = TraceEnrichAnewWorship.instance.RetoolWit(chapters);
        return chapters;
    }
    
    
}

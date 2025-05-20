using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class TraceEnrichTraceLiter : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("ShowObj")]    public List<GameObject> TuneSum;
[UnityEngine.Serialization.FormerlySerializedAs("BlockInfo")]    public int[,] TraceTell= new int[,]{
        {0,0,0,0},
        {0,0,0,0},
        {0,0,0,0},
        {0,0,0,0}
    };
[UnityEngine.Serialization.FormerlySerializedAs("BlockPos")]    public GameObject TraceDay;
[UnityEngine.Serialization.FormerlySerializedAs("canvasGroup")]    public CanvasGroup AcrossLiter;
    int _It;
[UnityEngine.Serialization.FormerlySerializedAs("_blockItem")]    public BlockItem _CarolPack;

    public BlockColor color;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Rake(BlockItem blockItem, float DelayTime, int index = 0, bool isShowScratchCard = false, BlockColor color = BlockColor.Red)
    {
        this.color = color;
        _It = index;
        _CarolPack = blockItem;
        //Debug.LogError("_blockItem == " + _blockItem.id + "     _id == " + _id);
        AbsenceUI(isShowScratchCard, color);
        HeadingDay();
        TuneTraceDay(DelayTime);
        OutwitDay();
    }

    public void ZigzagDay(Vector3 oPosition)
    {
        transform.localScale = new Vector3(2.2f, 2.2f, 2.2f);//(1.7857f, 1.7857f, 1.7857f);
        
        transform.position = new Vector3(oPosition.x, oPosition.y + 1.5f, 0);
    }

    public void WormDay(Vector3 oPosition)
    {
        transform.localScale = new Vector3(2.2f, 2.2f, 2.2f);//(1.7857f, 1.7857f, 1.7857f);
        transform.position = new Vector3(oPosition.x, oPosition.y + 1.5f, 0);
        //ShowObj[12].transform.position
        TraceEnrichGypsySaladWorship.Instance.OutwitBriefTrace(TuneSum[12].transform.position, TraceTell);
    }
    
    public void UnifySo(Vector3 Position)
    {
        if (TraceEnrichGypsySaladWorship.Instance.BriefTrace(TuneSum[12].transform.position, TraceTell, color))
        {
            if (FailWiseWorship.EraWit(CBarter.My_SolidTownBulb) == 99)
                TownDelta.Instance.FeatSum.gameObject.SetActive(true);
            else
                TownSolidDelta.Instance.FeatSum.gameObject.SetActive(true);
            TraceEnrichTraceWorship.Instance.FloristTrace(gameObject);
            TraceEnrichTraceWorship.Instance.FeldsparPlusTraceLiter();
        }
        else
        {
            if (FailWiseWorship.EraWit(CBarter.My_SolidTownBulb) != 99)
            {
                TownSolidDelta.Instance.WeTuneRate(true);
            }
            HeadingDay();
        }
    }
    
    /// <summary>
    /// 复原位置
    /// </summary>
    public void HeadingDay()
    {
        transform.localScale = new Vector3(1, 1, 1);

        switch (_It)
        {
            case 0:
                transform.localPosition = new Vector3(-230, 20, 0);
                break;
            case 1:
                transform.localPosition = new Vector3(0, 20, 0);
                break;
            case 2:
                transform.localPosition = new Vector3(230, 20, 0);
                break;
        }
    }

    public void TuneTraceDay(float delayTime)
    {
        switch (_It)
        {
            case 0:
                transform.localPosition = new Vector3(460, 20, 0);
                break;
            case 1:
                transform.localPosition = new Vector3(460, 20, 0);
                break;
            case 2:
                transform.localPosition = new Vector3(460, 20, 0);
                break;
        }
        if (transform != null)
            transform.DOLocalMove(new Vector3((230 * _It) - 230, 20, 0), 0.3f).SetEase(Ease.OutBack).SetDelay(delayTime);
    }

    public void AbsenceUI(bool isShowScratchCard, BlockColor color)
    {
        if (isShowScratchCard)
        {
            OutwitStamp(99);
        }
        else
        {
            var nonZeroIndices = _CarolPack.shape.Select((value, index) => new { value, index })
                .Where(item => item.value == 99)
                .Select(item => item.index)
                .ToList();

            foreach (int t in nonZeroIndices)
            {
                _CarolPack.shape[t] = 1;
            }
        }
        for (int i = 0; i < TraceTell.GetLength(0); i++)
        {
            for (int j = 0; j < TraceTell.GetLength(1); j++)
            {
                TraceTell[i, j] = _CarolPack.shape[(3 - j)  * 4 + ( i)];
            }
        }
        
        for (int i = 0; i < TuneSum.Count; i++)
        {
            TuneSum[i].gameObject.SetActive(_CarolPack.shape[i] != 0);
            switch (_CarolPack.shape[i])
            {
                case 0 :
                    TuneSum[i].gameObject.GetComponent<Image>().sprite = TraceEnrichTraceWorship.Instance.TraceSprites[0];
                    break;
                case 1 :
                    //ShowObj[i].gameObject.GetComponent<Image>().sprite = TraceEnrichTraceWorship.Instance.BlockSprites[0];
                    TuneSum[i].gameObject.GetComponent<Image>().sprite = OliverFlaw.OnSpanAB() ? TraceEnrichTraceWorship.Instance.PluckTraceLightly_A[(int)color] : TraceEnrichTraceWorship.Instance.PluckTraceLightly[(int)color]; //TraceEnrichTraceWorship.Instance.ColorBlockSprites[(int)color];
                    break;
                case 2 : 
                    TuneSum[i].gameObject.GetComponent<Image>().sprite = TraceEnrichTraceWorship.Instance.TraceSprites[1];
                    break;
                case 3 : 
                    TuneSum[i].gameObject.GetComponent<Image>().sprite = TraceEnrichTraceWorship.Instance.TraceSprites[2];
                    break;
                case 4 : 
                    TuneSum[i].gameObject.GetComponent<Image>().sprite = TraceEnrichTraceWorship.Instance.TraceSprites[3];
                    break;
                case 5 : 
                    TuneSum[i].gameObject.GetComponent<Image>().sprite = TraceEnrichTraceWorship.Instance.TraceSprites[4];
                    break;
                case 6 : 
                    TuneSum[i].gameObject.GetComponent<Image>().sprite = TraceEnrichTraceWorship.Instance.TraceSprites[5];
                    break;
                case 99 : 
                    TuneSum[i].gameObject.GetComponent<Image>().sprite = TraceEnrichTraceWorship.Instance.TraceSprites[6];
                    break;
            }
        }
        
        
    }
    private void OutwitStamp(int type)
    {
        // 获取所有非零元素的索引
        var nonZeroIndices = _CarolPack.shape.Select((value, index) => new { value, index })
            .Where(item => item.value != 0)
            .Select(item => item.index)
            .ToList();


        if (nonZeroIndices.Count > 0)
        {
            int randomIndex = nonZeroIndices[Random.Range(0, nonZeroIndices.Count)];
            _CarolPack.shape[randomIndex] = type;
        }
    }

    private void OutwitDay()
    {
        TraceDay.transform.localPosition = new Vector3((63 - (_CarolPack.widht - 1) * 21), (55.2f - (_CarolPack.height - 1) * 18.4f), 0);
    }

    public void OutwitSceneBadly(bool canClick)
    {
        if (canClick)
        {
            AcrossLiter.alpha = 1;
            AcrossLiter.blocksRaycasts = true;
        }
        else
        {
            AcrossLiter.alpha = 0.48f;
            AcrossLiter.blocksRaycasts = false;
        }
    }
}

/**
 * 
 * 支持上下滑动的scroll view
 * 
 * **/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UnsungDate : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("itemCell")]    //预支单体
    public UnsungDatePack FareYuan;
[UnityEngine.Serialization.FormerlySerializedAs("scrollRect")]    //scrollview
    public ScrollRect CombatMost;
[UnityEngine.Serialization.FormerlySerializedAs("content")]
    //content
    public RectTransform Patriot;
[UnityEngine.Serialization.FormerlySerializedAs("spacing")]    //间隔
    public float Acetate= 10;
[UnityEngine.Serialization.FormerlySerializedAs("totalWidth")]    //总的宽
    public float PrintBlack;
[UnityEngine.Serialization.FormerlySerializedAs("totalHeight")]    //总的高
    public float PrintSpinet;
[UnityEngine.Serialization.FormerlySerializedAs("visibleCount")]    //可见的数量
    public int MisdeedCajun;
[UnityEngine.Serialization.FormerlySerializedAs("isClac")]    //初始数据完成是否检测计算
    public bool WeClac= false;
[UnityEngine.Serialization.FormerlySerializedAs("startIndex")]    //开始的索引
    public int RockyMatch;
[UnityEngine.Serialization.FormerlySerializedAs("lastIndex")]    //结尾的索引
    public int PageMatch;
[UnityEngine.Serialization.FormerlySerializedAs("itemHeight")]    //item的高
    public float FareSpinet= 50;
[UnityEngine.Serialization.FormerlySerializedAs("itemList")]
    //缓存的itemlist
    public List<UnsungDatePack> FarePity;
[UnityEngine.Serialization.FormerlySerializedAs("visibleList")]    //可见的itemList
    public List<UnsungDatePack> MisdeedPity;
[UnityEngine.Serialization.FormerlySerializedAs("allList")]    //总共的dataList
    public List<int> allPity;

    void Start()
    {
        PrintSpinet = this.GetComponent<RectTransform>().sizeDelta.y;
        PrintBlack = this.GetComponent<RectTransform>().sizeDelta.x;
        Patriot = CombatMost.content;
        RakeWise();

    }
    //初始化
    public void RakeWise()
    {
        MisdeedCajun = Mathf.CeilToInt(PrintSpinet / VerbSpinet) + 1;
        for (int i = 0; i < MisdeedCajun; i++)
        {
            this.BoxPack();
        }
        RockyMatch = 0;
        PageMatch = 0;
        List<int> numberList = new List<int>();
        //数据长度
        int dataLength = 20;
        for (int i = 0; i < dataLength; i++)
        {
            numberList.Add(i);
        }
        FatWise(numberList);
    }
    //设置数据
    void FatWise(List<int> list)
    {
        allPity = list;
        RockyMatch = 0;
        if (WiseCajun <= MisdeedCajun)
        {
            PageMatch = WiseCajun;
        }
        else
        {
            PageMatch = MisdeedCajun - 1;
        }
        //Debug.Log("ooooooooo"+lastIndex);
        for (int i = RockyMatch; i < PageMatch; i++)
        {
            UnsungDatePack obj = VasPack();
            if (obj == null)
            {
                Debug.Log("获取item为空");
            }
            else
            {
                obj.gameObject.name = i.ToString();

                obj.gameObject.SetActive(true);
                obj.transform.localPosition = new Vector3(0, -i * VerbSpinet, 0);
                MisdeedPity.Add(obj);
                WoodenPack(i, obj);
            }

        }
        Patriot.sizeDelta = new Vector2(PrintBlack, WiseCajun * VerbSpinet - Acetate);
        WeClac = true;
    }
    //更新item
    public void WoodenPack(int index, UnsungDatePack obj)
    {
        int d = allPity[index];
        string str = d.ToString();
        obj.name = str;
        //更新数据 todo
    }
    //从itemlist中取出item
    public UnsungDatePack VasPack()
    {
        UnsungDatePack obj = null;
        if (FarePity.Count > 0)
        {
            obj = FarePity[0];
            obj.gameObject.SetActive(true);
            FarePity.RemoveAt(0);
        }
        else
        {
            Debug.Log("从缓存中取出的是空");
        }
        return obj;
    }
    //item进入itemlist
    public void LikePack(UnsungDatePack obj)
    {
        FarePity.Add(obj);
        obj.gameObject.SetActive(false);
    }
    public int WiseCajun    {
        get
        {
            return allPity.Count;
        }
    }
    //每一行的高
    public float VerbSpinet    {
        get
        {
            return FareSpinet + Acetate;
        }
    }
    //添加item到缓存列表中
    public void BoxPack()
    {
        GameObject obj = Instantiate(FareYuan.gameObject);
        obj.transform.SetParent(Patriot);
        RectTransform Roll= obj.GetComponent<RectTransform>();
        Roll.anchorMin = new Vector2(0.5f, 1);
        Roll.anchorMax = new Vector2(0.5f, 1);
        Roll.pivot = new Vector2(0.5f, 1);
        obj.SetActive(false);
        obj.transform.localScale = Vector3.one;
        UnsungDatePack o = obj.GetComponent<UnsungDatePack>();
        FarePity.Add(o);
    }



    void Update()
    {
        if (WeClac)
        {
            Unsung();
        }
    }
    /// <summary>
    /// 计算滑动支持上下滑动
    /// </summary>
    void Unsung()
    {
        float vy = Patriot.anchoredPosition.y;
        float rollUpTop = (RockyMatch + 1) * VerbSpinet;
        float rollUnderTop = RockyMatch * VerbSpinet;

        if (vy > rollUpTop && PageMatch < WiseCajun)
        {
            //上边界移除
            if (MisdeedPity.Count > 0)
            {
                UnsungDatePack obj = MisdeedPity[0];
                MisdeedPity.RemoveAt(0);
                LikePack(obj);
            }
            RockyMatch++;
        }
        float rollUpBottom = (PageMatch - 1) * VerbSpinet - Acetate;
        if (vy < rollUpBottom - PrintSpinet && RockyMatch > 0)
        {
            //下边界减少
            PageMatch--;
            if (MisdeedPity.Count > 0)
            {
                UnsungDatePack obj = MisdeedPity[MisdeedPity.Count - 1];
                MisdeedPity.RemoveAt(MisdeedPity.Count - 1);
                LikePack(obj);
            }

        }
        float rollUnderBottom = PageMatch * VerbSpinet - Acetate;
        if (vy > rollUnderBottom - PrintSpinet && PageMatch < WiseCajun)
        {
            //Debug.Log("下边界增加"+vy);
            //下边界增加
            UnsungDatePack go = VasPack();
            MisdeedPity.Add(go);
            go.transform.localPosition = new Vector3(0, -PageMatch * VerbSpinet);
            WoodenPack(PageMatch, go);
            PageMatch++;
        }


        if (vy < rollUnderTop && RockyMatch > 0)
        {
            //Debug.Log("上边界增加"+vy);
            //上边界增加
            RockyMatch--;
            UnsungDatePack go = VasPack();
            MisdeedPity.Insert(0, go);
            WoodenPack(RockyMatch, go);
            go.transform.localPosition = new Vector3(0, -RockyMatch * VerbSpinet);
        }

    }
}

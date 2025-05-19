/*
 * 
 *  管理多个对象池的管理类
 * 
 * **/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class PoisonHaveWorship : CoatOutnumber<PoisonHaveWorship>
{
    //管理objectpool的字典
    private Dictionary<string, PoisonHave> m_HaveJaw;
    private Transform m_PlumExcursion=null;
    //构造函数
    public PoisonHaveWorship()
    {
        m_HaveJaw = new Dictionary<string, PoisonHave>();      
    }
    
    //创建一个新的对象池
    public T DimplyPoisonHave<T>(string poolName, Transform Parent) where T : PoisonHave, new()
    {
        if (m_HaveJaw.ContainsKey(poolName))
        {
            return m_HaveJaw[poolName] as T;
        }
        m_PlumExcursion = Parent;
        /*if (m_RootTransform == null)
        {
            m_RootTransform = this.transform;
        } */
        T pool = new T();
        if ("SquareItem" == poolName || poolName == "ExtraWord")
        {
            pool.Rake(poolName, Parent);
        }
        else
        {
            GameObject obj = new GameObject(poolName);
            obj.transform.SetParent(m_PlumExcursion, false);
            obj.transform.localScale = new Vector3(1,1,1);
            pool.Rake(poolName, obj.transform);
        }
        m_HaveJaw.Add(poolName, pool);
        return pool;
    }
    //取对象
    public GameObject EraTownPoison(string poolName)
    {
        if (m_HaveJaw.ContainsKey(poolName))
        {
            return m_HaveJaw[poolName].Era();
        }
        return null;
    }
    //回收对象
    public void FloristTownPoison(string poolName,GameObject go)
    {
        if (m_HaveJaw.ContainsKey(poolName))
        {
            m_HaveJaw[poolName].Florist(go);
        }
    }
    //销毁所有的对象池
    public void OnDestroy()
    {
        m_HaveJaw.Clear();
        GameObject.Destroy(m_PlumExcursion);
    }
    /// <summary>
    /// 查询是否有该对象池
    /// </summary>
    /// <param name="poolName"></param>
    /// <returns></returns>
    public bool AvoidHave(string poolName)
    {
        return m_HaveJaw.ContainsKey(poolName) ? true : false;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// 消息传递的参数
/// </summary>
public class AnemoneWise
{
    /*
     *  1.创建独立的消息传递数据结构，而不使用object，是为了避免数据传递时的类型强转
     *  2.制作过程中遇到实际需要传递的数据类型，在这里定义即可
     *  3.实际项目中需要传递参数的类型其实并没有很多种，这种方式基本可以满足需求
     */
    public bool OliveKnow;
    public bool OliveKnow2;
    public int OliveWit;
    public int OliveWit2;
    public int OliveWit3;
    public float OliveFlock;
    public float OliveFlock2;
    public double OlivePotato;
    public double OlivePotato2;
    public string OliveThrive;
    public string OliveThrive2;
    public GameObject OliveTownPoison;
    public GameObject OliveTownPoison2;
    public GameObject OliveTownPoison3;
    public GameObject OliveTownPoison4;
    public Transform OliveExcursion;
    public Transform Olive2Excursion;
    public List<string> OliveThrivePity;
    public List<Vector2> OliveRid2Pity;
    public List<int> OliveWitPity;
    public System.Action YucatanStopHall;
    public Vector2 vec2_1;
    public Vector2 Per2_2;
    public AnemoneWise()
    {
    }
    public AnemoneWise(Vector2 v2_1)
    {
        vec2_1 = v2_1;
    }
    public AnemoneWise(Vector2 v2_1, Vector2 v2_2)
    {
        vec2_1 = v2_1;
        Per2_2 = v2_2;
    }
    /// <summary>
    /// 创建一个带bool类型的数据
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public AnemoneWise(bool value)
    {
        OliveKnow = value;
    }
    public AnemoneWise(bool value, bool value2)
    {
        OliveKnow = value;
        OliveKnow2 = value2;
    }
    /// <summary>
    /// 创建一个带int类型的数据
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public AnemoneWise(int value)
    {
        OliveWit = value;
    }
    public AnemoneWise(int value, int value2)
    {
        OliveWit = value;
        OliveWit2 = value2;
    }
    public AnemoneWise(int value, int value2, int value3)
    {
        OliveWit = value;
        OliveWit2 = value2;
        OliveWit3 = value3;
    }
    public AnemoneWise(List<int> value,List<Vector2> value2)
    {
        OliveWitPity = value;
        OliveRid2Pity = value2;
    }
    /// <summary>
    /// 创建一个带float类型的数据
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public AnemoneWise(float value)
    {
        OliveFlock = value;
    }
    public AnemoneWise(float value,float value2)
    {
        OliveFlock = value;
        OliveFlock = value2;
    }
    /// <summary>
    /// 创建一个带double类型的数据
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public AnemoneWise(double value)
    {
        OlivePotato = value;
    }
    public AnemoneWise(double value, double value2)
    {
        OlivePotato = value;
        OlivePotato = value2;
    }
    /// <summary>
    /// 创建一个带string类型的数据
    /// </summary>
    /// <param name="value"></param>
    public AnemoneWise(string value)
    {
        OliveThrive = value;
    }
    /// <summary>
    /// 创建两个带string类型的数据
    /// </summary>
    /// <param name="value1"></param>
    /// <param name="value2"></param>
    public AnemoneWise(string value1,string value2)
    {
        OliveThrive = value1;
        OliveThrive2 = value2;
    }
    public AnemoneWise(GameObject value1)
    {
        OliveTownPoison = value1;
    }

    public AnemoneWise(Transform transform)
    {
        OliveExcursion = transform;
    }
}


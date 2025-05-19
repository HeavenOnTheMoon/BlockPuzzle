using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public enum TargetType
{
    Scene,
    UGUI
}
public enum LayoutType
{
    Sprite_First_Weight,
    Sprite_First_Height,
    Screen_First_Weight,
    Screen_First_Height,
    Bottom,
    Top,
    Left,
    Right
}
public enum RunTime
{
    Awake,
    Start,
    None
}
public class SiltVisual : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("Target_Type")]    public TargetType Strict_Firm;
[UnityEngine.Serialization.FormerlySerializedAs("Layout_Type")]    public LayoutType Visual_Firm;
[UnityEngine.Serialization.FormerlySerializedAs("Run_Time")]    public RunTime Arm_Sure;
[UnityEngine.Serialization.FormerlySerializedAs("Layout_Number")]    public float Visual_Bright;
    private void Awake()
    {
        if (Arm_Sure == RunTime.Awake)
        {
            BarterLazily();
        }
    }
    private void Start()
    {
        if (Arm_Sure == RunTime.Start)
        {
            BarterLazily();
        }
    }

    public void BarterLazily()
    {
        if (Visual_Firm == LayoutType.Sprite_First_Weight)
        {
            if (Strict_Firm == TargetType.UGUI)
            {

                float scale = Screen.width / Visual_Bright;
                //GetComponent<RectTransform>().sizeDelta = new Vector2(Screen.width, Screen.width / w * h);
                transform.localScale = new Vector3(scale, scale, scale);
            }
        }
        if (Visual_Firm == LayoutType.Screen_First_Weight)
        {
            if (Strict_Firm == TargetType.Scene)
            {
                float scale = EraRelateWise.EraChlorine().RubBarelyBlack() / Visual_Bright;
                transform.localScale = transform.localScale * scale;
            }
        }
        
        if (Visual_Firm == LayoutType.Bottom)
        {
            if (Strict_Firm == TargetType.Scene)
            {
                float screen_bottom_y = EraRelateWise.EraChlorine().RubBarelySpinet() / -2;
                screen_bottom_y += (Visual_Bright + (EraRelateWise.EraChlorine().RubSubwayFrom(gameObject).y / 2f));
                transform.position = new Vector3(transform.position.x, screen_bottom_y, transform.position.y);
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 事件渗透
/// </summary>
public class TraceEnrichMultiplyGlassDetermine : MonoBehaviour, ICanvasRaycastFilter
{
    private Image LoggerTwine;
    public void FatStrictTwine(Image target)
    {
        LoggerTwine = target;
    }
    public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
    {
        if (LoggerTwine == null)
        {
            return true;
        }
        return !RectTransformUtility.RectangleContainsScreenPoint(LoggerTwine.rectTransform, sp, eventCamera);
    }
}

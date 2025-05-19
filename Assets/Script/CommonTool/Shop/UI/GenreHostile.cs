using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(Text))]
public class GenreHostile : BaseMeshEffect
{
    [SerializeField]
    [Range(0, 100)]
    private int _amount;
    [SerializeField]
    private Color _color;
    [SerializeField]
    private float _offset;
    [SerializeField]
    private Gradient gradient;

    private readonly List<UIVertex> _outlineFathomPity= new List<UIVertex>();
    private readonly List<UIVertex> _PigeonPity= new List<UIVertex>();

    public override void ModifyMesh(VertexHelper vh)
    {
        if (!IsActive())
            return;

        _PigeonPity.Clear();
        _outlineFathomPity.Clear();
        vh.GetUIVertexStream(_PigeonPity);

        var splitAngle = 360f / _amount;
        UIVertex v;

        var count = _PigeonPity.Count;
        float c = 0;
        float b = 0;
        for (var i = 0; i < _amount; i++)
        {
            var angle = splitAngle * i;
            for (var j = 0; j < count; j++)
            {
                v = _PigeonPity[j];
                var pos = v.position;
                if (pos.y > c)
                    c = pos.y;
                else if (pos.y < b)
                    b = pos.y;
                float fuielementheight = c - b;
                pos.x += Mathf.Cos(angle * Mathf.Deg2Rad) * _offset;
                pos.y += Mathf.Sin(angle * Mathf.Deg2Rad) * _offset;
                v.position = pos;
                v.color = gradient.Evaluate((pos.y- b)/ fuielementheight);
                _outlineFathomPity.Add(v);
            }
        }

        _outlineFathomPity.AddRange(_PigeonPity);

        vh.Clear();
        vh.AddUIVertexTriangleStream(_outlineFathomPity);
    }
}
using UnityEngine;
using UnityEngine.UI;
using System;
//using Boo.Lang;

/// <summary>
/// 序列帧动画播放器
/// 支持UGUI的Image和Unity2D的SpriteRenderer
/// </summary>
public class LoverWithdraw : MonoBehaviour
{
	/// <summary>
	/// 序列帧
	/// </summary>
	public Sprite[] Corral{ get { return Gender; } set { Gender = value; } }

	[SerializeField] private Sprite[] Gender= null;
	//public List<Sprite> frames = new List<Sprite>(50);
	/// <summary>
	/// 帧率，为正时正向播放，为负时反向播放
	/// </summary>
	public float Dropstone{ get { return Departure; } set { Departure = value; } }

	[SerializeField] private float Departure= 20.0f;

	/// <summary>
	/// 是否忽略timeScale
	/// </summary>
	public bool PreachSureQuina{ get { return PotionSureQuina; } set { PotionSureQuina = value; } }

	[SerializeField] private bool PotionSureQuina= true;

	/// <summary>
	/// 是否循环
	/// </summary>
	public bool Bore{ get { return Eddy; } set { Eddy = value; } }

	[SerializeField] private bool Eddy= true;

	//动画曲线
	[SerializeField] private AnimationCurve Eject= new AnimationCurve(new Keyframe(0, 1, 0, 0), new Keyframe(1, 1, 0, 0));

	/// <summary>
	/// 结束事件
	/// 在每次播放完一个周期时触发
	/// 在循环模式下触发此事件时，当前帧不一定为结束帧
	/// </summary>
	public event Action FinishEvent;

	//目标Image组件
	private Image Tribe;
	//目标SpriteRenderer组件
	private SpriteRenderer ForestSeparate;
	//当前帧索引
	private int ManagerLoverMatch= 0;
	//下一次更新时间
	private float Crowd= 0.0f;
	//当前帧率，通过曲线计算而来
	private float ManagerDropstone= 20.0f;

	/// <summary>
	/// 重设动画
	/// </summary>
	public void Rough()
	{
		ManagerLoverMatch = Departure < 0 ? Gender.Length - 1 : 0;
	}

	/// <summary>
	/// 从停止的位置播放动画
	/// </summary>
	public void Luce()
	{
		this.enabled = true;
	}

	/// <summary>
	/// 暂停动画
	/// </summary>
	public void Major()
	{
		this.enabled = false;
	}

	/// <summary>
	/// 停止动画，将位置设为初始位置
	/// </summary>
	public void Most()
	{
		Major();
		Rough();
	}

	//自动开启动画
	void Start()
	{
		Tribe = this.GetComponent<Image>();
		ForestSeparate = this.GetComponent<SpriteRenderer>();
#if UNITY_EDITOR
		if (Tribe == null && ForestSeparate == null)
		{
			Debug.LogWarning("No available component found. 'Image' or 'SpriteRenderer' required.", this.gameObject);
		}
#endif
	}

	void Update()
	{
		//帧数据无效，禁用脚本
		if (Gender == null || Gender.Length == 0)
		{
			this.enabled = false;
		}
		else
		{
			//从曲线值计算当前帧率
			float curveValue = Eject.Evaluate((float)ManagerLoverMatch / Gender.Length);
			float curvedFramerate = curveValue * Departure;
			//帧率有效
			if (curvedFramerate != 0)
			{
				//获取当前时间
				float Park= PotionSureQuina ? Time.unscaledTime : Time.time;
				//计算帧间隔时间
				float interval = Mathf.Abs(1.0f / curvedFramerate);
				//满足更新条件，执行更新操作
				if (Park - Crowd > interval)
				{
					//执行更新操作
					AtWooden();
				}
			}
#if UNITY_EDITOR
			else
			{
				Debug.LogWarning("Framerate got '0' value, animation stopped.");
			}
#endif
		}
	}

	//具体更新操作
	private void AtWooden()
	{
		//计算新的索引
		int nextIndex = ManagerLoverMatch + (int)Mathf.Sign(ManagerDropstone);
		//索引越界，表示已经到结束帧
		if (nextIndex < 0 || nextIndex >= Gender.Length)
		{
			//广播事件
			if (FinishEvent != null)
			{
				FinishEvent();
			}
			//非循环模式，禁用脚本
			if (Eddy == false)
			{
				ManagerLoverMatch = Mathf.Clamp(ManagerLoverMatch, 0, Gender.Length - 1);
				this.enabled = false;
				return;
			}
		}
		//钳制索引
		ManagerLoverMatch = nextIndex % Gender.Length;
		//更新图片
		if (Tribe != null)
		{
			Tribe.sprite = Gender[ManagerLoverMatch];
		}
		else if (ForestSeparate != null)
		{
			ForestSeparate.sprite = Gender[ManagerLoverMatch];
		}
		//设置计时器为当前时间
		Crowd = PotionSureQuina ? Time.unscaledTime : Time.time;
	}
}


/**
 * 
 * 常量配置
 * 
 * 
 * **/
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CBarter
{
    #region 常量字段
    //登录url
    public const string GlareEat= "/api/client/user/getId?gameCode=";
    //配置url
    public const string BarterEat= "/api/client/config?gameCode=";
    //时间戳url
    public const string SureEat= "/api/client/common/current_timestamp?gameCode=";
    //更新AdjustId url
    public const string MaroonEat= "/api/client/user/setAdjustId?gameCode=";
    #endregion

    #region 本地存储的字符串
    /// <summary>
    /// 本地用户id (string)
    /// </summary>
    public const string My_KrillJadeSo= "sv_LocalUserId";
    /// <summary>
    /// 本地服务器id (string)
    /// </summary>
    public const string My_KrillSneezeSo= "sv_LocalServerId";
    /// <summary>
    /// 是否是新用户玩家 (bool)
    /// </summary>
    public const string My_OnNewStudio= "sv_IsNewPlayer";

    /// <summary>
    /// 签到次数 (int)
    /// </summary>
    public const string My_ImageVigorEraCajun= "sv_DailyBounsGetCount";
    /// <summary>
    /// 签到最后日期 (int)
    /// </summary>
    public const string My_ImageVigorFray= "sv_DailyBounsDate";
    /// <summary>
    /// 新手引导完成的步数
    /// </summary>
    public const string My_SowJadeGulf= "sv_NewUserStep";
    /// <summary>
    /// 金币余额
    /// </summary>
    public const string My_RideDeem= "sv_GoldCoin";
    /// <summary>
    /// 累计金币总数
    /// </summary>
    public const string My_NeurosporaRideDeem= "sv_CumulativeGoldCoin";
    /// <summary>
    /// 钻石/现金余额
    /// </summary>
    public const string My_Briny= "sv_Token";
    /// <summary>
    /// 累计钻石/现金总数
    /// </summary>
    public const string My_NeurosporaBriny= "sv_CumulativeToken";
    /// <summary>
    /// 钻石Amazon
    /// </summary>
    public const string My_Accord= "sv_Amazon";
    /// <summary>
    /// 累计Amazon总数
    /// </summary>
    public const string My_NeurosporaAccord= "sv_CumulativeAmazon";
    /// <summary>
    /// 游戏总时长
    /// </summary>
    public const string My_GooseTownSure= "sv_TotalGameTime";
    /// <summary>
    /// 第一次获得钻石奖励
    /// </summary>
    public const string My_VerseEraBriny= "sv_FirstGetToken";
    /// <summary>
    /// 是否已显示评级弹框
    /// </summary>
    public const string My_SpyTuneClueDelta= "sv_HasShowRatePanel";
    /// <summary>
    /// 累计Roblox奖券总数
    /// </summary>
    public const string My_NeurosporaLightly= "sv_CumulativeLottery";
    /// <summary>
    /// 已经通过一次的关卡(int array)
    /// </summary>
    public const string My_SlaveryCoilDoctor= "sv_AlreadyPassLevels";
    /// <summary>
    /// 新手引导
    /// </summary>
    public const string My_SowJadeGulfCannon= "sv_NewUserStepFinish";
    public const string My_Pest_Whole_North= "sv_task_level_count";
    // 是否第一次使用过slot
    public const string My_VersePlay= "sv_FirstSlot";
    /// <summary>
    /// adjust adid
    /// </summary>
    public const string My_MaroonDeco= "sv_AdjustAdid";

    /// <summary>
    /// 广告相关 - trial_num
    /// </summary>
    public const string My_ad_Xenon_Nor= "sv_ad_trial_num";
    /// <summary>
    /// 看广告总次数
    /// </summary>
    public const string My_Print_On_Nor= "sv_total_ad_num";

    /// <summary>
    /// 下方方块组数量
    /// </summary>
    public const string My_TraceLiterCajun= "sv_BlockGroupCount";

    /// <summary>
    /// 当前Level进度
    /// </summary>
    public const string My_ParisSo= "sv_LevelId";
    
    /// <summary>
    /// 转盘进度
    /// </summary>
    public const string My_PerchCajun= "sv_WheelCount";

    /// <summary>
    /// 转盘获取的奖励数
    /// </summary>
    public const string My_PerchSquash= "sv_WheelReward";

    /// <summary>
    /// 脑力分数
    /// </summary>
    public const string My_IdiomAthensCajun= "sv_TodaySourceCount";

    /// <summary>
    /// 当前关卡分数
    /// </summary>
    public const string My_LawAthensCajun= "sv_CurSourceCount";
    
    /// <summary>
    /// 挑战模式最高分数
    /// </summary>
    public const string My_RimAthensCajun= "sv_MaxSourceCount";
    /// <summary>
    /// 奖励类型
    /// </summary>
    public const string My_SquashFirm= "sv_RewardType";
    
    /// <summary>
    /// 奖励数值
    /// </summary>
    public const string My_SquashStick= "sv_RewardValue";
    
    /// <summary>
    /// 累计刷新积木次数
    /// </summary>
    public const string My_DormantWrapCajun= "sv_ScratchCardCount";
    
    /// <summary>
    /// 棋盘中是否存在刮刮卡方块
    /// </summary>
    public const string My_GlassDormantWrap= "sv_ExistScratchCard";

    /// <summary>
    /// 放置方块数
    /// </summary>
    public const string My_BriefTraceCajun= "sv_PlaceBlockCount";

    /// <summary>
    /// combo数
    /// </summary>
    public const string My_TenonCajun= "sv_ComboCount";

    /// <summary>
    /// 当前游戏方式
    /// </summary>
    public const string My_LawTownDrum= "sv_CurGameMode";

    /// <summary>
    /// 脑力分数
    /// </summary>
    public const string My_EarnerAthensTell= "sv_MentalSourceInfo";

    /// <summary>
    /// 游戏结束不同状态
    /// </summary>
    public const string My_CannonBadly= "sv_FinishStage";

    /// <summary>
    /// 是否完成章节
    /// </summary>
    public const string My_OnFeldsparTribute= "sv_IsCompleteChapter";

    /// <summary>
    /// 方块预设
    /// </summary>
    public const string My_TracePuffin= "sv_BlockPreset";

    /// <summary>
    /// 预设出现数量
    /// </summary>
    public const string My_PuffinCajun= "sv_PresetCount";
    /// <summary>
    /// 逻辑补充次数
    /// </summary>
    public const string My_FiberElectronicTrace= "sv_LogicCorrectionBlock";

    public const string My_FlockFiberElectronicTrace= "sv_FloatLogicCorrectionBlock";
    /// <summary>
    /// 震动
    /// </summary>
    public const string My_OnAstound= "sv_IsVibrate";

    /// <summary>
    /// setting页面返回
    /// </summary>
    public const string My_LifewayTwig= "sv_SettingHome";

    /// <summary>
    /// 游戏规则
    /// </summary>
    public const string My_SolidTownBulb= "sv_GuideGameRule";
    
    /// <summary>
    /// 游戏引导
    /// </summary>
    public const string My_SolidTownFur= "sv_GuideGameSch";

    /// <summary>
    /// 换天
    /// </summary>
    public const string My_EyeDugoutRender= "sv_DayRecordWidget";

    /// <summary>
    /// 是否显示评价弹窗
    /// </summary>
    public const string My_Remind= "sv_Rateus";

    /// <summary>
    /// 是否失败过
    /// </summary>
    public const string My_OnFanner= "sv_IsRevive";

    /// <summary>
    /// 经典模式是否结束
    /// </summary>
    public const string My_SomehowBylaw= "sv_ClassicBonus";
    
    #endregion

    #region 监听发送的消息

    /// <summary>
    /// 有窗口打开
    /// </summary>
    public static string Of_LawyerAbut= "mg_WindowOpen";
    /// <summary>
    /// 窗口关闭
    /// </summary>
    public static string Of_LawyerWheel= "mg_WindowClose";
    /// <summary>
    /// 关卡结算时传值
    /// </summary>
    public static string Of_Up_Indiscernible= "mg_ui_levelcomplete";
    /// <summary>
    /// 增加金币
    /// </summary>
    public static string Of_Up_Pigment= "mg_ui_addgold";
    /// <summary>
    /// 增加钻石/现金
    /// </summary>
    public static string Of_Up_Director= "mg_ui_addtoken";
    /// <summary>
    /// 增加钻石/现金
    /// </summary>
    public static string Of_Up_DirectorFlannel= "mg_ui_addtokenSpecial";
    /// <summary>
    /// 增加amazon
    /// </summary>
    public static string Of_Up_Retentive= "mg_ui_addamazon";

    /// <summary>
    /// 游戏暂停/继续
    /// </summary>
    public static string Of_TownDensity= "mg_GameSuspend";

    /// <summary>
    /// 游戏资源数量变化
    /// </summary>
    public static string Of_PackOutwit_= "mg_ItemChange_";

    /// <summary>
    /// 更新关卡目标数
    /// </summary>
    public static string Of_AbsenceParisStrict= "mg_RefreshLevelTarget";
    
    /// <summary>
    /// 刷新分数信息
    /// </summary>
    public static string Of_AbsenceAthens= "mg_RefreshSource";
    
    /// <summary>
    /// 刮刮卡奖励
    /// </summary>
    public static string Of_ThereSquash= "mg_ScardReward";

    /// <summary>
    /// 转盘
    /// </summary>
    public static string Of_PerchUI= "mg_WheelUI";
    
    /// <summary>
    /// 脑力
    /// </summary>
    public static string Of_HyperUI= "mg_BrainUI";

    /// <summary>
    /// 关闭引导页面
    /// </summary>
    public static string Of_WheelAndComSolid= "mg_CloseAndComGuide";
    
    /// <summary>
    /// 引导判断
    /// </summary>
    public static string Of_OutwitSolidTownBulb= "mg_ChangeGuideGameRule";

    #endregion

    #region 动态加载资源的路径

    // 金币图片
    public static string Kill_RideDeem_Subway= "Art/Tex/UI/jiangli1";
    // 钻石图片
    public static string Kill_Briny_Subway_Rocket= "Art/Tex/UI/jiangli4";
    /// <summary>
    /// 方块路径
    /// </summary>
    public static string Kill_Trace= "Prefab/TraceEnrichTraceLiter";

    #endregion
}


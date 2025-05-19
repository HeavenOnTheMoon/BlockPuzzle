using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using System;
public class TripGlassSevere : CoatOutnumber<TripGlassSevere>
{
    public string Finnish= "1.2";
    public string TownSpin= PryTellOwn.instance.TownSpin;
    //channel
#if UNITY_IOS
    private string Adverse= "AppStore";
#elif UNITY_ANDROID
    private string Channel = "GooglePlay";
#else
    private string Channel = "GooglePlay";
#endif


    private void OnApplicationPause(bool pause)
    {
        TripGlassSevere.EraChlorine().CanyTownHomesick();
    }
    
    public Text Halt;

    protected override void Awake()
    {
        base.Awake();
        
        Finnish = Application.version;
        StartCoroutine("OnlyAnemone");
    }
    IEnumerator OnlyAnemone()
    {
        while (true)
        {
            yield return new WaitForSeconds(120f);
            TripGlassSevere.EraChlorine().CanyTownHomesick();
        }
    }
    private void Start()
    {
        if (FailWiseWorship.EraWit("event_day") != DateTime.Now.Day && FailWiseWorship.EraThrive("user_servers_id").Length != 0)
        {
            FailWiseWorship.FatWit("event_day", DateTime.Now.Day);
        }
    }
    public void RichMeDungGlass(string event_id)
    {
        RichGlass(event_id);
    }
    public void CanyTownHomesick(List<string> valueList = null)
    {
        if (FailWiseWorship.EraPotato(CBarter.My_NeurosporaRideDeem) == 0)
        {
            FailWiseWorship.FatPotato(CBarter.My_NeurosporaRideDeem, FailWiseWorship.EraPotato(CBarter.My_RideDeem));
        }
        if (FailWiseWorship.EraPotato(CBarter.My_NeurosporaBriny) == 0)
        {
            FailWiseWorship.FatPotato(CBarter.My_NeurosporaBriny, FailWiseWorship.EraPotato(CBarter.My_Briny));
        }
        if (valueList == null)
        {
            valueList = new List<string>() { 
                FailWiseWorship.EraWit(CBarter.My_NeurosporaRideDeem).ToString(),
                FailWiseWorship.EraThrive(CBarter.My_NeurosporaBriny),
                (TraceEnrichParisWorship.Instance.EraLawParis() + 1).ToString()
                //FailWiseWorship.GetInt(SlotConfig.sv_SlotSpinCount).ToString()
            };
        }
        
        if (FailWiseWorship.EraThrive(CBarter.My_KrillSneezeSo) == null)
        {
            return;
        }
        WWWForm wwwForm = new WWWForm();
        wwwForm.AddField("gameCode", TownSpin);
        wwwForm.AddField("userId", FailWiseWorship.EraThrive(CBarter.My_KrillSneezeSo));

        wwwForm.AddField("gameVersion", Finnish);

        wwwForm.AddField("channel", Adverse);

        for (int i = 0; i < valueList.Count; i++)
        {
            wwwForm.AddField("resource" + (i + 1), valueList[i]);
        }



        StartCoroutine(RichTrip(PryTellOwn.instance.TineEat + "/api/client/game_progress", wwwForm,
        (error) =>
        {
            Debug.Log(error);
        },
        (message) =>
        {
            Debug.Log(message);
        }));
    }
    public void RichGlass(string event_id, string p1 = null, string p2 = null, string p3 = null)
    {
        if (Halt != null)
        {
            if (int.Parse(event_id) < 9100 && int.Parse(event_id) >= 9000)
            {
                if (p1 == null)
                {
                    p1 = "";
                }
                Halt.text += "\n" + DateTime.Now.ToString() + "id:" + event_id + "  p1:" + p1;
            }
        }
        if (FailWiseWorship.EraThrive(CBarter.My_KrillSneezeSo) == null)
        {
            PryTellOwn.instance.Glare();
            return;
        }
        WWWForm wwwForm = new WWWForm();
        wwwForm.AddField("gameCode", TownSpin);
        wwwForm.AddField("userId", FailWiseWorship.EraThrive(CBarter.My_KrillSneezeSo));
        //Debug.Log("userId:" + FailWiseWorship.GetString(CBarter.sv_LocalServerId));
        wwwForm.AddField("version", Finnish);
        //Debug.Log("version:" + version);
        wwwForm.AddField("channel", Adverse);
        //Debug.Log("channel:" + channal);
        wwwForm.AddField("operateId", event_id);
        Debug.Log("operateId:" + event_id);


        if (p1 != null)
        {
            wwwForm.AddField("params1", p1);
        }
        if (p2 != null)
        {
            wwwForm.AddField("params2", p2);
        }
        if (p3 != null)
        {
            wwwForm.AddField("params3", p3);
        }
        StartCoroutine(RichTrip(PryTellOwn.instance.TineEat + "/api/client/log", wwwForm,
        (error) =>
        {
            Debug.Log(error);
        },
        (message) =>
        {
            Debug.Log(message);
        }));
    }
    IEnumerator RichTrip(string _url, WWWForm wwwForm, Action<string> fail, Action<string> success)
    {
        //Debug.Log(SerializeDictionaryToJsonString(dic));
        using UnityWebRequest request = UnityWebRequest.Post(_url, wwwForm);
        yield return request.SendWebRequest();
        if (request.isNetworkError || request.isNetworkError)
        {
            fail(request.error);
            FadNonself();
        }
        else
        {
            success(request.downloadHandler.text);
            FadNonself();
        }
    }
    private void FadNonself()
    {
        StopCoroutine("SendGet");
    }


}
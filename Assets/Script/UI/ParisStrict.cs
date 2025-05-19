using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using Image = UnityEngine.UI.Image;
using TMPro;

public class ParisStrict : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("Mask")]
    public GameObject Feat;
[UnityEngine.Serialization.FormerlySerializedAs("BG")]    public GameObject BG;
[UnityEngine.Serialization.FormerlySerializedAs("targetList")]    public List<GameObject> LoggerPity;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnEnable()
    {
        Feat.GetComponent<Image>().color = new UnityEngine.Color(0f,0f,0f,0.62f);
        BG.GetComponent<Image>().color = new UnityEngine.Color(1, 1, 1, 1);
        BG.transform.localScale = new Vector3(0, 0, 0);
        
    }

    public void Vine(List<GameObject> GamepanelBlockGroupList) 
    {

        for (int i = 0; i < GamepanelBlockGroupList.Count; i++)
        {
            GamepanelBlockGroupList[i].transform.localScale = new Vector3(0,0,0);
            if (TraceEnrichParisWorship.Instance.Strict.ContainsKey(i + 2))
            {
                LoggerPity[i].SetActive(true);
                LoggerPity[i].GetComponent<Image>().sprite = GamepanelBlockGroupList[i].transform.GetComponent<Image>().sprite;
                LoggerPity[i].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = TraceEnrichParisWorship.Instance.Strict[i + 2];
            }
            else 
            {
                LoggerPity[i].SetActive(false);
            }
        }
    }

    public void TuneFossilize(List<GameObject> GamepanelBlockGroupList,System.Action finish = null) 
    {
        Vine(GamepanelBlockGroupList);
        BG.transform.DOScale(1, 0.5f).SetEase(Ease.OutBack).OnComplete(()=> 
        {
            BG.transform.DOScale(1, 1f).OnComplete(() => 
            {
                BG.GetComponent<Image>().DOFade(0, 0.6f);
                Feat.GetComponent<Image>().DOFade(0, 0.6f);
                for (int i = 0; i < LoggerPity.Count; i++)
                {
                    int A = 0;
                    A = i;
                    GameObject Fare= Instantiate(LoggerPity[i],this.transform);
                    Fare.transform.position = LoggerPity[i].transform.position;
                    LoggerPity[i].SetActive(false);

                    if (Fare.activeSelf)
                    {
                        Fare.transform.DOMove(GamepanelBlockGroupList[i].transform.position, 0.6f).SetEase(Ease.InQuad).OnComplete(() =>
                        {
                            Destroy(Fare);
                            this.gameObject.SetActive(false);
                            if(A == LoggerPity.Count - 1)
                                finish();
                        });
                    }
                    else 
                    {
                        Fare.transform.DOMove(GamepanelBlockGroupList[i].transform.position, 0.6f).SetEase(Ease.InQuad).OnComplete(() =>
                        {
                            Destroy(Fare);
                            if(A == LoggerPity.Count - 1)
                                finish();
                        });
                    }
                }
            });
        });
        
    }

}

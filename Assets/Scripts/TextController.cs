using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TextController : MonoBehaviour
{
    public List<string> Lyrics;
    List<string> PresentLyrics=new List<string>();
    int LyricNum=0;
    float timer;
    bool bl0=false;
    bool bl1=false;
    bool bl2=false;
    bool bl3=false;
    bool bl4=false;
    bool bl5=false;
    bool bl6=false;
    bool bl7=false;
    bool bl8=false;
    bool bl9=false;
    bool bl10=false;
    bool bl11=false;

    void Start()
    {
        Invoke(nameof(SetLyric), 3.0f);//SetLyric大佐に3秒だけ待ってもらう
        Debug.Log("ready");
        //SetLyric();
    }

    void Update()
    {
        timer+=Time.deltaTime;
        if(Input.GetMouseButtonDown(0))
        {
            SetLyric();
        }
        if(timer>=5.0f&&bl0==false)
        {
            Debug.Log("textchange");
            bl0=true;
            SetLyric();
        }
        if(timer>=8.0f&&bl1==false)
        {
            Debug.Log("textchange");
            bl1=true;
            SetLyric();
        }
        if(timer>=11.0f&&bl2==false)
        {
            Debug.Log("textchange");
            bl2=true;
            SetLyric();
        }
        if(timer>=14.0f&&bl3==false)
        {
            Debug.Log("textchange");
            bl3=true;
            SetLyric();
        }
        if(timer>=17.0f&&bl4==false)
        {
            Debug.Log("textchange");
            bl4=true;
            SetLyric();
        }
        if(timer>=20.0f&&bl5==false)
        {
            Debug.Log("textchange");
            bl5=true;
            SetLyric();
        }
        if(timer>=23.0f&&bl6==false)
        {
            Debug.Log("textchange");
            bl6=true;
            SetLyric();
        }
        if(timer>=27.0f&&bl7==false)
        {
            Debug.Log("textchange");
            bl7=true;
            SetLyric();
        }
        if(timer>=30.0f&&bl8==false)
        {
            Debug.Log("textchange");
            bl8=true;
            SetLyric();
        }
        if(timer>=33.0f&&bl9==false)
        {
            Debug.Log("textchange");
            bl9=true;
            SetLyric();
        }
        if(timer>=36.0f&&bl10==false)
        {
            Debug.Log("textchange");
            bl10=true;
            SetLyric();
        }
        if(timer>=39.0f&&bl11==false)
        {
            Debug.Log("textchange");
            bl11=true;
            SetLyric();
        }
    }

    void SetLyric()
    {
        if(Lyrics.Count>LyricNum)
        {
            PresentLyrics.Add(Lyrics[LyricNum]);
            if(PresentLyrics.Count>=3)
            {
                PresentLyrics.RemoveAt(0);
            }
            gameObject.GetComponent<Text>().text="";
            foreach(string st in PresentLyrics)
            {
                gameObject.GetComponent<Text>().text+=st;
            }
            LyricNum+=1;
        }
    }
}

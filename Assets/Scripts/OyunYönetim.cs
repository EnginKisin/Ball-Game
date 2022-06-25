using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyunYönetim : MonoBehaviour
{
    public static int skor1 = 0;
    public static int skor2 = 0;
    public GUISkin ekran;
    GameObject topum;

    void Start()
    {
        topum = GameObject.FindGameObjectWithTag("Top");
    }

    public static void Skor(string duvar)
    {
        if (duvar == "duvarSag")
        {
            skor1++;
        }
        else if (duvar == "duvarSol")
        {
            skor2++;
        }
    }

    private void OnGUI()
    {
        GUI.skin = ekran;
        GUI.contentColor = Color.red;
        GUI.Label(new Rect(Screen.width / 2 - 150 - 12, 20, 100, 100), "" + skor1);
        GUI.Label(new Rect(Screen.width / 2 + 150 + 12, 20, 100, 100), "" + skor2);

        if (GUI.Button(new Rect(Screen.width / 2 - 60, 35, 120, 53), "RESTART"))
        {
            skor1 = 0;
            skor2 = 0;
            topum.SendMessage("YenidenBaslat", 0.5f, SendMessageOptions.RequireReceiver);
        }

        if (skor1 == 5)
        {
            GUI.Label(new Rect(Screen.width / 2 - 80, 180, 2000, 2000), "1.Oyuncu Kazandı");
            topum.SendMessage("TopuSıfırla", null, SendMessageOptions.RequireReceiver);
        }
        else if (skor2 == 5)
        {
            GUI.Label(new Rect(Screen.width / 2 - 80, 180, 2000, 2000), "2.Oyuncu Kazandı");
            topum.SendMessage("TopuSıfırla", null, SendMessageOptions.RequireReceiver);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}

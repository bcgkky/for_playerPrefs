using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerpref : MonoBehaviour
{
    public Text text1;
    public Text text2;
    public Text text3;

    public InputField eleman1, eleman2, eleman3;
    public Slider slider;

    void Start()
    {
        /*PlayerPrefs.SetInt("ParaDegeri", 89);
        PlayerPrefs.SetFloat("saglik", 44f);
        //PlayerPrefs.Save(); //bu komutun hangi satırda olduğunun önemi yok, playerprefs öncelikle oluşturulan ne varsa onları yapar sonra kaydeder.
        PlayerPrefs.SetString("ad", "bcgkky");*/

        text1.text = PlayerPrefs.GetInt("ParaDegeri").ToString();
        text3.text = PlayerPrefs.GetFloat("saglik").ToString();
        text2.text = PlayerPrefs.GetString("ad").ToString();

        Debug.Log(PlayerPrefs.GetInt("ParaDegeri").ToString());
        //PlayerPrefs.SetInt("ParaDegeri", 50);
        //PlayerPrefs.SetInt("ParaDegeri", PlayerPrefs.GetInt("ParaDegeri") + 12);
        Debug.Log(PlayerPrefs.GetInt("ParaDegeri").ToString());

        if (PlayerPrefs.HasKey("ParaDegeri")) Debug.Log("he var");
        else Debug.Log("yok bre");

        //PlayerPrefs.DeleteKey("saglik");

        Equals("ParaDegeri", "saglik"); //PlayerPrefs.Equals();

        slider.value = PlayerPrefs.GetFloat("saglik");

    }

    public void hepsiniSil()
    {
        PlayerPrefs.DeleteAll();
        veriGuncelle();
    }

    public void verileriYaz()
    {
        PlayerPrefs.SetInt("ParaDegeri", 89);
        PlayerPrefs.SetFloat("saglik", 44f);
        PlayerPrefs.SetString("ad", "bcgkky");
        PlayerPrefs.Save();
        veriGuncelle();

    }

    void veriGuncelle()
    {
        text1.text = PlayerPrefs.GetInt("ParaDegeri").ToString();
        text3.text = PlayerPrefs.GetFloat("saglik").ToString();
        text2.text = PlayerPrefs.GetString("ad").ToString();
    }

    public void yeniVeriler()
    {
        if (eleman1.text != "")
            PlayerPrefs.SetInt("ParaDegeri", int.Parse(eleman1.text));
        if (eleman3.text != "")
            PlayerPrefs.SetFloat("saglik", float.Parse(eleman3.text));
        if (eleman2.text != "")
            PlayerPrefs.SetString("ad", eleman2.text);
        veriGuncelle();
    }

    public void AnlikGuncelle(float deger)
    {
        PlayerPrefs.SetFloat("saglik", deger);
        veriGuncelle();
    }

}

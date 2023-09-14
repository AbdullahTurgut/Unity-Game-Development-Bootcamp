using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dolgu : MonoBehaviour
{
    public float dolgu = 8f;
    public float elemanBoyutGenislik = 150f;
    public float istenilenAralikUzunluk = 200f;

    private RectTransform rt;
    private int elemanMiktari;
    private float icerikBoyutu;
    void Start()
    {
        rt = GetComponent<RectTransform>();

    }

    void Update()
    {
        elemanMiktari = rt.childCount;
        icerikBoyutu = ((elemanMiktari * (elemanBoyutGenislik + dolgu)) - istenilenAralikUzunluk) * rt.localScale.x;

        if (rt.localPosition.x > dolgu)
        {
            rt.localPosition = new Vector3(dolgu, rt.localPosition.y, rt.localPosition.z);
        }
        else if(rt.localPosition.x < -icerikBoyutu)
        {
            rt.localPosition = new Vector3(-icerikBoyutu, rt.localPosition.y, rt.localPosition.z);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] Top _Top;
    [SerializeField] GameObject[] Ip_Merkezleri;
    [SerializeField] private int SahipOlunanTopSayisi;
    [SerializeField] private int DevrilmesiGerekenSayisi;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (hit.collider != null) //Eger isin herhangi bir carpisma yapiyorsa.
            {
                if (hit.collider.gameObject.CompareTag("Merkez_1"))
                {
                    hit.collider.gameObject.SetActive(false);
                    //_Top.HingeKontrol["Merkez_1"].enabled = false; //Bu ipe ait baglanti noktalarini yok et. Sadece top.

                    //foreach (var item in Ip_Merkezleri) //Tum baglantilari yoket.
                    //{
                    //   if(item.GetComponent<Ip_Yonetimi>().HingeAdi == "Merkez_1")
                    //    {
                    //        foreach (var item2 in item.GetComponent<Ip_Yonetimi>().BaglantiHavuzu)
                    //        {
                    //            item2.SetActive(false);
                    //        }
                    //    }
                    //}

                    CarpismaYakala("Merkez_1");
                }
                else if (hit.collider.gameObject.CompareTag("Merkez_2"))
                {
                    hit.collider.gameObject.SetActive(false);
                    //_Top.HingeKontrol["Merkez_2"].enabled = false;

                    //foreach (var item in Ip_Merkezleri) 
                    //{
                    //    if (item.GetComponent<Ip_Yonetimi>().HingeAdi == "Merkez_2")
                    //    {
                    //        foreach (var item2 in item.GetComponent<Ip_Yonetimi>().BaglantiHavuzu)
                    //        {
                    //            item2.SetActive(false);
                    //        }
                    //    }
                    //}

                    CarpismaYakala("Merkez_2");
                }
                else if (hit.collider.gameObject.CompareTag("Merkez_3"))
                {
                    hit.collider.gameObject.SetActive(false);
                    //_Top.HingeKontrol["Merkez_3"].enabled = false;

                    //foreach (var item in Ip_Merkezleri)
                    //{
                    //    if (item.GetComponent<Ip_Yonetimi>().HingeAdi == "Merkez_3")
                    //    {
                    //        foreach (var item2 in item.GetComponent<Ip_Yonetimi>().BaglantiHavuzu)
                    //        {
                    //            item2.SetActive(false);
                    //        }
                    //    }
                    //}

                    CarpismaYakala("Merkez_3");
                }
                else if (hit.collider.gameObject.CompareTag("Merkez_4"))
                {
                    hit.collider.gameObject.SetActive(false);
                    //_Top.HingeKontrol["Merkez_4"].enabled = false;

                    //foreach (var item in Ip_Merkezleri)
                    //{
                    //    if (item.GetComponent<Ip_Yonetimi>().HingeAdi == "Merkez_4")
                    //    {
                    //        foreach (var item2 in item.GetComponent<Ip_Yonetimi>().BaglantiHavuzu)
                    //        {
                    //            item2.SetActive(false);
                    //        }
                    //    }
                    //}

                    CarpismaYakala("Merkez_4");
                }
            }
        }
    }

    public void CarpismaYakala(string HingeAdi)
    {
        foreach (var item in Ip_Merkezleri)
        {
            if (item.GetComponent<Ip_Yonetimi>().HingeAdi == HingeAdi)
            {
                foreach (var item2 in item.GetComponent<Ip_Yonetimi>().BaglantiHavuzu)
                {
                    item2.SetActive(false);
                }
            }
        }
    }

    public void TopDustu()
    {
        SahipOlunanTopSayisi--;
        if (SahipOlunanTopSayisi == 0)
        {
            if (DevrilmesiGerekenSayisi > 0)
            {
                Debug.Log("Lose");
            }
            else if (DevrilmesiGerekenSayisi == 0)
            {
                Debug.Log("Win!!!");
            }
        }
        else
        {
            if (DevrilmesiGerekenSayisi == 0)
            {
                Debug.Log("Win!!!");
            }
        }
    }

    public void HedefObjeDustu()
    {
        DevrilmesiGerekenSayisi--;

        if (SahipOlunanTopSayisi == 0 && DevrilmesiGerekenSayisi == 0)
        {
            Debug.Log("Win!!!");
        }
        else if (SahipOlunanTopSayisi == 0 && DevrilmesiGerekenSayisi != 0)
        {
            Debug.Log("Lose");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ip_Yonetimi : MonoBehaviour
{
    [SerializeField] Rigidbody2D Ilk_Kanca; //Ipin baslangici.
    [SerializeField] Top _Top; //Son baglanti noktasi.
    [SerializeField] int BaglantiSayisi;
    //public GameObject BaglantiPrefab;
    public GameObject[] BaglantiHavuzu;
    public string HingeAdi;

    void Start()
    {
        Ip_Olustur();
    }

    void Ip_Olustur()
    {
        Rigidbody2D OncekiBaglanti = Ilk_Kanca; //Bir sonraki olusturulacak baglanti nereye baglanacak. Ornegin script 4. baglantiyi olusturdu. 3'e baglan.

        for (int i = 0; i < BaglantiSayisi; i++)
        {
            //GameObject Baglanti = Instantiate(BaglantiPrefab, transform);
            //HingeJoint2D joint = Baglanti.GetComponent<HingeJoint2D>();
            //joint.connectedBody = OncekiBaglanti; //Baglanti olustur.

            //if(i < BaglantiSayisi - 1)
            //{
            //    OncekiBaglanti = Baglanti.GetComponent<Rigidbody2D>(); //Bir sonraki kanca baglansin diye baglanti noktasini yeniledik.
            //}
            //else //Son kancayi topa bagla.
            //{
            //    _Top.SonZinciriBagla(Baglanti.GetComponent<Rigidbody2D>());
            //}

            BaglantiHavuzu[i].SetActive(true);
            HingeJoint2D joint = BaglantiHavuzu[i].GetComponent<HingeJoint2D>();
            joint.connectedBody = OncekiBaglanti; //Baglanti olustur.

            if (i < BaglantiSayisi - 1)
            {
                OncekiBaglanti = BaglantiHavuzu[i].GetComponent<Rigidbody2D>(); //Bir sonraki kanca baglansin diye baglanti noktasini yeniledik.
            }
            else //Son kancayi topa bagla.
            {
                _Top.SonZinciriBagla(BaglantiHavuzu[i].GetComponent<Rigidbody2D>(), HingeAdi);
            }
        }
    }
}

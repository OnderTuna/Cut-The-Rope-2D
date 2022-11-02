using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Top : MonoBehaviour
{
    [SerializeField] float ZincirIleOlanMesafe = .2f;
    public Dictionary<string, HingeJoint2D> HingeKontrol = new Dictionary<string, HingeJoint2D>(); //Anahtar ve deger ikilisi tutan liste. Anahtar hangi merkez, deger ise eklenti noktasi.

    public void SonZinciriBagla(Rigidbody2D SonZincir, string HingeAdi)
    {
        HingeJoint2D joint = gameObject.AddComponent<HingeJoint2D>();
        HingeKontrol.Add(HingeAdi, joint); //Ýlki hangi merkez, ikincisi eklenen joint.
        joint.autoConfigureConnectedAnchor = false; //Script tarafinda kontrol edecegimiz icin kapali.
        joint.connectedBody = SonZincir; //Topun baglanacagi son baglanti.
        joint.anchor = Vector2.zero;
        joint.connectedAnchor =  new Vector2(0f, -ZincirIleOlanMesafe); //Top ile zincir arasi mesafe.
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TopKontrol : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody fizik;
    public float hız;
    int sayac=0;
    public int toplanacakobjesayısı;
    public Text sayacText;
    public Text oyunBittiText;
    void Start()
    {
         fizik = GetComponent < Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float yatay = Input.GetAxisRaw("Horizontal");
        float dikey = Input.GetAxisRaw("Vertical");
        Vector3 vec = new Vector3(yatay, 0, dikey);
        fizik.AddForce(vec*hız);

    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "engel")
        {
            other.gameObject.SetActive(false);
            sayac++;
            sayacText.text = "Skor: " + sayac;
            if (sayac== toplanacakobjesayısı)
            {
                oyunBittiText.text = "Oyun Bitti!";
                SceneManager.LoadScene(0);
                
            }
        }
    }

}

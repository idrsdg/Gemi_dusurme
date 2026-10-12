using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PilVeDirenc : MonoBehaviour {

    // Start is called before the first frame update


    Vector3 ilkpos;
    bool surukle = false;
    bool icerdemi = false;

    GameObject anahtar;

    public void ilkpozisyonadon()
    {
        this.transform.position = ilkpos;
    }

    void Start()
    {

        ilkpos = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {

    }


    void OnMouseDown()
    {
        surukle = true;
        Debug.Log("Tıklandı");
    }
    void OnMouseUp()
    {
        surukle = false;

        if (!icerdemi)
        {
            this.transform.position = ilkpos;
        }
        else
        {
            if (anahtar != null)
            {

                    Vector3 merkez = anahtar.transform.position;
                   
                    this.transform.position = new Vector3(merkez.x , merkez.y, merkez.z);
            }
        }
    }
    void OnMouseDrag()
    {
        if (surukle)
        {
            Vector3 newpos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            this.transform.position = new Vector3(newpos.x, newpos.y, 0);

        }
    }
    public string eslesmedurumu = "eslesmedi";
    public string hedefadi = "";

    void OnTriggerEnter2D(Collider2D col)
    {
        if (hedefadi == col.gameObject.name)
        {
            eslesmedurumu = "dogru";
        }
        else
        {
            eslesmedurumu = "yanlis";
        }
        anahtar = col.gameObject;
        Debug.Log("Obje içerde");
        icerdemi = true;
    }

    void OnTriggerExit2D(Collider2D col)
    {
        eslesmedurumu = "eslesmedi";
        anahtar = null;
        Debug.Log("Obje Dışarda");
        icerdemi = false;
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        this.gameObject.transform.position = ilkpos;
    }
}

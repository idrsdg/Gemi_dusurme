using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CODE : MonoBehaviour {

    // Start is called before the first frame update
    public GameObject iletken;
    public GameObject volt1;
    public GameObject volt2;
    public GameObject resist1;
    public GameObject resist2;
    public GameObject kazandin;
    public GameObject tekrar;
    public GameObject isik1;
    public GameObject isik2;
    public GameObject isik3;
    public GameObject isik4;
    public GameObject isik5;


    Vector3 volt1pos;
    Vector3 volt2pos;
    Vector3 resist1pos;
    Vector3 resist2pos;

    void Start()
    {
        volt1pos = volt1.transform.position;
        volt2pos = volt2.transform.position;
        resist1pos = resist1.transform.position;
        resist2pos = resist2.transform.position;

    }

    public void tekrarbuttons()
    {
        volt1.transform.position = volt1pos;
        volt2.transform.position = volt2pos;
        resist1.transform.position = resist1pos;
        resist2.transform.position = resist2pos;
        iletken.transform.eulerAngles = new Vector3(0, 0, 0);
        tekrar.SetActive(false);
        kazandin.SetActive(false);
        isik1.SetActive(false);
        isik2.SetActive(false);
        isik3.SetActive(false);
        isik4.SetActive(false);
        isik5.SetActive(false);
    }

    public void GeriAl()
    {
        volt1.transform.position = volt1pos;
        volt2.transform.position = volt2pos;
        resist1.transform.position = resist1pos;
        resist2.transform.position = resist2pos;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void iletkenhareket()
    {
        StartCoroutine(iletkendon());
    }
    IEnumerator iletkendon()
    {


        float yeniaci = iletken.transform.eulerAngles.z;

        while (yeniaci < 90)
        {
            yeniaci++;
            yield return new WaitForSeconds(0.01f);
            iletken.transform.eulerAngles = new Vector3(0, 0, yeniaci);
        }


        yield return new WaitForSeconds(0.01f);
        iletken.transform.eulerAngles = new Vector3(0, 0, 90);

        if(volt1.transform.position!=volt1pos && volt2.transform.position != volt2pos)
        {
            kazandin.SetActive(true);
            Debug.Log("1st");
            isik1.SetActive(true);
            
        }
        if (volt1.transform.position != volt1pos && resist2.transform.position != resist2pos)
        {
            tekrar.SetActive(true);
            Debug.Log("2nd");
            isik2.SetActive(true);
        }
        if (volt1.transform.position != volt1pos && resist1.transform.position != resist1pos)
        {
            tekrar.SetActive(true);
            Debug.Log("3rd");
            isik3.SetActive(true);
        }
        if (volt2.transform.position != volt2pos && resist2.transform.position != resist2pos)
        {
            tekrar.SetActive(true);
            Debug.Log("4th");
            isik4.SetActive(true);
        }
        if (volt2.transform.position != volt2pos && resist1.transform.position != resist1pos)
        {
            tekrar.SetActive(true);
            Debug.Log("5th");
            isik5.SetActive(true);
        }

        if(volt1.transform.position!= volt1pos &&  volt2.transform.position == volt2pos &&
            resist1.transform.position == resist1pos && resist2.transform.position == resist2pos || volt2.transform.position != volt2pos &&
            volt1.transform.position == volt1pos && 
            resist1.transform.position == resist1pos && resist2.transform.position == resist2pos || resist1.transform.position != resist1pos && 
            volt1.transform.position == volt1pos && volt2.transform.position == volt2pos &&
            resist2.transform.position == resist2pos ||
            resist2.transform.position!=resist2pos && volt1.transform.position == volt1pos && volt2.transform.position == volt2pos &&
            resist1.transform.position == resist1pos  || volt1.transform.position == volt1pos && volt2.transform.position == volt2pos &&
            resist1.transform.position == resist1pos && resist2.transform.position == resist2pos || 
            resist1.transform.position != resist1pos && resist2.transform.position != resist2pos)
        {
            tekrar.SetActive(true);
            Debug.Log("calismaz");
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour {

    // Start is called before the first frame update
    public GameObject iletken;

    void Start()
    {
      

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

    }
}

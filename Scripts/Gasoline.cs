using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Gasoline : MonoBehaviour
{
    public int gas = 0;
    public bool hasGas = false;
    public GameObject gasImage;
    public TMP_Text gasCount;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        gasCount.text = gas.ToString();
    }
}

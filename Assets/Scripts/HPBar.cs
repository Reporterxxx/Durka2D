using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPBar : MonoBehaviour
{

    public Image bar; //чтобы привязать картинку к персонажу
    public float fill; //для регулировки заполнения хп и возможности менять его

    // Start is called before the first frame update
    void Start()
    {
        fill = 1f; // 100% хп
    }

    // Update is called once per frame
    void Update()
    {
        bar.fillAmount = fill;
    }
}

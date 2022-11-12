using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class HP_SYSTEM : MonoBehaviour
{
    public TextMeshProUGUI hp_ui_display;
    public int hp_count;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        hp_ui_display.text = hp_count.ToString();
    }
}

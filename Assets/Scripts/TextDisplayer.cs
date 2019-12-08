using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TextMeshProUGUI
public class TextDisplayer : MonoBehaviour
{
    // Start is called before the first frame update
    private TextMeshProUGUI Score;
    
    void Start()
    {
        Score = getComponent<TextMeshProUGUI> ();

    }

    // Update is called once per frame
    void Update()
    {
        Score.text = .toString(timeOnTarget);
    }
}

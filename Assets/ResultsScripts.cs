using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultsScripts : MonoBehaviour
{
    public Text txtScore;
    public Text txtRecord;
    void Start()
    {
        txtScore.text = GameManager.Instance.score.ToString("F2");
        txtRecord.text = GameManager.Instance.record.ToString("F2");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

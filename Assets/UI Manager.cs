using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public void OnButtonClickScene(string value)
    {
        GameManager.Instance.ChangeScene(value);
    }
}

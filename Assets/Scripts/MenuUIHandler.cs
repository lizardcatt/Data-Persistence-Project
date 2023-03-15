using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuUIHandler : MonoBehaviour
{
    [SerializeField] InputField iField;

    public void NameSelected()
    {
        Debug.Log(iField.text);
        DataManager.Instance.Name = iField.text;
    }

    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }
}

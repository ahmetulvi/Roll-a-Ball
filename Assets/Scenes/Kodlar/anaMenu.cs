using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class anaMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public Button basla;
    void Start()
    {
        Button btn = basla.GetComponent<Button>();
        btn.onClick.AddListener(sahne);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void sahne()
    {
        
        SceneManager.LoadScene(1);
    }
    
}

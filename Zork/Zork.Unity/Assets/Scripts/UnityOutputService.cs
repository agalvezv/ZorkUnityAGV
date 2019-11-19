using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zork.Common;
using TMPro;


public class UnityOutputService : MonoBehaviour, IOutputService
{
    [SerializeField]
    private TextMeshProUGUI TextLinePreFab;
    [SerializeField]
    private Transform OutputTextContainer;
    [SerializeField]
    private int MaxTextLines = 60;



    
    
    public UnityOutputService()
    {
        mEntries = new List<GameObject>();
    }

    public void Clear()
    {
        throw new System.NotImplementedException();
    }

    public void Write(string value)
    {
        throw new System.NotImplementedException();
    }

    public void Write(object value)
    {
        throw new System.NotImplementedException();
    }

    public void WriteLine(string value)
    {

        if (mEntries.Count >= MaxTextLines)
        {
            Destroy(mEntries[0]);
            mEntries.RemoveAt(0);
        }
        //throw new System.NotImplementedException();
        //OutputText.text = value;
        var textLine = Instantiate(TextLinePreFab);
        textLine.transform.SetParent(OutputTextContainer, false);
        textLine.text = value;
        mEntries.Add(textLine.gameObject);
    }

    public void WriteLine(object value)
    {
        //throw new System.NotImplementedException();
        WriteLine(value.ToString());
    }

    //
    private List<GameObject> mEntries;

    // Start is called before the first frame update
    //This is the bridge between our game and Unity for output.
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

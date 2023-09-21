using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayBu : MonoBehaviour
{
    public PuzulPlayerCon puzul;
    public Upjudge upjudge;
    public Downjudge downjudge;
    public LeftJudge leftJudge;
    public Rightjudge rightjudge;

    public void Clickedddddddd()
    {
        puzul.Initial();
        upjudge.Prepare();
        downjudge.Prepare();
        leftJudge.Prepare();
        rightjudge.Prepare();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

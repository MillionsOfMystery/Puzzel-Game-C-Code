using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    
    [SerializeField]
    private Transform[] doraeman;

    [SerializeField]
    private GameObject winText;
    public static bool youWin;


    // Start is called before the first frame update
    void Start()
    {
        winText.SetActive(false);
        youWin = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(doraeman[0].rotation.z == 0 &&
           doraeman[1].rotation.z == 0 &&
           doraeman[2].rotation.z == 0 &&
           doraeman[3].rotation.z == 0 &&
           doraeman[4].rotation.z == 0 &&
           doraeman[5].rotation.z == 0 &&
           doraeman[6].rotation.z == 0 &&
           doraeman[7].rotation.z == 0 &&
           doraeman[8].rotation.z == 0 &&
           doraeman[9].rotation.z == 0 &&
           doraeman[10].rotation.z == 0 &&
           doraeman[11].rotation.z == 0 &&
           doraeman[12].rotation.z == 0 &&
           doraeman[13].rotation.z == 0 &&
           doraeman[14].rotation.z == 0 &&
           doraeman[15].rotation.z == 0 &&
           doraeman[16].rotation.z == 0 &&
           doraeman[17].rotation.z == 0 &&
           doraeman[18].rotation.z == 0 &&
           doraeman[19].rotation.z == 0 &&
           doraeman[18].rotation.z == 0 &&
           doraeman[19].rotation.z == 0 &&
           doraeman[20].rotation.z == 0 &&
           doraeman[21].rotation.z == 0 &&
           doraeman[22].rotation.z == 0 &&
           doraeman[23].rotation.z == 0 &&
           doraeman[24].rotation.z == 0 &&
           doraeman[25].rotation.z == 0 &&
           doraeman[26].rotation.z == 0 &&
           doraeman[27].rotation.z == 0 &&
           doraeman[28].rotation.z == 0 &&
           doraeman[29].rotation.z == 0 &&
           doraeman[30].rotation.z == 0 &&
           doraeman[31].rotation.z == 0 &&
           doraeman[32].rotation.z == 0 &&
           doraeman[34].rotation.z == 0 &&
           doraeman[35].rotation.z == 0 &&
           doraeman[36].rotation.z == 0 &&
           doraeman[37].rotation.z == 0 &&
           doraeman[38].rotation.z == 0 &&
           doraeman[39].rotation.z == 0 &&
           doraeman[40].rotation.z == 0 &&
           doraeman[41].rotation.z == 0 &&
           doraeman[42].rotation.z == 0 &&
           doraeman[43].rotation.z == 0 &&
           doraeman[44].rotation.z == 0 &&
           doraeman[45].rotation.z == 0 &&
           doraeman[46].rotation.z == 0 &&
           doraeman[47].rotation.z == 0 &&
           doraeman[48].rotation.z == 0 &&
           doraeman[49].rotation.z == 0 &&
           doraeman[50].rotation.z == 0  )
        {
            youWin = true;
            winText.SetActive(true);
        }
    }
}

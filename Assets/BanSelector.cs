using UnityEngine;
using System.Collections;

public class BanSelector : MonoBehaviour {

    public GameObject roda2;
    public GameObject roda1;

    public int banSelected;

    void Start () {
    
        roda1.SetActive (true);
        roda2.SetActive (false);

        banSelected = 1;
    }
    
    public void ban1 () {

        roda1.SetActive (true);
        roda2.SetActive (false);

        banSelected = 1;
    }

    public void ban2 () {

        roda1.SetActive (false);
        roda2.SetActive (true);

        banSelected = 2;
    }

}
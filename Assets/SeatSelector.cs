using UnityEngine;
using System.Collections;

public class SeatSelector : MonoBehaviour {

    public GameObject seat1;
    public GameObject seat2;

    public int seatSelected;

    void Start () {
    
        seat1.SetActive (true);
		seat2.SetActive (false);

        seatSelected = 1;
    }
    
    public void kursi1 () {

        seat1.SetActive (true);
		seat2.SetActive (false);

        seatSelected = 1;
    }

    public void kursi2 () {

        seat2.SetActive (true);
		seat1.SetActive (false);

        seatSelected = 1;
    }

}
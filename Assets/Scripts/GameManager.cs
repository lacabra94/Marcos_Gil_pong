using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    public int PuntosP1 = 00;
    public int PuntosP2 = 00;
    public string Marcador;
    public TextMeshProUGUI marcadorText;

    // Update is called once per frame
    public void UpdatePointsText()
    {
        Marcador = PuntosP1 + "|" + PuntosP2;
        marcadorText.text = Marcador;
    }
}

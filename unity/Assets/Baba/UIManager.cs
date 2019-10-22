﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text TxtSphere;
    public Text TxtColor;
    public Text TxtTrain;

    private MLClassification _mlClassification;

    private void Start()
    {
        _mlClassification = GetComponent<MLClassification>();
    }

    public void SetNbSphere(Slider val)
    {
       _mlClassification.NbSphere = (int)val.value;
        TxtSphere.text = "Sphère : " +  _mlClassification.NbSphere;
    }
    public void SetNbColor(Slider val)
    {
        _mlClassification.NbColor = (int)val.value;
        TxtColor.text = "Couleurs : " + _mlClassification.NbColor;
    }
    public void SetNbTraining(Slider val)
    {
        _mlClassification.NbTraining = (int)val.value;
        TxtColor.text = "Entrainements : " + _mlClassification.NbColor;
    }
    public void SetPas(Slider val)
    {
        _mlClassification.Pas = val.value;
        TxtColor.text = "Pas : " + _mlClassification.NbColor;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartInstructionsController : MonoBehaviour
{
    public GameObject panelInstruction;

    public void startPanel()
    {
        panelInstruction.SetActive(true);
    }
}

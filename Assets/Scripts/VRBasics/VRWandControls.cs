using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class VRWandControls : MonoBehaviour {

    #region Singleton

    public static VRWandControls instance;

    #endregion

    private void Awake()
    {
        instance = this;
    }

    public WandController wand;

    public VRProgressControlV3D expectoPatronum;

    public string currentSpell;

    private void Start()
    {
        if (GetComponent<VRTK_ControllerEvents>() == null)
        {
            VRTK_Logger.Error(VRTK_Logger.GetCommonMessage(VRTK_Logger.CommonMessageKeys.REQUIRED_COMPONENT_MISSING_FROM_GAMEOBJECT, "Sphere_Spawner", "VRTK_ControllerEvents", "the same"));
            return;
        }

        GetComponent<VRTK_ControllerEvents>().TriggerPressed += new ControllerInteractionEventHandler(DoTriggerPressed);
    }

    private void Update()
    {
        if (currentSpell == "ExpectoPatronum" && GetComponent<VRTK_ControllerEvents>().gripPressed)
        {
            expectoPatronum.InitializeExpectoPatronum();
        }
    }

    private void DoTriggerPressed(object send, ControllerInteractionEventArgs e)
    {
        if (currentSpell == "Expelliarmus")
        {
            wand.InitializeExpelliarmus();
        }
    }
}

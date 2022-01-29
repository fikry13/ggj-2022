using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RealityObjectEvent : RealityObject
{
    [SerializeField]
    private UnityEvent onActivate;
    [SerializeField]
    private UnityEvent onDeactivate;

    public override void Activate()
    {
        if (onActivate != null) onActivate.Invoke();
    }

    public override void Deactivate()
    {
        if (onDeactivate != null) onDeactivate.Invoke();
    }

    [ContextMenu("Duplicate On Activate Event")]
    public void DuplicateOnActivateToDeactivate()
    {
        UnityEditor.EditorUtility.CopySerializedManagedFieldsOnly(onActivate, onDeactivate);
    }

    [ContextMenu("Duplicate On Deactivate Event")]
    public void DuplicateOnDeactivateToActivate()
    {
        UnityEditor.EditorUtility.CopySerializedManagedFieldsOnly(onDeactivate, onActivate);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class RealityObject : MonoBehaviour
{
    [SerializeField]
    private Reality _reality;

    public void OnRealityChange(bool negative)
    {
        if (negative)
        {
            switch(_reality)
            {
                case Reality.Default:
                    Deactivate();
                    break;
                case Reality.Negative:
                case Reality.Both:
                default:
                    Activate();
                        break;
            }
        }
        else
        {
            switch (_reality)
            {
                case Reality.Negative:
                    Deactivate();
                    break;
                case Reality.Default:
                case Reality.Both:
                default:
                    Activate();
                    break;
            }
        }
    }

    public abstract void Activate();
    public abstract void Deactivate();
}

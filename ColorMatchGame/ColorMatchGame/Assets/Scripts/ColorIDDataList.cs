using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]

public class ColorIDDataList : ScriptableObject
{
    public List<ColorID> colorIDList;
    public ColorID currentColor;
    private int num;

    public void SetCurrentColorRandomly()
    {
        num = colorIDList.Count-1;
        currentColor = colorIDList[num];
    }
}

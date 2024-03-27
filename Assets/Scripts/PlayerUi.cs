using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUi : MonoBehaviour
{
    public AutoFade leftScratch;
    public AutoFade rightScratch;

    public void ShowLeft() => leftScratch.Show();
    public void ShowRight() => rightScratch.Show();
}

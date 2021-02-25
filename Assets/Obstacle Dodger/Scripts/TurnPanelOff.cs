using UnityEngine;

public class TurnPanelOff : MonoBehaviour
{
    private void Start()
    {
        gameObject.SetActive(true);
    }

    public void PanelOff()
    {
        gameObject.SetActive(false);
    }
}

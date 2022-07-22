using UnityEngine;
public class Options : MonoBehaviour
{
    [SerializeField]  private GameObject obj;
    public void OnMouseUp()
    {
        obj.SetActive(!obj.activeSelf);
    }
}

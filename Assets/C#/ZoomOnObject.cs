using UnityEngine;

public class ZoomOnObject : MonoBehaviour
{
    [SerializeField] private Transform _picture;
    [SerializeField] private Transform _marker;
    [SerializeField] private Transform _parens;
    [SerializeField] private GameObject _gag;
    Vector3 _normalPositiom;
    Vector3 _normalScale;
    bool conter = true;
    private void Awake()
    {
         _normalPositiom = _picture.localPosition;
         _normalScale = _picture.localScale;
    }
    public void OnMouseUp()
    {
        if (conter == true)
        {
            _gag.SetActive(true);
            _picture.position = _marker.position; 
            _picture.localScale = new Vector3(1.5f, 1.5f, 1);
            _picture.SetParent(_marker);
            conter = false;
        }
        else 
        {
            _gag.SetActive(false);
            _picture.SetParent(_parens);
            _picture.localPosition = _normalPositiom;
            _picture.localScale = _normalScale;
            
            conter = true;
        }
    }
}

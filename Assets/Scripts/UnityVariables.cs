using UnityEngine;

public class UnityVariables : MonoBehaviour
{
    [SerializeField] private int variable = 99;
    [SerializeField] private Color color = new Color(0f, 0f, 0f, 0f);
    
   void Start()
    {
        Debug.Log($"Start(): {gameObject.name}");
        Debug.Log(variable);
        Debug.Log(color);
    }

}

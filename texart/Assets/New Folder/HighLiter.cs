using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class HighLiter : MonoBehaviour
{
    private MeshRenderer m_Renderer;
   [SerializeField] private Material m_Material;
   [SerializeField] private Material def_Material;

    private void Start()
    {
        m_Renderer = GetComponent<MeshRenderer>(); 
    }

    public void EnableHighlight(bool onOff)
    {
        if (m_Renderer != null && def_Material!=null&&m_Material!=null)
        {
            m_Renderer.material=onOff ? m_Material : def_Material;
        }
    }

    private void OnMouseOver()
    {
        EnableHighlight(true);
    }
    private void OnMouseExit()
    {
        EnableHighlight(false); 
    }
}

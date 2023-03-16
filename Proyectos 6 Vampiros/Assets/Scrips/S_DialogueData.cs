using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_DialogueData : MonoBehaviour
{
    public LineDialogue m_LineDialogue;
    public List<Acciones> m_Acciones = new List<Acciones>();
    public string Persona;
    private int Index;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Acciones Siguiente()
    {

        Acciones[] Acciones = m_Acciones.ToArray();
        if(Index < Acciones.Length)
        {
            Index++;
            return Acciones[Index--];
        }
        return null;
    }
    public void Condicion()
    {

    }


}
public class LineDialogue
{
    private int m_Valor;
    public List<Acciones> m_Acciones = new List<Acciones>();
    public List<LineDialogue> Ramas = new List<LineDialogue>();

    public List<Acciones> Lista()
    {
        return m_Acciones;
    }
    public LineDialogue Eleccion(int Num)
    {
        for(int i = 0; i < Ramas.Count; i++)
        {
            Ramas[i].GetValor();
        }
        return null;
    }





    public int GetValor()
    {
        return m_Valor;
    }
}

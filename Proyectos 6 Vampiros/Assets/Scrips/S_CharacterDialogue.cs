using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_CharacterDialogue : MonoBehaviour
{
    public string Nombre;


    private S_DialogueManager m_DialogueManager;
    private S_DialogueData m_Data;
    private Acciones AccionActual;

    private void Start()
    {
        m_DialogueManager = S_DialogueManager.Instance;   
    }
    private void Update()
    {
        


    }
    public void NextInteraction()
    {
        AccionActual = m_Data.Siguiente();
    }

    public void Visualizar()
    { 
        if(AccionActual.GetComponent<Dialogos>() != null)
        {
            
        }
        else if(AccionActual.GetComponent<Condiciones>() != null)
        {

        }
        else if(true == false)
        {

        }

    }


}

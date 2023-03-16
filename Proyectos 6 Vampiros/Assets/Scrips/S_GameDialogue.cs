using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_GameDialogue : ScriptableObject
{
    List<S_DialogueData> Personajes = new List<S_DialogueData>();

    public S_DialogueData GetData(string Nombre)
    {
        return Personajes.Find(delegate (S_DialogueData Data)
        {
            if(Data.Persona == Nombre)
            {
                return Data;
            }
            return false;
        });
    }
}

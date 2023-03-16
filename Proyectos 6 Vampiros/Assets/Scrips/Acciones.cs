using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Acciones : MonoBehaviour
{
    public string Persona;
    public abstract string GetPersona();
    public abstract void Accionar();

}

public class Dialogos : Acciones
{

    private string Texto;
    public override void Accionar()
    {
        
    }
    public string GetTextos()
    {
        return Texto;
    }
    public override string GetPersona()
    {
        return Persona;
    }
}
public class Condiciones : Acciones
{
    private bool Condicion;

    public override void Accionar()
    {
        
    }
    public bool GetCondicion()
    {
        return Condicion;
    }
    public override string GetPersona()
    {
        return Persona;
    }


}

public class Pausas : Acciones
{

    public override void Accionar()
    {
        
    }
    public override string GetPersona()
    {
        return Persona;
    }
}
public class Eleccion : Acciones
{

    public List<EleccionTexto> Elecciones = new List<EleccionTexto>();
    public override void Accionar()
    {
        
    }
    public EleccionTexto[] GetEleciones()
    {
        return Elecciones.ToArray();
    }

    public override string GetPersona()
    {
        return Persona;
    }
}


    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Utils;


public class S_DialogueManager : TemporalSingleton<S_DialogueManager>
{
    [TextArea]
    public string Texto;

    public GameObject BloqueDeTexto;
    public TMP_Text CajaDeTexto;
    public TMP_Text Nombre;
    public int CharactersOfDialog;
    public int ValorEspacio; // A partir de este 

    public List<string> Dialo;
    public List<string> Nombres;
    public string[] TextoOriginal;

    private int IndiceTexto;
    private int IndiceNombres;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OcultarDialogo()
    {
        BloqueDeTexto.SetActive(false);
    }
    public void MostrarDialogo()
    {
        BloqueDeTexto.SetActive(true);
    }
    [ContextMenu("SigienteLinea")]
    public void ReproducirDialogo()
    {
        string[] Texto = Dialo.ToArray();
        string[] namae = Nombres.ToArray();
        if(IndiceTexto > Texto.Length)
        {
            IndiceTexto = 0;
        }
        else
        {
            MostrarTexto(Texto[IndiceTexto], namae[IndiceTexto]);
            IndiceTexto++;
        }

    }


    public void OrganizarTextos(string dialogo, string Names)
    {
        Dialo.Clear();
        Nombres.Clear();
        char[] Texto = dialogo.ToCharArray();
        CrearDalogo(Texto, 0, Names);
        //for (int i = 0; i < dialogo.Length; i++)   Lo dejo por aqui por si acaso tengo que volver a utilizarlo, y si por alguna razon no eres yo y digamos que te cuesta, esta parte del codigo estaba ya que antes le metia todos lo dialogos con un array de string y tambien los nombres. 
        //{
        //    
        //    char[] Texto = dialogo[i].ToCharArray();
        //    CrearDalogo(Texto, 0, Names[i]);
        //}
    }


    private void CrearDalogo(char [] Texto, int Num, string Names)  // Esta funcion en teoria tranforma los string de numero de caracteres indeterminado en string de un tamaño determinado por CharactersOfDialog, para que los textos quepan en los cuadrados de texto
    {
        IndiceTexto = 0;
        int Numero = Num;
        char[] TextoPart1 = new char[CharactersOfDialog];
        for (int k = 0; k < TextoPart1.Length; k++)
        {
            bool FinLinea = false;
            if (k > Texto.Length -1)
            {
                TextoPart1[k] = ' ';
            }
            else
            {

                if(k > ValorEspacio && Texto[k] == ' ')
                {
                    FinLinea = true;
                }
                else if(FinLinea == true)
                {
                    TextoPart1[k] = ' ';
                }
                else
                {
                    TextoPart1[k] = Texto[k];
                    Num++;
                }
                
            }
            
        }
        Num--;
        Nombres.Add(Names);
        Dialo.Add(TextoPart1.ArrayToString());
        if (Texto.Length - 1 > CharactersOfDialog)
        {
            TextoPart1 = SObreEscribirTexto(Texto, Num);
            CrearDalogo(TextoPart1, 0, Names);
        }
    }

    private char[] SObreEscribirTexto(char[] TextoCmpleto, int piedra)
    {   
        char[] NewText = new char[TextoCmpleto.Length - piedra];
        for (int i = 0; i < NewText.Length; i++)
        {
            NewText[i] = TextoCmpleto[piedra + i];
        }
        return NewText;
        
        
    }

    public void MostrarTexto(string dialogo, string namae)
    {
        CajaDeTexto.text = null;
        Nombre.text = null;
        foreach (char letter in dialogo.ToCharArray())
        {
            CajaDeTexto.text += letter;
            
        }
        foreach (char letter in namae.ToCharArray())
        {
            Nombre.text += letter;

        }
    }
    
}

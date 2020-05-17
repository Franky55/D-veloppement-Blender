using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class Age : MonoBehaviour
{
    //déclaration de mes objets
    //Nom animation
    public string Name;

    //Ecriture de l'utilisateur
    public InputField AGE;

    //bouttons
    public Button enter;
    public Button retour;
    public Button Menu;
    public Button InfoBu;

    //valeur de l'age
    int a;
    float Val;

    //Le texte de l'information
    public Text Info;
    public Text Source;
    //Tableau des stats
    public Image image;

    //Ecriture sur le jamar 
    TextMesh kg;
    public GameObject text1; 

    //Animation de la main
    public Animation Main;

    //Message d'erreur
    public Text Petit;
    public Text Grand;
    public Text erreur;

    

    // Start is called before the first frame update
    void Start()
    {
        //aller chercher la composante de textMesh
        kg = text1.GetComponent<TextMesh>();
        
    }

    

    //fonction du boutton Information
    public void InfoPress()
    {
        //Rendre les information visible
        image.enabled = true;   
        Info.enabled = true;
        Source.enabled = true;

        //rendre boutton interactible ou pas
        retour.GetComponent<Button>().interactable = true;
        enter.GetComponent<Button>().interactable = false;
        Menu.GetComponent<Button>().interactable = false;
        InfoBu.GetComponent<Button>().interactable = false;

    }

    //fonction du boutton Retour
    public void Retour()
    {
        //Rendre les information invisible
        image.enabled = false;  
        Info.enabled = false;
        Source.enabled = false;

        //rendre boutton interactible ou pas
        retour.GetComponent<Button>().interactable = false;
        enter.GetComponent<Button>().interactable = true;
        Menu.GetComponent<Button>().interactable = true;
        InfoBu.GetComponent<Button>().interactable = true;

    }

    //Fonction du boutton menuPrincipale
    public void MenuPrincipal()
    {
        SceneManager.LoadScene("Menu");
    }

    //Fonction du boutton enter
    public void BouttonPress()
    {
        
        //Le if regarde pour s'assurer que le champ de caractère n'est pas vide
        if (AGE.text != null)
        {
            //Ce if essaie de convertir le string en int
            if(!Int32.TryParse(AGE.text, out a))//si ça ne fonctionne pas a =-1
            {
                a = -1;
                erreur.enabled = true;//mesage d'erreur;
                Grand.enabled = false;
                Petit.enabled = false;

            }
            
            
            

            if(a<6 || a > 79)
            {
                //faire apparaitre erreur sur l'ecran du jamar si la donnée est plus grand que 79 ou s'elle st plus petite que 6
                kg.text = "erreur";
                if(a != -1)
                {
                    if (a < 6)
                    {
                        //mesage d'erreur;
                        Petit.enabled = true;
                        Grand.enabled = false;
                        erreur.enabled = false;
                    }
                    else
                    {
                        //mesage d'erreur;
                        Grand.enabled = true;
                        Petit.enabled = false;
                        erreur.enabled = false;
                    }
                }
                
            }
            else //Si ça fonctionne
            {//faire jouer l'animation
                Main.Play(Name);
                Petit.enabled = false;
                Grand.enabled = false;
                erreur.enabled = false;
            }

            if (a >= 6 && a <= 11)//entre 6 et 11
            {
                Val = UnityEngine.Random.Range(133, 140);//faire un chiffre entre ces valeurs
                
               
                kg.text = Val/10 + " kg";//faire apparaitre le chiffre avec un chiffre après la virgule
            }

            if (a >= 12 && a <= 19)// entre 12 et 19
            {
                Val = UnityEngine.Random.Range(305, 318);//faire un chiffre entre ces valeurs
                kg.text = Val / 10 + " kg";//faire apparaitre le chiffre avec un chiffre après la virgule
            }

            if (a >= 20 && a <= 39)// entre 20 et 39
            {
                Val = UnityEngine.Random.Range(379, 395);//faire un chiffre entre ces valeurs
                kg.text = Val / 10 + " kg";//faire apparaitre le chiffre avec un chiffre après la virgule
            }

            if (a >= 40 && a <= 59)// entre 40 et 59
            {
                Val = UnityEngine.Random.Range(369, 385);//faire un chiffre entre ces valeurs
                kg.text = Val / 10 + " kg";//faire apparaitre le chiffre avec un chiffre après la virgule
            }

            if (a >= 60 && a <= 79)// entre 60 et 79
            {
                Val = UnityEngine.Random.Range(314, 332);//faire un chiffre entre ces valeurs
                kg.text = Val / 10 + " kg";//faire apparaitre le chiffre avec un chiffre après la virgule
            }


            
        }

    }
}

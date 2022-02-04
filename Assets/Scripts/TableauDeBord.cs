using UnityEngine;
using System.Collections.Generic;

public class TableauDeBord : MonoBehaviour
{
    private int config = -1;

    System.Collections.IEnumerator resoudre()
    {
        List<string> aClignoter = new List<string>();
        aClignoter.Add("Bouton0");
        aClignoter.Add("Bouton1");
        aClignoter.Add("Bouton2");
        aClignoter.Add("Bouton3");
        aClignoter.Add("Bouton4");
        aClignoter.Add("Bouton5");
        aClignoter.Add("Bouton6");
        aClignoter.Add("Bouton7");
        aClignoter.Add("Bouton8");
        aClignoter.Add("Bouton9");
        aClignoter.Add("Bouton10");
        aClignoter.Add("Bouton11");
        aClignoter.Add("Bouton12");
        aClignoter.Add("Bouton13");
        aClignoter.Add("Bouton14");
        aClignoter.Add("Bouton15");
        allumerBoutons(aClignoter);
        yield return new WaitForSecondsRealtime(0.5f);
        eteindreBoutons(aClignoter);
        yield return new WaitForSecondsRealtime(0.5f);
        allumerBoutons(aClignoter);
        yield return new WaitForSecondsRealtime(0.5f);
        eteindreBoutons(aClignoter);
    }
    public void OnButton0Press()
    {
        if (config == 0)
        {
            Debug.Log("Bravo !");
            StartCoroutine(resoudre());
        } else
        {
            // TODO : punition !
            // On enlève une vie sur ce module, s'il n'y en a plus on explose
            // On relance aussi les dés pour la configuration
        }
    }

    // TODO : Les 15 autres fonctions d'appui sur les différents boutons

    private void allumerBouton(string name)
    {
        GameObject.Find(name).GetComponent<Boutons>().allume = true;
    }

    private void allumerBoutons(List<string> names)
    {
        foreach (string name in names)
        {
            allumerBouton(name);
        }
    }

    private void eteindreBouton(string name)
    {
        GameObject.Find(name).GetComponent<Boutons>().allume = false;
    }

    private void eteindreBoutons(List<string> names)
    {
        foreach (string name in names)
        {
            eteindreBouton(name);
        }
    }

    private void Start()
    {
        // Pour la version de test, on force une configuration donnée
        // Dans le "vrai" jeu, on pourra implémenter autant de configurations que l'on veut
        config = 0;//(int)Mathf.Round(Random.Range(0, 3));
        
        switch (config)
        {
            // Dans cette configuration, le bouton solution est 0
            case 0:
                List<string> aAllumer = new List<string>();
                aAllumer.Add("Bouton3");
                aAllumer.Add("Bouton5");
                aAllumer.Add("Bouton1");
                aAllumer.Add("Bouton7");
                aAllumer.Add("Bouton8");
                allumerBoutons(aAllumer);
                break;
            // Dans cette configuration, le bouton solution est 1
            case 1:
                break;
            // Dans cette configuration, le bouton solution est 2
            case 2:
                break;
            // Dans cette configuration, le bouton solution est 3
            case 3:
                break;
            // TODO : etc.
        }
    }

}
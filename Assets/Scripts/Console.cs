using UnityEngine;
using System.Collections.Generic;

public class Console : MonoBehaviour
{
    private int ordre = -1;
    private int config = -1;
    public List<string> trajs = new List<string>();
    public List<string> aRelier = new List<string>();
    System.Collections.IEnumerator resoudre()
    {
        List<string> aClignoter = new List<string>();
        aClignoter.Add("BR");
        aClignoter.Add("BVe");
        aClignoter.Add("BB");
        aClignoter.Add("BJ");
        aClignoter.Add("BVi");
        affTrajs(aClignoter);
        yield return new WaitForSecondsRealtime(0.5f);
        cacherTrajs(aClignoter);
        yield return new WaitForSecondsRealtime(0.5f);
        affTrajs(aClignoter);
        yield return new WaitForSecondsRealtime(0.5f);
        cacherTrajs(aClignoter);
    }
    public void OnBBPress()
    {
        if (!GameObject.Find("BB").GetComponent<Boutons>().allume)
        {
            GameObject.Find("BB").GetComponent<Boutons>().allume = true;
            ordre += 1;
            if (aRelier[ordre] == "BB")
            {
                if (ordre == 4) { StartCoroutine(resoudre()); }
                else if (ordre > 0)
                {
                    switch (aRelier[ordre - 1])
                    {
                        case "BR":
                            affTraj("TrajRB");
                            break;
                        case "Bve":
                            affTraj("TrajVeB");
                            break;
                        case "BJ":
                            affTraj("TrajJB");
                            break;
                        case "BVi":
                            affTraj("TrajBVi");
                            break;
                    }
                }
            }
            else
            {
                ordre = 0;
                for (int i = 0; i < 5; i++)
                {
                    GameObject.Find(aRelier[i]).GetComponent<Boutons>().allume = false;
                }
                cacherTrajs(trajs);
                // TODO : punition !
                // On enl�ve une vie sur ce module, s'il n'y en a plus on explose
                // On relance aussi les d�s pour la configuration
            }
        }
    }
    public void OnBRPress()
    {
        if (!GameObject.Find("BR").GetComponent<Boutons>().allume)
        {
            GameObject.Find("BR").GetComponent<Boutons>().allume = true;
            ordre += 1;
            if (aRelier[ordre] == "BR")
            {
                if (ordre == 4) { StartCoroutine(resoudre()); }
                else if (ordre > 0)
                {
                    switch (aRelier[ordre - 1])
                    {
                        case "BB":
                            affTraj("TrajRB");
                            break;
                        case "Bve":
                            affTraj("TrajRVe");
                            break;
                        case "BJ":
                            affTraj("TrajRJ");
                            break;
                        case "BVi":
                            affTraj("TrajViR");
                            break;
                    }
                }
            }
            else
            {
                ordre = 0;
                for (int i = 0; i < 5; i++)
                {
                    GameObject.Find(aRelier[i]).GetComponent<Boutons>().allume = false;
                }
                cacherTrajs(trajs);
                // TODO : punition !
            }
        }
    }

    public void OnBVePress()
    {
        if (GameObject.Find("BVe").GetComponent<Boutons>().allume == false)
        {
            GameObject.Find("BVe").GetComponent<Boutons>().allume = true;
            ordre += 1;
            if (aRelier[ordre] == "BVe")
            {
                if (ordre == 4) { StartCoroutine(resoudre()); }
                else if (ordre > 0)
                {
                    switch (aRelier[ordre - 1])
                    {
                        case "BR":
                            affTraj("TrajRVe");
                            break;
                        case "BB":
                            affTraj("TrajVeB");
                            break;
                        case "BJ":
                            affTraj("TrajJVe");
                            break;
                        case "BVi":
                            affTraj("TrajVeVi");
                            break;
                    }
                }
            }
            else
            {
                ordre = 0;
                for (int i = 0; i < 5; i++)
                {
                    GameObject.Find(aRelier[i]).GetComponent<Boutons>().allume = false;
                }
                cacherTrajs(trajs);
                // TODO : punition !
            }
        }
    }
    public void OnBJPress()
    {
        if (!GameObject.Find("BJ").GetComponent<Boutons>().allume)
        {
            GameObject.Find("BJ").GetComponent<Boutons>().allume = true;
            ordre += 1;
            if (aRelier[ordre] == "BJ")
            {
                if (ordre == 4) { StartCoroutine(resoudre()); }
                else if (ordre > 0)
                {
                    switch (aRelier[ordre - 1])
                    {
                        case "BR":
                            affTraj("TrajRJ");
                            break;
                        case "BB":
                            affTraj("TrajJB");
                            break;
                        case "Bve":
                            affTraj("TrajJVe");
                            break;
                        case "BVi":
                            affTraj("TrajJVi");
                            break;
                    }
                }
            }
            else
            {
                ordre = 0;
                for (int i = 0; i < 5; i++)
                {
                    GameObject.Find(aRelier[i]).GetComponent<Boutons>().allume = false;
                }
                cacherTrajs(trajs);
                // TODO : punition !
            }
        }
    }
    public void OnBViPress()
    {
        if (!GameObject.Find("BVi").GetComponent<Boutons>().allume)
        {
            GameObject.Find("BVi").GetComponent<Boutons>().allume = true;
            ordre += 1;
            if (aRelier[ordre] == "BVi")
            {
                if (ordre == 4) { StartCoroutine(resoudre()); }
                else if (ordre > 0)
                {
                    switch (aRelier[ordre - 1])
                    {
                        case "BR":
                            affTraj("TrajViR");
                            break;
                        case "BB":
                            affTraj("TrajBVi");
                            break;
                        case "Bve":
                            affTraj("TrajVeVi");
                            break;
                        case "BJ":
                            affTraj("TrajJVi");
                            break;
                    }
                }
            }
            else
            {
                ordre = 0;
                for (int i = 0; i < 5; i++)
                {
                    GameObject.Find(aRelier[i]).GetComponent<Boutons>().allume = false;
                }
                cacherTrajs(trajs);
                // TODO : punition !
            }
        }
    }

    private void affTraj(string name)
    {
        GameObject.Find(name).GetComponent<Trajectoires>().allume = true;
    }

    private void affTrajs(List<string> names)
    {
        foreach (string name in names)
        {
            affTraj(name);
        }
    }

    private void cacherTraj(string name)
    {
        GameObject.Find(name).GetComponent<Trajectoires>().allume = false;
    }

    private void cacherTrajs(List<string> names)
    {
        foreach (string name in names)
        {
            cacherTraj(name);
        }
    }

    private void Start()
    {
        // Pour la version de test, on force une configuration donn�e
        // Dans le "vrai" jeu, on pourra impl�menter autant de configurations que l'on veut
        config = 0;//(int)Mathf.Round(Random.Range(0, 3));

        trajs.Clear();
        trajs.Add("TrajRVe");
        trajs.Add("TrajRB");
        trajs.Add("TrajRJ");
        trajs.Add("TrajViR");
        trajs.Add("TrajVeB");
        trajs.Add("TrajBVi");
        trajs.Add("TrajJVe");
        trajs.Add("TrajJB");
        trajs.Add("TrajJVi");
        trajs.Add("TrajVeVi");

        switch (config)
        {
            case 0:
                aRelier.Add("BJ");
                aRelier.Add("BVe");
                aRelier.Add("BVi");
                aRelier.Add("BB");
                aRelier.Add("BR");
                break;
            case 1:
                break;
            case 2:
                break;
            case 3:
                break;
                // TODO : etc.
        }
    }

}
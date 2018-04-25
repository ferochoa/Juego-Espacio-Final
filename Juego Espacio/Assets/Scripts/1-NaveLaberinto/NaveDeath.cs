using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaveDeath : MonoBehaviour {

    public NaveLife naveLife;

    public GameObject explosion;
    public GameObject panelMuerte;
    public GameObject canvas_nave;
    public GameObject nave;
    public Transform meta;

    private bool IsLife;

    [HideInInspector]
    public float distanceToWin;
    private void Start()
    {
        print(Vector3.Distance(nave.transform.position, meta.position));
    }

    void Update ()
    {
        if (naveLife.vida <=-1 && IsLife == false)
        {
            IsLife = true;
            distanceToWin = Mathf.Abs(Vector3.Distance(nave.transform.position, meta.position) - 3247);
            Instantiate(explosion, nave.transform.position, Quaternion.identity);
            nave.SetActive(false);
            StartCoroutine(MuerteInminente());
        }
    }

    IEnumerator MuerteInminente()
    {
        yield return new WaitForSeconds(1);

        canvas_nave.SetActive(false);
        panelMuerte.SetActive(true);
        Time.timeScale = 0;
    }
}

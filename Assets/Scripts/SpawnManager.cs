using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject squarePrefab;
    public GameObject spherePrefab;
    public GameObject capsulePrefab;
    public GameObject cylinderPrefab;

    private int cube = 0, sphere = 0, capsule = 0, cylinder = 0;

    public Renderer cubeRenderer;
    public Renderer sphereRenderer;
    public Renderer capsuleRenderer;
    public Renderer cylinderRenderer;

    public Toggle cubeToggle,sphereToggle, capsuleToggle, cylinderToggle;
    private void Start()
    {
        cubeRenderer = squarePrefab.GetComponent<Renderer>();
        sphereRenderer = spherePrefab.GetComponent<Renderer>();
        capsuleRenderer = capsulePrefab.GetComponent<Renderer>();
        cylinderRenderer = cylinderPrefab.GetComponent<Renderer>();
    }
    public void AddSquare()
    {
        Vector3 position = new Vector3(Random.Range(-3f, 3f), Random.Range(-3f, 3f), 0);
        Instantiate(squarePrefab, position, Quaternion.LookRotation(position));
        cube++;
        cubeShow();
    }

    public void AddSphere()
    {
        Vector3 position = new Vector3(Random.Range(-4f, 4f), Random.Range(-4f, 4f), 0);
        Instantiate(spherePrefab, position, Quaternion.LookRotation(position));
        sphere++;
        sphereShow();
    }

    public void AddCapsule()
    {
        Vector3 position = new Vector3(Random.Range(-3f, 3f), Random.Range(-3f, 3f), 0);
        Instantiate(capsulePrefab, position, Quaternion.LookRotation(position));
        capsule++;
        capsuleShow();
    }

    public void AddCyliner()
    {
        Vector3 position = new Vector3(Random.Range(-3f, 3f), Random.Range(-3f, 3f), 0);
        Instantiate(cylinderPrefab, position, Quaternion.LookRotation(position));
        cylinder++;
        cylinderShow();
    }

    public GameObject showSquare, showSphere, showCapsule, showCylinder;

    public void cubeShow()
    {
        if (cube > 0)
        {
            showSquare.SetActive(true);
        }
        else
        {
            showSquare.SetActive(false);
        }
    }

    public void sphereShow()
    {
        if (sphere > 0)
        {
            showSphere.SetActive(true);
        }
        else
        {
            showSphere.SetActive(false);
        }
    }

    public void capsuleShow()
    {
        if (capsule > 0)
        {
            showCapsule.SetActive(true);
        }
        else
        {
            showCapsule.SetActive(false);
        }
    }

    public void cylinderShow()
    {
        if (cylinder > 0)
        {
            showCylinder.SetActive(true);
        }
        else
        {
            showCylinder.SetActive(false);
        }
    }

    public void cubeChange()
    {
        if (cubeToggle.isOn)
        {
            cubeRenderer.sharedMaterial.SetColor("_Color", Color.red);
        }
        else
        {
            cubeRenderer.sharedMaterial.SetColor("_Color", Color.white);
        }
    }

    public void sphereChange()
    {
        if (sphereToggle.isOn)
        {
            sphereRenderer.sharedMaterial.SetColor("_Color", Color.green);
        }
        else
        {
            sphereRenderer.sharedMaterial.SetColor("_Color", Color.white);
        }
    }

    public void capsuleChange()
    {
        if (capsuleToggle.isOn)
        {
            capsuleRenderer.sharedMaterial.SetColor("_Color", Color.blue);
        }
        else
        {
            capsuleRenderer.sharedMaterial.SetColor("_Color", Color.white);
        }
    }

    public void cylinderChange()
    {
        if (cylinderToggle.isOn)
        {
            cylinderRenderer.sharedMaterial.SetColor("_Color", Color.yellow);
        }
        else
        {
            cylinderRenderer.sharedMaterial.SetColor("_Color", Color.white);
        }
    }
}

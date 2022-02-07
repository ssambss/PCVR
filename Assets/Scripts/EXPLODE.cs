using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EXPLODE : MonoBehaviour
{
    [SerializeField] private float threshold = 0.1f;
    [SerializeField] private float deadZone = 0.025f;
    [SerializeField] ParticleSystem cannonParticle, kaboom;
    [SerializeField] AudioSource cannon, posankka;

    private MeshRenderer posank;
    private float counter = 0;
    private bool isPressed;
    private Vector3 startPos;
    private ConfigurableJoint joint;

    public UnityEvent onPressed;

    void Start()
    {
        startPos = transform.localPosition;
        joint = GetComponent<ConfigurableJoint>();
        posank = posankka.GetComponent<MeshRenderer>();
    }

    void Update()
    {
        counter += Time.deltaTime;

        if (GetValue() + threshold >= 1f)
        {
            if (counter > 0.5f)
            {
                Pressed();
                counter = 0;
            }
        }
        else
        {
            isPressed = false;
        }
    }

    private float GetValue()
    {
        var value = Vector3.Distance(startPos, transform.localPosition) / joint.linearLimit.limit;

        if (Mathf.Abs(value) < deadZone)
        {
            value = 0;
        }

        return Mathf.Clamp(value, -1f, 1f);
    }

    private void Pressed()
    {
        isPressed = true;
        onPressed.Invoke();
        Debug.Log("Pressed");
    }

    public void PlayParticles()
    {
        cannon.Play(0);
        cannonParticle.Play();
        StartCoroutine(WaitForSeconds());
    }

    IEnumerator WaitForSeconds()
    {
        yield return new WaitForSeconds(1f);
        kaboom.Play();
        posankka.Play(0);
        posank.enabled = false;
    }
}
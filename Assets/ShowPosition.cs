using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowPosition : MonoBehaviour
{
    [SerializeField] GameObject imageTarget;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<TextMeshProUGUI>().text = "Rotation Z: "+imageTarget.transform.localRotation.eulerAngles.z;
    }
}

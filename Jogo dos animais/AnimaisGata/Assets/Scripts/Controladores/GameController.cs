using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    private Camera cam;
    public float speedCam;

    public Transform playerTransform;
    public Transform LimiteCamEsq, LimiteCamDir, LimiteCamSup, LimiteCamInf;

    void Start()
    {
        cam = Camera.main;
    }

    private void LateUpdate()
    {
        float posCamX = playerTransform.position.x;
        float posCamY = playerTransform.position.y;

        if (cam.transform.position.x < LimiteCamEsq.position.x && playerTransform.position.x < LimiteCamEsq.position.x)
        {
            posCamX = LimiteCamEsq.position.x;
        }
        else if (cam.transform.position.x > LimiteCamDir.position.x && playerTransform.position.x > LimiteCamDir.position.x)
        {
            posCamX = LimiteCamDir.position.x;
        }

        if (cam.transform.position.y > LimiteCamSup.position.y && playerTransform.position.y > LimiteCamSup.position.y)
        {
            posCamY = LimiteCamSup.position.y;
        }
        else if (cam.transform.position.y < LimiteCamInf.position.y && playerTransform.position.y < LimiteCamInf.position.y)
        {
            posCamY = LimiteCamInf.position.y;
        }

        Vector3 posCam = new Vector3(posCamX, posCamY, cam.transform.position.z);
        cam.transform.position = Vector3.Lerp(cam.transform.position, posCam, speedCam * Time.deltaTime);
    }
}


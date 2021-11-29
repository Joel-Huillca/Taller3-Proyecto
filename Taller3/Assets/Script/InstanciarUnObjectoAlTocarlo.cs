using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.Experimental.XR;
using UnityEngine.UI;
using UnityEngine.XR.ARSubsystems;

public class InstanciarUnObjectoAlTocarlo : MonoBehaviour
{
                    //Sript:
    /*Detección de plano + cuadro Emergente*/
    /*Se instancia un objecto al apretar la pantalla*/
    /*Sonido al instanciar un objecto*/
    

    public GameObject audioInico;//             (Audio_1)
    public GameObject objectCuadroTxt;//   ~(Detectando plano)~
    public GameObject objectToPlace;//          (Obejto)
    public GameObject placementIndicator;//  (Plano indicador)
    
    private ARRaycastManager _arRaycast;//(Lista-Guarda los rayos)
    private Pose _placementPose;//    (Posición donde se instanciara)
    private bool _placementPoseIsValid = false;// (Dato: true o false)
    private bool _isPlace;//              (Plano activado: true o false)

    //public TextMeshProUGUI debugText;//    (Cuadro: nos indica la posic)
    public Camera cam;// (Camara)

    private void Start()
    {
        objectToPlace.SetActive(false);//_____(-)
        audioInico.SetActive(false);
        _arRaycast = FindObjectOfType<ARRaycastManager>();
    }

    private void Update()
    {
        if (!_isPlace)
        {
            UpdatePlacementPose();
            UpdatePlacementIndicator();

        }

        //_________Solo aparece el cuadro cuando el indicador desaparece___________
        objectCuadroTxt.SetActive(true);

        if(_placementPoseIsValid){
            objectCuadroTxt.SetActive(false);
        }//____________________________________________________________________________
        

        if (_placementPoseIsValid && Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began && !_isPlace)
        {
            PlaceObject();
            _isPlace = true;
            placementIndicator.SetActive(false);

            //___________(audio)___________
            audioInico.SetActive(true);
            //_____________________________


        }

        //debugText.text = cam.transform.rotation.ToString();
        //Debug.Log(cam.transform.rotation.ToString());
    }
    
    private void PlaceObject()          /*Instanciamos el objecto*/
    {
        objectToPlace.SetActive(true);//_____(-)
        //Instantiate(objectToPlace, _placementPose.position, _placementPose.rotation);
        Instantiate(objectToPlace, placementIndicator.transform.position, placementIndicator.transform.rotation); // _-_
    }

    /*Activamos o Descativamos el "Plano Indicator"*/
    private void UpdatePlacementIndicator()
    {
        if (_placementPoseIsValid)
        {
            placementIndicator.SetActive(true);
            placementIndicator.transform.SetPositionAndRotation(_placementPose.position, _placementPose.rotation);
        }
        else
        {
            placementIndicator.SetActive(false);
        }
    }

    /*Posición del plano, sacado desde la camara*/
    private void UpdatePlacementPose()
    {
        var screenCenter = new Vector2 (Screen.width / 2f, Screen.height / 2f);
        var hits = new List<ARRaycastHit>();
        _arRaycast.Raycast(screenCenter, hits, TrackableType.Planes);

        _placementPoseIsValid = hits.Count > 0;
        if (_placementPoseIsValid)
        {
            _placementPose = hits[0].pose;

            var cameraForward = Camera.current.transform.forward;
            var cameraBearing = new Vector3(cameraForward.x, 0, cameraForward.z).normalized;
            _placementPose.rotation = Quaternion.LookRotation(cameraBearing);
        }
    }
}


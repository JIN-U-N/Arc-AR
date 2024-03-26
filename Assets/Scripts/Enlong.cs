    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.EventSystems;
    using UnityEngine.XR.ARFoundation;
    using UnityEngine.XR.ARSubsystems;

    public class Enlong : MonoBehaviour
    {
        public SetReactor setReactor;
        private bool IsButton;
        public AudioSource audioSource;
        private GameObject G1,G2,G3,G4,G5,G6,G7,G8,G9,G10,G11,G12,G13;
        private Vector3 P1,P2,P3,P4,P5,P6,P7,P8,P9,P10,P11,P12,P13;
        
        private float LongSpeed=0.4f;

        void Start()
        {
            setReactor=FindObjectOfType<SetReactor>();
            IsButton=false;
        }

        void Update()
        {
            if(IsButton==true)
            {
                setReactor.ReactorObj.transform.Find("1").transform.position=Vector3.Lerp(setReactor.ReactorObj.transform.Find("1").transform.position,P1,LongSpeed*Time.deltaTime);
                setReactor.ReactorObj.transform.Find("2").transform.position=Vector3.Lerp(setReactor.ReactorObj.transform.Find("2").transform.position,P2,LongSpeed*Time.deltaTime);
                setReactor.ReactorObj.transform.Find("3").transform.position=Vector3.Lerp(setReactor.ReactorObj.transform.Find("3").transform.position,P3,LongSpeed*Time.deltaTime);
                setReactor.ReactorObj.transform.Find("4").transform.position=Vector3.Lerp(setReactor.ReactorObj.transform.Find("4").transform.position,P4,LongSpeed*Time.deltaTime);
                setReactor.ReactorObj.transform.Find("5").transform.position=Vector3.Lerp(setReactor.ReactorObj.transform.Find("5").transform.position,P5,LongSpeed*Time.deltaTime);
                setReactor.ReactorObj.transform.Find("6").transform.position=Vector3.Lerp(setReactor.ReactorObj.transform.Find("6").transform.position,P6,LongSpeed*Time.deltaTime);
                setReactor.ReactorObj.transform.Find("7").transform.position=Vector3.Lerp(setReactor.ReactorObj.transform.Find("7").transform.position,P7,LongSpeed*Time.deltaTime);
                setReactor.ReactorObj.transform.Find("8").transform.position=Vector3.Lerp(setReactor.ReactorObj.transform.Find("8").transform.position,P8,LongSpeed*Time.deltaTime);
                setReactor.ReactorObj.transform.Find("9").transform.position=Vector3.Lerp(setReactor.ReactorObj.transform.Find("9").transform.position,P9,LongSpeed*Time.deltaTime);
                setReactor.ReactorObj.transform.Find("10").transform.position=Vector3.Lerp(setReactor.ReactorObj.transform.Find("10").transform.position,P10,LongSpeed*Time.deltaTime);
                setReactor.ReactorObj.transform.Find("11").transform.position=Vector3.Lerp(setReactor.ReactorObj.transform.Find("11").transform.position,P11,LongSpeed*Time.deltaTime);
                setReactor.ReactorObj.transform.Find("12").transform.position=Vector3.Lerp(setReactor.ReactorObj.transform.Find("12").transform.position,P12,LongSpeed*Time.deltaTime);
                setReactor.ReactorObj.transform.Find("13").transform.position=Vector3.Lerp(setReactor.ReactorObj.transform.Find("13").transform.position,P13,LongSpeed*Time.deltaTime);
            }
        }

        public void Long()
        {
            audioSource.Play();
            IsButton=true;

            G1= setReactor.ReactorObj.transform.Find("1").gameObject;
            G2= setReactor.ReactorObj.transform.Find("2").gameObject;
            G3= setReactor.ReactorObj.transform.Find("3").gameObject;
            G4= setReactor.ReactorObj.transform.Find("4").gameObject;
            G5= setReactor.ReactorObj.transform.Find("5").gameObject;
            G6= setReactor.ReactorObj.transform.Find("6").gameObject;
            G7= setReactor.ReactorObj.transform.Find("7").gameObject;
            G8= setReactor.ReactorObj.transform.Find("8").gameObject;
            G9= setReactor.ReactorObj.transform.Find("9").gameObject;
            G10= setReactor.ReactorObj.transform.Find("10").gameObject;
            G11= setReactor.ReactorObj.transform.Find("11").gameObject;
            G12= setReactor.ReactorObj.transform.Find("12").gameObject;
            G13= setReactor.ReactorObj.transform.Find("13").gameObject;

            P1= new Vector3(0.03846033f,0.2440703f,-0.528513f)+G1.transform.position;
            P2= new Vector3(0.03061418f,0.1955777f,-0.4284139f)+G2.transform.position;
            P3= new Vector3(0.02512726f,0.1625596f,-0.3499534f)+G3.transform.position;
            P4= new Vector3(0.02017147f,0.1300354f,-0.2793638f)+G4.transform.position;
            P5= new Vector3(0.02145418f,0.1375772f,-0.3069572f)+G5.transform.position;
            P6= new Vector3(0.01507242f,0.09743328f,-0.2190393f)+G6.transform.position;
            P7= new Vector3(0.01001297f,0.06786105f,-0.1341848f)+G7.transform.position;
            P8= new Vector3(0.01226354f,0.0877538f,-0.1976824f)+G8.transform.position;
            P9= new Vector3(0.006127153f,0.04154391f,-0.09106982f)+G9.transform.position;
            P10= new Vector3(-0.001236521f,-0.0051568f,0.005639717f)+G10.transform.position;
            P11= new Vector3(-0.009934619f,-0.05987148f,0.1254684f)+G11.transform.position;
            P12= new Vector3(-0.02099638f,-0.1294543f,0.2778594f)+G12.transform.position;
            P13= new Vector3(0.009974487f,0.06642731f,-0.1519151f)+G13.transform.position;
            
        }
    }


        
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.UI;

    public class CutSceneManager : MonoBehaviour
    {
        public GameObject[] scene;

        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            
            
        }

        private void Awake()
        {
            StartCoroutine(ChangeCutSceneImage());
        }

        private IEnumerator ChangeCutSceneImage()
        {
            for (int i = 0; i < scene.Length; i++)
            {
                yield return new WaitForSeconds(4f);
                scene[i].gameObject.SetActive(false);
            }
            
        }
    }

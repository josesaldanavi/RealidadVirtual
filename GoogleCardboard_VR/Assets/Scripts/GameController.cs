using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    //Pseudo Singleton
    public static GameController Instance { get; private set; }
    public int value;
    //-->>s
    [Header("CanvasController")]
    public Canvas over_Canvas;
    public Animator canvas_over;
    public Text puntos;
    public GameObject restar_GameObject;
    public GameObject hazard;
    public Vector3 spawnValues;
    public int indexHazard;
    public int score=0;
    private int indice;
    public float spawnWait;
    public float startSpawn;
    public float waveWait;
    public bool gameOver = false;
    public static bool restart = false;
    // Start is called before the first frame update

    private void Awake()
    {
        //PseudoSingleton
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else { Destroy(gameObject); }
    }

    void Start()
    {
        StartCoroutine(SpawnHazard());
        
    }

    // Update is called once per frame
    void Update()
    {
        puntos.text = score.ToString();
    }
    IEnumerator SpawnHazard()
    {
        yield return new WaitForSeconds(startSpawn);
        while (true)
        {
            for (int i = 0; i < indexHazard; i++)
            {
                Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
                Instantiate(hazard, spawnPosition, Quaternion.identity);

                Physics.IgnoreCollision(hazard.GetComponent<Collider>(), hazard.GetComponent<Collider>());

                yield return new WaitForSeconds(spawnWait);
            }
        }
    }
    
}
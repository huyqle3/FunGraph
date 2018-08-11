using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Spawner : MonoBehaviour {

    #region Singleton

    public static Spawner instance;

    #endregion

    public GameObject dementor;
    public TextMeshPro scoreText;
    public int count = 0;

    public int playerScore = 0;

    private void Awake()
    {
        instance = this;
    }

    // Use this for initialization
    void Start () {
        SpawnDementors();
	}
	
	// Update is called once per frame
	void Update () {
		if (count == 0)
        {
            SpawnDementors();
        }
	}

    public void UpdateScore()
    {
        playerScore += 1;

        /*
        GameObject score = Instantiate(Resources.Load("Prefabs/ScoreText") as GameObject);
        Transform cameraTransform = VRTK.VRTK_DeviceFinder.DeviceTransform(VRTK.VRTK_DeviceFinder.Devices.Headset);
        score.transform.position = cameraTransform.position + cameraTransform.forward * 0.5f;
        TextMeshPro text = score.transform.Find("Text").gameObject.GetComponent<TextMeshPro>();
        */
        scoreText.text = playerScore.ToString();
    }

    void SpawnDementors()
    {
        for (int i = 0; i < 4; i++)
        {
            float x = Random.Range(0, 14);
            float y = Random.Range(0, 1);
            float z = Random.Range(0, 14);

            Vector3 spawnPosition = new Vector3(x, y, z);

            GameObject spawnedDementor = Instantiate(Resources.Load("Prefabs/Dementor")) as GameObject;
            spawnedDementor.transform.position = spawnPosition;

            count++;
        }
    }
}

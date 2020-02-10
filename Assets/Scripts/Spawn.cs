﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {
    //生成的游戏对象列表
    public GameObject enemy0;
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject award_0;
    public GameObject award_1;
    //生成物体的速率
    public float rateOfCreateEnemy0;
    public float rateOfCreateEnemy1;
    public float rateOfCreateEnemy2;
    public float rateOfCreateAward_0;
    public float rateOfCreateAward_1;
    // Start is called before the first frame update
    void Start() {
        rateOfCreateEnemy0 = 0.5f;
        rateOfCreateEnemy1 = 5f;
        rateOfCreateEnemy2 = 8f;

        rateOfCreateAward_0 = 0.5f;
        rateOfCreateAward_1 = 0.5f;
        InvokeRepeating("CreateEnemy0",1,rateOfCreateEnemy0);
        InvokeRepeating("CreateEnemy1",3, rateOfCreateEnemy1);
        InvokeRepeating("CreateEnemy2", 6, rateOfCreateEnemy2);
    }

    // Update is called once per frame
    void Update() {

    }

    public void CreateEnemy0() {
        float x = Random.Range(-2f, 2f);
        Instantiate(enemy0, new Vector3(x, transform.position.y,transform.position.z), Quaternion.identity);
    }
    public void CreateEnemy1() {
        float x = Random.Range(-2f, 2f);
        Instantiate(enemy1, new Vector3(x, transform.position.y, transform.position.z), Quaternion.identity);
    }
    public void CreateEnemy2() {
        float x = Random.Range(-1.5f, 1.5f);
        Instantiate(enemy2, new Vector3(x, transform.position.y, transform.position.z), Quaternion.identity);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss {     //mpを53で初期化     private int mp = 53;      //魔法攻撃用関数     public void Magic(int attackmp) {         this.mp -= attackmp;         if(mp >= 0) {             Debug.Log("魔法攻撃をした。残りMPは" + this.mp);         } else {             Debug.Log("mpが足りないため魔法が使えない");         }     } }

public class ScriptTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Boss lastboss = new Boss();         for (int i = 0; i < 11; i++) {             lastboss.Magic(5);         } 
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

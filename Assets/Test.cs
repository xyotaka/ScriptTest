using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Boss{
	private int mp = 53;

	public void Magic(){
		//必要あMPを宣言
		int neededMP = 5;

		if (mp >= neededMP) {
			//攻撃
			this.mp -= neededMP;
			Debug.Log ("魔法攻撃をした。残りMPは" + this.mp + "。");
		} else {
			//攻撃できない
			Debug.Log ("MPが足りないため魔法が使えない。");
		}
	}
}

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		int[] numbers = {34, 56, 23, 10, 5};
		Boss testBoss = new Boss ();

		//課題あ発展課題のどちらを表示するか聞く
		if (EditorUtility.DisplayDialog ("Lesson 4", 
			    "どっちを表示しますか？",
			    "配列",
			    "ボス")) {
			//配列を表示
			for (int i = 0; i < numbers.Length; i++) {
				Debug.Log (numbers [i]);
			}
			for (int j = numbers.Length - 1; j > -1; j--) {
				Debug.Log (numbers [j]);
			}
		} else {
			//ボスの魔法を表示
			for (int i = 0; i < 10; i++) {
				testBoss.Magic ();
			}
			testBoss.Magic ();
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;

public class EnemySpawner : MonoBehaviour {
	[SerializeField]
	string[] _words;

	[SerializeField]
	Transform _enemyRoot;

	[SerializeField]
	PlayerScript _player;

	public GameObject enemy; //敵のオブジェクト
	public float interval = 2; //何秒に一回敵を発生させるか
	float timer = 0; //タイマー

	List<EnemyScript> _enemies;
	string str;

	void Start()
	{
		_enemies = new List<EnemyScript>();
	}

	void Update () {
		timer -= Time.deltaTime; //タイマーを減らす
		if (timer < 0) { //タイマーがゼロより小さくなったら
			Spawn (); // Spawnメソッドを呼ぶ
			timer = interval; // タイマーをリセットする
		}
	}
	// 敵を生成するメソッド
	void Spawn(){
		GameObject obj = (GameObject)Instantiate (enemy, transform.position, transform.rotation);
		obj.transform.SetParent (_enemyRoot);
		EnemyScript enemyScript = obj.GetComponent<EnemyScript> ();
		enemyScript.player = _player;
		int wordId = Random.Range (0, _words.Length);
		str = _words[wordId];
		enemyScript.wordId = wordId;
		enemyScript.text = str;
		_enemies.Add (enemyScript);

	}
}

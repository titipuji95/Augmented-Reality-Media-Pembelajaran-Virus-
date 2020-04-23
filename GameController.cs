using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;


public class GameController : MonoBehaviour {
	
	public Text questionText;
	public Text scoreDisplayText;
	public Text timeRemainingDisplayText;
	public SimpleObjectPool answerButtonObjectPool;
	public Transform answerButtonParent;
	public GameObject questionDisplay;
	public GameObject roundEndDisplay;


	private DataController dataController;
	private RoundData currentRoundData;
	private QuestionData[] questionPool;

	private bool isRoundActive;
	private float timeRemaining;
	private int questionIndex;
	private int playerScore;
	private List<GameObject> answerButtonGameObjects = new List<GameObject> ();
	// Use this for initialization
	void Start () {
		dataController = FindObjectOfType<DataController> ();
		currentRoundData = dataController.GetCurrentRoundData ();
		questionPool = currentRoundData.questions;
		timeRemaining = currentRoundData.timeLimitInSeconds;

		playerScore = 0;
		questionIndex = 0;

		ShowQuestion ();
		isRoundActive = true;
	}
	private void ShowQuestion(){
		RemoveAnswerButtons ();
		QuestionData questionData = questionPool [questionIndex];
		questionText.text = questionData.questionText;

		for (int i = 0; i < questionData.answers.Length; i++) {
			GameObject answerButtonGameObject = answerButtonObjectPool.GetObject();
			answerButtonGameObjects.Add(answerButtonGameObject);
			answerButtonGameObject.transform.SetParent(answerButtonParent);

			AnswerButton answerButton = answerButtonGameObject.GetComponent<AnswerButton>();
			answerButton.Setup(questionData.answers[i]);
		}
	
	}
	private void RemoveAnswerButtons(){
		while (answerButtonGameObjects.Count > 0) {
			answerButtonObjectPool.ReturnObject(answerButtonGameObjects[0]);
			answerButtonGameObjects.RemoveAt(0);
		}
	}
	public void AnswerButtonClicked(bool isCorrect){
		if (isCorrect) {
			playerScore += currentRoundData.pointsAddedCorrectAnswer;
			scoreDisplayText.text = "Score : "+playerScore.ToString();
		}
		if (questionPool.Length > questionIndex + 1) {
			questionIndex++;
			ShowQuestion ();
		} 
		
		if (questionIndex >= 20) {
			EndRound ();
		} else {
			ShowQuestion ();
		}
	}
	public void EndRound(){	
		isRoundActive = false;
		questionDisplay.SetActive (false);
		roundEndDisplay.SetActive (true);
	
		if(playerScore>90){
			//Excellent
			GameObject.Find("RoundOverPanel/Result").GetComponent<Text>().text = "Nilai Anda Sangat Baik";
		}else 
		if(playerScore>75){
			//Excellent
			GameObject.Find("RoundOverPanel/Result").GetComponent<Text>().text = "Nilai Anda Baik";
		}else 
		if(playerScore>60){
			//Excellent
			GameObject.Find("RoundOverPanel/Result").GetComponent<Text>().text = "Nilai Anda Cukup";
		}else 
			//Poor
			GameObject.Find("RoundOverPanel/Result").GetComponent<Text>().text = "Coba Belajar Lagi";

	}

	
	public void ReturnToMenu(){
		Application.LoadLevel ("Game");
	}

	private void UpdateTimeRemainingDisplay(){
		int minutes = Mathf.FloorToInt (timeRemaining / 60F);
		int seconds = Mathf.FloorToInt (timeRemaining - minutes * 60);
		string niceTime = string.Format ("{0:0}:{1:00}", minutes, seconds);
		timeRemainingDisplayText.text = "Time : " + niceTime;
		//timeRemainingDisplayText.text = "Time : " + Mathf.Round (timeRemaining).ToString ();
	}
	// Update is called once per frame
	void Update () {
		if (isRoundActive) {
			timeRemaining-=Time.deltaTime;
			UpdateTimeRemainingDisplay();

			if(timeRemaining<=0f){
				EndRound();
			}
		}
	
	}
}

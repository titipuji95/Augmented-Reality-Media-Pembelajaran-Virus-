﻿using UnityEngine;
using System.Collections;

[System.Serializable]
public class RoundData {
	public string name;
	public int timeLimitInSeconds;
	public int pointsAddedCorrectAnswer;
	public QuestionData[] questions;
}

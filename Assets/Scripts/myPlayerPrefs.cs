using UnityEngine;
using System.Collections;

public static class myPlayerPrefs {

	public static string FirstHighestScore = "FirstHighestScore";
	public static string SecondHighestScore = "SecondHighestScore";
	public static string ThirdHighestScore = "ThirdHighestScore";
	public static string FourthHighestScore = "FourthHighestScore";
	public static string FifthHighestScore = "FifthHighestScore";
	public static string SixthHighestScore = "SixthHighestScore";
	public static string SeventhHighestScore = "SeventhHighestScore";
	public static string EighthHighestScore = "EighthHighestScore";
	public static string NinthHighestScore = "NinthHighestScore";
	public static string TenthHighestScore = "TenthHighestScore";

	public static string IsThereScores = "IsThereScores";

	/*
	public static int GetIsThereScores(){
		return PlayerPrefs.GetInt (myPlayerPrefs.IsThereScores);
	}

	public static void SetIsThereScores(int state){
		PlayerPrefs.SetInt (myPlayerPrefs.IsThereScores, state);
	}
	*/
	public static float GetFirstHighestScore(){
		return PlayerPrefs.GetFloat ( myPlayerPrefs.FirstHighestScore);
	}

	public static float GetSecondHighestScore(){
		return PlayerPrefs.GetFloat (myPlayerPrefs.SecondHighestScore);
	}

	public static float GetThirdHighestScore(){
		return PlayerPrefs.GetFloat (myPlayerPrefs.ThirdHighestScore);
	}

	public static float GetFourthHighestScore(){
		return PlayerPrefs.GetFloat (myPlayerPrefs.FourthHighestScore);
	}
	public static float GetFifthHighestScore(){
		return PlayerPrefs.GetFloat (myPlayerPrefs.FifthHighestScore);
	}

	public static float GetSixthHighestScore(){
		return PlayerPrefs.GetFloat (myPlayerPrefs.SixthHighestScore);
	}

	public static float GetSeventhHighestScore(){
		return PlayerPrefs.GetFloat (myPlayerPrefs.SeventhHighestScore);
	}

	public static float GetEighthHighestScore(){
		return PlayerPrefs.GetFloat (myPlayerPrefs.EighthHighestScore);
	}

	public static float GetNinthHighestScore(){
		return PlayerPrefs.GetFloat (myPlayerPrefs.NinthHighestScore);
	}

	public static float GetTenthHighestScore(){
		return PlayerPrefs.GetFloat (myPlayerPrefs.TenthHighestScore);
	}
		
	public static void SetFirstHighestScore(float score){
		PlayerPrefs.SetFloat ("FirstHighestScore", score);
		Debug.Log (score);
	}

	public static void SetSecondHighestScore(float score){
		PlayerPrefs.SetFloat ("SecondHighestScore", score);
	}

	public static void SetThirdHighestScore(float score){
		PlayerPrefs.SetFloat ("ThirdHighestScore", score);
	}

	public static void SetFourthHighestScore(float score){
		PlayerPrefs.SetFloat ("FourthHighestScore", score);
	}

	public static void SetFifthHighestScore(float score){
		PlayerPrefs.SetFloat ("FifthHighestScore", score);
	}

	public static void SetSixthHighestScore(float score){
		PlayerPrefs.SetFloat ("SixthHighestScore", score);
	}

	public static void SetSeventhHighestScore(float score){
		PlayerPrefs.SetFloat ("SeventhHighestScore", score);
	}

	public static void SetEighthHighestScore(float score){
		PlayerPrefs.SetFloat ("EighthHighestScore", score);
	}

	public static void SetNinthHighestScore(float score){
		PlayerPrefs.SetFloat ("NinthHighestScore", score);
	}

	public static void SetTenthHighestScore(float score){
		PlayerPrefs.SetFloat ("TenthHighestScore", score);
	}


}

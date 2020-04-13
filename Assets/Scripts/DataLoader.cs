using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DataLoader : MonoBehaviour {

    public Text highscoreName1;
    public Text highscoreName2;
    public Text highscoreName3;
    public Text highscoreName4;
    public Text highscoreName5;
    public Text highscoreName6;
    public Text highscoreName7;
    public Text highscoreName8;
    public Text highscoreName9;
    public Text highscoreName10;

    public Text highscoreScore1;
    public Text highscoreScore2;
    public Text highscoreScore3;
    public Text highscoreScore4;
    public Text highscoreScore5;
    public Text highscoreScore6;
    public Text highscoreScore7;
    public Text highscoreScore8;
    public Text highscoreScore9;
    public Text highscoreScore10;




    public string[] items;

    public void Start()
    {
        StartCoroutine(Data());
    }




	IEnumerator Data()
    {
		WWW playerData = new WWW("http://64.227.64.26/sqlconnect/highscore.php");
		yield return playerData;
		string playerDataString = playerData.text;
		
		items = playerDataString.Split(';');
        print(items[1]);
        int sizeoflist = items.Length-1;
        print(sizeoflist);
        highscoreName1.text = "1: " + items[0].Split('|')[0];
        highscoreScore1.text = items[0].Split('|')[1];

        //  if (sizeoflist > 0)
        // {
        //    highscoreName1.text = items[0];
        // }
        if (sizeoflist > 1)
        {
            highscoreName2.text = "2: " + items[1].Split('|')[0];
            highscoreScore2.text = items[1].Split('|')[1];
        }
        if (sizeoflist > 2)
        {
            highscoreName3.text = "3: " + items[2].Split('|')[0];
            highscoreScore3.text = items[2].Split('|')[1];
        }
        if (sizeoflist > 3)
        {
            highscoreName4.text = "4: " + items[3].Split('|')[0];
            highscoreScore4.text = items[3].Split('|')[1];
        }
        if (sizeoflist > 4)
        {
            highscoreName5.text = "5: " + items[4].Split('|')[0];
            highscoreScore5.text = items[4].Split('|')[1];
        }
        if (sizeoflist > 5)
        {
            highscoreName6.text = "6: " + items[5].Split('|')[0];
            highscoreScore6.text = items[5].Split('|')[1];
        }
        if (sizeoflist > 6)
        {
            highscoreName7.text = "7: " + items[6].Split('|')[0];
            highscoreScore7.text = items[6].Split('|')[1];
        }
        if (sizeoflist > 7)
        {
            highscoreName8.text = "8: " + items[7].Split('|')[0];
            highscoreScore8.text = items[7].Split('|')[1];
        }
        if (sizeoflist > 8)
        {
            highscoreName9.text = "9: " + items[8].Split('|')[0];
            highscoreScore9.text = items[8].Split('|')[1];
        }
        if (sizeoflist > 9)
        {
            highscoreName10.text = "10: " + items[9].Split('|')[0];
            highscoreScore10.text = items[9].Split('|')[1];
        }


        //print(GetDataValue(items[0], "Cost:"));
    }
    
	   /** string GetDataValue(string data, string index)
    {
		string value = data.Substring(data.IndexOf(index)+index.Length);
		if(value.Contains("|"))value = value.Remove(value.IndexOf("|"));
		return value;
	}
    */
    
    
}


























//void Start(){
//	string data = "ID:1|Name:Health Potion|Type:consumables|Cost:50";
//	print(GetDataValue(data, "Cost:"));
//}
//
//void Update(){
//	
//}
//
//string GetDataValue(string data ,string index){
//	string value = data.Substring(data.IndexOf(index)+index.Length);
//	if(value.Contains("|"))value = value.Remove(value.IndexOf("|"));
//	return value;
//}

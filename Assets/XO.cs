using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class XO : MonoBehaviour {
	private bool check;
	int count = 9 ;
	public Text nop1,nop2,nop3,nop4,nop5,nop6,nop7,nop8,nop9;	
	public Button box1,box2,box3,box4,box5,box6,box7,box8,box9;
	void Start () {
		check = true;
	}
	void Update () 
	{
		if (
			nop1.text == "X" && nop2.text == "X" && nop3.text == "X" || nop1.text == "X" && nop8.text == "X" && nop7.text == "X" || 
			nop1.text == "X" && nop9.text == "X" && nop5.text == "X" || nop3.text == "X" && nop9.text == "X" && nop7.text == "X" ||
			nop2.text == "X" && nop9.text == "X" && nop6.text == "X" || nop7.text == "X" && nop6.text == "X" && nop5.text == "X" || 
			nop3.text == "X" && nop4.text == "X" && nop5.text == "X" || nop8.text == "X" && nop9.text == "X" && nop4.text == "X" ||
			nop7.text == "X" && nop6.text == "X" && nop5.text == "X")
		{
			print("x win");
		}
		if(
			nop1.text == "O" && nop2.text == "O" && nop3.text == "O" || nop1.text == "O" && nop8.text == "O" && nop7.text == "O" || 
			nop1.text == "O" && nop9.text == "O" && nop5.text == "O" || nop3.text == "O" && nop9.text == "O" && nop7.text == "O" ||
			nop2.text == "O" && nop9.text == "O" && nop6.text == "O" || nop7.text == "O" && nop6.text == "O" && nop5.text == "O" || 
			nop3.text == "O" && nop4.text == "O" && nop5.text == "O" || nop8.text == "O" && nop9.text == "O" && nop4.text == "O" ||
			nop7.text == "O" && nop6.text == "O" && nop5.text == "O")
		{
			print("O win");
		}
		if (count == 0)
		{
			print("summergun");
		}
	}
	void xWin(){
	}
	void oWin(){
	}
	void summergun(){
	}
	
	public void nap1(){
		if (check == true) {
			nop1.text = "O";
			check = false;
			count = count - 1;
		} else {
			nop1.text = "X";
			check = true;
			count = count - 1;
		}
		box1.enabled = false;
	}
	public void nap2(){
		if (check == true) {
			nop2.text = "O";
			check = false;
			count = count - 1;
		} else {
			nop2.text = "X";
			check = true;
			count = count - 1;
		}
		box2.enabled = false;
	}
	public void nap3(){
		if (check == true) {
			nop3.text = "O";
			check = false;
			count = count - 1;
		} else {
			nop3.text = "X";
			check = true;
			count = count - 1;
		}
		box3.enabled = false;
	}
	public void nap4(){
		if (check == true) {
			nop4.text = "O";
			check = false;
			count = count - 1;
		} else {
			nop4.text = "X";
			check = true;
			count = count - 1;
		}
		box4.enabled = false;
	}
	public void nap5(){
		if (check == true) {
			nop5.text = "O";
			check = false;
			count = count - 1;
			
		} else {
			nop5.text = "X";
			check = true;
			count = count - 1;
		}
		box5.enabled = false;
	}
	public void nap6(){
		if (check == true) {
			nop6.text = "O";
			check = false;
			count = count - 1;
		} else {
			nop6.text = "X";
			check = true;
			count = count - 1;
		}
		box6.enabled = false;
	}
	public void nap7(){
		if (check == true) {
			nop7.text = "O";
			check = false;
			count = count - 1;
		} else {
			nop7.text = "X";
			check = true;
			count = count - 1;
		}
		box7.enabled = false;
	}
	public void nap8(){
		if (check == true) {
			nop8.text = "O";
			check = false;
			count = count - 1;
		} else {
			nop8.text = "X";
			check = true;
			count = count - 1;
		}
		box8.enabled = false;
	}
	public void nap9(){
		if (check == true) {
			nop9.text = "O";
			check = false;
			count = count - 1;
		} else {
			nop9.text = "X";
			check = true;
			count = count - 1;
		}
		box9.enabled = false;
	}
}

using UnityEngine;
using System.Collections;
using UnityEngine.UI;



public class SneakMission : MonoBehaviour {

	public Text descriptionText;
	public Text choicesText;
	public Text weaponText;

	public LevelManager levelManager;

	public bool gameOver = false;
	public bool level1Complete = false;
	public bool isWaiting = false;

	private enum Positions {r1c1, r1c2, r1c3, r1c4, r1c5, r2c1, r2c2, r2c3, r2c4, r2c5, r3c1, r3c2, r3c3, r3c4, r3c5, r4c1, r4c2, r4c3, r4c4, r4c5, r5c1, r5c2, r5c3, r5c4, r5c5};

	private Positions currentPosition;
	private string weaponEquipped = "Unarmed";


	// Use this for initialization
	void Start () {

		GameObject go = GameObject.Find ("_LevelManager");
		levelManager = go.GetComponent<LevelManager>();

		go = GameObject.Find("DescriptionText");
		descriptionText = go.GetComponent<Text>();

		go = GameObject.Find("ChoicesText");
		choicesText = go.GetComponent<Text>();

		go = GameObject.Find("WeaponText");
		weaponText = go.GetComponent<Text>();
		weaponText.text = weaponEquipped;

		currentPosition = Positions.r5c4;
	}
	
	// Update is called once per frame
	void Update () {

		if (gameOver == true) {
			GameOver ();
		} else if (level1Complete) {
			Level1Complete ();
		} else {
			switch (currentPosition) {
			case Positions.r1c1:
				Position_r1c1 ();
				break;
			case Positions.r1c2:
				Position_r1c2 ();
				break;
			case Positions.r1c3:
				Position_r1c3 ();
				break;
			case Positions.r1c4:
				Position_r1c4 ();
				break;
			case Positions.r1c5:
				Position_r1c5 ();
				break;
			case Positions.r2c1:
				Position_r2c1 ();
				break;
			case Positions.r2c2:
				Position_r2c2 ();
				break;
			case Positions.r2c3:
				Position_r2c3 ();
				break;
			case Positions.r2c4:
				Position_r2c4 ();
				break;
			case Positions.r2c5:
				Position_r2c5 ();
				break;
			case Positions.r3c1:
				Position_r3c1 ();
				break;
			case Positions.r3c2:
				Position_r3c2 ();
				break;
			case Positions.r3c3:
				Position_r3c3 ();
				break;
			case Positions.r3c4:
				Position_r3c4 ();
				break;
			case Positions.r3c5:
				Position_r3c5 ();
				break;
			case Positions.r4c1:
				Position_r4c1 ();
				break;
			case Positions.r4c2:
				Position_r4c2 ();
				break;
			case Positions.r4c3:
				Position_r4c3 ();
				break;
			case Positions.r4c4:
				Position_r4c4 ();
				break;
			case Positions.r4c5:
				Position_r4c5 ();
				break;
			case Positions.r5c1:
				Position_r5c1 ();
				break;
			case Positions.r5c2:
				Position_r5c2 ();
				break;
			case Positions.r5c3:
				Position_r5c3 ();
				break;
			case Positions.r5c4:
				Position_r5c4 ();
				break;
			case Positions.r5c5:
				Position_r5c5 ();
				break;
			}
		}

		weaponText.text = weaponEquipped;


	}

	void GameOver() {
		switch (currentPosition) {
		case Positions.r5c2:
			descriptionText.text = "Suprising and taking out two armed guards while unarmed would be pretty impressive, but alas, you are not that good.";
			break;
		case Positions.r1c4:
			descriptionText.text = "You sneak up to the guard by the door and dispatch him easily, however as you grab the keycard from the downed guard, the patrolling guard spots you from the far stairs. You are immediately gunned down.";
			break;
		}

		choicesText.text = "Press Spacebar to Continue.";
		if (Input.GetKeyDown("space")) {
			levelManager.LoadLevel ("WinLoseScreen");
		} 
	}

	void Level1Complete() {
		descriptionText.text = "You easily dispatch the guard with your pistol. As you search the guards body for the keycard, the patrolling guard comes up the stairs. You fire off a couple more shots, dispatching him before he has a chance to react.";
		choicesText.text = "Press SPACE to enter the facility. (Just goes to Game Over Screen for this build)";

		if (Input.GetKeyDown("space")) {
			levelManager.LoadLevel ("WinLoseScreen");
		}
	}

	void Position_r1c1() {
		descriptionText.text = "";
		choicesText.text = "";
	}

	void Position_r1c2() {
		descriptionText.text = "";
		choicesText.text = "";
	}
		
	void Position_r1c3() {
		descriptionText.text = "";
		choicesText.text = "";
	}

	void Position_r1c4() {
		descriptionText.text = "You climb the stairs and kneel near a railing for cover. You see the entrance to the building with a guard posted.";

		if (weaponEquipped == "Silenced Pistol") {
			choicesText.text = "Press S to SHOOT the Guard. \nPress B to go BACK to tree.";
			if (Input.GetKeyDown("s")) {
				if (!level1Complete) {
					level1Complete = true;
				}
			}else if (Input.GetKeyDown("b")) {
				currentPosition = Positions.r3c4;
			}
		} else {
			choicesText.text = "Press A to sneak up and ATTACK the guard. \nPress B to go BACK to tree.";
			if (Input.GetKeyDown("a")) {
				gameOver = true;
			}else if (Input.GetKeyDown("b")) {
				currentPosition = Positions.r3c4;
			}
		}
	}

	void Position_r1c5() {
		descriptionText.text = "";
		choicesText.text = "";
	}

	void Position_r2c1() {
		descriptionText.text = "";
		choicesText.text = "";
	}

	void Position_r2c2() {
		descriptionText.text = "";
		choicesText.text = "";
	}

	void Position_r2c3() {
		descriptionText.text = "";
		choicesText.text = "";
	}

	void Position_r2c4() {
		descriptionText.text = "";
		choicesText.text = "";
	}

	void Position_r2c5() {
		descriptionText.text = "You sneak down the wall but don't see a way into the facility. Under a bush near the wall however, you do see a spot that has been recently dug up. " + 
			"You clear away the loose soil and find a package with a silenced pistol and some rounds. 'Looks like the mole came through.' you think to yourself.";
		choicesText.text = "Press B to go BACK towards the tree.";
		weaponEquipped = "Silenced Pistol";
		if (Input.GetKeyDown("b")) {
			currentPosition = Positions.r3c5;
		}
	}

	void Position_r3c1() {
		descriptionText.text = "";
		choicesText.text = "";
	}

	void Position_r3c2() {
		descriptionText.text = "";
		choicesText.text = "";
	}

	void Position_r3c3() {
		descriptionText.text = "You sneak up to the side of the Helipad as the chopper is lifting off. You think to yourself \"A Hind D? What's a Russian gunship doing here?\"";
		choicesText.text = "Press S to SNEAK to the southern side of the helipad. \nPress B to go BACK to the tree.";
		if (Input.GetKeyDown("b")) {
			currentPosition = Positions.r3c4;
		}
	}

	void Position_r3c4() {
		

		if (isWaiting) {
			descriptionText.text = "You wait and observe the movements of the guards. The guard next to the door on the upper walkway does not move. \nThe guard on the lower platform seems to be lazily sweeping the area visually, but doesn't seem to be " + 
				"paying much attention and also appears to occasionally nod off. \nThe third guard's patrol takes him up the west stairs, across the walkway, then down the east stairway. He then goes west between the helipad and the guard on the " + 
				"platform. Instead of turning right to head back up the west stairs, he goes left. This takes him south between a bunch of crates and the west side of the helipad. He then circles around the south side of the helipad and then goes north " +
				"between the east side of the helipad and the tree you are in. Once he gets to the north edge of the helipad, he then heads back west back past the guard on the platform again. From there he goes right to head up the west stairs again, " + 
				"creating a figure 8 pattern.";
			choicesText.text = "Press W to go WEST towards the helipad. \nPress N to go North towards the stairs. \nPress B to go BACk over the wall";
			if (Input.GetKeyDown("w")) {
				isWaiting = false;
				currentPosition = Positions.r3c3;
			} else if (Input.GetKeyDown("n")) {
				isWaiting = false;
				currentPosition = Positions.r1c4;
			} else if (Input.GetKeyDown("b")) {
				isWaiting = false;
				currentPosition = Positions.r3c5;
			}
				
		} else {
			descriptionText.text = "Hiding in the treetop, you can survey the area. The facility you need to infiltrate is to the North. It looks like there are 2 entraces. The first is a door on the upper walkway. You can see a guard posted " + 
				"at the door, as well as a guard patrolling the area. There are stairs on the far east and west sides of the walkway. The second way in is a small ventalation shaft located under the far west staircase. " + 
				"The area appears to be blocked off by crates. There is a platform coming off the west staircase that has another guard posted on it. To the south of the platform you see a helipad. You can see a chopper of some kind on it but " +
				"can't tell what kind it is or if it's piloted.";
			choicesText.text = "Press O to OBSERVE the guards. \nPress W to go WEST towards the helipad. \nPress N to go NORTh towards the stairs. \nPress B to go BACk over the wall";

			if (Input.GetKeyDown("w")) {
				currentPosition = Positions.r3c3;
			} else if (Input.GetKeyDown("o")) {
				if (!isWaiting) {
					isWaiting = true;
				}
			} else if (Input.GetKeyDown("n")) {
				currentPosition = Positions.r1c4;
			} else if (Input.GetKeyDown("b")) {
				currentPosition = Positions.r3c5;
			}
		}
			
	}

	void Position_r3c5() {
		descriptionText.text = "You can see the tree has fallen on the wall. you can climb up and over the wall or explore further north up the wall.";
		choicesText.text = "Press C to CLIMB the tree. \nPress E to EXPLORE further north. \nPress B to go back towards the corner of the wall.";

		if (Input.GetKeyDown("c")) {
			currentPosition = Positions.r3c4;
		} else if (Input.GetKeyDown("e")) {
			currentPosition = Positions.r2c5;
		} else if (Input.GetKeyDown("b")) {
			currentPosition = Positions.r4c5;
		}
	}

	void Position_r4c1() {
		descriptionText.text = "";
		choicesText.text = "";
	}

	void Position_r4c2() {
		descriptionText.text = "";
		choicesText.text = "";
	}

	void Position_r4c3() {
		descriptionText.text = "";
		choicesText.text = "";
	}

	void Position_r4c4() {
		descriptionText.text = "";
		choicesText.text = "";
	}

	void Position_r4c5() {
		descriptionText.text = "You sneak to the corner of the wall. You see a tree that has fallen on the wall.";
		choicesText.text = "Press T to go toward the TREE. \nPress B to go BACK around the corner.";

		if (Input.GetKeyDown("t")) {
			currentPosition = Positions.r3c5;
		} else if (Input.GetKeyDown("b")) {
			currentPosition = Positions.r5c4;
		}
	}

	void Position_r5c1() {

	}

	void Position_r5c2() {
		descriptionText.text = "As you sneak down the length of the wall, you come upon a lit gate. There are 2 guards with assault rifles posted in front of the gate.";
		choicesText.text = "Press A to ATTACK. \nPress R to RETREAT to the right.";
		if (Input.GetKeyDown("a")) {
			gameOver = true;
		} else if (Input.GetKeyDown("r")) {
			currentPosition = Positions.r5c4;
		}
	}

	void Position_r5c3() {

	}

	void Position_r5c4() {
		descriptionText.text = "Nearby is a wall. To the left is further stretch of wall, to the right is a corner of the wall.";
		choicesText.text = "Press L to go LEFT. \nPress R to go RIGHT.";

		if (Input.GetKeyDown("l")) {
			currentPosition = Positions.r5c2;
		} else if (Input.GetKeyDown("r")) {
			currentPosition = Positions.r4c5;
		}
	}

	void Position_r5c5() {

	}

}

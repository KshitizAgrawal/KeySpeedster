using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Paragraphs : MonoBehaviour {

	public static Dictionary<int, string> dict = new Dictionary<int, string>();

	public static void addParagraphs() {
		dict.Add (1, "I believe that we are who we choose to be. Nobody’s going to come and save you, you’ve " +
		"got to save yourself. Nobody’s going to give you anything. You’ve got to go out and fight for it. " +
		"Nobody knows what you want except for you. And nobody will be as sorry as you if you don’t get it. " +
		"So don’t give up on your dreams.");
		dict.Add (2, "i really wonder why people suddenly change after they get what they wanted. one day " +
			"they’re sweet, the next day, they’re not. one day they’re here, the next day they’re not. one " +
			"day you’re important to them, the next day you’re worthless. one day they love you, the next day" +
			" they don’t care about you. that’s how ironic people and things can be. pretty shits, pretty lies, " +
			"pretty fucked up. but it’s still your choice. cause you choose to get hurt when you choose to be in love.");
		dict.Add (3, "It’s hard to accept, but you can’t change the past. You can’t go back and manipulate things" +
			" to the way you wanted them to happen. Because life would be meaningless and boring and just not worth" +
			" living. But you can change the future and that’s a beautiful thing about life. Yes, you will make mistakes." +
			" And yes, you will have bad days – but as long as you let the past go, you’ll have such a gorgeous and bright" +
			" future ahead of you. Knowing that things were meant to happen. Knowing that each day you will learn something" +
			" so that you keep growing to be a better person. Life is like a rope, twined in all its complexities and yet" +
			" weaved into one marvelous stream that you have the chance you use something amazing from. So grab hold of it.");
	}
}

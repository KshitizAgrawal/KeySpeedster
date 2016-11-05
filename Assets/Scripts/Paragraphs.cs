/* Five paragraphs for each level
 * for each level paragraphs will be selected randomly
 * length of paragraphs of same level will be same
 */
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Paragraphs : MonoBehaviour {

	public static Dictionary<int, string> dict = new Dictionary<int, string>();

	public static void addParagraphs() {
		/*dict.Add (1, "I believe that we are who we choose to be. Nobody’s going to come and save you, you’ve " +
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
		//About Willian Shakespeare
		dict.Add (4, "William Shakespeare was an English poet, playwright, and actor. He was born on 26 April 1564 in " +
		"Stratford-upon-Avon. His father was a successful local businessman and his mother was the daughter of a " +
		"landowner. Shakespeare is widely regarded as the greatest writer in the English language and the world's " +
		"pre-eminent dramatist. He is often called England's national poet and nicknamed the Bard of Avon. He wrote " +
		"about 38 plays, 154 sonnets, two long narrative poems, and a few other verses, of which the authorship of " +
		"some is uncertain. His plays have been translated into every major living language and are performed more " +
		"often than those of any other playwright.");
		//Mahatama Gandhi Non-Violence
		dict.Add (5, "Gandhiji believed in non-violence and love. He was against untouchability and all sorts of injustice" +
		" in society. He lived a saintly life and suffered a lot to see truth triumph. His heart bled for the poor and" +
		" the oppressed. He said that all men were equal. He wanted them all to live in peace. He dreamed of a Ram Rajya" +
		" where everybody would live in peace. He was against the modern civilization. Instead, he wanted his countrymen" +
		" to live in the villages. His philosophy and deed are so great that he is regarded as “Mahatma” meaning “Great Soul”.");
		//Abraham Lincoln
		dict.Add (6, "At this difficult time, Abraham Lincoln was elected President of the USA in 1860. He wanted to solve the" +
		" problem of slavery. The southern states were against the abolition of slavery. This brought the unity of the" +
		" country in danger. The southern states were prepared even to form a new country. Abraham Lincoln wanted all" +
		" the states to remain united. He faced many problems. He wanted to preserve the unity of the country at any cost." +
		" Finally a civil war broke out between the northern and southern states. He fought the war bravely and declared," +
		" 'A Nation cannot exist half free and half slave.' He won the war and kept the country united.");*/

		//for high excitation
		dict.Add (5, "The Solar System consists of the Sun Moon and Planets. It also consists of comets, meteoroids " + 
			"and asteroids. The Sun is the largest member of the Solar System. In order of distance from the Sun, the " +
			"planets are Mercury, Venus, Earth, Mars, Jupiter, Saturn, Uranus, Neptune and Pluto; the dwarf planet. The " +
			"Sun is at the centre of the Solar System and the planets, asteroids, comets and meteoroids revolve around it.");
		dict.Add (6, "The Mahabharata is a story about a great battle between the Kauravas and the Pandavas. The battle " +
			"was fought in Kurukshetra near Delhi. Many kings and princes took part in the battle. The Pandavas defeated " +
			"the Kauravas. The Bhagvad Gita is a holy book of the Hindus. It is a part of the Mahabharata. Then, Lord Rama, " +
			"with the help of It is a book of collection of teachings of Lord Krishna to Arjuna in the battlefield. It is the " +
			"longest epic in the world.");
		dict.Add (7, "The Ramayana is a story of Lord Rama written by the SageValmiki. Lord Rama, the prince of Ayodhya, " +
			"in order to help his father Dasharatha went to exile for fourteen years. His wife, Sita and his younger brother " +
			"Lakshmana also went with him. He went through many difficulties in the forest. One day Ravana, the king of Lanka " +
			"carried away Sita with him. Then, Lord Rama, with the help of Hanumana, defeated and killed Ravana; Sita, Rama " +
			"and Lakshmana returned to Ayod hya after their exile.");
		dict.Add (8, "Delhi is the capital of India. It is situated on the banks of the river Yamuna. It is surrounded by " +
			"Haryana and Uttar Pradesh. It has some of the famous buildings and monuments such as the Qutub Minar, Reu Fort, " +
			"Lotus Temple, Akshardham Temple etc. Some of the monuments are hundreds of years old. Apart from this, there is " +
			"the Parliament House, the Central Secretariat and the famous Connaught place. Delhi is a beautiful city. But, it " +
			"is becoming very crowded and polluted. I love Delhi a lot.");


		//for low excitation
		dict.Add (1, "His skin was torn. The scar ran jagged, his face ruined. His hands were strong, his touch gentle. Here lies a man, a life well spent.");
		dict.Add (2, "Cars passed as he biked halfway over the train bridge. Fireworks exploded pink and green. No one saw him put the kickstand down and leap.");
		dict.Add (3, "When she arrives home after work, the bedroom light is on. She did not turn it on. Water is running in the tub. She does not have a tub.");
		dict.Add (4, "After he retired, Hal spent his mornings on the cement stoop outside his two flat. One day, he saw God walk by. He looks good, he thought.");

		
	}
}

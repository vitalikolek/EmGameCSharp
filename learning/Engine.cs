using System;

namespace learning {
	public class Engine {
		protected bool gameOver = false;
		Random rnd = new Random();

		void punchPlayer(Player player, Monster mob) {
			if (player.getPlayerDefence() > mob.damage) {
			}
			else {
				player.hp = player.hp - (mob.damage - player.getPlayerDefence());
			}
		}

		void punchMonster(Player player, Monster mob) {
			if (mob.defence > player.getPlayerDamage()) {
			}
			else {
				mob.hp = mob.hp - (player.getPlayerDamage() - mob.defence);
			}
		}

		Weapon choiceWeapon() {
			int ch = 0;
			int damage = 0;
			string weaponName = "";

			Console.WriteLine("1 - Glock, 2 - Updated Glock, 3 - Magnum, 4 - MP-40");
			Console.WriteLine("Choose weapon: ");
			ch = Convert.ToInt32(Console.ReadLine());

			switch (ch) {
				case 1:
					damage = 3;
					weaponName = "Glock";
					break;
				case 2:
					damage = 5;
					weaponName = "Updated Glock";
					break;
				case 3:
					damage = 7;
					weaponName = "Magnum";
					break;
				case 4:
					damage = 10;
					weaponName = "MP-40";
					break;
				default:
					damage = 3;
					weaponName = "Glock";
					break;

			};

			Weapon obj = new Weapon(damage, weaponName);
			return obj;
		}

		Armor choiceArmor() {
			int ch = 0;
			int defence = 0;
			string armorName = "";

			Console.WriteLine("1 - armor lvl 1, 2 - armor lvl 2, 3 - armor lvl 3, 4 - armor lvl 4");
			Console.WriteLine("Choose armor: ");
			ch = Convert.ToInt32(Console.ReadLine());

			switch (ch)	{
				case 1:
					defence = 1;
					armorName = "Armor lvl 1";
					break;
				case 2:
					defence = 2;
					armorName = "Armor lvl 2";
					break;
				case 3:
					defence = 3;
					armorName = "Armor lvl 3";
					break;
				case 4:
					defence = 5;
					armorName = "Armor lvl 4";
					break;
				default:
					defence = 1;
					armorName = "Armor lvl 1";
					break;
			}

			Armor obj = new Armor(defence, armorName);

			return obj;
		}

		void fight(Player player, Monster monster) {
			if(Console.ReadKey().Key == ConsoleKey.F) {
				punchMonster(player, monster);
				if (rnd.Next(1, 3) == 2) {
					punchPlayer(player, monster);
				}
			}
		}

		public void firstRound(Player player) {
			if (player.skillLvl == 0) {
				Monster firstMonster = new Monster("First monster", 50, 4, 1);
				player.maxHitPoint();

				player.setWeapon(choiceWeapon());
				player.setArmor(choiceArmor());
				//!firstMonster->isDead() || !player->isDead()

				Console.WriteLine("First round");
				Thread.Sleep(1000);

				while (!firstMonster.isDead()) {
					//Console.Clear();
					fight(player, firstMonster);
					Console.WriteLine("Your hp: " + player.hp);
					Console.WriteLine("Monster hp: " + firstMonster.hp);
					if (firstMonster.isDead() == true) {
						player.skillLvl = player.skillLvl + 1;
						player.lvlUp();
						player.hillHp();
					}
					else if (player.isDead() == true) {
						Console.WriteLine("Game over");
						break;
                    }
				}
			}
		}

		public Engine() {
		}
	}
}
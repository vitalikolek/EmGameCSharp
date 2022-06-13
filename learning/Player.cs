using System;

namespace learning {
	public class Player : Unit {
		protected int maxHp = 0;
		public int skillLvl { get; set; } = 0;
        protected Weapon playerWeapon = new Weapon(0, "");
		protected Armor playerArmor = new Armor(0, "");
		
		public Player(string name, int hp) : base(name, hp) {

		}

		public void setWeapon(Weapon weapon) {
			this.playerWeapon = weapon;
		}

		public void setArmor(Armor armor) {
			this.playerArmor = armor;
		}

		public int getPlayerDamage() {
			return this.playerWeapon.damage;
		}

		public int getPlayerDefence() {
			return this.playerArmor.defence;
		}

		public void lvlUp() {
			this.maxHp += 10;
			this.hp += 10;
			this.skillLvl += 1;
		}

		public void maxHitPoint() {
			this.maxHp = this.hp;
		}

		public void hillHp() {
			hp += 30;
			if (hp > maxHp)	{
				hp = maxHp;
			}
		}

	}
}


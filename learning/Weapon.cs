using System;

namespace learning {
	public class Weapon {
        public int damage { get; }
		public string weaponName { get; }

		public Weapon(int damage, string weaponName) {
			this.damage = damage;
			this.weaponName = weaponName;
		}
	}
}


using System;

namespace learning {
	public class Monster : Unit {
		public int damage { get; } = 0;
		public int defence { get; } = 0;

		public Monster(string name, int hp, int damage, int defence) : base(name, hp) {
			this.damage = damage;
			this.defence = defence;
		}
	}
}


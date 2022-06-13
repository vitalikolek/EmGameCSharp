using System;

namespace learning {
	abstract public class Unit {
		protected string name = "";
		public int hp { get; set; } = 0;

        public Unit(string name, int hp) {
			this.name = name;
			this.hp = hp;
		}

		public bool isDead() {
			if (this.hp <= 0) {
				return true;
			}
			else {
				return false;
			}
		}
	}
}